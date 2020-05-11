using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalTaskManagerWebAPI.Migrations
{
    public partial class newseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Mario", "Mario", "0704499449" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 1, "Mattias", "Segelspjut", "0701806573" });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "ID", "DepartmentId", "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[,]
                {
                    { 28, 1, "Benjamin", "Gråskägge", true, "0705173032" },
                    { 29, 1, "Silver", "Woltersson", true, "0707642468" },
                    { 30, 1, "Mario", "Skraputnik", true, "0706375412" },
                    { 31, 1, "Gandalf", "Segelspjut", true, "0708832478" },
                    { 32, 1, "Mattias", "Anka", true, "0701465453" },
                    { 33, 1, "Nikolaj", "Ramone", true, "0703207589" },
                    { 34, 1, "Krösus", "Fritjiofsdottir", true, "0704773253" },
                    { 35, 1, "Mattias", "Kvackzelius", true, "0707619485" },
                    { 36, 1, "Krösus", "Springsteen", true, "0704949245" },
                    { 37, 1, "Mario", "Kenttä", true, "0706977795" },
                    { 38, 1, "Katja", "Ramone", true, "0708469235" },
                    { 39, 1, "Benjamin", "Fritjiofsdottir", true, "0708445819" },
                    { 40, 1, "Svetlana", "Woltersson", true, "0708535555" },
                    { 41, 1, "Savanna", "Hormoz", true, "0708105371" },
                    { 42, 1, "Svetlana", "Filling", true, "0702558023" },
                    { 43, 1, "Svetlana", "Gråskägge", true, "0701303179" },
                    { 44, 1, "Benjamin", "Fritjiofsdottir", true, "0706517545" },
                    { 45, 1, "Tyrion", "Skraputnik", true, "0704844036" },
                    { 46, 1, "CourageWolf", "Von Röfvenstråhle", true, "0706584869" },
                    { 47, 1, "Svetlana", "Adrafsfader", true, "0705674124" },
                    { 48, 1, "CourageWolf", "Woltersson", true, "0707385017" },
                    { 27, 1, "Tyrion", "Fritjiofsdottir", true, "0709214423" },
                    { 26, 1, "Krösus", "Skraputnik", true, "0705287178" },
                    { 25, 1, "Stina", "Kenttä", true, "0706167369" },
                    { 24, 1, "Super", "Springsteen", true, "0709705386" },
                    { 3, 1, "Katja", "Fritjiofsdottir", true, "0709926135" },
                    { 4, 1, "Silver", "Gråskägge", true, "0705959157" },
                    { 5, 1, "Nikolaj", "Krunkenstör", true, "0707308269" },
                    { 6, 1, "CourageWolf", "Ek", true, "0702398987" },
                    { 7, 1, "Mattias", "Hormoz", true, "0705228959" },
                    { 8, 1, "Super", "Springsteen", true, "0709169682" },
                    { 9, 1, "Nikolaj", "Sork", true, "0708606453" },
                    { 10, 1, "Nikolaj", "Ek", true, "0709185486" },
                    { 11, 1, "CourageWolf", "Filling", true, "0708566462" },
                    { 12, 1, "Krösus", "Woltersson", true, "0708563408" },
                    { 13, 1, "CourageWolf", "Sork", true, "0703431240" },
                    { 14, 1, "Stina", "Woltersson", true, "0708429447" },
                    { 15, 1, "Mario", "Ek", true, "0703023054" },
                    { 16, 1, "Svetlana", "Sork", true, "0705242940" },
                    { 17, 1, "Gandalf", "Sork", true, "0708886625" },
                    { 18, 1, "Kalle", "Adrafsfader", true, "0702027443" },
                    { 19, 1, "Gandalf", "Mario", true, "0703439282" },
                    { 20, 1, "Mattias", "Ek", true, "0708802916" },
                    { 21, 1, "Kalle", "Ramone", true, "0704154185" },
                    { 22, 1, "Gandalf", "Segelspjut", true, "0705376397" },
                    { 23, 1, "Mattias", "Hormoz", true, "0703710514" },
                    { 49, 1, "Stina", "Sork", true, "0708121391" },
                    { 50, 1, "Katja", "Gråskägge", true, "0703047691" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 50);

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Benjamin", "Ek", "0227896541" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 2, "Malin", "Jönsson", "0227896541" });
        }
    }
}
