using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LP3.BlazorServer.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Codigo = table.Column<string>(type: "TEXT", nullable: false),
                    Creditos = table.Column<int>(type: "INTEGER", nullable: false),
                    Activo = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estudiantes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Apellido = table.Column<string>(type: "TEXT", nullable: false),
                    Matricula = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    FechaIngreso = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Estado = table.Column<int>(type: "INTEGER", nullable: false),
                    CreadoEn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ActualizadoEn = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudiantes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Matriculaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EstudianteId = table.Column<int>(type: "INTEGER", nullable: false),
                    CursoId = table.Column<int>(type: "INTEGER", nullable: false),
                    FechaInscripcion = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CalificacionFinal = table.Column<decimal>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matriculaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Matriculaciones_Cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Matriculaciones_Estudiantes_EstudianteId",
                        column: x => x.EstudianteId,
                        principalTable: "Estudiantes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Matriculaciones_CursoId",
                table: "Matriculaciones",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_Matriculaciones_EstudianteId",
                table: "Matriculaciones",
                column: "EstudianteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Matriculaciones");

            migrationBuilder.DropTable(
                name: "Cursos");

            migrationBuilder.DropTable(
                name: "Estudiantes");
        }
    }
}
