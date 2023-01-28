using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiectulmeu.Migrations
{
    /// <inheritdoc />
    public partial class InitDataBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bluze",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descriere = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Culoare = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Marime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Material = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pret = table.Column<double>(type: "float", nullable: false),
                    Hoodie = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bluze", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Incaltari",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descriere = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Culoare = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Marime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Material = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pret = table.Column<double>(type: "float", nullable: false),
                    Pantofi = table.Column<bool>(type: "bit", nullable: false),
                    DinPiele = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incaltari", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pantaloni",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descriere = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Culoare = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Marime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Material = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pret = table.Column<double>(type: "float", nullable: false),
                    scurti = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pantaloni", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tricouri",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descriere = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Culoare = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Marime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Material = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pret = table.Column<double>(type: "float", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tricouri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Treninguri",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BluzaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PantaloniId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Treninguri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Treninguri_Bluze_BluzaId",
                        column: x => x.BluzaId,
                        principalTable: "Bluze",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Treninguri_Pantaloni_PantaloniId",
                        column: x => x.PantaloniId,
                        principalTable: "Pantaloni",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sosete",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descriere = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Culoare = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Marime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Material = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pret = table.Column<double>(type: "float", nullable: false),
                    Scurte = table.Column<bool>(type: "bit", nullable: false),
                    Diferite = table.Column<bool>(type: "bit", nullable: false),
                    TreningId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sosete", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sosete_Treninguri_TreningId",
                        column: x => x.TreningId,
                        principalTable: "Treninguri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TricouriLaTrening",
                columns: table => new
                {
                    TreningID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TricouID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TricouriLaTrening", x => new { x.TreningID, x.TricouID });
                    table.ForeignKey(
                        name: "FK_TricouriLaTrening_Treninguri_TreningID",
                        column: x => x.TreningID,
                        principalTable: "Treninguri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TricouriLaTrening_Tricouri_TricouID",
                        column: x => x.TricouID,
                        principalTable: "Tricouri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sosete_TreningId",
                table: "Sosete",
                column: "TreningId");

            migrationBuilder.CreateIndex(
                name: "IX_Treninguri_BluzaId",
                table: "Treninguri",
                column: "BluzaId");

            migrationBuilder.CreateIndex(
                name: "IX_Treninguri_PantaloniId",
                table: "Treninguri",
                column: "PantaloniId");

            migrationBuilder.CreateIndex(
                name: "IX_TricouriLaTrening_TricouID",
                table: "TricouriLaTrening",
                column: "TricouID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Incaltari");

            migrationBuilder.DropTable(
                name: "Sosete");

            migrationBuilder.DropTable(
                name: "TricouriLaTrening");

            migrationBuilder.DropTable(
                name: "Treninguri");

            migrationBuilder.DropTable(
                name: "Tricouri");

            migrationBuilder.DropTable(
                name: "Bluze");

            migrationBuilder.DropTable(
                name: "Pantaloni");
        }
    }
}
