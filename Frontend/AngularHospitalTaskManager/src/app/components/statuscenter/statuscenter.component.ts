import { Component, OnInit, Input } from '@angular/core';
import { Service, ScheduledProcedure, Schedule, Staff, StaffViewModel } from '../../services/schedule.service';
import Query from "devextreme/data/query"
import { kMaxLength } from 'buffer';

@Component({
  selector: 'app-statuscenter',
  templateUrl: './statuscenter.component.html',
  styleUrls: ['./statuscenter.component.css']
})
export class StatuscenterComponent implements OnInit {
  
  //statusMessages:any[];
  scheduleData:Schedule[];
  staffData:Staff[];
  @Input()scheduledProcedureData:ScheduledProcedure[];
  currentDate: Date = new Date();

  constructor(service:Service) {
    this.scheduleData = service.getSchedule();
    this.staffData = service.getEmployees();
  }

  ngOnInit(): void {
  }

  GetDeviantProceduresStatus(){
    let deviantProcedures = this.scheduledProcedureData.filter(p => p.statusId === 3);
    return deviantProcedures;
  }

  GetAbsentStaff(){
    let scheduledAbsentees = this.scheduleData.filter(sch => sch.onSite = false)
    let absentStaff = this.staffData.filter(s => s.id = scheduledAbsentees.find(sch => sch.staffId = s.id).staffId);

    return absentStaff;
  }

  GetAbsentScheduledStaff(){
    
  }

  GetStatusList(){
    let statusMessages:any[];
    statusMessages = this.GetDeviantProceduresStatus();
    return statusMessages;
  }

}
