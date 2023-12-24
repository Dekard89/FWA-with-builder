using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DbRecipeContext.Migrations
{
    /// <inheritdoc />
    public partial class Image : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimeToCook",
                table: "Recipes");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Recipes",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Recipes");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "TimeToCook",
                table: "Recipes",
                type: "interval",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));
        }
    }
}
