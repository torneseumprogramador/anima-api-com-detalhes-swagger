using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapi.crud.dundermifflin.Migrations
{
    /// <inheritdoc />
    public partial class addanotacaoColumnnoscamposdataetable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_funcionario",
                table: "funcionario");

            migrationBuilder.RenameTable(
                name: "funcionario",
                newName: "Funcionarios");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Funcionarios",
                table: "Funcionarios",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Funcionarios",
                table: "Funcionarios");

            migrationBuilder.RenameTable(
                name: "Funcionarios",
                newName: "funcionario");

            migrationBuilder.AddPrimaryKey(
                name: "PK_funcionario",
                table: "funcionario",
                column: "Id");
        }
    }
}
