import { Injectable } from "@angular/core";
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

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


let today = new Date();
today.setHours(0, 0, 0, 0);
//today.setDate(today.getDate() - today.getDay() + 3);

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

let procedure_scheduleData: Procedure_Schedule[] = [
    {
        scheduleId: 10,
        procedureId: 1,
        keyPerson: true
    }, {
        scheduleId: 11,
        procedureId: 1,
        keyPerson: true
    }, {
        scheduleId: 12,
        procedureId: 2,
        keyPerson: true
    }, {
        scheduleId: 10,
        procedureId: 3,
        keyPerson: true
    }, {
        scheduleId: 13,
        procedureId: 4,
        keyPerson: true
    }, {
        scheduleId: 14,
        procedureId: 5,
        keyPerson: true
    }, {
        scheduleId: 12,
        procedureId: 5,
        keyPerson: true
    },

]

let procedureData: Procedure[] = [
    {
        id: 1,
        text: "Operation",
        deptId: 1,
        startDate: new Date(today.getTime() + 10 * 3600000),
        endDate: new Date(today.getTime() + 15.5 * 3600000),
        isHandled:false
    }, {
        id: 2,
        text: "Spola lungor",
        deptId: 1,
        startDate: new Date(today.getTime() + 9 * 3600000),
        endDate: new Date(today.getTime() + 11 * 3600000),
        isHandled:false
    }, {
        id: 3,
        text: "Öronkontroll",
        deptId: 1,
        startDate: new Date(today.getTime() + 17 * 3600000),
        endDate: new Date(today.getTime() + 18 * 3600000),
        isHandled:false
    }, {
        id: 4,
        text: "Knäskålsrekonstruktion",
        deptId: 1,
        startDate: new Date(today.getTime() + 8 * 3600000),
        endDate: new Date(today.getTime() + 12.5 * 3600000),
        isHandled:false
    },
    {
        id: 5,
        text: "Örfilning",
        deptId: 1,
        startDate: new Date(today.getTime() + 15 * 3600000),
        endDate: new Date(today.getTime() + 17 * 3600000),
        isHandled:false
    }

];

let scheduleData: Schedule[] = [
    {
        startDate: new Date(today.getTime() + 8.5 * 3600000),
        endDate: new Date(today.getTime() + 19 * 3600000),
        staffId: 1,
        id: 10
    },
    {
        startDate: new Date(today.getTime() + 7 * 3600000),
        endDate: new Date(today.getTime() + 16 * 3600000),
        staffId: 2,
        id: 11
    },
    {
        startDate: new Date(today.getTime() + 8 * 3600000),
        endDate: new Date(today.getTime() + 17 * 3600000),
        staffId: 3,
        id: 12
    },
    {
        startDate: new Date(today.getTime() + 7 * 3600000),
        endDate: new Date(today.getTime() + 15 * 3600000),
        staffId: 4,
        id: 13
    },
    {
        startDate: new Date(today.getTime() + 14 * 3600000),
        endDate: new Date(today.getTime() + 22 * 3600000),
        staffId: 5,
        id: 14
    },
    {
        startDate: new Date(today.getTime() + 0 * 3600000),
        endDate: new Date(today.getTime() + 10 * 3600000),
        staffId: 6,
        id: 15
    }
    ,
    {
        startDate: new Date(today.getTime() + 0 * 3600000),
        endDate: new Date(today.getTime() + 10 * 3600000),
        staffId: 7,
        id: 16
    }
    ,
    {
        startDate: new Date(today.getTime() + 0 * 3600000),
        endDate: new Date(today.getTime() + 10 * 3600000),
        staffId: 8,
        id: 17
    }
    ,
    {
        startDate: new Date(today.getTime() + 0 * 3600000),
        endDate: new Date(today.getTime() + 10 * 3600000),
        staffId: 9,
        id: 18
    }
    ,
    {
        startDate: new Date(today.getTime() + 0 * 3600000),
        endDate: new Date(today.getTime() + 10 * 3600000),
        staffId: 10,
        id: 19
    }
    ,
    {
        startDate: new Date(today.getTime() + 0 * 3600000),
        endDate: new Date(today.getTime() + 10 * 3600000),
        staffId: 11,
        id: 20
    }
    ,
    {
        startDate: new Date(today.getTime() + 0 * 3600000),
        endDate: new Date(today.getTime() + 10 * 3600000),
        staffId: 12,
        id: 21
    }
    ,
    {
        startDate: new Date(today.getTime() + 0 * 3600000),
        endDate: new Date(today.getTime() + 10 * 3600000),
        staffId: 13,
        id: 22
    }
];

