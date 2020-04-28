import { Injectable } from "@angular/core";

export class Procedure {
    id:number;
    deptId:number;
    text: string;
    startDate: Date;
    endDate: Date;
}

export class Staff {
    firstName:string;
    lastName:string;
    id: number;
    deptId:number;
    phoneNr:string;
}

export class Schedule {
    id:number;
    startDate: Date;
    endDate: Date;
    staffId: number;
    onSite: boolean;
}

export class Dept {
    id:number;
    text:string;
}

export class Procedure_Schedule {
    procedureId: number;
    scheduleId: number;
    keyPerson: boolean;
}

export class ScheduledProcedure {
    id: number;
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
        color: "#d6d381"
    },
    {
        id:2,
        text: "Pågående",
        color: "#9cadf7"
    },
    {
        id:3,
        text: "Avvikelse",
        color: "#ff0000"
    },
    {
        id:4,
        text: "Slutförd",
        color: "#9cadf7"
    }
]

let procedure_scheduleData:Procedure_Schedule[] = [
    {
        scheduleId:11,
        procedureId:1,
        keyPerson:true
    },{
        scheduleId:12,
        procedureId:1,
        keyPerson:true
    },{
        scheduleId:13,
        procedureId:2,
        keyPerson:true
    },{
        scheduleId:11,
        procedureId:3,
        keyPerson:true
    },{
        scheduleId:14,
        procedureId:4,
        keyPerson:true
    },{
        scheduleId:13,
        procedureId:5,
        keyPerson:true
    },

]

let scheduledProcedureData: ScheduledProcedure[] = [
    {
        id: 1,
        text: "Operation",
        startDate: new Date(today.getTime() + 11 * 3600000),
        endDate: new Date(today.getTime() + 15 * 3600000),
        staffId: [1, 2],
        procedureId: 1,
        statusId:1

    },
    {
        id: 2,
        text: "Hörselkontroll",
        startDate: new Date(today.getTime() + 15 * 3600000),
        endDate: new Date(today.getTime() + 16.5 * 3600000),
        staffId: [3],
        procedureId: 3,
        statusId:1
    },
    {
        id: 3,
        text: "Lungmätning",
        startDate: new Date(today.getTime() + 15 * 3600000),
        endDate: new Date(today.getTime() + 16.5 * 3600000),
        staffId: [1],
        procedureId: 3,
        statusId:1
    },
    {
        id: 4,
        text: "Knäskålsrekonstruktion",
        startDate: new Date(today.getTime() + 8 * 3600000),
        endDate: new Date(today.getTime() + 11 * 3600000),
        staffId: [4],
        procedureId: 3,
        statusId:1
    },
    {
        id: 5,
        text: "Rutinkontroll",
        startDate: new Date(today.getTime() + 8 * 3600000),
        endDate: new Date(today.getTime() + 10 * 3600000),
        staffId: [3],
        procedureId: 3,
        statusId:1
    }
];

// let staffViewModelData: StaffViewModel[] = [
//     {
//         text: "Benjamin Ek",
//         id: 1
//     }, {
//         text: "Mattias Kenttä",
//         id: 2
//     }, {
//         text: "Eva Morlind",
//         id: 3
//     }, {
//         text: "Harry Potter",
//         id: 4
//     },
// ]

let procedureData: Procedure[] = [
    {
        id:1,
        text: "Operation",
        deptId:1,
        startDate: new Date(today.getTime() + 8 * 3600000),
        endDate: new Date(today.getTime() + 15 * 3600000)
    }, {
        id:2,
        text: "Spola lungor",
        deptId:1,
        startDate: new Date(today.getTime() + 8 * 3600000),
        endDate: new Date(today.getTime() + 13 * 3600000)
    }, {
        id:3,
        text: "Öronkontroll",
        deptId:1,
        startDate: new Date(today.getTime() + 8 * 3600000),
        endDate: new Date(today.getTime() + 13 * 3600000)
    }, {
        id:4,
        text: "Knäskålsrekonstruktion",
        deptId:1,
        startDate: new Date(today.getTime() + 8 * 3600000),
        endDate: new Date(today.getTime() + 13 * 3600000)
    },
    {
        id: 5,
        text: "Örfilning",
        deptId:1,
        startDate: new Date(today.getTime() + 9 * 3600000),
        endDate: new Date(today.getTime() + 12 * 3600000)
    }

];

