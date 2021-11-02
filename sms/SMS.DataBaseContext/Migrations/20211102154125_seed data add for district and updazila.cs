using Microsoft.EntityFrameworkCore.Migrations;

namespace SMS.DataBaseContext.Migrations
{
    public partial class seeddataaddfordistrictandupdazila : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "Code", "DivisonId", "Name" },
                values: new object[,]
                {
                    { 1L, "001Di", 1L, "Kishoreganj" },
                    { 2L, "002Di", 1L, "Gazipur" },
                    { 3L, "003Di", 1L, "Manikganj" }
                });

            migrationBuilder.UpdateData(
                table: "Divisons",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Code",
                value: "001D");

            migrationBuilder.UpdateData(
                table: "Divisons",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Code",
                value: "002D");

            migrationBuilder.InsertData(
                table: "Upazilas",
                columns: new[] { "Id", "Code", "DistrictId", "Name" },
                values: new object[,]
                {
                    { 1L, "001U", 1L, "Kishoreganj Sadar" },
                    { 2L, "002U", 1L, "Bhairab" },
                    { 3L, "003U", 1L, "Bajitpur" },
                    { 4L, "004U", 1L, "Kuliarchar" },
                    { 5L, "005U", 1L, "Pakundia" },
                    { 6L, "006U", 1L, "Itna" },
                    { 7L, "007U", 1L, "Karimganj" },
                    { 8L, "008U", 1L, "Katiadi" },
                    { 9L, "009U", 1L, "Ashtagram" },
                    { 10L, "0010U", 1L, "Mithamin" },
                    { 11L, "0011U", 1L, "Tarail" },
                    { 12L, "0012U", 1L, "Hossainpur" },
                    { 13L, "0013U", 1L, "Nikli" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Upazilas",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Upazilas",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Upazilas",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Upazilas",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Upazilas",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Upazilas",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Upazilas",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Upazilas",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Upazilas",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Upazilas",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Upazilas",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Upazilas",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Upazilas",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.UpdateData(
                table: "Divisons",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Code",
                value: "001");

            migrationBuilder.UpdateData(
                table: "Divisons",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Code",
                value: "001");
        }
    }
}
