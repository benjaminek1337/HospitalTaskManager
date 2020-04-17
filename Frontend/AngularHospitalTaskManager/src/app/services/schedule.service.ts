import { Injectable } from "@angular/core";

export class Procedure {
    id:number;
    deptId:number;
    text: string;
}

export class Staff {
    firstName:string;
    lastName:string;
    id: number;
    departmentId:number;
    phoneNr:string;
}

export class Schedule {
    id:number;
    startDate: Date;
    endDate: Date;
    staffId: number;
    color: string;
    onSite: boolean;
}

export class Dept {
    id:number;
    text:string;
}

export class Procedure_Schedule {
    ProcedureId: number;
    ScheduleId: number;
    KeyPerson: boolean;
}

export class ScheduledProcedure {
    text:string;
    startDate: Date;
    endDate: Date;
    staffId: number[];
    procedureId: number;
    statusId:number;
}

export class StaffViewModel
{
    text: string;
    id: number;
    onSite: boolean;
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
        id:1,
        text: "Planerad",
        color: "#4287f5"
    },
    {
        id:2,
        text: "Påbörjad",
        color: "#00bfb6"
    },
    {
        id:3,
        text: "Avvikelse",
        color: "#ff0000"
    },
    {
        id:4,
        text: "Slutförd",
        color: "#00c911"
    }
]

let scheduledProcedureData: ScheduledProcedure[] = [
    {
        text: "Operation",
        startDate: new Date(today.getTime() + 8 * 3600000),
        endDate: new Date(today.getTime() + 11 * 3600000),
        staffId: [1, 2],
        procedureId: 1,
        statusId:1

    },
    {
        text: "Öronkontroll",
        startDate: new Date(today.getTime() + 12 * 3600000),
        endDate: new Date(today.getTime() + 16 * 3600000),
        staffId: [3],
        procedureId: 3,
        statusId:1
    },
    {
        text: "Lungmätning",
        startDate: new Date(today.getTime() + 15 * 3600000),
        endDate: new Date(today.getTime() + 18 * 3600000),
        staffId: [1],
        procedureId: 3,
        statusId:1
    },
    {
        text: "Knäskålsrekonstruktion",
        startDate: new Date(today.getTime() + 18 * 3600000),
        endDate: new Date(today.getTime() + 24 * 3600000),
        staffId: [4],
        procedureId: 3,
        statusId:1
    }
];

let staffViewModelData: StaffViewModel[] = [
    {
        text: "Benjamin Ek",
        id: 1,
        onSite: true
    }, {
        text: "Mattias Kenttä",
        id: 2,
        onSite: true
    }, {
        text: "Eva Morlind",
        id: 3,
        onSite: false
    }, {
        text: "Harry Potter",
        id: 4,
        onSite: true
    }
]

let procedureData: Procedure[] = [
    {
        id:1,
        text: "Operation",
        deptId:1
    }, {
        id:2,
        text: "Spola lungor",
        deptId:1
    }, {
        id:3,
        text: "Öronkontroll",
        deptId:1
    }, {
        id:4,
        text: "Knäskålsrekonstruktion",
        deptId:1
    }, {
        id:5,
        text: "Dra och fiska",
        deptId:1
    }, {
        id:6,
        text:"Nattvakt",
        deptId:1
    }

];

let scheduleData: Schedule[] = [
    {        
        startDate: new Date(today.getTime() + 7 * 3600000),
        endDate: new Date(today.getTime() + 17 * 3600000),
        staffId: 1,
        color: "#dae8de",
        onSite: true,
        id:10
    },
    {
        startDate: new Date(today.getTime() + 10 * 3600000),
        endDate: new Date(today.getTime() + 19 * 3600000),
        staffId: 2,
        color: "dae8de",
        onSite: false,
        id:11
    },
    {
        startDate: new Date(today.getTime() + 18 * 3600000),
        endDate: new Date(today.getTime() + 24 * 3600000),
        staffId: 3,
        color: "dae8de",
        onSite: true,
        id:12
    },
    {
        startDate: new Date(today.getTime() + 0 * 3600000),
        endDate: new Date(today.getTime() + 7 * 3600000),
        staffId: 4,
        color: "dae8de",
        onSite: false,
        id:13
    }

]

let staffData: Staff[] = [
  {
    firstName: "Benjamin",
    lastName: "Ek",
    phoneNr:"0729875641",
    id: 1,
    departmentId:1
  }, {
    firstName: "Johannes",
    lastName: "Lundkvist",
    phoneNr:"0729875641",
    id: 2,
    departmentId:1
  }, {
    firstName: "Harry",
    lastName: "Potter",
    phoneNr:"0729875641",
    id: 3,
    departmentId:1
  }, {
    firstName: "Gandalf",
    lastName: "Gråskägge",
    phoneNr:"0729875641",
    id: 4,
    departmentId:1
  }
];

let departmentData: Dept[] = [{
    id: 1,
    text: "Coola avdelningen"
}];

@Injectable()
export class Service {
    getAppointments(){
        return procedureData;
    }
    getStaffs() {
        return staffViewModelData;
    }
    getSchedule(){
        return scheduleData;
    }
    getDepartment(){
        return departmentData;
    }
    getScheduledProcedures(){
        return scheduledProcedureData;
    }
    getStatus(){
        return procedureStatusData;
    }
}