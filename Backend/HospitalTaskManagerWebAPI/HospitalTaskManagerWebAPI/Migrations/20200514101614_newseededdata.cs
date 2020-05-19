using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalTaskManagerWebAPI.Migrations
{
    public partial class newseededdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 13, 0, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 9, 0, 0, 0, DateTimeKind.Unspecified), "Tömma ryggradsvätska", new DateTime(2020, 5, 14, 8, 0, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 11, 0, 0, 0, DateTimeKind.Unspecified), "Laga stormiddag", new DateTime(2020, 5, 14, 9, 0, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 14, 0, 0, 0, DateTimeKind.Unspecified), "Skapa vaccin för kåråna", new DateTime(2020, 5, 14, 12, 0, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), "Skapa vaccin för kåråna", new DateTime(2020, 5, 14, 13, 0, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 9, 0, 0, 0, DateTimeKind.Unspecified), "Injicera dunderhonung", new DateTime(2020, 5, 14, 8, 0, 0, 0, DateTimeKind.Unspecified) });

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
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { 2, "Nikolaj", "Ek", false, "0706103095" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Lisa", "Krunkenstör", "0708916010" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 2, "Stina", "Sork", "0709909447" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 2, "Kalle", "Askrafvsfader", "0701102853" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 2, "Katja", "Krunkenstör", "0708188736" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Benjamin", "Filling", "0702193267" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Carla", "Ek", "0706310482" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { "Lisa", "Kvackzelius", false, "0708019285" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 2, "Tyrion", "Vader", "0705339536" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 2, "Stina", "Anka", "0706068293" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Gandalf", "Woltersson", "0709791736" });

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
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Tyrion", "Woltersson", "0706906558" });

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
                columns: new[] { "DepartmentId", "FirstName", "OnSite", "PhoneNr" },
                values: new object[] { 2, "Tyrion", false, "0705765904" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Savanna", "Krunkenstör", "0705938969" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { 2, "Gandalf", "Hormoz", false, "0709931932" });

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
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Kalle", "Krukskalle", "0707637357" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { 2, "Nikolaj", "Hormoz", false, "0707241332" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { 2, "Silver", "Krukskalle", false, "0708867520" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Super", "Krukskalle", "0708778086" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { "Mattias", "Krukskalle", false, "0707948570" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Mario", "Vader", "0703549500" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Nikolaj", "Pruselius", "0705464821" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "FirstName", "PhoneNr" },
                values: new object[] { "Carlos", "0702803342" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 2, "Nikolaj", "Vader", "0701595159" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "LastName", "PhoneNr" },
                values: new object[] { "Gandhi", "0706818395" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { 2, "Super", "Dorian", false, "0705230568" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { 2, "Savanna", "Kvackzelius", false, "0701694258" });

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
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Mario", "Askrafvsfader", "0704939908" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "FirstName", "PhoneNr" },
                values: new object[] { "JD", "0702746751" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 2, "Krösus", "Gandhi", "0709370830" });

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
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 2, "Nikolaj", "Kvackzelius", "0703713699" });

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
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 2, "Sauron", "Vader", "0704532838" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Carlos", "Askrafvsfader", "0708051504" });

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
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 2, "Gandalf", "Anka", "0708877565" });

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
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 2, "Stina", "Gråskägge", "0709803141" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { 2, "Super", "Ramone", false, "0709553831" });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "ID", "DepartmentId", "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[,]
                {
                    { 68, 1, "Svetlana", "Woltersson", true, "0705665027" },
                    { 67, 2, "Mario", "Segelspjut", true, "0702262464" },
                    { 66, 2, "Sauron", "Kenttä", true, "0707614470" },
                    { 65, 2, "Sauron", "Gandhi", true, "0705312343" },
                    { 64, 2, "JD", "Sork", true, "0704563426" },
                    { 63, 1, "Tyrion", "Pruselius", true, "0701244182" },
                    { 62, 2, "Kristian", "Krukskalle", true, "0707711562" },
                    { 61, 1, "Carla", "Daniels", true, "0705983522" },
                    { 60, 2, "Katja", "Woltersson", true, "0702460664" },
                    { 59, 2, "Kalle", "Fritjiofsdottir", true, "0702421279" },
                    { 58, 1, "Carlos", "Lannister", true, "0707067954" },
                    { 57, 1, "Savanna", "Vader", true, "0702376117" },
                    { 56, 2, "Obi-Wan", "Von Röfvenstråhle", true, "0707631929" },
                    { 55, 1, "Katja", "Springsteen", true, "0705917443" },
                    { 54, 1, "Mario", "Daniels", true, "0709280634" },
                    { 53, 1, "Kristian", "Anka", true, "0708584367" },
                    { 52, 2, "Silver", "Krunkenstör", true, "0703857499" },
                    { 51, 1, "Super", "Von Röfvenstråhle", true, "0705046259" },
                    { 69, 1, "Carla", "Sork", true, "0702695376" },
                    { 70, 1, "Nikolaj", "Segelspjut", true, "0705828015" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "ID", "EndDate", "StaffID", "StartDate" },
                values: new object[,]
                {
                    { 51, new DateTime(2020, 5, 14, 15, 0, 0, 0, DateTimeKind.Unspecified), 51, new DateTime(2020, 5, 14, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 68, new DateTime(2020, 5, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), 68, new DateTime(2020, 5, 14, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 67, new DateTime(2020, 5, 14, 15, 0, 0, 0, DateTimeKind.Unspecified), 67, new DateTime(2020, 5, 14, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 66, new DateTime(2020, 5, 14, 19, 0, 0, 0, DateTimeKind.Unspecified), 66, new DateTime(2020, 5, 14, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 65, new DateTime(2020, 5, 14, 19, 0, 0, 0, DateTimeKind.Unspecified), 65, new DateTime(2020, 5, 14, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 64, new DateTime(2020, 5, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), 64, new DateTime(2020, 5, 14, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 63, new DateTime(2020, 5, 14, 20, 0, 0, 0, DateTimeKind.Unspecified), 63, new DateTime(2020, 5, 14, 13, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 62, new DateTime(2020, 5, 14, 19, 0, 0, 0, DateTimeKind.Unspecified), 62, new DateTime(2020, 5, 14, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 61, new DateTime(2020, 5, 14, 22, 0, 0, 0, DateTimeKind.Unspecified), 61, new DateTime(2020, 5, 14, 15, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 60, new DateTime(2020, 5, 14, 20, 0, 0, 0, DateTimeKind.Unspecified), 60, new DateTime(2020, 5, 14, 13, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 59, new DateTime(2020, 5, 14, 14, 0, 0, 0, DateTimeKind.Unspecified), 59, new DateTime(2020, 5, 14, 7, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 58, new DateTime(2020, 5, 14, 21, 0, 0, 0, DateTimeKind.Unspecified), 58, new DateTime(2020, 5, 14, 14, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 57, new DateTime(2020, 5, 14, 19, 0, 0, 0, DateTimeKind.Unspecified), 57, new DateTime(2020, 5, 14, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 56, new DateTime(2020, 5, 14, 14, 0, 0, 0, DateTimeKind.Unspecified), 56, new DateTime(2020, 5, 14, 7, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 55, new DateTime(2020, 5, 14, 18, 0, 0, 0, DateTimeKind.Unspecified), 55, new DateTime(2020, 5, 14, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 54, new DateTime(2020, 5, 14, 15, 0, 0, 0, DateTimeKind.Unspecified), 54, new DateTime(2020, 5, 14, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 53, new DateTime(2020, 5, 14, 15, 0, 0, 0, DateTimeKind.Unspecified), 53, new DateTime(2020, 5, 14, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 52, new DateTime(2020, 5, 14, 14, 0, 0, 0, DateTimeKind.Unspecified), 52, new DateTime(2020, 5, 14, 7, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 69, new DateTime(2020, 5, 14, 20, 0, 0, 0, DateTimeKind.Unspecified), 69, new DateTime(2020, 5, 14, 13, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 70, new DateTime(2020, 5, 14, 14, 0, 0, 0, DateTimeKind.Unspecified), 70, new DateTime(2020, 5, 14, 7, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 70);

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), "Skälla ut praktikanten", new DateTime(2020, 5, 11, 13, 0, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 12, 0, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), "Skriva ut krumelurpiller", new DateTime(2020, 5, 11, 10, 0, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), "Skriva ut krumelurpiller", new DateTime(2020, 5, 11, 7, 0, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), "Tandskrapning", new DateTime(2020, 5, 11, 17, 0, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), "Rutinkontroll", new DateTime(2020, 5, 11, 8, 0, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), "Operation", new DateTime(2020, 5, 11, 17, 0, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), "Laga stormiddag", new DateTime(2020, 5, 11, 9, 0, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), "Tömma ryggradsvätska", new DateTime(2020, 5, 11, 8, 0, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 19, 0, 0, 0, DateTimeKind.Unspecified), "Ögonkorrigering", new DateTime(2020, 5, 11, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 13, 0, 0, 0, DateTimeKind.Unspecified), "Rutinkontroll", new DateTime(2020, 5, 11, 12, 0, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndDate", "ProcedureName", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), "Operation", new DateTime(2020, 5, 11, 8, 0, 0, 0, DateTimeKind.Unspecified) });

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
                keyValue: 19,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 8, 0, 0, 0, DateTimeKind.Unspecified) });

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
                keyValue: 25,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 11, 0, 0, 0, DateTimeKind.Unspecified) });

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
                keyValue: 36,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 7, 0, 0, 0, DateTimeKind.Unspecified) });

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
                keyValue: 41,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 7, 0, 0, 0, DateTimeKind.Unspecified) });

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
                keyValue: 47,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 13, 0, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "DepartmentId", "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { 1, "Super", "Gråskägge", true, "0703417071" });

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
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 1, "Krösus", "Woltersson", "0701465387" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 1, "Mario", "Woltersson", "0708896015" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 1, "Savanna", "Adrafsfader", "0701596615" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Mattias", "Von Röfvenstråhle", "0705693046" });

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
                columns: new[] { "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { "Katja", "Lannister", true, "0703138957" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 1, "Mattias", "Woltersson", "0701273432" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 1, "Svetlana", "Kvackzelius", "0708301219" });

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
                columns: new[] { "DepartmentId", "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { 1, "Stina", "Hormoz", true, "0706747844" });

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
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 1, "CourageWolf", "Ek", "0701850421" });

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
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 1, "Katja", "Skraputnik", "0702516062" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DepartmentId", "FirstName", "OnSite", "PhoneNr" },
                values: new object[] { 1, "Kalle", true, "0709149243" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Super", "Woltersson", "0707835100" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { 1, "Nikolaj", "Filling", true, "0702762434" });

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
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 1, "Kalle", "Springsteen", "0702439083" });

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
                columns: new[] { "DepartmentId", "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { 1, "Benjamin", "Anka", true, "0701370198" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { 1, "Super", "Woltersson", true, "0709741831" });

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
                columns: new[] { "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { "Krösus", "Skraputnik", true, "0709165521" });

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
                columns: new[] { "FirstName", "LastName", "PhoneNr" },
                values: new object[] { "Katja", "Lannister", "0701729645" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "FirstName", "PhoneNr" },
                values: new object[] { "Tyrion", "0708472537" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 1, "Krösus", "Ek", "0708042819" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "LastName", "PhoneNr" },
                values: new object[] { "Adrafsfader", "0702904227" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { 1, "Benjamin", "Kenttä", true, "0706523346" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { 1, "Gandalf", "Segelspjut", true, "0709326149" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { "Gandalf", "Krunkenstör", true, "0707831571" });

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
                columns: new[] { "FirstName", "PhoneNr" },
                values: new object[] { "Mattias", "0705762297" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 1, "Mattias", "Von Röfvenstråhle", "0702703472" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 1, "Krösus", "Sork", "0707683738" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 1, "Gandalf", "Ramone", "0703284393" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 1, "Gandalf", "Gråskägge", "0708651148" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 1, "Gandalf", "Skraputnik", "0701034184" });

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
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 1, "Svetlana", "Anka", "0709791293" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 1, "Svetlana", "Lannister", "0704204066" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 1, "Benjamin", "Hormoz", "0706213256" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "PhoneNr" },
                values: new object[] { 1, "Krösus", "Krunkenstör", "0707729589" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "DepartmentId", "FirstName", "LastName", "OnSite", "PhoneNr" },
                values: new object[] { 1, "CourageWolf", "Kenttä", true, "0704163560" });
        }
    }
}
