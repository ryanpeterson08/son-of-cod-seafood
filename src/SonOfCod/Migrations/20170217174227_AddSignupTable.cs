using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SonOfCod.Migrations
{
    public partial class AddSignupTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Newsletters_NewsletterId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_NewsletterId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NewsletterId",
                table: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "Signups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    userAddress = table.Column<string>(nullable: true),
                    userEmail = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Signups", x => x.Id);
                });

            migrationBuilder.AddColumn<int>(
                name: "SignupId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_SignupId",
                table: "AspNetUsers",
                column: "SignupId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Signups_SignupId",
                table: "AspNetUsers",
                column: "SignupId",
                principalTable: "Signups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Signups_SignupId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_SignupId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SignupId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Signups");

            migrationBuilder.AddColumn<int>(
                name: "NewsletterId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_NewsletterId",
                table: "AspNetUsers",
                column: "NewsletterId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Newsletters_NewsletterId",
                table: "AspNetUsers",
                column: "NewsletterId",
                principalTable: "Newsletters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
