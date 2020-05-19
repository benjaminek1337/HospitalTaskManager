import { Component, OnInit, Input } from '@angular/core';
import { Staff, Schedule, ScheduledProcedure } from "../../services/schedule.service"
import { DxoSearchPanelModule } from 'devextreme-angular/ui/nested';

@Component({
  selector: 'app-available-staff-list',
  templateUrl: './available-staff-list.component.html',
  styleUrls: ['./available-staff-list.component.css']
})
export class AvailableStaffListComponent implements OnInit {

  @Input()_scheduledProcedureData:ScheduledProcedure[];
  @Input()_scheduleData:Schedule[];
  @Input()_staffData:Staff[];

  availableStaff:Staff[];
  availableStaffOWH:Staff[];
  availableStaffCount:number;
  availableStaffOWHCount:number;

  currentTime:Date = new Date();
  //currentTime:Date = new Date("2020-05-14 11:00");
  
  search;

  constructor() {
  }

  interval1: any;
  interval2: any;
  ngOnInit() {
      this.availableStaff = this.GetAvailableStaff();
      this.availableStaffOWH = this.GetStaffOnSiteOutsideWorkhours();
      this.interval1 = setInterval(() => { this.availableStaff = this.GetAvailableStaff(); }, 60000);
      this.interval2 = setInterval(() => { this.availableStaffOWH = this.GetStaffOnSiteOutsideWorkhours(); }, 60000);
  }

  ngOnDestroy() {
      clearInterval(this.interval1);
      clearInterval(this.interval2)
  }

  GetAvailableStaff(){
    let availableStaff:Staff[] = [];
    for (let i = 0; i < this._staffData.length; i++) {
      const staff = this._staffData[i];
      
      let schedule = this._scheduleData.find(s => s.staffId == staff.id);
      let scheduledProcedures:ScheduledProcedure[] = this._scheduledProcedureData.filter(p => p.staffId.find(id => id == staff.id));
      let isAvailable:boolean = true;

      for (let j = 0; j < scheduledProcedures.length; j++) {
        const element = scheduledProcedures[j];
        if(Date.parse(element.startDate.toString()) <= this.currentTime.getTime() 
        && this.currentTime.getTime() <= Date.parse(element.endDate.toString()))
        {
          isAvailable = false;
          break;
        }
      }
      if(schedule == null || this.currentTime.getTime() < Date.parse(schedule.startDate.toString()) 
      || this.currentTime.getTime() > Date.parse(schedule.endDate.toString())){
        isAvailable = false;
      }
      if(isAvailable && staff.onSite){
        availableStaff.push(staff);
      }
    }
    this.availableStaffCount = availableStaff.length;
    return availableStaff;
  }

  GetStaffOnSiteOutsideWorkhours(){
    let availableStaffOWH:Staff[] = [];
    for (let i = 0; i < this._staffData.length; i++) {
      const staff = this._staffData[i];
      
      let schedule = this._scheduleData.find(s => s.staffId == staff.id);
      let scheduledProcedures:ScheduledProcedure[] = this._scheduledProcedureData.filter(p => p.staffId.find(id => id == staff.id));
      let isAvailable:boolean = true;

      for (let j = 0; j < scheduledProcedures.length; j++) {
        const element = scheduledProcedures[j];
        if(Date.parse(element.startDate.toString()) <= this.currentTime.getTime() 
        && this.currentTime.getTime() <= Date.parse(element.endDate.toString()))
        {
          isAvailable = false;
          break;
        }
      }
      if(schedule != null && this.currentTime.getTime() > Date.parse(schedule.startDate.toString()) 
      && this.currentTime.getTime() < Date.parse(schedule.endDate.toString())){
        isAvailable = false;
      }
      if(isAvailable && staff.onSite){
        availableStaffOWH.push(staff);
      }
    }
    this.availableStaffOWHCount = availableStaffOWH.length;
    return availableStaffOWH;
  }


}
