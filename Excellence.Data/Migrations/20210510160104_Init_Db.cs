using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Excellence.Data.Migrations
{
    public partial class Init_Db : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BankAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameLocal = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    NameEnglish = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    BirthDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SocialId = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    CityCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    BankCode = table.Column<int>(type: "int", nullable: false),
                    BranchNumber = table.Column<int>(type: "int", nullable: false),
                    AccountNumber = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankAccounts", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BankAccounts");
        }
    }
}
