using Microsoft.EntityFrameworkCore.Migrations;

namespace SMS.DataBaseContext.Migrations
{
    public partial class seeddataadd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Divisons",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 1L, "001", "Dhaka" });

            migrationBuilder.InsertData(
                table: "Divisons",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 2L, "001", "Khulna" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Divisons",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Divisons",
                keyColumn: "Id",
                keyValue: 2L);
        }
    }
}
