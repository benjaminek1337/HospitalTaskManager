import { Component, OnInit } from '@angular/core';
import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';
import { Procedure, Staff, Service, Schedule, ScheduledProcedure, ProcedureStatus, Procedure_Schedule } from '../../services/schedule.service';
import Query from "devextreme/data/query"
import { locale, loadMessages } from 'devextreme/localization';

@Component({
    selector: 'app-schedule',
    templateUrl: './schedule.component.html',
    styleUrls: ['./schedule.component.css'],
    providers: [Service]
})

export class ScheduleComponent {
    procedureData: Procedure[];
    scheduleData: Schedule[];
    procedure_scheduleData:Procedure_Schedule[];
    scheduledProcedureData: ScheduledProcedure[];
    statusData: ProcedureStatus[];
    staffData: Staff[];
    scheduledStaff: Staff[];

    currentDate: Date = new Date();

    showCurrentTimeIndicator = true;
    shadeUntilCurrentTime = true;


    constructor(private service: Service) {
    }

    polling: any;
    ngOnInit() {
        this.staffData = this.service.GetStaff()
        this.scheduleData = this.service.getSchedule()
        this.procedureData = this.service.getProcedures();
        this.procedure_scheduleData = this.service.getProcedure_Schedule();
        this.scheduledProcedureData = this.getScheduledProcedures();
        this.statusData = this.service.getStatus();
        this.scheduledStaff = this.GetScheduledStaff();
        locale(navigator.language);
        this.CheckProcedureStatus();
        this.polling = setInterval(() => { this.CheckProcedureStatus(); }, 60000);        
    }

    ngOnDestroy() {
        clearInterval(this.polling);
    }

    GetScheduledStaff():Staff[]{
        return this.staffData.filter(s => this.scheduleData.map(a => a.staffId).includes(s.id));
    }
    
    GetEmployee(id:number){
        return Query(this.staffData).filter(["id", "=", id]).toArray()[0];
    }

    GetStaffPresenceStatus(id:number){
        return Query(this.scheduleData).filter(["staffId", "=", id]).toArray()[0];
    }

    GetProcedureStatus(id:number){
        return Query(this.statusData).filter(["id", "=", id]).toArray()[0];
    }
    
    CheckProcedureStatus() {
        this.scheduledProcedureData.forEach(p => {
            let staff = this.staffData.filter(item => p.staffId.includes(item.id));

            if (p.startDate > this.currentDate) {
                p.statusId = 1;
            }
            if (staff.find(item => item.onSite == false)) {
                if (p.startDate < this.currentDate) {
                    p.statusId = 3;
                    //TODO SEN kanske se till att 3600000 är justerbar till preferens ist för fast siffra. DB-post?
                    //Signalera bakänden att problemz sker
                }
                else if(p.startDate.getTime() < this.currentDate.getTime() + 3600000){
                    p.statusId = 2;
                }
            }
        })
    }

    MarkWorkHours(data){
        let classObject = {};
        let className: string = "";
        classObject[this.IsWorkHours(data, className)] = true;
        return classObject;
    }

    IsWorkHour(id:number){
        let schedule:Schedule = this.scheduleData.find(s => s.staffId == id);
        let staff:Staff = this.staffData.find(s => s.id == id)
        if(schedule.startDate <= this.currentDate && schedule.endDate >= this.currentDate && staff.onSite == true){
            return "inside";
        }
        else if(schedule.startDate >= this.currentDate || schedule.endDate <= this.currentDate && staff.onSite == true){
            return "outside";
        }
        else{
            return "not";
        }

    }

    IsWorkHours(data:any, className:string) {
        let schedule = this.scheduleData.find(s => s.staffId == data.groups.staffId);
        if(this.IsWorkHour(data.groups.staffId) == "inside" && schedule != null){
            if (schedule.startDate < data.endDate && data.startDate < schedule.endDate){
                if(data.startDate <= schedule.startDate ){
                    className="workTimeStart";
                }
                else{
                    className="workTime";
                }
                return className;
            }
            else{
                if(data.startDate <= schedule.endDate && data.startDate >= schedule.startDate)
                    className="workTimeEnded";
                else
                    className="notWorkTime";
                return className;
            }
        }
        else if(schedule != null){
            if (schedule.startDate < data.endDate && data.startDate < schedule.endDate){
                if(data.startDate <= schedule.startDate ){
                    className="workTimeStartNotOnSite";
                }
                else{
                    className="workTimeNotOnSite";
                }
                return className;
            }
            else{
                if(data.startDate <= schedule.endDate && data.startDate >= schedule.startDate)
                    className="workTimeEndedNotOnSite";
                else
                    className="notWorkTime";
                return className;
            }
        }
    }

    getScheduledProcedures() {
        let scheduledProcedureData: ScheduledProcedure[] = [];
        for (let i = 0; i < this.procedure_scheduleData.length; i++) {
            const element = this.procedure_scheduleData[i];

            let procedure = this.procedureData.find(p => p.id == element.procedureId);
            let schedule = this.procedure_scheduleData.filter(p => p.procedureId == element.procedureId);

            let scheduleIds: number[] = [];

            for (let j = 0; j < schedule.length; j++) {
                try {
                    const s = schedule[j];
                    let staffSchedule = this.scheduleData.find(q => q.id == s.scheduleId);
                    scheduleIds.push(staffSchedule.staffId);
                } catch (error) {
                    console.log(error);
                }
            }

            if (procedure != null) {
                let scheduledProcedure = new ScheduledProcedure();

                scheduledProcedure = {
                    id: i,
                    text: procedure.text,
                    startDate: procedure.startDate,
                    endDate: procedure.endDate,
                    staffId: scheduleIds,
                    procedureId: procedure.id,
                    statusId: 1
                }
                scheduledProcedureData.push(scheduledProcedure);
            }
        }
        return scheduledProcedureData.filter((obj, index, self) => self.findIndex(s => s.procedureId === obj.procedureId) === index);
    }
}
