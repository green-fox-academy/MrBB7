using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TodoDb.Migrations
{
    public partial class OneToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_todos",
                table: "todos");

            migrationBuilder.RenameTable(
                name: "todos",
                newName: "Todos");

            migrationBuilder.AddColumn<int>(
                name: "AssigneeId",
                table: "Todos",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Todos",
                table: "Todos",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Assignees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignees", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Todos_AssigneeId",
                table: "Todos",
                column: "AssigneeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_Assignees_AssigneeId",
                table: "Todos",
                column: "AssigneeId",
                principalTable: "Assignees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_Assignees_AssigneeId",
                table: "Todos");

            migrationBuilder.DropTable(
                name: "Assignees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Todos",
                table: "Todos");

            migrationBuilder.DropIndex(
                name: "IX_Todos_AssigneeId",
                table: "Todos");

            migrationBuilder.DropColumn(
                name: "AssigneeId",
                table: "Todos");

            migrationBuilder.RenameTable(
                name: "Todos",
                newName: "todos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_todos",
                table: "todos",
                column: "Id");
        }
    }
}
