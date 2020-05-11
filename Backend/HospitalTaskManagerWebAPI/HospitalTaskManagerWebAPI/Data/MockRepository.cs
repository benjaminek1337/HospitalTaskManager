using HospitalTaskManagerWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalTaskManagerWebAPI.Data
{
    public class MockRepository : IRepository
    {
        private readonly List<string> firstNames = new List<string>();
        private readonly List<string> lastNames = new List<string>();
        private readonly List<string> procedureNames = new List<string>();

        private readonly Random random = new Random();
        private readonly Random random2 = new Random();
        private DateTime dateNow = DateTime.Now;

        private readonly List<Status> statuses = new List<Status>();
        private readonly List<Department> departments = new List<Department>();
        private List<Procedure> procedures = new List<Procedure>();
        private List<Schedule> schedules = new List<Schedule>();
        private List<Staff> staffs = new List<Staff>();
        private List<ScheduledProcedure> scheduledProcedures = new List<ScheduledProcedure>();


        public MockRepository()
        {
            firstNames.AddRange(new List<string>{
                "Benjamin",
                "Katja",
                "Silver",
                "Mattias",
                "Kalle",
                "Savanna",
                "Stina",
                "Krösus",
                "Gandalf",
                "CourageWolf",
                "Mario",
                "Super",
                "Nikolaj",
                "Svetlana",
                "Tyrion"
            });
            lastNames.AddRange(new List<string>{
                "Ek",
                "Sork",
                "Gråskägge",
                "Hormoz",
                "Kvackzelius",
                "Anka",
                "Woltersson",
                "Segelspjut",
                "Fritjiofsdottir",
                "Krunkenstör",
                "Adrafsfader",
                "Von Röfvenstråhle",
                "Kenttä",
                "Ramone",
                "Skraputnik",
                "Mario",
                "Springsteen",
                "Filling",
                "Lannister"
            });
            procedureNames.AddRange(new List<string>
            {
                "Operation",
                "Knäskålsrekonstruktion",
                "Öronkontroll",
                "Lungmätning",
                "Skriva ut krumelurpiller",
                "Ögonkorrigering",
                "Injicera dunderhonung",
                "Skapa vaccin för kåråna",
                "Tandskrapning",
                "Botoxa stortår",
                "Laga stormiddag",
                "Tömma analsäck",
                "Ge filiduttvaccin",
                "Genkodning",
                "Dyrka Satan",
                "Rutinkontroll",
                "Skälla ut praktikanten",
                "Programmera statuslistan"
            });
            statuses.AddRange(new List<Status>
            {
                new Status
                {
                    ID = 1,
                    Text = "Utan problem",
                    Color = "#9cadf7"
                },
                new Status
                {
                    ID = 2,
                    Text = "Kommande avvikelse",
                    Color = "#f5902c"
                },
                new Status
                {
                    ID = 3,
                    Text = "Avvikelse skedd",
                    Color = "#ff0000"
                }
            });
            var department = new Department
            {
                ID = 1,
                DepartmentName = "Coola avdelningen"
            };
            departments.Add(department);
            bool onSite = false;

            for (int i = 0; i < 50; i++)
            {
                if (random.Next(0, 10) > 1)
                {
                    onSite = true;
                }

                var staff = new Staff
                {
                    FirstName = firstNames[random.Next(0, firstNames.Count)],
                    LastName = lastNames[random.Next(0, lastNames.Count)],
                    DepartmentId = 1,
                    ID = i + 1,
                    PhoneNr = "070" + random.Next(1000000, 9999999).ToString(),
                    OnSite = onSite
                }; staffs.Add(staff);
            }
            for (int i = 0; i < 50; i++)
            {
                var startDate = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day, random.Next(7, 16), 00, 00);
                var endDate = new DateTime(startDate.Year, startDate.Month, startDate.Day, (startDate.Hour + random.Next(7, 8)), 00, 00);

                var s = new Schedule
                {
                    StaffID = i + 1,
                    StartDate = startDate,
                    EndDate = endDate,
                    ID = i + 1
                }; schedules.Add(s);
            }
            for (int i = 0; i < 60; i++)
            {
                var startDate = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day, random.Next(7, 18), 00, 00);
                var endDate = new DateTime(startDate.Year, startDate.Month, startDate.Day, (startDate.Hour + random.Next(1, 3)), 00, 00);

                var p = new Procedure
                {
                    ProcedureName = procedureNames[random.Next(0, procedureNames.Count)],
                    DepartmentId = 1,
                    ID = i + 1,
                    StartDate = startDate,
                    EndDate = endDate
                }; procedures.Add(p);
            }
        }

        public List<Staff> GetTodaysStaff()
        {
            return staffs;
        }

        public List<Schedule> GetTodaysSchedule()
        {
            return schedules;
        }

        public List<Procedure> GetTodaysProcedures()
        {
            return procedures;
        }

        public List<Status> GetStatus()
        {
            return statuses;
        }

        public List<ScheduledProcedure> GetScheduledProcedures()
        {
            //int rand1;
            //int rand2;
            List<ScheduledProcedure> scheduledProcedures = new List<ScheduledProcedure>();

            //for (int i = 0; i < staffs.Count; i++)
            //{
            //    date = DateTime.Now.AddHours(random.Next(0, 15));

            //    var s = new Schedule
            //    {
            //        StaffID = i+1,
            //        StartDate = date,
            //        EndDate = date.AddHours(date.Hour + 9),
            //        ID = i + 1
            //    }; schedules.Add(s);
            //}

            ////Kör igenom listan en vända till och ta lite sannolikhet att dom är på plats under eller utanför sina pass. EZ!

            //for (int i = 0; i < 150; i++)
            //{
            //    rand1 = random.Next(1, procedures.Count);
            //    rand2 = random2.Next(1, schedules.Count);
            //    procedure = procedures.FirstOrDefault(p => p.ID == rand1);
            //    schedule = schedules.FirstOrDefault(s => s.ID == rand2);

            //    var scheduledProcedure = new ScheduledProcedure
            //    {
            //        Procedure = procedure,
            //        ProcedureId = procedure.ID,
            //        Schedule = schedule,
            //        ScheduleId = schedule.ID
            //    }; scheduledProcedures.Add(scheduledProcedure);
            //}

            return scheduledProcedures;

        }
    }
}
