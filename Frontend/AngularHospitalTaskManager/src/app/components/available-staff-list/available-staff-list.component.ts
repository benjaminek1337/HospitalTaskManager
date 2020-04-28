import { Component, OnInit } from '@angular/core';
import { Service, Staff, Schedule, ScheduledProcedure } from "../../services/schedule.service"
import { DxoSearchPanelModule } from 'devextreme-angular/ui/nested';

@Component({
  selector: 'app-available-staff-list',
  templateUrl: './available-staff-list.component.html',
  styleUrls: ['./available-staff-list.component.css']
})
export class AvailableStaffListComponent implements OnInit {

  staffData:Staff[];
  scheduleData:Schedule[];
  scheduledProcedureData:ScheduledProcedure[];
  availableStaff:Staff[];
  availableStaffOWH:Staff[];

  currentTime:Date = new Date();
  

  search;

  constructor(service:Service) {
    this.staffData = service.getEmployees();
    this.scheduleData = service.getSchedule();
    this.scheduledProcedureData = service.getScheduledProcedures();
    this.availableStaff = this.GetAvailableStaff();
    this.availableStaffOWH = this.GetStaffOnSiteOutsideWorkhours();
     }

  ngOnInit(): void {
  }

  GetAvailableStaff(){
    let availableStaff:Staff[] = [];
    for (let i = 0; i < this.staffData.length; i++) {
      const staff = this.staffData[i];

      let scheduledProcedures:ScheduledProcedure[] = this.scheduledProcedureData.filter(p => p.staffId.find(id => id == staff.id))
      let schedule = this.scheduleData.find(g => g.staffId == staff.id)
      let isAvailable:boolean = true;

      for (let j = 0; j < scheduledProcedures.length; j++) {
        const element = scheduledProcedures[j];
        if(element.startDate <= this.currentTime && this.currentTime <= element.endDate)
        {
          isAvailable = false;
        }
        else if(this.currentTime < schedule.startDate || this.currentTime > schedule.endDate){
          isAvailable = false;
        }
      }
      if(isAvailable && schedule.onSite){
        availableStaff.push(staff);
      }
    }
    return availableStaff;
  }

  GetStaffOnSiteOutsideWorkhours(){
    let availableStaffOWH:Staff[] = [];
    for (let i = 0; i < this.staffData.length; i++) {
      const staff = this.staffData[i];

      let scheduledProcedures:ScheduledProcedure[] = this.scheduledProcedureData.filter(p => p.staffId.find(id => id == staff.id))
      let schedule = this.scheduleData.find(g => g.staffId == staff.id)
      let isAvailable:boolean = true;

      for (let j = 0; j < scheduledProcedures.length; j++) {
        const element = scheduledProcedures[j];
        if(element.startDate <= this.currentTime && this.currentTime <= element.endDate)
        {
          isAvailable = false;
        }
        else if(this.currentTime > schedule.startDate && this.currentTime < schedule.endDate){
          isAvailable = false;
        }
      }
      if(isAvailable && schedule.onSite){
        availableStaffOWH.push(staff);
      }
    }
    return availableStaffOWH;
  }

}
