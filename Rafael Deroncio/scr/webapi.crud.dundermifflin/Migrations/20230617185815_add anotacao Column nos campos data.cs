using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapi.crud.dundermifflin.Migrations
{
    /// <inheritdoc />
    public partial class addanotacaoColumnnoscamposdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "funcionario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Sobrenome = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    data_nascimento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Endereco = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    Salario = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Cargo = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Departamento = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    data_contratacao = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_funcionario", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "funcionario");
        }
    }
}
