﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace clase5.Migrations
{
    /// <inheritdoc />
    public partial class add_console_model : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GameConsoleId",
                table:"Game",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name:"Console",
                columns: table => new{
                    Id = table.Column<int>(type:"INTEGER", nullable: false) .Annotation("Squile;Autoincrement", true),
                    Name = table.Column<string>(type:"TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    Company = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Console", x=> x.Id);
                });
            
            migrationBuilder.CreateIndex(
                name: "IX_Game_GameConsoleId",
                table: "Game",
                column: "GameConsoleId");

            migrationBuilder.AddForeignKey(
                name:"FK_Game_Console_Game_ConsoleId",
                table:"Game",
                column:"GameConsoleId",
                principalTable: "Console",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade); 
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
