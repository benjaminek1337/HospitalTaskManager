import { Component, OnInit, Input } from '@angular/core';
import { Service, ScheduledProcedure, Schedule } from '../../services/schedule.service';
import Query from "devextreme/data/query"

@Component({
  selector: 'app-statuscenter',
  templateUrl: './statuscenter.component.html',
  styleUrls: ['./statuscenter.component.css']
})
export class StatuscenterComponent implements OnInit {
  
  statusMessages:any[];
  scheduleData:Schedule[];
  @Input()scheduledProcedureData:ScheduledProcedure[];

  constructor(service:Service) {
    this.scheduleData = service.getSchedule();
  }

  ngOnInit(): void {
  }

  GetDeviantsStatus(){
    let deviants = this.scheduledProcedureData.filter(p => p.statusId === 3);
    this.statusMessages.push(deviants);
    this.GetStatusList();
  }

  GetStatusList(){
    return this.statusMessages;
  }

}
