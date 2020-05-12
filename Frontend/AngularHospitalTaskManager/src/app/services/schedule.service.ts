import { Injectable } from "@angular/core";
import { HttpClient } from '@angular/common/http';
import { Observable, forkJoin } from 'rxjs';
import { DatePipe } from '@angular/common';

export class Procedure {
    id: number;
    deptId: number;
    text: string;
    startDate: Date;
    endDate: Date;
    isHandled:Boolean;
}

export interface Staff {
    firstName: string;
    lastName: string;
    id: number;
    deptId: number;
    phoneNr: string;
    onSite:boolean;
}

export class Schedule {
    id: number;
    startDate: Date;
    endDate: Date;
    staffId: number;
}

export class Department {
    id: number;
    text: string;
}

export class Procedure_Schedule {
    procedureId: number;
    scheduleId: number;
    keyPerson: boolean;
}

export interface AllData {
    departments:Department[];
    procedures:Procedure[];
    schedules:Schedule[];
    procedure_schedule:Procedure_Schedule[];
    staffs:Staff[];
}

export class ScheduledProcedure {
    id: number;
    text: string;
    startDate: Date;
    endDate: Date;
    staffId: number[];
    procedureId: number;
    statusId: number;
}

export class ProcedureStatus {
    id: number;
    text: string;
    color: string;
}

let procedureStatusData: ProcedureStatus[] = [
    {
        id: 1,
        text: "Utan problem",
        color: "#9cadf7"
    },
    {
        id: 2,
        text: "Avvikelse påväg",
        color: "#f5902c"
    },
    {
        id: 3,
        text: "Avvikelse skedd",
        color: "#ff0000"
    }
]

@Injectable()
export class Service {

    //TODO FIXA DATUM TILL ALLA CALLS SOM KRÄVE DEM

    url:string = "https://localhost:44336/api/schedule/";
    http:HttpClient;
    datePipe:DatePipe;
    constructor(http: HttpClient, datePipe:DatePipe){
        this.http = http;
        this.datePipe = datePipe;
     }

    GetInitScheduleData(date:Date):Observable<any[]> {
        return this.http.get<AllData[]>(this.url + "initdata/" + this.datePipe.transform(date, "yyyy-MM-dd"));
        // let staffs = this.GetStaff(date);
        // let schedules = this.getSchedule(date);
        // let procedures = this.getProcedures(date);
        // let procedure_schedule = this.getProcedure_Schedule(date);
        // return Observable.forkJoin([staffs, schedules, procedures, procedure_schedule]);

    }

    getSchedule(date:Date):Observable<Schedule[]> {
        return this.http.get<Schedule[]>(this.url + "schedules/" + this.datePipe.transform(date, "yyyy-MM-dd"));
    }

    getDepartment():Observable<Department[]> {
        return this.http.get<Department[]>(this.url + "departments");
    }

    getProcedures(date:Date):Observable<Procedure[]> {
        return this.http.get<Procedure[]>(this.url + "procedures/" + this.datePipe.transform(date, "yyyy-MM-dd"));
    }

    getProcedure_Schedule(date:Date):Observable<Procedure_Schedule[]>{
        return this.http.get<Procedure_Schedule[]>(this.url + "scheduledprocedures/" + this.datePipe.transform(date, "yyyy-MM-dd"));
    }

    getStatus() {
        return procedureStatusData;
    }

    GetStaff(date:Date):Observable<Staff[]>{
        return this.http.get<Staff[]>(this.url + "staff/" + this.datePipe.transform(date, "yyyy-MM-dd"));
    }

}