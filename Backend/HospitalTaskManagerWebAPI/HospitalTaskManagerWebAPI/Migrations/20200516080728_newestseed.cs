using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalTaskManagerWebAPI.Migrations
{
    public partial class newestseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 14, 0, 0, 0, DateTimeKind.Unspecified), "Botoxa stortår", new DateTime(2020, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), "Genkodning", new DateTime(2020, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 9, 0, 0, 0, DateTimeKind.Unspecified), "Knäskålsrekonstruktion", new DateTime(2020, 5, 16, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), "Injicera dunderhonung", new DateTime(2020, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 10, 0, 0, 0, DateTimeKind.Unspecified), "Injicera dunderhonung", new DateTime(2020, 5, 16, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), "Genkodning", new DateTime(2020, 5, 16, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), "Injicera dunderhonung", new DateTime(2020, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 12, 0, 0, 0, DateTimeKind.Unspecified), "Skapa vaccin för kåråna", new DateTime(2020, 5, 16, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified), "Rutinkontroll", new DateTime(2020, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 18, 0, 0, 0, DateTimeKind.Unspecified), "Tömma ryggradsvätska", new DateTime(2020, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 17, 0, 0, 0, DateTimeKind.Unspecified), "Injicera dunderhonung", new DateTime(2020, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified), "Operation", new DateTime(2020, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 18, 0, 0, 0, DateTimeKind.Unspecified), "Tandskrapning", new DateTime(2020, 5, 16, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 8, 0, 0, 0, DateTimeKind.Unspecified), "Skälla ut praktikanten", new DateTime(2020, 5, 16, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 10, 0, 0, 0, DateTimeKind.Unspecified), "Ögonkorrigering", new DateTime(2020, 5, 16, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 17, 0, 0, 0, DateTimeKind.Unspecified), "Laga stormiddag", new DateTime(2020, 5, 16, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), "Botoxa stortår", new DateTime(2020, 5, 16, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), "Rutinkontroll", new DateTime(2020, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 9, 0, 0, 0, DateTimeKind.Unspecified), "Öronkontroll", new DateTime(2020, 5, 16, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 17, 0, 0, 0, DateTimeKind.Unspecified), "Ögonkorrigering", new DateTime(2020, 5, 16, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 12, 0, 0, 0, DateTimeKind.Unspecified), "Genkodning", new DateTime(2020, 5, 16, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 18, 0, 0, 0, DateTimeKind.Unspecified), "Operation", new DateTime(2020, 5, 16, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 11, 0, 0, 0, DateTimeKind.Unspecified), "Programmera statuslistan", new DateTime(2020, 5, 16, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), "Knäskålsrekonstruktion", new DateTime(2020, 5, 16, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 11, 0, 0, 0, DateTimeKind.Unspecified), "Ögonkorrigering", new DateTime(2020, 5, 16, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 11, 0, 0, 0, DateTimeKind.Unspecified), "Ögonkorrigering", new DateTime(2020, 5, 16, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified), "Lungmätning", new DateTime(2020, 5, 16, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 11, 0, 0, 0, DateTimeKind.Unspecified), "Tömma ryggradsvätska", new DateTime(2020, 5, 16, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified), "Skapa vaccin för kåråna", new DateTime(2020, 5, 16, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 14, 0, 0, 0, DateTimeKind.Unspecified), "Laga stormiddag", new DateTime(2020, 5, 16, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified), "Knäskålsrekonstruktion", new DateTime(2020, 5, 16, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 18, 0, 0, 0, DateTimeKind.Unspecified), "Laga stormiddag", new DateTime(2020, 5, 16, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 18, 0, 0, 0, DateTimeKind.Unspecified), "Knäskålsrekonstruktion", new DateTime(2020, 5, 16, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), "Ögonkorrigering", new DateTime(2020, 5, 16, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), "Genkodning", new DateTime(2020, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 8, 0, 0, 0, DateTimeKind.Unspecified), "Öronkontroll", new DateTime(2020, 5, 16, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), "Rutinkontroll", new DateTime(2020, 5, 16, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 18, 0, 0, 0, DateTimeKind.Unspecified), "Ge filiduttvaccin", new DateTime(2020, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 12, 0, 0, 0, DateTimeKind.Unspecified), "Skapa vaccin för kåråna", new DateTime(2020, 5, 16, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified), "Tömma ryggradsvätska", new DateTime(2020, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 18, 0, 0, 0, DateTimeKind.Unspecified), "Botoxa stortår", new DateTime(2020, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 9, 0, 0, 0, DateTimeKind.Unspecified), "Ögonkorrigering", new DateTime(2020, 5, 16, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), "Lungmätning", new DateTime(2020, 5, 16, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 11, 0, 0, 0, DateTimeKind.Unspecified), "Genkodning", new DateTime(2020, 5, 16, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 10, 0, 0, 0, DateTimeKind.Unspecified), "Injicera dunderhonung", new DateTime(2020, 5, 16, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 17, 0, 0, 0, DateTimeKind.Unspecified), "Skapa vaccin för kåråna", new DateTime(2020, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 11, 0, 0, 0, DateTimeKind.Unspecified), "Botoxa stortår", new DateTime(2020, 5, 16, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 17, 0, 0, 0, DateTimeKind.Unspecified), "Programmera statuslistan", new DateTime(2020, 5, 16, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), "Ge filiduttvaccin", new DateTime(2020, 5, 16, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 55,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 11, 0, 0, 0, DateTimeKind.Unspecified), "Tandskrapning", new DateTime(2020, 5, 16, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 56,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), "Injicera dunderhonung", new DateTime(2020, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), "Operation", new DateTime(2020, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 58,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 12, 0, 0, 0, DateTimeKind.Unspecified), "Knäskålsrekonstruktion", new DateTime(2020, 5, 16, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 59,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 18, 0, 0, 0, DateTimeKind.Unspecified), "Genkodning", new DateTime(2020, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 60,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), "Öronkontroll", new DateTime(2020, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 6, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 6, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 6, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 6, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 55,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 6, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 56,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 58,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 59,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 60,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 6, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 61,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 62,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 63,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 64,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 65,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 66,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 67,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 68,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 69,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 70,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 16, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { 1, "Silver", "Sork", true, "0709037319" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 2, "Gandalf", "Krukskalle", "0703991945" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { 1, "Svetlana", "Gandhi", false, "0702622392" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { "Carlos", "Segelspjut", false, "0701795058" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Tyrion", "Sainz", "0707264223" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "FirstName", "OnSite", "PhoneNr" },
                values: new object[] { "Nikolaj", false, "0704030363" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 2, "Silver", "Dorian", "0708711616" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { 2, "Sauron", "Anka", true, "0708081420" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Silver", "Segelspjut", "0704978837" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Kalle", "Gandhi", "0702523431" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 2, "Katja", "Springsteen", "0706218451" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { 1, "Savanna", "Fritjiofsdottir", true, "0707785944" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 2, "Sauron", "Daniels", "0704852704" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 1, "Tyrion", "Sork", "0706283336" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Sauron", "Kenttä", "0705754952" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Krösus", "Askrafvsfader", "0703233393" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 1, "Tyrion", "Ramone", "0707433490" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 1, "Lisa", "Krunkenstör", "0705853177" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { "Krösus", "Askrafvsfader", false, "0708377980" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { "Mario", "Gandhi", true, "0709480195" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Mattias", "Segelspjut", "0705953927" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Nikolaj", "Hormoz", "0708280821" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 1, "Ali", "Gråskägge", "0705307237" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Mattias", "Gandhi", "0704031493" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { 2, "Stina", "Kenttä", false, "0705050064" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { "Savanna", "Filling", true, "0709139384" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { "Lisa", "Von Röfvenstråhle", true, "0701258856" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { "Krösus", "Dorian", false, "0702435719" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { 2, "Stina", "Ramone", true, "0707082210" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { "Savanna", "Dorian", false, "0701247488" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "DepartmentId", "LastName", "PhoneNr" },
                values: new object[] { 2, "Ramone", "0709035034" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 2, "Svetlana", "Sainz", "0703235656" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Ali", "Woltersson", "0709669695" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 2, "Gandalf", "Sork", "0704612832" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { "Mattias", "Filling", true, "0704283018" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Sauron", "Sainz", "0704940880" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { "Savanna", "Springsteen", true, "0706017866" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { "Carlos", "Ramone", false, "0706361656" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "FirstName", "OnSite", "PhoneNr" },
                values: new object[] { "Mario", false, "0703827665" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { 1, "Benjamin", "Daniels", false, "0707999796" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 1, "Mattias", "Ramone", "0703385890" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "FirstName", "PhoneNr" },
                values: new object[] { "Ali", "0707644642" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 1, "Kristian", "Askrafvsfader", "0704797059" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Mattias", "Springsteen", "0709045804" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 2, "Kristian", "Von Röfvenstråhle", "0703232983" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 1, "Gandalf", "Askrafvsfader", "0703482312" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { 1, "Katja", "Sork", false, "0701930227" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 1, "Tyrion", "Askrafvsfader", "0702347394" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Sauron", "Sainz", "0707046938" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { "Benjamin", "Segelspjut", true, "0709361946" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 2, "Stina", "Filling", "0703306541" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 1, "Sauron", "Segelspjut", "0709072981" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Lisa", "Gandhi", "0706713201" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Obi-Wan", "Segelspjut", "0707348668" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 55,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { 2, "Obi-Wan", "Ramone", false, "0705022184" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 56,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 1, "Carla", "Vader", "0703935736" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Katja", "Von Röfvenstråhle", "0708317501" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 58,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Krösus", "Vader", "0705917194" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 59,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Krösus", "Kenttä", "0702922392" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 60,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 1, "Kristian", "Anka", "0703164559" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 61,
                columns: new[] { "DepartmentId", "FirstName", "PhoneNr" },
                values: new object[] { 2, "Sauron", "0708494329" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 62,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 1, "Obi-Wan", "Woltersson", "0703366846" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 63,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Carlos", "Ek", "0702090193" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 64,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 1, "Carla", "Gråskägge", "0704800307" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 65,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Carla", "Lannister", "0703848073" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 66,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Kalle", "Fritjiofsdottir", "0702928516" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 67,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 1, "Obi-Wan", "Ramone", "0706057234" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 68,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 2, "Mario", "Pruselius", "0703676971" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 69,
                columns: new[] { "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { "Katja", "Kenttä", false, "0701442496" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 70,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 2, "Krösus", "Krunkenstör", "0707433827" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), "Injicera dunderhonung", new DateTime(2020, 5, 14, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 10, 0, 0, 0, DateTimeKind.Unspecified), "Botoxa stortår", new DateTime(2020, 5, 14, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 15, 0, 0, 0, DateTimeKind.Unspecified), "Rutinkontroll", new DateTime(2020, 5, 14, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 13, 0, 0, 0, DateTimeKind.Unspecified), "Lungmätning", new DateTime(2020, 5, 14, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), "Laga stormiddag", new DateTime(2020, 5, 14, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 10, 0, 0, 0, DateTimeKind.Unspecified), "Botoxa stortår", new DateTime(2020, 5, 14, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 9, 0, 0, 0, DateTimeKind.Unspecified), "Skapa vaccin för kåråna", new DateTime(2020, 5, 14, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 11, 0, 0, 0, DateTimeKind.Unspecified), "Botoxa stortår", new DateTime(2020, 5, 14, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 19, 0, 0, 0, DateTimeKind.Unspecified), "Genkodning", new DateTime(2020, 5, 14, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 14, 0, 0, 0, DateTimeKind.Unspecified), "Ögonkorrigering", new DateTime(2020, 5, 14, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 14, 0, 0, 0, DateTimeKind.Unspecified), "Dyrka Satan", new DateTime(2020, 5, 14, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 11, 0, 0, 0, DateTimeKind.Unspecified), "Skriva ut krumelurpiller", new DateTime(2020, 5, 14, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), "Programmera statuslistan", new DateTime(2020, 5, 14, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 10, 0, 0, 0, DateTimeKind.Unspecified), "Programmera statuslistan", new DateTime(2020, 5, 14, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), "Operation", new DateTime(2020, 5, 14, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 13, 0, 0, 0, DateTimeKind.Unspecified), "Tandskrapning", new DateTime(2020, 5, 14, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 14, 0, 0, 0, DateTimeKind.Unspecified), "Injicera dunderhonung", new DateTime(2020, 5, 14, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 12, 0, 0, 0, DateTimeKind.Unspecified), "Genkodning", new DateTime(2020, 5, 14, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 15, 0, 0, 0, DateTimeKind.Unspecified), "Genkodning", new DateTime(2020, 5, 14, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 15, 0, 0, 0, DateTimeKind.Unspecified), "Botoxa stortår", new DateTime(2020, 5, 14, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 15, 0, 0, 0, DateTimeKind.Unspecified), "Tömma ryggradsvätska", new DateTime(2020, 5, 14, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 13, 0, 0, 0, DateTimeKind.Unspecified), "Programmera statuslistan", new DateTime(2020, 5, 14, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 15, 0, 0, 0, DateTimeKind.Unspecified), "Öronkontroll", new DateTime(2020, 5, 14, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 13, 0, 0, 0, DateTimeKind.Unspecified), "Dyrka Satan", new DateTime(2020, 5, 14, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 12, 0, 0, 0, DateTimeKind.Unspecified), "Tömma ryggradsvätska", new DateTime(2020, 5, 14, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 18, 0, 0, 0, DateTimeKind.Unspecified), "Tandskrapning", new DateTime(2020, 5, 14, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 8, 0, 0, 0, DateTimeKind.Unspecified), "Tandskrapning", new DateTime(2020, 5, 14, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 11, 0, 0, 0, DateTimeKind.Unspecified), "Knäskålsrekonstruktion", new DateTime(2020, 5, 14, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 13, 0, 0, 0, DateTimeKind.Unspecified), "Botoxa stortår", new DateTime(2020, 5, 14, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 12, 0, 0, 0, DateTimeKind.Unspecified), "Skälla ut praktikanten", new DateTime(2020, 5, 14, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 14, 0, 0, 0, DateTimeKind.Unspecified), "Genkodning", new DateTime(2020, 5, 14, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), "Operation", new DateTime(2020, 5, 14, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 15, 0, 0, 0, DateTimeKind.Unspecified), "Rutinkontroll", new DateTime(2020, 5, 14, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), "Laga stormiddag", new DateTime(2020, 5, 14, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 12, 0, 0, 0, DateTimeKind.Unspecified), "Ögonkorrigering", new DateTime(2020, 5, 14, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 18, 0, 0, 0, DateTimeKind.Unspecified), "Ögonkorrigering", new DateTime(2020, 5, 14, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 10, 0, 0, 0, DateTimeKind.Unspecified), "Botoxa stortår", new DateTime(2020, 5, 14, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 13, 0, 0, 0, DateTimeKind.Unspecified), "Botoxa stortår", new DateTime(2020, 5, 14, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 10, 0, 0, 0, DateTimeKind.Unspecified), "Programmera statuslistan", new DateTime(2020, 5, 14, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 10, 0, 0, 0, DateTimeKind.Unspecified), "Botoxa stortår", new DateTime(2020, 5, 14, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 14, 0, 0, 0, DateTimeKind.Unspecified), "Tandskrapning", new DateTime(2020, 5, 14, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), "Genkodning", new DateTime(2020, 5, 14, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 13, 0, 0, 0, DateTimeKind.Unspecified), "Injicera dunderhonung", new DateTime(2020, 5, 14, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), "Ge filiduttvaccin", new DateTime(2020, 5, 14, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 18, 0, 0, 0, DateTimeKind.Unspecified), "Skälla ut praktikanten", new DateTime(2020, 5, 14, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), "Rutinkontroll", new DateTime(2020, 5, 14, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 10, 0, 0, 0, DateTimeKind.Unspecified), "Ge filiduttvaccin", new DateTime(2020, 5, 14, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 12, 0, 0, 0, DateTimeKind.Unspecified), "Ge filiduttvaccin", new DateTime(2020, 5, 14, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 11, 0, 0, 0, DateTimeKind.Unspecified), "Injicera dunderhonung", new DateTime(2020, 5, 14, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 55,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 15, 0, 0, 0, DateTimeKind.Unspecified), "Ge filiduttvaccin", new DateTime(2020, 5, 14, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 56,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), "Öronkontroll", new DateTime(2020, 5, 14, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 10, 0, 0, 0, DateTimeKind.Unspecified), "Genkodning", new DateTime(2020, 5, 14, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 58,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), "Tandskrapning", new DateTime(2020, 5, 14, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 59,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 15, 0, 0, 0, DateTimeKind.Unspecified), "Rutinkontroll", new DateTime(2020, 5, 14, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 60,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 11, 0, 0, 0, DateTimeKind.Unspecified), "Rutinkontroll", new DateTime(2020, 5, 14, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 6, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 6, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 6, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 6, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 6, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 6, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 55,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 56,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 58,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 59,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 60,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 61,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 62,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 63,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 64,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 65,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 66,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 67,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 68,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 69,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 70,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { 2, "Nikolaj", "Ek", false, "0706103095" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 1, "Lisa", "Krunkenstör", "0708916010" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { 2, "Stina", "Sork", true, "0709909447" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { "Kalle", "Askrafvsfader", true, "0701102853" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Katja", "Krunkenstör", "0708188736" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "FirstName", "OnSite", "PhoneNr" },
                values: new object[] { "Benjamin", true, "0702193267" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 1, "Carla", "Ek", "0706310482" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { 1, "Lisa", "Kvackzelius", false, "0708019285" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Tyrion", "Vader", "0705339536" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Stina", "Anka", "0706068293" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 1, "Gandalf", "Woltersson", "0709791736" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { 2, "Mattias", "Kvackzelius", false, "0708189911" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 1, "Tyrion", "Woltersson", "0706906558" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 2, "Savanna", "Von Röfvenstråhle", "0709606035" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "JD", "Springsteen", "0707911253" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Savanna", "Gandhi", "0704955716" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 2, "Kristian", "Kvackzelius", "0704884948" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 2, "Tyrion", "Sork", "0705765904" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { "Savanna", "Krunkenstör", true, "0705938969" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { "Gandalf", "Hormoz", false, "0709931932" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Kristian", "Woltersson", "0703191240" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Sauron", "Kenttä", "0701916869" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 2, "Savanna", "Lannister", "0706232169" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Mario", "Sainz", "0705630139" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { 1, "Kalle", "Krukskalle", true, "0707637357" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { "Nikolaj", "Hormoz", false, "0707241332" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { "Silver", "Krukskalle", false, "0708867520" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { "Super", "Krukskalle", true, "0708778086" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { 1, "Mattias", "Krukskalle", false, "0707948570" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { "Mario", "Vader", true, "0703549500" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "DepartmentId", "LastName", "PhoneNr" },
                values: new object[] { 1, "Pruselius", "0705464821" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 1, "Carlos", "Kenttä", "0702803342" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Nikolaj", "Vader", "0701595159" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 1, "Stina", "Gandhi", "0706818395" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { "Super", "Dorian", false, "0705230568" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Savanna", "Kvackzelius", "0701694258" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { "Obi-Wan", "Sainz", false, "0709909125" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { "Mario", "Askrafvsfader", true, "0704939908" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "FirstName", "OnSite", "PhoneNr" },
                values: new object[] { "JD", true, "0702746751" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { 2, "Krösus", "Gandhi", true, "0709370830" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 2, "Nikolaj", "Kvackzelius", "0702491419" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "FirstName", "PhoneNr" },
                values: new object[] { "Nikolaj", "0703713699" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 2, "Sauron", "Von Röfvenstråhle", "0702777152" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Sauron", "Vader", "0704532838" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 1, "Carlos", "Askrafvsfader", "0708051504" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 2, "Kristian", "Lannister", "0709445869" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { 2, "Gandalf", "Anka", true, "0708877565" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 2, "Svetlana", "Springsteen", "0702237997" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Stina", "Gråskägge", "0709803141" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { "Super", "Ramone", false, "0709553831" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 1, "Super", "Von Röfvenstråhle", "0705046259" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 2, "Silver", "Krunkenstör", "0703857499" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Kristian", "Anka", "0708584367" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Mario", "Daniels", "0709280634" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 55,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { 1, "Katja", "Springsteen", true, "0705917443" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 56,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 2, "Obi-Wan", "Von Röfvenstråhle", "0707631929" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Savanna", "Vader", "0702376117" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 58,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Carlos", "Lannister", "0707067954" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 59,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Kalle", "Fritjiofsdottir", "0702421279" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 60,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 2, "Katja", "Woltersson", "0702460664" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 61,
                columns: new[] { "DepartmentId", "FirstName", "PhoneNr" },
                values: new object[] { 1, "Carla", "0705983522" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 62,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 2, "Kristian", "Krukskalle", "0707711562" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 63,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Tyrion", "Pruselius", "0701244182" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 64,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 2, "JD", "Sork", "0704563426" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 65,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Sauron", "Gandhi", "0705312343" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 66,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Sauron", "Kenttä", "0707614470" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 67,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 2, "Mario", "Segelspjut", "0702262464" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 68,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 1, "Svetlana", "Woltersson", "0705665027" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 69,
                columns: new[] { "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { "Carla", "Sork", true, "0702695376" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 70,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 1, "Nikolaj", "Segelspjut", "0705828015" });
        }
    }
}
