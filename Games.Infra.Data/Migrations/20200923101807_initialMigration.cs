using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Games.Infra.Data.Migrations
{
    public partial class initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(type: "varchar(150)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(type: "varchar(150)", nullable: false),
                    Phone = table.Column<string>(type: "varchar(11)", nullable: false),
                    Email = table.Column<string>(type: "varchar(150)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GameLends",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IdPerson = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdGame = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LendOn = table.Column<DateTime>(type: "datetime", nullable: false),
                    ReturnedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameLends", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GameLends_Games_IdGame",
                        column: x => x.IdGame,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GameLends_Persons_IdPerson",
                        column: x => x.IdPerson,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GameLends_IdGame",
                table: "GameLends",
                column: "IdGame");

            migrationBuilder.CreateIndex(
                name: "IX_GameLends_IdPerson",
                table: "GameLends",
                column: "IdPerson");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GameLends");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
