using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MovieReview.Data.Migrations
{
    public partial class movies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Genre",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Length",
                table: "Genre",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MovieID",
                table: "Genre",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Rating",
                table: "Genre",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Genre",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Genre");

            migrationBuilder.DropColumn(
                name: "Length",
                table: "Genre");

            migrationBuilder.DropColumn(
                name: "MovieID",
                table: "Genre");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Genre");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Genre");
        }
    }
}
