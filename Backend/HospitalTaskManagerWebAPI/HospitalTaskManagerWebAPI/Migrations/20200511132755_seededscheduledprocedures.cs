using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalTaskManagerWebAPI.Migrations
{
    public partial class seededscheduledprocedures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 1,
                column: "ProcedureName",
                value: "Skälla ut praktikanten");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), "Ge filiduttvaccin", new DateTime(2020, 5, 11, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), "Rutinkontroll", new DateTime(2020, 5, 11, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), "Skriva ut krumelurpiller", new DateTime(2020, 5, 11, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "EndDate", "ProcedureName" },
                values: new object[] { new DateTime(2020, 5, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), "Skriva ut krumelurpiller" });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), "Tandskrapning", new DateTime(2020, 5, 11, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), "Öronkontroll", new DateTime(2020, 5, 11, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), "Skriva ut krumelurpiller", new DateTime(2020, 5, 11, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), "Lungmätning", new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "ProcedureName", "StartDate" },
                values: new object[] { "Skriva ut krumelurpiller", new DateTime(2020, 5, 11, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), "Knäskålsrekonstruktion", new DateTime(2020, 5, 11, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), "Ge filiduttvaccin", new DateTime(2020, 5, 11, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 13,
                column: "StartDate",
                value: new DateTime(2020, 5, 11, 17, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), "Rutinkontroll", new DateTime(2020, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), "Tandskrapning", new DateTime(2020, 5, 11, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), "Lungmätning", new DateTime(2020, 5, 11, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), "Tandskrapning", new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), "Dyrka Satan", new DateTime(2020, 5, 11, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), "Knäskålsrekonstruktion", new DateTime(2020, 5, 11, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), "Skriva ut krumelurpiller", new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 13, 0, 0, 0, DateTimeKind.Unspecified), "Genkodning", new DateTime(2020, 5, 11, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), "Skälla ut praktikanten", new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 23,
                column: "ProcedureName",
                value: "Rutinkontroll");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), "Ögonkorrigering", new DateTime(2020, 5, 11, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), "Ge filiduttvaccin", new DateTime(2020, 5, 11, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), "Öronkontroll", new DateTime(2020, 5, 11, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), "Lungmätning", new DateTime(2020, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "ProcedureName", "StartDate" },
                values: new object[] { "Operation", new DateTime(2020, 5, 11, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), "Genkodning", new DateTime(2020, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), "Skälla ut praktikanten", new DateTime(2020, 5, 11, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), "Öronkontroll", new DateTime(2020, 5, 11, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), "Injicera dunderhonung", new DateTime(2020, 5, 11, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), "Ge filiduttvaccin", new DateTime(2020, 5, 11, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), "Operation", new DateTime(2020, 5, 11, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), "Knäskålsrekonstruktion", new DateTime(2020, 5, 11, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 19, 0, 0, 0, DateTimeKind.Unspecified), "Skapa vaccin för kåråna", new DateTime(2020, 5, 11, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), "Öronkontroll", new DateTime(2020, 5, 11, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), "Botoxa stortår", new DateTime(2020, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), "Ögonkorrigering", new DateTime(2020, 5, 11, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), "Ge filiduttvaccin", new DateTime(2020, 5, 11, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 13, 0, 0, 0, DateTimeKind.Unspecified), "Skälla ut praktikanten", new DateTime(2020, 5, 11, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 13, 0, 0, 0, DateTimeKind.Unspecified), "Rutinkontroll", new DateTime(2020, 5, 11, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), "Genkodning", new DateTime(2020, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), "Lungmätning", new DateTime(2020, 5, 11, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 19, 0, 0, 0, DateTimeKind.Unspecified), "Knäskålsrekonstruktion", new DateTime(2020, 5, 11, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), "Ge filiduttvaccin", new DateTime(2020, 5, 11, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "EndDate", "ProcedureName" },
                values: new object[] { new DateTime(2020, 5, 11, 19, 0, 0, 0, DateTimeKind.Unspecified), "Ögonkorrigering" });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), "Tömma ryggradsvätska", new DateTime(2020, 5, 11, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), "Botoxa stortår", new DateTime(2020, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), "Lungmätning", new DateTime(2020, 5, 11, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 13, 0, 0, 0, DateTimeKind.Unspecified), "Ögonkorrigering", new DateTime(2020, 5, 11, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 55,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 56,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), "Genkodning", new DateTime(2020, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), "Dyrka Satan", new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 58,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 19, 0, 0, 0, DateTimeKind.Unspecified), "Ögonkorrigering", new DateTime(2020, 5, 11, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 59,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), "Genkodning", new DateTime(2020, 5, 11, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 60,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), "Ögonkorrigering", new DateTime(2020, 5, 11, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "ScheduledProcedures",
                columns: new[] { "ScheduleId", "ProcedureId", "KeyPerson" },
                values: new object[,]
                {
                    { 7, 7, true },
                    { 7, 8, true },
                    { 8, 10, true },
                    { 5, 5, true },
                    { 6, 7, true },
                    { 3, 5, true },
                    { 1, 4, true },
                    { 32, 32, true },
                    { 2, 2, true },
                    { 2, 1, true },
                    { 1, 1, true },
                    { 31, 31, true },
                    { 8, 9, true },
                    { 33, 33, true },
                    { 34, 34, true },
                    { 1, 3, true },
                    { 11, 10, true },
                    { 17, 17, true },
                    { 13, 13, true },
                    { 28, 28, true },
                    { 27, 27, true },
                    { 26, 26, true },
                    { 26, 25, true },
                    { 25, 25, true },
                    { 24, 24, true },
                    { 23, 23, true },
                    { 12, 11, true },
                    { 22, 22, true },
                    { 20, 20, true },
                    { 19, 19, true },
                    { 18, 18, true },
                    { 35, 35, true },
                    { 16, 16, true },
                    { 15, 15, true },
                    { 14, 14, true },
                    { 21, 21, true },
                    { 37, 36, true },
                    { 30, 30, true },
                    { 36, 37, true },
                    { 29, 29, true }
                });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { "Super", "Gråskägge", true, "0703417071" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Mario", "Anka", "0705327273" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Krösus", "Woltersson", "0701465387" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "LastName", "PhoneNr" },
                values: new object[] { "Woltersson", "0708896015" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Savanna", "Adrafsfader", "0701596615" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "FirstName", "PhoneNr" },
                values: new object[] { "Mattias", "0705693046" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Stina", "Ramone", "0704451699" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Katja", "Lannister", "0703138957" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Mattias", "Woltersson", "0701273432" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Svetlana", "Kvackzelius", "0708301219" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Mattias", "Krunkenstör", "0708061591" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Stina", "Hormoz", "0706747844" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Mattias", "Kenttä", "0704833730" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 14,
                column: "PhoneNr",
                value: "0701850421");

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "CourageWolf", "Kenttä", "0709840259" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Svetlana", "Fritjiofsdottir", "0706044579" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Katja", "Skraputnik", "0702516062" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "FirstName", "PhoneNr" },
                values: new object[] { "Kalle", "0709149243" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "LastName", "PhoneNr" },
                values: new object[] { "Woltersson", "0707835100" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Nikolaj", "Filling", "0702762434" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Katja", "Ek", "0708154548" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Gandalf", "Adrafsfader", "0706943431" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Kalle", "Springsteen", "0702439083" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Kalle", "Mario", "0708388141" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Tyrion", "Kvackzelius", "0705517598" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "LastName", "PhoneNr" },
                values: new object[] { "Anka", "0701370198" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "FirstName", "PhoneNr" },
                values: new object[] { "Super", "0709741831" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Mattias", "Woltersson", "0703804437" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Krösus", "Skraputnik", "0709165521" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "CourageWolf", "Hormoz", "0709932933" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "LastName", "PhoneNr" },
                values: new object[] { "Lannister", "0701729645" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Tyrion", "Kenttä", "0708472537" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Krösus", "Ek", "0708042819" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Stina", "Adrafsfader", "0702904227" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Benjamin", "Kenttä", "0706523346" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Gandalf", "Segelspjut", "0709326149" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Gandalf", "Krunkenstör", "0707831571" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Svetlana", "Lannister", "0701772682" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Mattias", "Filling", "0705762297" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Mattias", "Von Röfvenstråhle", "0702703472" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Krösus", "Sork", "0707683738" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "FirstName", "PhoneNr" },
                values: new object[] { "Gandalf", "0703284393" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Gandalf", "Gråskägge", "0708651148" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Gandalf", "Skraputnik", "0701034184" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Benjamin", "Hormoz", "0708795436" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Svetlana", "Anka", "0709791293" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Svetlana", "Lannister", "0704204066" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Benjamin", "Hormoz", "0706213256" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Krösus", "Krunkenstör", "0707729589" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "CourageWolf", "Kenttä", "0704163560" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ScheduledProcedures",
                keyColumns: new[] { "ScheduleId", "ProcedureId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ScheduledProcedures",
                keyColumns: new[] { "ScheduleId", "ProcedureId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "ScheduledProcedures",
                keyColumns: new[] { "ScheduleId", "ProcedureId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "ScheduledProcedures",
                keyColumns: new[] { "ScheduleId", "ProcedureId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "ScheduledProcedures",
                keyColumns: new[] { "ScheduleId", "ProcedureId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "ScheduledProcedures",
                keyColumns: new[] { "ScheduleId", "ProcedureId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "ScheduledProcedures",
                keyColumns: new[] { "ScheduleId", "ProcedureId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "ScheduledProcedures",
                keyColumns: new[] { "ScheduleId", "ProcedureId" },
                keyValues: new object[] { 6, 7 });

            migrationBuilder.DeleteData(
                table: "ScheduledProcedures",
                keyColumns: new[] { "ScheduleId", "ProcedureId" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "ScheduledProcedures",
                keyColumns: new[] { "ScheduleId", "ProcedureId" },
                keyValues: new object[] { 7, 8 });

            migrationBuilder.DeleteData(
                table: "ScheduledProcedures",
                keyColumns: new[] { "ScheduleId", "ProcedureId" },
                keyValues: new object[] { 8, 9 });

            migrationBuilder.DeleteData(
                table: "ScheduledProcedures",
                keyColumns: new[] { "ScheduleId", "ProcedureId" },
                keyValues: new object[] { 8, 10 });

            migrationBuilder.DeleteData(
                table: "ScheduledProcedures",
                keyColumns: new[] { "ScheduleId", "ProcedureId" },
                keyValues: new object[] { 11, 10 });

            migrationBuilder.DeleteData(
                table: "ScheduledProcedures",
                keyColumns: new[] { "ScheduleId", "ProcedureId" },
                keyValues: new object[] { 12, 11 });

            migrationBuilder.DeleteData(
                table: "ScheduledProcedures",
                keyColumns: new[] { "ScheduleId", "ProcedureId" },
                keyValues: new object[] { 13, 13 });

            migrationBuilder.DeleteData(
                table: "ScheduledProcedures",
                keyColumns: new[] { "ScheduleId", "ProcedureId" },
                keyValues: new object[] { 14, 14 });

            migrationBuilder.DeleteData(
                table: "ScheduledProcedures",
                keyColumns: new[] { "ScheduleId", "ProcedureId" },
                keyValues: new object[] { 15, 15 });

            migrationBuilder.DeleteData(
                table: "ScheduledProcedures",
                keyColumns: new[] { "ScheduleId", "ProcedureId" },
                keyValues: new object[] { 16, 16 });

            migrationBuilder.DeleteData(
                table: "ScheduledProcedures",
                keyColumns: new[] { "ScheduleId", "ProcedureId" },
                keyValues: new object[] { 17, 17 });

            migrationBuilder.DeleteData(
                table: "ScheduledProcedures",
                keyColumns: new[] { "ScheduleId", "ProcedureId" },
                keyValues: new object[] { 18, 18 });

            migrationBuilder.DeleteData(
                table: "ScheduledProcedures",
                keyColumns: new[] { "ScheduleId", "ProcedureId" },
                keyValues: new object[] { 19, 19 });

            migrationBuilder.DeleteData(
                table: "ScheduledProcedures",
                keyColumns: new[] { "ScheduleId", "ProcedureId" },
                keyValues: new object[] { 20, 20 });

            migrationBuilder.DeleteData(
                table: "ScheduledProcedures",
                keyColumns: new[] { "ScheduleId", "ProcedureId" },
                keyValues: new object[] { 21, 21 });

            migrationBuilder.DeleteData(
                table: "ScheduledProcedures",
                keyColumns: new[] { "ScheduleId", "ProcedureId" },
                keyValues: new object[] { 22, 22 });

            migrationBuilder.DeleteData(
                table: "ScheduledProcedures",
                keyColumns: new[] { "ScheduleId", "ProcedureId" },
                keyValues: new object[] { 23, 23 });

            migrationBuilder.DeleteData(
                table: "ScheduledProcedures",
                keyColumns: new[] { "ScheduleId", "ProcedureId" },
                keyValues: new object[] { 24, 24 });

            migrationBuilder.DeleteData(
                table: "ScheduledProcedures",
                keyColumns: new[] { "ScheduleId", "ProcedureId" },
                keyValues: new object[] { 25, 25 });

            migrationBuilder.DeleteData(
                table: "ScheduledProcedures",
                keyColumns: new[] { "ScheduleId", "ProcedureId" },
                keyValues: new object[] { 26, 25 });

            migrationBuilder.DeleteData(
                table: "ScheduledProcedures",
                keyColumns: new[] { "ScheduleId", "ProcedureId" },
                keyValues: new object[] { 26, 26 });

            migrationBuilder.DeleteData(
                table: "ScheduledProcedures",
                keyColumns: new[] { "ScheduleId", "ProcedureId" },
                keyValues: new object[] { 27, 27 });

            migrationBuilder.DeleteData(
                table: "ScheduledProcedures",
                keyColumns: new[] { "ScheduleId", "ProcedureId" },
                keyValues: new object[] { 28, 28 });

            migrationBuilder.DeleteData(
                table: "ScheduledProcedures",
                keyColumns: new[] { "ScheduleId", "ProcedureId" },
                keyValues: new object[] { 29, 29 });

            migrationBuilder.DeleteData(
                table: "ScheduledProcedures",
                keyColumns: new[] { "ScheduleId", "ProcedureId" },
                keyValues: new object[] { 30, 30 });

            migrationBuilder.DeleteData(
                table: "ScheduledProcedures",
                keyColumns: new[] { "ScheduleId", "ProcedureId" },
                keyValues: new object[] { 31, 31 });

            migrationBuilder.DeleteData(
                table: "ScheduledProcedures",
                keyColumns: new[] { "ScheduleId", "ProcedureId" },
                keyValues: new object[] { 32, 32 });

            migrationBuilder.DeleteData(
                table: "ScheduledProcedures",
                keyColumns: new[] { "ScheduleId", "ProcedureId" },
                keyValues: new object[] { 33, 33 });

            migrationBuilder.DeleteData(
                table: "ScheduledProcedures",
                keyColumns: new[] { "ScheduleId", "ProcedureId" },
                keyValues: new object[] { 34, 34 });

            migrationBuilder.DeleteData(
                table: "ScheduledProcedures",
                keyColumns: new[] { "ScheduleId", "ProcedureId" },
                keyValues: new object[] { 35, 35 });

            migrationBuilder.DeleteData(
                table: "ScheduledProcedures",
                keyColumns: new[] { "ScheduleId", "ProcedureId" },
                keyValues: new object[] { 36, 37 });

            migrationBuilder.DeleteData(
                table: "ScheduledProcedures",
                keyColumns: new[] { "ScheduleId", "ProcedureId" },
                keyValues: new object[] { 37, 36 });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 1,
                column: "ProcedureName",
                value: "Öronkontroll");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), "Tandskrapning", new DateTime(2020, 5, 11, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), "Tömma ryggradsvätska", new DateTime(2020, 5, 11, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), "Skapa vaccin för kåråna", new DateTime(2020, 5, 11, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "EndDate", "ProcedureName" },
                values: new object[] { new DateTime(2020, 5, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), "Skapa vaccin för kåråna" });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), "Skälla ut praktikanten", new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), "Knäskålsrekonstruktion", new DateTime(2020, 5, 11, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 13, 0, 0, 0, DateTimeKind.Unspecified), "Ge filiduttvaccin", new DateTime(2020, 5, 11, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), "Tömma ryggradsvätska", new DateTime(2020, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "ProcedureName", "StartDate" },
                values: new object[] { "Ögonkorrigering", new DateTime(2020, 5, 11, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), "Ögonkorrigering", new DateTime(2020, 5, 11, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), "Genkodning", new DateTime(2020, 5, 11, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 13,
                column: "StartDate",
                value: new DateTime(2020, 5, 11, 16, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), "Tandskrapning", new DateTime(2020, 5, 11, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), "Dyrka Satan", new DateTime(2020, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), "Genkodning", new DateTime(2020, 5, 11, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), "Operation", new DateTime(2020, 5, 11, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), "Skriva ut krumelurpiller", new DateTime(2020, 5, 11, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), "Skapa vaccin för kåråna", new DateTime(2020, 5, 11, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 13, 0, 0, 0, DateTimeKind.Unspecified), "Dyrka Satan", new DateTime(2020, 5, 11, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), "Tandskrapning", new DateTime(2020, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), "Programmera statuslistan", new DateTime(2020, 5, 11, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 23,
                column: "ProcedureName",
                value: "Öronkontroll");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), "Dyrka Satan", new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 13, 0, 0, 0, DateTimeKind.Unspecified), "Skälla ut praktikanten", new DateTime(2020, 5, 11, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), "Injicera dunderhonung", new DateTime(2020, 5, 11, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), "Rutinkontroll", new DateTime(2020, 5, 11, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "ProcedureName", "StartDate" },
                values: new object[] { "Programmera statuslistan", new DateTime(2020, 5, 11, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), "Skapa vaccin för kåråna", new DateTime(2020, 5, 11, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), "Skriva ut krumelurpiller", new DateTime(2020, 5, 11, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), "Genkodning", new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), "Rutinkontroll", new DateTime(2020, 5, 11, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), "Programmera statuslistan", new DateTime(2020, 5, 11, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), "Tömma ryggradsvätska", new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), "Skapa vaccin för kåråna", new DateTime(2020, 5, 11, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), "Skälla ut praktikanten", new DateTime(2020, 5, 11, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 19, 0, 0, 0, DateTimeKind.Unspecified), "Laga stormiddag", new DateTime(2020, 5, 11, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 13, 0, 0, 0, DateTimeKind.Unspecified), "Rutinkontroll", new DateTime(2020, 5, 11, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), "Dyrka Satan", new DateTime(2020, 5, 11, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 13, 0, 0, 0, DateTimeKind.Unspecified), "Ögonkorrigering", new DateTime(2020, 5, 11, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), "Programmera statuslistan", new DateTime(2020, 5, 11, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), "Knäskålsrekonstruktion", new DateTime(2020, 5, 11, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 13, 0, 0, 0, DateTimeKind.Unspecified), "Skapa vaccin för kåråna", new DateTime(2020, 5, 11, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), "Ögonkorrigering", new DateTime(2020, 5, 11, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), "Programmera statuslistan", new DateTime(2020, 5, 11, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), "Knäskålsrekonstruktion", new DateTime(2020, 5, 11, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "EndDate", "ProcedureName" },
                values: new object[] { new DateTime(2020, 5, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), "Programmera statuslistan" });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), "Tandskrapning", new DateTime(2020, 5, 11, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), "Öronkontroll", new DateTime(2020, 5, 11, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), "Ögonkorrigering", new DateTime(2020, 5, 11, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), "Knäskålsrekonstruktion", new DateTime(2020, 5, 11, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 55,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 56,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), "Tandskrapning", new DateTime(2020, 5, 11, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 13, 0, 0, 0, DateTimeKind.Unspecified), "Tömma ryggradsvätska", new DateTime(2020, 5, 11, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 58,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), "Skälla ut praktikanten", new DateTime(2020, 5, 11, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 59,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 19, 0, 0, 0, DateTimeKind.Unspecified), "Skriva ut krumelurpiller", new DateTime(2020, 5, 11, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 60,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), "Skälla ut praktikanten", new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { "Silver", "Filling", false, "0704410651" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Kalle", "Von Röfvenstråhle", "0701345407" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Benjamin", "Mario", "0709957172" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "LastName", "PhoneNr" },
                values: new object[] { "Adrafsfader", "0708931183" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Stina", "Sork", "0707327461" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "FirstName", "PhoneNr" },
                values: new object[] { "Silver", "0709680944" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Kalle", "Filling", "0705585897" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Benjamin", "Gråskägge", "0705537208" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Tyrion", "Skraputnik", "0707250114" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Silver", "Von Röfvenstråhle", "0703720361" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Tyrion", "Adrafsfader", "0704802627" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "CourageWolf", "Fritjiofsdottir", "0706322585" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Mario", "Fritjiofsdottir", "0702983046" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 14,
                column: "PhoneNr",
                value: "0709680304");

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Tyrion", "Ek", "0709264376" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Katja", "Anka", "0706889538" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Kalle", "Kvackzelius", "0704775990" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "FirstName", "PhoneNr" },
                values: new object[] { "Svetlana", "0702865234" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "LastName", "PhoneNr" },
                values: new object[] { "Ramone", "0708570650" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Silver", "Kvackzelius", "0707969173" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Savanna", "Hormoz", "0701252195" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Tyrion", "Sork", "0702196057" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Nikolaj", "Hormoz", "0708542166" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Mario", "Lannister", "0709389473" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Svetlana", "Adrafsfader", "0704594357" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "LastName", "PhoneNr" },
                values: new object[] { "Kenttä", "0705029892" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "FirstName", "PhoneNr" },
                values: new object[] { "Mattias", "0707023751" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Silver", "Segelspjut", "0704073140" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Mattias", "Ek", "0709893576" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Kalle", "Sork", "0709427879" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "LastName", "PhoneNr" },
                values: new object[] { "Krunkenstör", "0701938330" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Mattias", "Sork", "0702796340" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Super", "Hormoz", "0707000604" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Nikolaj", "Segelspjut", "0708453924" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Mario", "Segelspjut", "0703933738" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Savanna", "Hormoz", "0707750792" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Nikolaj", "Gråskägge", "0709268524" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Tyrion", "Ek", "0704463247" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "CourageWolf", "Gråskägge", "0703686907" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Gandalf", "Ramone", "0704388800" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Silver", "Springsteen", "0702748815" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "FirstName", "PhoneNr" },
                values: new object[] { "Mario", "0708570934" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Mattias", "Anka", "0702514154" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Super", "Woltersson", "0708649922" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Super", "Kenttä", "0709059653" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Silver", "Adrafsfader", "0708436052" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Super", "Mario", "0701193120" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Katja", "Anka", "0701923050" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Benjamin", "Gråskägge", "0704916469" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Tyrion", "Skraputnik", "0707539431" });
        }
    }
}
