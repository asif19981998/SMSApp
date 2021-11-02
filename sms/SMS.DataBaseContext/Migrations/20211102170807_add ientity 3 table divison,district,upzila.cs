using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SMS.DataBaseContext.Migrations
{
    public partial class addientity3tabledivisondistrictupzila : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "DeletedById",
                table: "Upazilas",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "Upazilas",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Upazilas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "DeletedById",
                table: "Divisons",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "Divisons",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Divisons",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "DeletedById",
                table: "Districts",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "Districts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Districts",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "Upazilas");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Upazilas");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Upazilas");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "Divisons");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Divisons");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Divisons");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "Districts");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Districts");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Districts");
        }
    }
}
