using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace back_end.Migrations
{
    /// <inheritdoc />
    public partial class Initialize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cpp_tute",
                columns: table => new
                {
                    topic_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    topic_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    body = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    topic_code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cpp_tute", x => x.topic_id);
                });

            migrationBuilder.CreateTable(
                name: "cs_tute",
                columns: table => new
                {
                    topic_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    topic_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    body = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    topic_code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cs_tute", x => x.topic_id);
                });

            migrationBuilder.CreateTable(
                name: "javascript_tute",
                columns: table => new
                {
                    topic_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    sort_key = table.Column<int>(type: "int", nullable: false),
                    topic_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    body = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    topic_code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_javascript_tute", x => x.topic_id);
                });

            migrationBuilder.CreateTable(
                name: "python_tute",
                columns: table => new
                {
                    topic_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    topic_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    body = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    topic_code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_python_tute", x => x.topic_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cpp_tute");

            migrationBuilder.DropTable(
                name: "cs_tute");

            migrationBuilder.DropTable(
                name: "javascript_tute");

            migrationBuilder.DropTable(
                name: "python_tute");
        }
    }
}
