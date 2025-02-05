﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstApp.Migrations
{
    public partial class relationsbetweenCustomertableAndProfileTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Profiles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Profiles_CustomerId",
                table: "Profiles",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Profiles_Customers_CustomerId",
                table: "Profiles",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profiles_Customers_CustomerId",
                table: "Profiles");

            migrationBuilder.DropIndex(
                name: "IX_Profiles_CustomerId",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Profiles");
        }
    }
}
