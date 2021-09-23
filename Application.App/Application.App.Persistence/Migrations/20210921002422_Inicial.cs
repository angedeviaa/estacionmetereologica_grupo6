using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Application.App.Persistence.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    identificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    genero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    estado = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "t_reportes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    estado = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    tecnicoEncargado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_reportes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "t_estaciones",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigoEstacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    latitud = table.Column<float>(type: "real", nullable: false),
                    longitud = table.Column<float>(type: "real", nullable: false),
                    municipio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fechaMontaje = table.Column<DateTime>(type: "datetime2", nullable: false),
                    reporteid = table.Column<int>(type: "int", nullable: true),
                    estado = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    tecnicoid = table.Column<int>(type: "int", nullable: true),
                    encargadoSeguridadid = table.Column<int>(type: "int", nullable: true),
                    adminid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_estaciones", x => x.id);
                    table.ForeignKey(
                        name: "FK_t_estaciones_Persona_adminid",
                        column: x => x.adminid,
                        principalTable: "Persona",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_t_estaciones_Persona_encargadoSeguridadid",
                        column: x => x.encargadoSeguridadid,
                        principalTable: "Persona",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_t_estaciones_Persona_tecnicoid",
                        column: x => x.tecnicoid,
                        principalTable: "Persona",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_t_estaciones_t_reportes_reporteid",
                        column: x => x.reporteid,
                        principalTable: "t_reportes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_t_estaciones_adminid",
                table: "t_estaciones",
                column: "adminid");

            migrationBuilder.CreateIndex(
                name: "IX_t_estaciones_encargadoSeguridadid",
                table: "t_estaciones",
                column: "encargadoSeguridadid");

            migrationBuilder.CreateIndex(
                name: "IX_t_estaciones_reporteid",
                table: "t_estaciones",
                column: "reporteid");

            migrationBuilder.CreateIndex(
                name: "IX_t_estaciones_tecnicoid",
                table: "t_estaciones",
                column: "tecnicoid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "t_estaciones");

            migrationBuilder.DropTable(
                name: "Persona");

            migrationBuilder.DropTable(
                name: "t_reportes");
        }
    }
}
