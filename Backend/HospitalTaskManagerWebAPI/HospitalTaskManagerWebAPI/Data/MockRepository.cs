using HospitalTaskManagerWebAPI.Models;
using HospitalTaskManagerWebAPI.Models.ViewModels;
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
                "Lisa",
                "Mario",
                "Super",
                "Nikolaj",
                "Svetlana",
                "Tyrion",
                "Sauron",
                "Obi-Wan",
                "Kristian",
                "Ali",
                "Carlos",
                "Carla",
                "JD"

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
                "Askrafvsfader",
                "Von Röfvenstråhle",
                "Kenttä",
                "Ramone",
                "Daniels",
                "Pruselius",
                "Springsteen",
                "Filling",
                "Lannister",
                "Vader",
                "Sainz",
                "Gandhi",
                "Krukskalle",
                "Dorian"
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
                "Tömma ryggradsvätska",
                "Ge filiduttvaccin",
                "Genkodning",
                "Rutinkontroll",
                "Skälla ut praktikanten",
                "Programmera statuslistan"
            });
            var department = new Department
            {
                ID = 1,
                DepartmentName = "Coola avdelningen"
            };
            departments.Add(department);
            var department2 = new Department
            {
                ID = 2,
                DepartmentName = "Mindre coola avdelningen"
            }; departments.Add(department2);
            
            

            for (int i = 0; i < 70; i++)
            {
                bool onSite = false;
                int dept = 1;
                if (random.Next(0, 10) > 1)
                {
                    onSite = true;
                }
                if (random.Next(0, 10) >= 5)
                {
                    dept = 2;
                }
                var staff = new Staff
                {
                    FirstName = firstNames[random.Next(0, firstNames.Count)],
                    LastName = lastNames[random.Next(0, lastNames.Count)],
                    DepartmentId = dept,
                    ID = i + 1,
                    PhoneNr = "070" + random.Next(1000000, 9999999).ToString(),
                    OnSite = onSite
                }; staffs.Add(staff);
            }
            for (int i = 0; i < 70; i++)
            {
                var startDate = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day, random.Next(6, 16), 00, 00);
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
                var startDate = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day, random.Next(7, 17), 00, 00);
                var endDate = new DateTime(startDate.Year, startDate.Month, startDate.Day, (startDate.Hour + random.Next(1, 4)), 00, 00);

                var p = new Procedure
                {
                    ProcedureName = procedureNames[random.Next(0, procedureNames.Count)],
                    DepartmentId = 1,
                    ID = i + 1,
                    StartDate = startDate,
                    EndDate = endDate,
                    IsHandled = false
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

        public List<Department> GetDepartments()
        {
            return departments;
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

        public List<Schedule> GetTodaysSchedule(DateTime date)
        {
            throw new NotImplementedException();
        }

        public List<Procedure> GetTodaysProcedures(DateTime date)
        {
            throw new NotImplementedException();
        }

        public List<ScheduledProcedure> GetTodaysScheduledProcedures(DateTime date)
        {
            throw new NotImplementedException();
        }

        public AllDataViewModel GetInitScheduleData(DateTime date)
        {
            throw new NotImplementedException();
        }

        public void MarkProcedureAsHandled(Procedure procedure)
        {
            throw new NotImplementedException();
        }

        public void MarkProcedureAsUnhandled(Procedure procedure)
        {
            throw new NotImplementedException();
        }
    }
}
