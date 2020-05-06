import { Component, OnInit, Input } from '@angular/core';
import { Staff, Schedule, ScheduledProcedure } from "../../services/schedule.service"
import { DxoSearchPanelModule } from 'devextreme-angular/ui/nested';

@Component({
  selector: 'app-available-staff-list',
  templateUrl: './available-staff-list.component.html',
  styleUrls: ['./available-staff-list.component.css']
})
export class AvailableStaffListComponent implements OnInit {

  // staffData:Staff[];
  // scheduleData:Schedule[];
  // scheduledProcedureData:ScheduledProcedure[];

  @Input()_scheduledProcedureData:ScheduledProcedure[];
  @Input()_scheduleData:Schedule[];
  @Input()_staffData:Staff[];

  availableStaff:Staff[];
  availableStaffOWH:Staff[];

  currentTime:Date = new Date();
  
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

      let scheduledProcedures:ScheduledProcedure[] = this._scheduledProcedureData.filter(p => p.staffId.find(id => id == staff.id))
      let schedule = this._scheduleData.find(g => g.staffId == staff.id)
      let isAvailable:boolean = true;

      for (let j = 0; j < scheduledProcedures.length; j++) {
        const element = scheduledProcedures[j];
        if(element.startDate <= this.currentTime && this.currentTime <= element.endDate)
        {
          isAvailable = false;
        }
      }
      if(this.currentTime < schedule.startDate || this.currentTime > schedule.endDate){
        isAvailable = false;
      }
      if(isAvailable && schedule.onSite){
        availableStaff.push(staff);
      }
    }
    return availableStaff;
  }

  GetStaffOnSiteOutsideWorkhours(){
    let availableStaffOWH:Staff[] = [];
    for (let i = 0; i < this._staffData.length; i++) {
      const staff = this._staffData[i];

      let scheduledProcedures:ScheduledProcedure[] = this._scheduledProcedureData.filter(p => p.staffId.find(id => id == staff.id))
      let schedule = this._scheduleData.find(g => g.staffId == staff.id)
      let isAvailable:boolean = true;

      for (let j = 0; j < scheduledProcedures.length; j++) {
        const element = scheduledProcedures[j];
        if(element.startDate <= this.currentTime && this.currentTime <= element.endDate)
        {
          isAvailable = false;
        }
      }
      if(this.currentTime > schedule.startDate && this.currentTime < schedule.endDate){
        isAvailable = false;
      }
      if(isAvailable && schedule.onSite){
        availableStaffOWH.push(staff);
      }
    }
    return availableStaffOWH;
  }

}
