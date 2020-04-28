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
    staffViewModelData: StaffViewModel[];
    scheduleData: Schedule[];
    scheduledProcedureData: ScheduledProcedure[];
    statusData: ProcedureStatus[];
    staffData: Staff[];

    currentDate: Date = new Date();

    showCurrentTimeIndicator = true;
    shadeUntilCurrentTime = true;


    constructor(service: Service) {
        this.procedureData = service.getProcedures();
        this.staffData = service.getEmployees();
        this.staffViewModelData = service.getStaffs();
        this.scheduleData = service.getSchedule();
        this.scheduledProcedureData = service.getScheduledProcedures();
        this.statusData = service.getStatus();

        locale(navigator.language);
    }

    polling: any;
    ngOnInit() {
        this.CheckProcedureStatus();
        this.polling = setInterval(() => { this.CheckProcedureStatus(); }, 60);
    }

    ngOnDestroy() {
        clearInterval(this.polling);
    }


    IsWorkHours(data:any, className:string) {
        let schedule = this.scheduleData.find(s => s.staffId == data.groups.staffId);

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
    
    MarkWorkHours(data){
        let classObject = {};
        let className: string = "";
        classObject[this.IsWorkHours(data, className)] = true;
        return classObject;
    }

    GetEmployee(id:number){
        return Query(this.staffData).filter(["id", "=", id]).toArray()[0];
    }

    GetProcedureStaff(id:number){
        return Query(this.staffViewModelData).filter(["id", "=", id]).toArray()[0];
    }

    GetProcedureStatus(id:number){
        return Query(this.statusData).filter(["id", "=", id]).toArray()[0];
    }



    //HÄR INNE SKA DU JÄVLAR I MIG GÖRA GREJER IMORN FÖR ATT SE INNAN SAKER GÅR ÅT HELVETE (RÖTT NÄR KENTTÄ ÄR BAKIS INNAN SKIFTET) 
    CheckProcedureStatus() {
        this.scheduledProcedureData.forEach(p => {
            let staff = this.staffData.find(s => s.id == p.staffId.find(id => id == s.id))
            let schedule = this.scheduleData.find(s => s.staffId == staff.id); //Hitta sätt att bomma procedur på en gång om det ligger utanför schematid
            if (p.startDate > this.currentDate) {
                p.statusId = 1;
            }
            else if (schedule.onSite == false) {
                if (p.startDate < this.currentDate) {
                    p.statusId = 3;
                    //Här finns de go plats för att signalera backend att avvikelse sker
                    //och därgenom slänga ut lite notiser
                }
            }
            else if (schedule.onSite) {
                if (p.startDate < this.currentDate && p.endDate > this.currentDate) {
                    p.statusId = 2;
                }
                else if (p.endDate < this.currentDate) {
                    p.statusId = 4;
                }
            }
        })
    };
}
