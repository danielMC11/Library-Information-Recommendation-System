using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Interaction.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ChangeUserIdToStudentId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_InteractionEvents_UserId",
                table: "InteractionEvents");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "InteractionEvents");

            migrationBuilder.AddColumn<long>(
                name: "StudentId",
                table: "InteractionEvents",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_InteractionEvents_StudentId",
                table: "InteractionEvents",
                column: "StudentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_InteractionEvents_StudentId",
                table: "InteractionEvents");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "InteractionEvents");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "InteractionEvents",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_InteractionEvents_UserId",
                table: "InteractionEvents",
                column: "UserId");
        }
    }
}
