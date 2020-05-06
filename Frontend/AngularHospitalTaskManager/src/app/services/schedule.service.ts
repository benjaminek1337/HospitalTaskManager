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
}

export class Schedule {
    id: number;
    startDate: Date;
    endDate: Date;
    staffId: number;
    onSite: boolean;
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

export class StaffViewModel {
    text: string;
    id: number;
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
        startDate: new Date(today.getTime() + 13.5 * 3600000),
        endDate: new Date(today.getTime() + 15.5 * 3600000)
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
    }

];

let scheduleData: Schedule[] = [
    {
        startDate: new Date(today.getTime() + 8.5 * 3600000),
        endDate: new Date(today.getTime() + 19 * 3600000),
        staffId: 1,
        onSite: false,
        id: 10
    },
    {
        startDate: new Date(today.getTime() + 7 * 3600000),
        endDate: new Date(today.getTime() + 16 * 3600000),
        staffId: 2,
        onSite: true,
        id: 11
    },
    {
        startDate: new Date(today.getTime() + 8 * 3600000),
        endDate: new Date(today.getTime() + 17 * 3600000),
        staffId: 3,
        onSite: true,
        id: 12
    },
    {
        startDate: new Date(today.getTime() + 7 * 3600000),
        endDate: new Date(today.getTime() + 15 * 3600000),
        staffId: 4,
        onSite: false,
        id: 13
    },
    {
        startDate: new Date(today.getTime() + 14 * 3600000),
        endDate: new Date(today.getTime() + 22 * 3600000),
        staffId: 5,
        onSite: false,
        id: 14
    },
    {
        startDate: new Date(today.getTime() + 0 * 3600000),
        endDate: new Date(today.getTime() + 10 * 3600000),
        staffId: 6,
        onSite: true,
        id: 15
    }
    ,
    {
        startDate: new Date(today.getTime() + 0 * 3600000),
        endDate: new Date(today.getTime() + 10 * 3600000),
        staffId: 7,
        onSite: true,
        id: 16
    }
    ,
    {
        startDate: new Date(today.getTime() + 0 * 3600000),
        endDate: new Date(today.getTime() + 10 * 3600000),
        staffId: 8,
        onSite: true,
        id: 17
    }
    ,
    {
        startDate: new Date(today.getTime() + 0 * 3600000),
        endDate: new Date(today.getTime() + 10 * 3600000),
        staffId: 9,
        onSite: true,
        id: 18
    }
    ,
    {
        startDate: new Date(today.getTime() + 0 * 3600000),
        endDate: new Date(today.getTime() + 10 * 3600000),
        staffId: 10,
        onSite: true,
        id: 19
    }
    ,
    {
        startDate: new Date(today.getTime() + 0 * 3600000),
        endDate: new Date(today.getTime() + 10 * 3600000),
        staffId: 11,
        onSite: true,
        id: 20
    }
    ,
    {
        startDate: new Date(today.getTime() + 0 * 3600000),
        endDate: new Date(today.getTime() + 10 * 3600000),
        staffId: 12,
        onSite: true,
        id: 21
    }
    ,
    {
        startDate: new Date(today.getTime() + 0 * 3600000),
        endDate: new Date(today.getTime() + 10 * 3600000),
        staffId: 13,
        onSite: true,
        id: 22
    }

];

let staffData: Staff[] = [
    {
        firstName: "Benjamin",
        lastName: "Ek",
        phoneNr: "0729875641",
        id: 1,
        deptId: 1
    }, {
        firstName: "Mattias",
        lastName: "Kenttä",
        phoneNr: "0729875641",
        id: 2,
        deptId: 1
    }, {
        firstName: "Eva",
        lastName: "Morlind",
        phoneNr: "0729875641",
        id: 3,
        deptId: 1
    }, {
        firstName: "Harry",
        lastName: "Hormoz",
        phoneNr: "0729875641",
        id: 4,
        deptId: 1
    }, {
        firstName: "Stina",
        lastName: "Wolter",
        phoneNr: "0729875641",
        id: 5,
        deptId: 1
    }, {
        firstName: "Karl",
        lastName: "Kvackzelius",
        phoneNr: "0729875641",
        id: 6,
        deptId: 1
    }, {
        firstName: "Karl",
        lastName: "Kvackzelius",
        phoneNr: "0729875641",
        id: 7,
        deptId: 1
    }, {
        firstName: "Karl",
        lastName: "Kvackzelius",
        phoneNr: "0729875641",
        id: 8,
        deptId: 1
    }, {
        firstName: "Karl",
        lastName: "Kvackzelius",
        phoneNr: "0729875641",
        id: 9,
        deptId: 1
    }, {
        firstName: "Karl",
        lastName: "Kvackzelius",
        phoneNr: "0729875641",
        id: 10,
        deptId: 1
    }, {
        firstName: "Karl",
        lastName: "Kvackzelius",
        phoneNr: "0729875641",
        id: 11,
        deptId: 1
    }, {
        firstName: "Karl",
        lastName: "Kvackzelius",
        phoneNr: "0729875641",
        id: 12,
        deptId: 1
    }, {
        firstName: "Karl",
        lastName: "Kvackzelius",
        phoneNr: "0729875641",
        id: 13,
        deptId: 1
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


    getProcedures() {
        return procedureData;
    }
    getStaffs() {
        let staffViewModelData: StaffViewModel[] = [];

        for (let i = 0; i < staffData.length; i++) {
            const element = staffData[i];
            let staffViewModel: StaffViewModel = new StaffViewModel();

            staffViewModel = {
                id: element.id,
                text: element.firstName + " " + element.lastName
            };

            staffViewModelData.push(staffViewModel);
        }
        return staffViewModelData;
    }
    getSchedule() {
        return scheduleData;
    }
    getDepartment() {
        return departmentData;
    }
    getScheduledProcedures() {
        let scheduledProcedureData: ScheduledProcedure[] = [];
        for (let i = 0; i < procedure_scheduleData.length; i++) {
            const element = procedure_scheduleData[i];

            let procedure = procedureData.find(p => p.id == element.procedureId);
            let schedule = procedure_scheduleData.filter(p => p.procedureId == element.procedureId);

            let scheduleIds: number[] = [];

            for (let j = 0; j < schedule.length; j++) {
                try {
                    const s = schedule[j];
                    let staffSchedule = scheduleData.find(q => q.id == s.scheduleId);
                    scheduleIds.push(staffSchedule.staffId);
                } catch (error) {
                    console.log(error);
                }
            }

            if (procedure != null) {
                let scheduledProcedure = new ScheduledProcedure();

                scheduledProcedure = {
                    id: i,
                    text: procedure.text,
                    startDate: procedure.startDate,
                    endDate: procedure.endDate,
                    staffId: scheduleIds,
                    procedureId: procedure.id,
                    statusId: 1
                }
                scheduledProcedureData.push(scheduledProcedure);
            }
        }
        return scheduledProcedureData.filter((obj, index, self) => self.findIndex(s => s.procedureId === obj.procedureId) === index);
    }
    getStatus() {
        return procedureStatusData;
    }

    url:string = "https://localhost:44336/api/";
    filepath:string = "../test.json";

    getEmployees() {
        return staffData;
    }

    fungeraHoraSatan():Observable<Staff[]>{
        return this.http.get<Staff[]>(this.url + "values");
    }

}