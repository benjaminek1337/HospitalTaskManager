import { Component, OnInit, Input } from '@angular/core';
import { Service, ScheduledProcedure, Schedule, Staff, Procedure_Schedule } from '../../services/schedule.service';
import Query from "devextreme/data/query"
import { kMaxLength } from 'buffer';

@Component({
  selector: 'app-statuscenter',
  templateUrl: './statuscenter.component.html',
  styleUrls: ['./statuscenter.component.css']
})
export class StatuscenterComponent implements OnInit {

  @Input()scheduledProcedureData:ScheduledProcedure[];
  @Input()scheduleData:Schedule[];
  @Input()staffData:Staff[];
  currentDate: Date = new Date();
  deviationCount:Number;
  //currentDate:Date = new Date("2020-05-14 11:00");
  isLoaded:boolean;
  constructor(service:Service) {}


  interval1: any;
  ngOnInit() {
      this.GetDeviantProceduresStatus();
      this.interval1 = setInterval(() => { this.GetDeviantProceduresStatus(); }, 30000);
  }

  ngOnDestroy() {
      clearInterval(this.interval1);
  }

  GetMinutesLate(procedure:ScheduledProcedure){
    let goingToOrHasDeviated:{ minutesLate:number, hasDeviated:number };
    
    if (this.currentDate.getTime() >= Date.parse(procedure.startDate.toString())){
      goingToOrHasDeviated = {
        minutesLate: Math.round(this.currentDate.getTime()/60000 - Date.parse(procedure.startDate.toString())/60000),
        hasDeviated: 1 
      }
    }
    else{
      
      goingToOrHasDeviated = {
        minutesLate: Math.round(Date.parse(procedure.startDate.toString())/60000 - Date.parse(this.currentDate.toString())/60000),
        hasDeviated: 0 
      }
    }
    
    return goingToOrHasDeviated;
  }

  GetSortedDeviations(deviants:any){
    deviants.sort((a, b) => a.hasDeviated - b.hasDeviated || a.minutesLate - b.minutesLate )
    return deviants
  }

  GetDeviantProceduresStatus(){
    this.isLoaded = false;
    
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
        if(staff.onSite == false){
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
    this.isLoaded = true;
    this.deviationCount = deviants.length;
    //setTimeout(() => {this.ngOnInit()}, 150);
    return this.GetSortedDeviations(deviants);
  }

}
