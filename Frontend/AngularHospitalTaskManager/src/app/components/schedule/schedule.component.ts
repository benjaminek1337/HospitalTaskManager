import { Component, OnInit } from '@angular/core';
import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';
import { Procedure, StaffViewModel, Staff, Service, Schedule, ScheduledProcedure, ProcedureStatus } from '../../services/schedule.service';
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
    scheduledProcedureData: ScheduledProcedure[];
    statusData: ProcedureStatus[];
    staffData: Staff[];

    currentDate: Date = new Date();

    showCurrentTimeIndicator = true;
    shadeUntilCurrentTime = true;


    constructor(private service: Service) {
    }

    polling: any;
    ngOnInit() {
        //this.staffData = this.service.getEmployees();
        this.service.fungeraHoraSatan()
            .subscribe(data => this.staffData = data);
        this.procedureData = this.service.getProcedures();
        this.scheduleData = this.service.getSchedule();
        this.scheduledProcedureData = this.service.getScheduledProcedures();
        this.statusData = this.service.getStatus();


        locale(navigator.language);

        this.CheckProcedureStatus();
        this.polling = setInterval(() => { this.CheckProcedureStatus(); }, 60000);
    }

    ngOnDestroy() {
        clearInterval(this.polling);
    }

    IsWorkHour(id:number){
        let schedule:Schedule = this.scheduleData.find(s => s.staffId == id);
        if(schedule.startDate <= this.currentDate && schedule.endDate >= this.currentDate && schedule.onSite == true){
            return "inside";
        }
        else if(schedule.startDate >= this.currentDate || schedule.endDate <= this.currentDate && schedule.onSite == true){
            return "outside";
        }
        else{
            return "not";
        }

    }

    IsWorkHours(data:any, className:string) {
        let schedule = this.scheduleData.find(s => s.staffId == data.groups.staffId);
        if(this.IsWorkHour(data.groups.staffId) == "inside"){
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
        else{
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
    
    MarkWorkHours(data){
        let classObject = {};
        let className: string = "";
        classObject[this.IsWorkHours(data, className)] = true;
        return classObject;
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
            let staffs = this.staffData.filter(s => s.id == p.staffId.find(id => id == s.id))
            for (let i = 0; i < staffs.length; i++) {
                const staff = staffs[i];
                let schedule = this.scheduleData.find(s => s.staffId == staff.id);

                if (p.startDate > this.currentDate) {
                    p.statusId = 1;
                }
                if (schedule.onSite == false) {
                    if (p.startDate < this.currentDate) {
                        p.statusId = 3;
                        break;
                        //TODO SEN kanske se till att 3600000 är justerbar till preferens ist för fast siffra. DB-post?
                        //Signalera bakänden att problemz sker
                    }
                    else if(p.startDate.getTime() < this.currentDate.getTime() + 3600000){
                        p.statusId=2;
                        break;
                    }
                }
                // else if (schedule.onSite) {
                //     if (p.startDate < this.currentDate && p.endDate > this.currentDate) {
                //         p.statusId = 2;
                //     }
                //     else if (p.endDate < this.currentDate) {
                //         p.statusId = 4;
                //     }
                // }
            }
        })
    };
}