let scheduleData: Schedule[] = [
    {        
        startDate: new Date(today.getTime() + 8.5 * 3600000),
        endDate: new Date(today.getTime() + 19 * 3600000),
        staffId: 1,
        onSite: true,
        id:10
    },
    {
        startDate: new Date(today.getTime() + 7 * 3600000),
        endDate: new Date(today.getTime() + 16 * 3600000),
        staffId: 2,
        onSite: true,
        id:11
    },
    {
        startDate: new Date(today.getTime() + 8 * 3600000),
        endDate: new Date(today.getTime() + 17 * 3600000),
        staffId: 3,
        onSite: true,
        id:12
    },
    {
        startDate: new Date(today.getTime() + 7 * 3600000),
        endDate: new Date(today.getTime() + 15 * 3600000),
        staffId: 4,
        onSite: false,
        id:13
    }

];

let staffData: Staff[] = [
  {
    firstName: "Benjamin",
    lastName: "Ek",
    phoneNr:"0729875641",
    id: 1,
    deptId:1
  }, {
    firstName: "Mattias",
    lastName: "Kenttä",
    phoneNr:"0729875641",
    id: 2,
    deptId:1
  }, {
    firstName: "Eva",
    lastName: "Morlind",
    phoneNr:"0729875641",
    id: 3,
    deptId:1
  }, {
    firstName: "Harry",
    lastName: "Potter",
    phoneNr:"0729875641",
    id: 4,
    deptId:1
  }
];

let departmentData: Dept[] = [{
    id: 1,
    text: "Coola avdelningen"
}];

@Injectable()
export class Service {
    getProcedures(){
        return procedureData;
    }
    getStaffs() {
        let staffViewModelData:StaffViewModel[] = [];

        for (let i = 0; i < staffData.length; i++) {
            const element = staffData[i];
            let staffViewModel:StaffViewModel = new StaffViewModel();

            staffViewModel = {
                id: element.id,
                text: element.firstName + " " + element.lastName
            };

            staffViewModelData.push(staffViewModel);
            
        }


        return staffViewModelData;
    }
    getSchedule(){
        return scheduleData;
    }
    getDepartment(){
        return departmentData;
    }
    getScheduledProcedures(){
        // let scheduledProcedureData: ScheduledProcedure[] = [];
        // for (let i = 0; i < procedure_scheduleData.length; i++) {
        //     const element = procedure_scheduleData[i];

        //     let procedure = procedureData.find(p => p.id = element.procedureId);
        //     let schedule = procedure_scheduleData.filter(p => p.procedureId = element.procedureId);
            
        //     let scheduleIds:number[] = [];

        //     for (let j = 0; j < schedule.length; j++) {
        //         const s = schedule[j];
        //         let staffSchedule = scheduleData.find(q => q.id = s.scheduleId);
        //         scheduleIds.push(staffSchedule.staffId);
        //     }

        //     let scheduledProcedure = new ScheduledProcedure();
            
        //     scheduledProcedure = {
        //         id: i,
        //         text: procedure.text,
        //         startDate: procedure.startDate,
        //         endDate: procedure.endDate,
        //         staffId: scheduleIds,
        //         procedureId: procedure.id,
        //         statusId: 1
        //     }
        //     scheduledProcedureData.push(scheduledProcedure);
        // }
        return scheduledProcedureData;
    }
    getStatus(){
        return procedureStatusData;
    }
    getEmployees(){
        return staffData;
    }
}