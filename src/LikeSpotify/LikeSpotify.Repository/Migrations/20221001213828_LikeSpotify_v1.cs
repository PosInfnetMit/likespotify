using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LikeSpotify.Repository.Migrations
{
    public partial class LikeSpotify_v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artista",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Descricao = table.Column<string>(type: "varchar(1024)", maxLength: 1024, nullable: false),
                    E_Banda = table.Column<bool>(type: "bit", nullable: false),
                    Foto = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artista", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nome = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    DtNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "varchar(1024)", maxLength: 1024, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Albuns",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    DataLancamento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArtistaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albuns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Albuns_Artista_ArtistaId",
                        column: x => x.ArtistaId,
                        principalTable: "Artista",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Playlists",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ordem_Execucao = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Playlists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Playlists_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Midia",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Ordem = table.Column<int>(type: "int", nullable: false),
                    Tempo_Midia = table.Column<int>(type: "int", nullable: true),
                    AlbumId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Midia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Midia_Albuns_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Albuns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MidiaPlaylist",
                columns: table => new
                {
                    MidiasId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlaylistsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MidiaPlaylist", x => new { x.MidiasId, x.PlaylistsId });
                    table.ForeignKey(
                        name: "FK_MidiaPlaylist_Midia_MidiasId",
                        column: x => x.MidiasId,
                        principalTable: "Midia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MidiaPlaylist_Playlists_PlaylistsId",
                        column: x => x.PlaylistsId,
                        principalTable: "Playlists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Albuns_ArtistaId",
                table: "Albuns",
                column: "ArtistaId");

            migrationBuilder.CreateIndex(
                name: "IX_Midia_AlbumId",
                table: "Midia",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_MidiaPlaylist_PlaylistsId",
                table: "MidiaPlaylist",
                column: "PlaylistsId");

            migrationBuilder.CreateIndex(
                name: "IX_Playlists_UsuarioId",
                table: "Playlists",
                column: "UsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MidiaPlaylist");

            migrationBuilder.DropTable(
                name: "Midia");

            migrationBuilder.DropTable(
                name: "Playlists");

            migrationBuilder.DropTable(
                name: "Albuns");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Artista");
        }
    }
}
