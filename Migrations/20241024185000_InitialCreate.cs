using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace radlab3._0.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Summary = table.Column<string>(type: "TEXT", nullable: false),
                    Publication = table.Column<string>(type: "TEXT", nullable: false),
                    AuthorID = table.Column<int>(type: "INTEGER", nullable: false),
                    PublisherID = table.Column<int>(type: "INTEGER", nullable: false),
                    DateOfPublication = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CoverPageUrl = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
