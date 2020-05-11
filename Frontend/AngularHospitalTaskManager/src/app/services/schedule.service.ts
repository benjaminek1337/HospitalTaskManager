import { Injectable } from "@angular/core";
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

export class Procedure {
    id: number;
    deptId: number;
    text: string;
    startDate: Date;
    endDate: Date;
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

export class Dept {
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
    }, {
        scheduleId: 16,
        procedureId: 6,
        keyPerson: true
    },
    {
        scheduleId: 15,
        procedureId: 8,
        keyPerson: true
    },
    {
        scheduleId: 15,
        procedureId: 7,
        keyPerson: true
    },

]

let procedureData: Procedure[] = [
    {
        id: 1,
        text: "Operation",
        deptId: 1,
        startDate: new Date(today.getTime() + 11 * 3600000),
        endDate: new Date(today.getTime() + 14 * 3600000)
    }, {
        id: 2,
        text: "Spola lungor",
        deptId: 1,
        startDate: new Date(today.getTime() + 9 * 3600000),
        endDate: new Date(today.getTime() + 11 * 3600000)
    }, {
        id: 3,
        text: "Öronkontroll",
        deptId: 1,
        startDate: new Date(today.getTime() + 17 * 3600000),
        endDate: new Date(today.getTime() + 18 * 3600000)
    }, {
        id: 4,
        text: "Knäskålsrekonstruktion",
        deptId: 1,
        startDate: new Date(today.getTime() + 8 * 3600000),
        endDate: new Date(today.getTime() + 12.5 * 3600000)
    },
    {
        id: 5,
        text: "Örfilning",
        deptId: 1,
        startDate: new Date(today.getTime() + 15 * 3600000),
        endDate: new Date(today.getTime() + 17 * 3600000)
    },
    {
        id: 6,
        text: "Skrämma Benjamin",
        deptId: 1,
        startDate: new Date(today.getTime() + 8.5 * 3600000),
        endDate: new Date(today.getTime() + 11 * 3600000)
    },
    {
        id: 7,
        text: "Skriva ut krumelurpiller",
        deptId: 1,
        startDate: new Date(today.getTime() + 11 * 3600000),
        endDate: new Date(today.getTime() + 14 * 3600000)
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
        startDate: new Date(today.getTime() + 6 * 3600000),
        endDate: new Date(today.getTime() + 14 * 3600000),
        staffId: 6,
        id: 15
    }
    ,
    {
        startDate: new Date(today.getTime() + 8 * 3600000),
        endDate: new Date(today.getTime() + 16 * 3600000),
        staffId: 7,
        id: 16
    }
    ,
    {
        startDate: new Date(today.getTime() + 16 * 3600000),
        endDate: new Date(today.getTime() + 23 * 3600000),
        staffId: 8,
        id: 17
    }
];

let staffData: Staff[] = [
    {
        firstName: "Benjamin",
        lastName: "Ek",
        phoneNr: "0729875641",
        id: 1,
        deptId: 1,
        onSite: false
    }, {
        firstName: "Mattias",
        lastName: "Kenttä",
        phoneNr: "0729875641",
        id: 2,
        deptId: 1,
        onSite: true
    }, {
        firstName: "Lena-Maria",
        lastName: "Öberg",
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
        onSite: false
    }, {
        firstName: "Karl",
        lastName: "Kvackzelius",
        phoneNr: "0729875641",
        id: 6,
        deptId: 1,
        onSite: true
    }, {
        firstName: "Malin",
        lastName: "Jönsson",
        phoneNr: "0729875641",
        id: 7,
        deptId: 1,
        onSite: true
    }, {
        firstName: "Emelie",
        lastName: "Öhman",
        phoneNr: "0729875641",
        id: 8,
        deptId: 1,
        onSite: true
    }
];

let departmentData: Dept[] = [{
    id: 1,
    text: "Coola avdelningen"
}];

@Injectable()
export class Service {

    http:HttpClient;
    constructor(http: HttpClient){
        this.http = http;
     }

    getSchedule() {
        return scheduleData;
    }
    getDepartment() {
        return departmentData;
    }

    getProcedures() {
        return procedureData;
    }

    getProcedure_Schedule(){
        return procedure_scheduleData;
    }
    getStatus() {
        return procedureStatusData;
    }

    url:string = "https://localhost:44336/api/";
    filepath:string = "../test.json";

    getEmployees() {
        return staffData;
    }

    GetStaff(){
        return staffData;
    }

}