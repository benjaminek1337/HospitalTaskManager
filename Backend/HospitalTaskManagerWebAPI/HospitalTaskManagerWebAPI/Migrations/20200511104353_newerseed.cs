using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalTaskManagerWebAPI.Migrations
{
    public partial class newerseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ID", "DepartmentId", "EndDate", "IsHandled", "ProcedureName", "StartDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), false, "Öronkontroll", new DateTime(2020, 5, 11, 13, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, 1, new DateTime(2020, 5, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), false, "Rutinkontroll", new DateTime(2020, 5, 11, 7, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, 1, new DateTime(2020, 5, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), false, "Programmera statuslistan", new DateTime(2020, 5, 11, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, 1, new DateTime(2020, 5, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), false, "Tömma ryggradsvätska", new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 36, 1, new DateTime(2020, 5, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), false, "Skapa vaccin för kåråna", new DateTime(2020, 5, 11, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 37, 1, new DateTime(2020, 5, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), false, "Tömma ryggradsvätska", new DateTime(2020, 5, 11, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 38, 1, new DateTime(2020, 5, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), false, "Skälla ut praktikanten", new DateTime(2020, 5, 11, 7, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 39, 1, new DateTime(2020, 5, 11, 19, 0, 0, 0, DateTimeKind.Unspecified), false, "Laga stormiddag", new DateTime(2020, 5, 11, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 40, 1, new DateTime(2020, 5, 11, 13, 0, 0, 0, DateTimeKind.Unspecified), false, "Rutinkontroll", new DateTime(2020, 5, 11, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 41, 1, new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), false, "Dyrka Satan", new DateTime(2020, 5, 11, 13, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 42, 1, new DateTime(2020, 5, 11, 13, 0, 0, 0, DateTimeKind.Unspecified), false, "Ögonkorrigering", new DateTime(2020, 5, 11, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 44, 1, new DateTime(2020, 5, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), false, "Knäskålsrekonstruktion", new DateTime(2020, 5, 11, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 45, 1, new DateTime(2020, 5, 11, 13, 0, 0, 0, DateTimeKind.Unspecified), false, "Skapa vaccin för kåråna", new DateTime(2020, 5, 11, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 46, 1, new DateTime(2020, 5, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), false, "Ögonkorrigering", new DateTime(2020, 5, 11, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 47, 1, new DateTime(2020, 5, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), false, "Programmera statuslistan", new DateTime(2020, 5, 11, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 48, 1, new DateTime(2020, 5, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), false, "Knäskålsrekonstruktion", new DateTime(2020, 5, 11, 7, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 49, 1, new DateTime(2020, 5, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), false, "Programmera statuslistan", new DateTime(2020, 5, 11, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 50, 1, new DateTime(2020, 5, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), false, "Rutinkontroll", new DateTime(2020, 5, 11, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 51, 1, new DateTime(2020, 5, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), false, "Tandskrapning", new DateTime(2020, 5, 11, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 52, 1, new DateTime(2020, 5, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), false, "Öronkontroll", new DateTime(2020, 5, 11, 7, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 53, 1, new DateTime(2020, 5, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), false, "Ögonkorrigering", new DateTime(2020, 5, 11, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 54, 1, new DateTime(2020, 5, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), false, "Knäskålsrekonstruktion", new DateTime(2020, 5, 11, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 55, 1, new DateTime(2020, 5, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), false, "Operation", new DateTime(2020, 5, 11, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 56, 1, new DateTime(2020, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), false, "Tandskrapning", new DateTime(2020, 5, 11, 13, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 57, 1, new DateTime(2020, 5, 11, 13, 0, 0, 0, DateTimeKind.Unspecified), false, "Tömma ryggradsvätska", new DateTime(2020, 5, 11, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 58, 1, new DateTime(2020, 5, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), false, "Skälla ut praktikanten", new DateTime(2020, 5, 11, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 59, 1, new DateTime(2020, 5, 11, 19, 0, 0, 0, DateTimeKind.Unspecified), false, "Skriva ut krumelurpiller", new DateTime(2020, 5, 11, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 60, 1, new DateTime(2020, 5, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), false, "Skälla ut praktikanten", new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, 1, new DateTime(2020, 5, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), false, "Genkodning", new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, 1, new DateTime(2020, 5, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), false, "Skriva ut krumelurpiller", new DateTime(2020, 5, 11, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 43, 1, new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), false, "Programmera statuslistan", new DateTime(2020, 5, 11, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, 1, new DateTime(2020, 5, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), false, "Skapa vaccin för kåråna", new DateTime(2020, 5, 11, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, new DateTime(2020, 5, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), false, "Tandskrapning", new DateTime(2020, 5, 11, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 1, new DateTime(2020, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), false, "Tömma ryggradsvätska", new DateTime(2020, 5, 11, 13, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, 1, new DateTime(2020, 5, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), false, "Laga stormiddag", new DateTime(2020, 5, 11, 7, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 1, new DateTime(2020, 5, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), false, "Skapa vaccin för kåråna", new DateTime(2020, 5, 11, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 1, new DateTime(2020, 5, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), false, "Skälla ut praktikanten", new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 1, new DateTime(2020, 5, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), false, "Knäskålsrekonstruktion", new DateTime(2020, 5, 11, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 1, new DateTime(2020, 5, 11, 13, 0, 0, 0, DateTimeKind.Unspecified), false, "Ge filiduttvaccin", new DateTime(2020, 5, 11, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 1, new DateTime(2020, 5, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), false, "Tömma ryggradsvätska", new DateTime(2020, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 1, new DateTime(2020, 5, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), false, "Ögonkorrigering", new DateTime(2020, 5, 11, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 1, new DateTime(2020, 5, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), false, "Ögonkorrigering", new DateTime(2020, 5, 11, 7, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 1, new DateTime(2020, 5, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), false, "Genkodning", new DateTime(2020, 5, 11, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 1, new DateTime(2020, 5, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), false, "Tandskrapning", new DateTime(2020, 5, 11, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 1, new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), false, "Tandskrapning", new DateTime(2020, 5, 11, 13, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 1, new DateTime(2020, 5, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), false, "Dyrka Satan", new DateTime(2020, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 1, new DateTime(2020, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), false, "Skapa vaccin för kåråna", new DateTime(2020, 5, 11, 13, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, 1, new DateTime(2020, 5, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), false, "Operation", new DateTime(2020, 5, 11, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, 1, new DateTime(2020, 5, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), false, "Genkodning", new DateTime(2020, 5, 11, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, 1, new DateTime(2020, 5, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), false, "Programmera statuslistan", new DateTime(2020, 5, 11, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, 1, new DateTime(2020, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), false, "Injicera dunderhonung", new DateTime(2020, 5, 11, 13, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, 1, new DateTime(2020, 5, 11, 13, 0, 0, 0, DateTimeKind.Unspecified), false, "Skälla ut praktikanten", new DateTime(2020, 5, 11, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, 1, new DateTime(2020, 5, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), false, "Dyrka Satan", new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, 1, new DateTime(2020, 5, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), false, "Öronkontroll", new DateTime(2020, 5, 11, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, 1, new DateTime(2020, 5, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), false, "Rutinkontroll", new DateTime(2020, 5, 11, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, 1, new DateTime(2020, 5, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), false, "Tandskrapning", new DateTime(2020, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, 1, new DateTime(2020, 5, 11, 13, 0, 0, 0, DateTimeKind.Unspecified), false, "Dyrka Satan", new DateTime(2020, 5, 11, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, 1, new DateTime(2020, 5, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), false, "Skapa vaccin för kåråna", new DateTime(2020, 5, 11, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, 1, new DateTime(2020, 5, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), false, "Skriva ut krumelurpiller", new DateTime(2020, 5, 11, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, 1, new DateTime(2020, 5, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), false, "Programmera statuslistan", new DateTime(2020, 5, 11, 10, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "ID", "EndDate", "StaffID", "StartDate" },
                values: new object[,]
                {
                    { 37, new DateTime(2020, 5, 11, 21, 0, 0, 0, DateTimeKind.Unspecified), 37, new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, new DateTime(2020, 5, 11, 21, 0, 0, 0, DateTimeKind.Unspecified), 28, new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, new DateTime(2020, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), 29, new DateTime(2020, 5, 11, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, new DateTime(2020, 5, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2020, 5, 11, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, new DateTime(2020, 5, 11, 20, 0, 0, 0, DateTimeKind.Unspecified), 31, new DateTime(2020, 5, 11, 13, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, new DateTime(2020, 5, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), 32, new DateTime(2020, 5, 11, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, new DateTime(2020, 5, 11, 22, 0, 0, 0, DateTimeKind.Unspecified), 33, new DateTime(2020, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, new DateTime(2020, 5, 11, 21, 0, 0, 0, DateTimeKind.Unspecified), 34, new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), 35, new DateTime(2020, 5, 11, 7, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 36, new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), 36, new DateTime(2020, 5, 11, 7, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 38, new DateTime(2020, 5, 11, 22, 0, 0, 0, DateTimeKind.Unspecified), 38, new DateTime(2020, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 45, new DateTime(2020, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), 45, new DateTime(2020, 5, 11, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 40, new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), 40, new DateTime(2020, 5, 11, 7, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 41, new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), 41, new DateTime(2020, 5, 11, 7, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 42, new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), 42, new DateTime(2020, 5, 11, 7, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 43, new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), 43, new DateTime(2020, 5, 11, 7, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 44, new DateTime(2020, 5, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), 44, new DateTime(2020, 5, 11, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 46, new DateTime(2020, 5, 11, 19, 0, 0, 0, DateTimeKind.Unspecified), 46, new DateTime(2020, 5, 11, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 47, new DateTime(2020, 5, 11, 20, 0, 0, 0, DateTimeKind.Unspecified), 47, new DateTime(2020, 5, 11, 13, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 48, new DateTime(2020, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), 48, new DateTime(2020, 5, 11, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 49, new DateTime(2020, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), 49, new DateTime(2020, 5, 11, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 50, new DateTime(2020, 5, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), 50, new DateTime(2020, 5, 11, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, new DateTime(2020, 5, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), 27, new DateTime(2020, 5, 11, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 39, new DateTime(2020, 5, 11, 22, 0, 0, 0, DateTimeKind.Unspecified), 39, new DateTime(2020, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, new DateTime(2020, 5, 11, 21, 0, 0, 0, DateTimeKind.Unspecified), 26, new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, new DateTime(2020, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), 20, new DateTime(2020, 5, 11, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, new DateTime(2020, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), 24, new DateTime(2020, 5, 11, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, new DateTime(2020, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2020, 5, 11, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2020, 5, 11, 7, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2020, 5, 11, 19, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2020, 5, 11, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2020, 5, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2020, 5, 11, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2020, 5, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2020, 5, 11, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(2020, 5, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2020, 5, 11, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, new DateTime(2020, 5, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), 8, new DateTime(2020, 5, 11, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, new DateTime(2020, 5, 11, 19, 0, 0, 0, DateTimeKind.Unspecified), 9, new DateTime(2020, 5, 11, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, new DateTime(2020, 5, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), 10, new DateTime(2020, 5, 11, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, new DateTime(2020, 5, 11, 22, 0, 0, 0, DateTimeKind.Unspecified), 11, new DateTime(2020, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, new DateTime(2020, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), 12, new DateTime(2020, 5, 11, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, new DateTime(2020, 5, 11, 22, 0, 0, 0, DateTimeKind.Unspecified), 7, new DateTime(2020, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, new DateTime(2020, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), 14, new DateTime(2020, 5, 11, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, new DateTime(2020, 5, 11, 19, 0, 0, 0, DateTimeKind.Unspecified), 15, new DateTime(2020, 5, 11, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, new DateTime(2020, 5, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), 16, new DateTime(2020, 5, 11, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, new DateTime(2020, 5, 11, 22, 0, 0, 0, DateTimeKind.Unspecified), 17, new DateTime(2020, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, new DateTime(2020, 5, 11, 22, 0, 0, 0, DateTimeKind.Unspecified), 13, new DateTime(2020, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, new DateTime(2020, 5, 11, 20, 0, 0, 0, DateTimeKind.Unspecified), 18, new DateTime(2020, 5, 11, 13, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), 19, new DateTime(2020, 5, 11, 7, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, new DateTime(2020, 5, 11, 20, 0, 0, 0, DateTimeKind.Unspecified), 25, new DateTime(2020, 5, 11, 13, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, new DateTime(2020, 5, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), 21, new DateTime(2020, 5, 11, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, new DateTime(2020, 5, 11, 20, 0, 0, 0, DateTimeKind.Unspecified), 22, new DateTime(2020, 5, 11, 13, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, new DateTime(2020, 5, 11, 20, 0, 0, 0, DateTimeKind.Unspecified), 23, new DateTime(2020, 5, 11, 13, 0, 0, 0, DateTimeKind.Unspecified) }
                });

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
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Mario", "Adrafsfader", "0708931183" });

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
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Silver", "Von Röfvenstråhle", "0709680944" });

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
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "CourageWolf", "Ek", "0709680304" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "FirstName", "PhoneNr" },
                values: new object[] { "Tyrion", "0709264376" });

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
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Svetlana", "Sork", "0702865234" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Super", "Ramone", "0708570650" });

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
                columns: new[] { "FirstName", "PhoneNr" },
                values: new object[] { "Nikolaj", "0708542166" });

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
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Benjamin", "Kenttä", "0705029892" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Mattias", "Woltersson", "0707023751" });

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
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Katja", "Krunkenstör", "0701938330" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "LastName", "PhoneNr" },
                values: new object[] { "Sork", "0702796340" });

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
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Mario", "Ramone", "0708570934" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 50);

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { "Mario", "Mario", true, "0704499449" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Mattias", "Segelspjut", "0701806573" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Katja", "Fritjiofsdottir", "0709926135" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Silver", "Gråskägge", "0705959157" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Nikolaj", "Krunkenstör", "0707308269" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "CourageWolf", "Ek", "0702398987" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Mattias", "Hormoz", "0705228959" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Super", "Springsteen", "0709169682" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Nikolaj", "Sork", "0708606453" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Nikolaj", "Ek", "0709185486" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "CourageWolf", "Filling", "0708566462" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Krösus", "Woltersson", "0708563408" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "CourageWolf", "Sork", "0703431240" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Stina", "Woltersson", "0708429447" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "FirstName", "PhoneNr" },
                values: new object[] { "Mario", "0703023054" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Svetlana", "Sork", "0705242940" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Gandalf", "Sork", "0708886625" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Kalle", "Adrafsfader", "0702027443" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Gandalf", "Mario", "0703439282" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Mattias", "Ek", "0708802916" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Kalle", "Ramone", "0704154185" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Gandalf", "Segelspjut", "0705376397" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "FirstName", "PhoneNr" },
                values: new object[] { "Mattias", "0703710514" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Super", "Springsteen", "0709705386" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Stina", "Kenttä", "0706167369" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Krösus", "Skraputnik", "0705287178" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Tyrion", "Fritjiofsdottir", "0709214423" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Benjamin", "Gråskägge", "0705173032" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Silver", "Woltersson", "0707642468" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Mario", "Skraputnik", "0706375412" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Gandalf", "Segelspjut", "0708832478" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "LastName", "PhoneNr" },
                values: new object[] { "Anka", "0701465453" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Nikolaj", "Ramone", "0703207589" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Krösus", "Fritjiofsdottir", "0704773253" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Mattias", "Kvackzelius", "0707619485" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Krösus", "Springsteen", "0704949245" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Mario", "Kenttä", "0706977795" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Katja", "Ramone", "0708469235" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Benjamin", "Fritjiofsdottir", "0708445819" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Svetlana", "Woltersson", "0708535555" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Savanna", "Hormoz", "0708105371" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Svetlana", "Filling", "0702558023" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Svetlana", "Gråskägge", "0701303179" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Benjamin", "Fritjiofsdottir", "0706517545" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Tyrion", "Skraputnik", "0704844036" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "CourageWolf", "Von Röfvenstråhle", "0706584869" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Svetlana", "Adrafsfader", "0705674124" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "CourageWolf", "Woltersson", "0707385017" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Stina", "Sork", "0708121391" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Katja", "Gråskägge", "0703047691" });
        }
    }
}
