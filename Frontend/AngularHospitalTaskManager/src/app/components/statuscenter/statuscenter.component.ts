import { Component, OnInit, Input } from '@angular/core';
import { Service, ScheduledProcedure, Schedule, Staff, StaffViewModel, Procedure_Schedule } from '../../services/schedule.service';
import Query from "devextreme/data/query"
import { kMaxLength } from 'buffer';

@Component({
  selector: 'app-statuscenter',
  templateUrl: './statuscenter.component.html',
  styleUrls: ['./statuscenter.component.css']
})
export class StatuscenterComponent implements OnInit {

  //scheduleData:Schedule[];
  staffData:Staff[];

  @Input()scheduledProcedureData:ScheduledProcedure[];
  @Input()scheduleData:Schedule[];
  currentDate: Date = new Date();

  constructor(service:Service) {
    //this.scheduleData = service.getSchedule();
    this.staffData = service.getEmployees();
  }


  interval1: any;
  ngOnInit() {
      this.interval1 = setInterval(() => { this.GetDeviantProceduresStatus(); }, 1000);
  }

  ngOnDestroy() {
      clearInterval(this.interval1);
  }

  GetMinutesLate(procedure:ScheduledProcedure){
    let goingToOrHasDeviated:{ minutesLate:number, hasDeviated:number };
    
    if (this.currentDate.getTime() >= procedure.startDate.getTime()){
      goingToOrHasDeviated = {
        minutesLate: Math.round(this.currentDate.getTime()/60000 - procedure.startDate.getTime()/60000),
        hasDeviated: 1 
      }
    }
    else{
      
      goingToOrHasDeviated = {
        minutesLate: Math.round(procedure.startDate.getTime()/60000 - this.currentDate.getTime()/60000),
        hasDeviated: 0 
      }
    }
    
    return goingToOrHasDeviated;
  }

  GetSortedDeviations(){
    let deviants = this.GetDeviantProceduresStatus();
    deviants.sort((a, b) => a.hasDeviated - b.hasDeviated || a.minutesLate - b.minutesLate )
    return deviants
  }

  GetDeviantProceduresStatus(){
    let deviants:{ procedure:string, staff?:Staff[], minutesLate:number, hasDeviated:number}[] = [];
    let deviant:{ procedure:string, staff?:Staff[], minutesLate:number, hasDeviated:number};
    let deviantProcedures:ScheduledProcedure[] = this.scheduledProcedureData.filter(p => p.statusId === 2 || p.statusId === 3);
    
    for (let i = 0; i < deviantProcedures.length; i++) {
      const procedure = deviantProcedures[i];
      let absentees:Staff[] = [];
      
      for (let j = 0; j < procedure.staffId.length; j++) {
        const sta = procedure.staffId[j];
        let staff = this.staffData.find(s => s.id === sta);
        let schedule = this.scheduleData.find(s => s.staffId === sta);
        if(schedule.onSite == false){
          absentees.push(staff);
        }
      }

      let goingToOrHasDeviated = this.GetMinutesLate(procedure);
      deviant = {
        procedure: procedure.text,
        staff: absentees,
        minutesLate: goingToOrHasDeviated.minutesLate,
        hasDeviated: goingToOrHasDeviated.hasDeviated
      };
      deviants.push(deviant)
    }
    return deviants;
  }

}
