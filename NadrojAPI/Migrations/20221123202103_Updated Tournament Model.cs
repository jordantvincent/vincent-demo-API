using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NadrojAPI.Migrations
{
    public partial class UpdatedTournamentModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "nickName",
                table: "tournaments",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<double>(
                name: "entryFee",
                table: "tournaments",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "entryFee",
                table: "tournaments");

            migrationBuilder.AlterColumn<string>(
                name: "nickName",
                table: "tournaments",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");
        }
    }
}
