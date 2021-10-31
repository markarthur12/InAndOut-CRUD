﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace InAndOut.Migrations
{
    public partial class AddedFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TypeId",
                table: "Expenses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_TypeId",
                table: "Expenses",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Expenses_ExpenseTypes_TypeId",
                table: "Expenses",
                column: "TypeId",
                principalTable: "ExpenseTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expenses_ExpenseTypes_TypeId",
                table: "Expenses");

            migrationBuilder.DropIndex(
                name: "IX_Expenses_TypeId",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Expenses");
        }
    }
}
