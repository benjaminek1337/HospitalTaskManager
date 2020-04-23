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
    staffData: StaffViewModel[];
    scheduleData: Schedule[];
    scheduledProcedureData: ScheduledProcedure[];
    statusData: ProcedureStatus[];
    employeeData: Staff[];

    currentDate: Date = new Date();

    showCurrentTimeIndicator = true;
    shadeUntilCurrentTime = true;


    constructor(service: Service) {
        this.procedureData = service.getProcedures();
        this.employeeData = service.getEmployees();
        this.staffData = service.getStaffs();
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


    IsWorkHours(data:any) {
        //let schedule = Query(this.scheduleData).filter(["staffId", "=", data.groups.staffId]).toArray()[0];
        let schedule = this.scheduleData.find(s => s.staffId == data.groups.staffId);
        if (schedule.startDate < data.endDate && data.startDate < schedule.endDate){
            return true;
        }
        else
            return false;

    }

    MarkWorkHours(data){
       
        let classObject = {};
        classObject["notWorkTime"] = true;
        classObject["workTime"] = this.IsWorkHours(data);
        if(classObject["workTime"] == true)
            classObject["notWorkTime"] = false;
        return classObject;
    }

    PopulateSchedulerOutput(){
        let schedulerOutputData = [];
        for (let i = 0; i < this.scheduleData.length; i++) {
            schedulerOutputData.push(this.scheduleData[i]);
        }
        for (let i = 0; i < this.scheduledProcedureData.length; i++) {
            schedulerOutputData.push(this.scheduledProcedureData[i]);
        }
        // procedures = Query(this.scheduledProcedureData).toArray()[0];
        // schedules = Query(this.scheduleData).toArray()[0];
        // this.schedulerOutputData.push(schedules, procedures);
        return schedulerOutputData;
    }

    GetEmployee(id:number){
        return Query(this.employeeData).filter(["id", "=", id]).toArray()[0];
    }

    GetProcedureStaff(id:number){
        return Query(this.staffData).filter(["id", "=", id]).toArray()[0];
    }

    GetProcedureStatus(id:number){
        return Query(this.statusData).filter(["id", "=", id]).toArray()[0];
    }

    CheckProcedureStatus() {
        this.PopulateSchedulerOutput();
        this.scheduledProcedureData.forEach(p => {
            let staff = this.staffData.find(s => s.id == p.staffId.find(id => id == s.id))
            let schedule = this.scheduleData.find(s => s.staffId == staff.id); //Hitta sätt att bomma procedur på en gång om det ligger utanför schematid
            if (p.startDate > this.currentDate) {
                p.statusId = 1;
            }
            else if (staff.onSite == false) {
                if (p.startDate < this.currentDate) {
                    p.statusId = 3;
                    //Här finns de go plats för att signalera backend att avvikelse sker
                    //och därgenom slänga ut lite notiser
                }
            }
            else if (staff.onSite) {
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
