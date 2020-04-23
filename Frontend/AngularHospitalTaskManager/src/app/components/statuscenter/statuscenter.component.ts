import { Component, OnInit } from '@angular/core';
import { StatusMessage, Service, ScheduledProcedure, Schedule } from '../../services/schedule.service';

@Component({
  selector: 'app-statuscenter',
  templateUrl: './statuscenter.component.html',
  styleUrls: ['./statuscenter.component.css']
})
export class StatuscenterComponent implements OnInit {
  
  statusMessages:StatusMessage[];
  scheduleData:Schedule[];
  scheduledProcedureData:ScheduledProcedure[];

  constructor(service:Service) {
    this.scheduledProcedureData = service.getScheduledProcedures();
    this.scheduleData = service.getSchedule();
  }

  ngOnInit(): void {
  }

  CreateStatusMessage(){
    
  }

}