let staffData: Staff[] = [
    {
        firstName: "Benjamin",
        lastName: "Ek",
        phoneNr: "0729875641",
        id: 1,
        deptId: 1,
        onSite: true
    }, {
        firstName: "Mattias",
        lastName: "Kenttä",
        phoneNr: "0729875641",
        id: 2,
        deptId: 1,
        onSite: true
    }, {
        firstName: "Eva",
        lastName: "Morlind",
        phoneNr: "0729875641",
        id: 3,
        deptId: 1,
        onSite: true
    }, {
        firstName: "Harry",
        lastName: "Hormoz",
        phoneNr: "0729875641",
        id: 4,
        deptId: 1,
        onSite: false
    }, {
        firstName: "Stina",
        lastName: "Wolter",
        phoneNr: "0729875641",
        id: 5,
        deptId: 1,
        onSite: true
    }, {
        firstName: "Karl",
        lastName: "Kvackzelius",
        phoneNr: "0729875641",
        id: 6,
        deptId: 1,
        onSite: true
    }, {
        firstName: "Karl",
        lastName: "Kvackzelius",
        phoneNr: "0729875641",
        id: 7,
        deptId: 1,
        onSite: true
    }, {
        firstName: "Karl",
        lastName: "Kvackzelius",
        phoneNr: "0729875641",
        id: 8,
        deptId: 1,
        onSite: true
    }, {
        firstName: "Karl",
        lastName: "Kvackzelius",
        phoneNr: "0729875641",
        id: 9,
        deptId: 1,
        onSite: true
    }, {
        firstName: "Karl",
        lastName: "Kvackzelius",
        phoneNr: "0729875641",
        id: 10,
        deptId: 1,
        onSite: true
    }, {
        firstName: "Karl",
        lastName: "Kvackzelius",
        phoneNr: "0729875641",
        id: 11,
        deptId: 1,
        onSite: true
    }, {
        firstName: "Karl",
        lastName: "Kvackzelius",
        phoneNr: "0729875641",
        id: 12,
        deptId: 1,
        onSite: true
    }, {
        firstName: "Karl",
        lastName: "Kvackzelius",
        phoneNr: "0729875641",
        id: 13,
        deptId: 1,
        onSite: true
    }
    , {
        firstName: "Ksdfsfg",
        lastName: "asdasd",
        phoneNr: "0729875641",
        id: 14,
        deptId: 1,
        onSite: true
    }
];

let departmentData: Department[] = [{
    id: 1,
    text: "Coola avdelningen"
}];

@Injectable()
export class Service {

    //TODO FIXA DATUM TILL ALLA CALLS SOM KRÄVE DEM

    url:string = "https://localhost:44336/api/schedule/";
    http:HttpClient;
    constructor(http: HttpClient){
        this.http = http;
     }

    getSchedule(date:Date):Observable<Schedule[]> {
        return this.http.get<Schedule[]>(this.url + "schedules/" + date.getDate());
    }
    getDepartment():Observable<Department[]> {
        return this.http.get<Department[]>(this.url + "/department");
    }

    getProcedures(date:Date):Observable<Procedure[]> {
        return this.http.get<Procedure[]>(this.url + "procedures/" + date.getDate());
    }

    getProcedure_Schedule(date:Date):Observable<Procedure_Schedule[]>{
        return this.http.get<Procedure_Schedule[]>(this.url + "scheduledprocedures/" + date.getDate());
    }
    getStatus() {
        return procedureStatusData;
    }

    GetStaff(date:Date):Observable<Staff[]>{
        return this.http.get<Staff[]>(this.url + "staff/" + date.getDate());
    }

}