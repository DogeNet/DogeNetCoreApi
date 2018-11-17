using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DogeNetCore.DataAccess.lib.implementations.EntityFramework.ClipRepository.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clips",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 24, nullable: false),
                    Uri = table.Column<string>(nullable: false),
                    SourceType = table.Column<string>(nullable: false),
                    StartTime = table.Column<int>(nullable: true),
                    EndTime = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clip", x => x.Id);
                    table.UniqueConstraint("UK_Name", x => x.Name);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Clips");
        }
    }
}

