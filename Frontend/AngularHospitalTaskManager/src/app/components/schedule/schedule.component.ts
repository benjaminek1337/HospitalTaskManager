import { Component, OnInit } from '@angular/core';
import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';

import { Procedure, StaffViewModel, Service, Schedule, ScheduledProcedure, ProcedureStatus } from '../../services/schedule.service';
import { timeInterval } from 'rxjs/operators';
import DataSource from 'devextreme/data/data_source';



@Component({
    selector: 'app-schedule',
    templateUrl: './schedule.component.html',
    styleUrls: ['./schedule.component.css'],
    providers: [Service]
})
export class ScheduleComponent {
    procedureData: Procedure[];
    currentDate: Date = new Date();
    employeeData: StaffViewModel[];
    scheduleData: Schedule[];
    scheduledProcedureData: ScheduledProcedure[];
    statusData: ProcedureStatus[];


    showCurrentTimeIndicator = true;
    shadeUntilCurrentTime = true;


    constructor(service: Service) {
        this.procedureData = service.getAppointments();
        this.employeeData = service.getStaffs();
        this.scheduleData = service.getSchedule();
        this.scheduledProcedureData = service.getScheduledProcedures();
        this.statusData = service.getStatus();
    }

    polling: any;
    ngOnInit() {
        this.CheckProcedureStatus();
        //this.polling = setInterval(()=> {this.CheckProcedureStatus();}, 60000);
        this.polling = setInterval(() => { this.CheckProcedureStatus(); }, 60);
    }

    ngOnDestroy() {
        clearInterval(this.polling);
    }



    CheckProcedureStatus() {
        this.scheduledProcedureData.forEach(p => {
            let staff = this.employeeData.find(s => s.id == p.staffId.find(id => id == s.id))
            if (p.startDate > this.currentDate) {
                p.statusId = 1;
            }
            else if (staff.onSite == true) {
                if (p.startDate < this.currentDate && p.endDate > this.currentDate) {
                    p.statusId = 2;
                }
                else if (p.endDate < this.currentDate) {
                    p.statusId = 4;
                }
            }
            else if (staff.onSite == false) {
                if (p.startDate < this.currentDate) {
                    p.statusId = 3;
                }
            }
        })
    }
}
