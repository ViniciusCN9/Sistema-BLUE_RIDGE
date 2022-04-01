using Microsoft.EntityFrameworkCore.Migrations;

namespace DesafioMVC.Migrations
{
    public partial class SeedSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Generos",
                columns: new[] { "Id", "Nome", "Status" },
                values: new object[] { 1, "Jazz", true });
            
            migrationBuilder.InsertData(
                table: "Generos",
                columns: new[] { "Id", "Nome", "Status" },
                values: new object[] { 2, "Soul", true });
        
            migrationBuilder.InsertData(
                table: "Generos",
                columns: new[] { "Id", "Nome", "Status" },
                values: new object[] { 3, "Rock", true });
        
            migrationBuilder.InsertData(
                table: "Generos",
                columns: new[] { "Id", "Nome", "Status" },
                values: new object[] { 4, "Pop", true });

            migrationBuilder.InsertData(
                table: "Generos",
                columns: new[] { "Id", "Nome", "Status" },
                values: new object[] { 5, "HipHop", true });

            migrationBuilder.InsertData(
                table: "Generos",
                columns: new[] { "Id", "Nome", "Status" },
                values: new object[] { 6, "Indie", true });

            migrationBuilder.InsertData(
                table: "Generos",
                columns: new[] { "Id", "Nome", "Status" },
                values: new object[] { 7, "Alternative", true });

            migrationBuilder.InsertData(
                table: "Generos",
                columns: new[] { "Id", "Nome", "Status" },
                values: new object[] { 8, "Blues", true });

            migrationBuilder.InsertData(
                table: "Generos",
                columns: new[] { "Id", "Nome", "Status" },
                values: new object[] { 9, "Clássica", true });

            migrationBuilder.InsertData(
                table: "Generos",
                columns: new[] { "Id", "Nome", "Status" },
                values: new object[] { 10, "Outro", true });

            migrationBuilder.InsertData(
                table: "Estabelecimentos",
                columns: new[] { "Id", "Nome", "Endereco", "Email", "Telefone", "Status" },
                values: new object[] { 1, "JazzNosFundos", "Rua Cardeal Arcoverde, 742 - Pinheiros, São Paulo - SP, 05412-002", "jazzmusic@example.com", "(11) 3088-0645", true });

            migrationBuilder.InsertData(
                table: "Estabelecimentos",
                columns: new[] { "Id", "Nome", "Endereco", "Email", "Telefone", "Status" },
                values: new object[] { 2, "Bourbon Convention Ibirapuera", "Av. Ibirapuera 2927, São Paulo, SP, 04029-200", "bluesmusic@example.com", "(11) 2161-2200", true });

            migrationBuilder.InsertData(
                table: "Estabelecimentos",
                columns: new[] { "Id", "Nome", "Endereco", "Email", "Telefone", "Status" },
                values: new object[] { 3, "General Bar", "Av. Rodolpho Magnani 613, Jaú, SP, 17210-100", "rockmusic@example.com", "(14) 3626-5936", true });

            migrationBuilder.InsertData(
                table: "Estabelecimentos",
                columns: new[] { "Id", "Nome", "Endereco", "Email", "Telefone", "Status" },
                values: new object[] { 4, "Lolla Disco & Bar", "Av. João Franceschi, 905 - Jardim Alvorada, Jaú - SP, 17210-373", "popmusic@example.com", "(14) 99773-3459", true });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "Nome", "Capacidade", "Data", "ValorIngresso", "EstabelecimentoId", "GeneroId", "ImagemUrl", "Status" },
                values: new object[] { 1, "Delicatessen", 2200, "2022-06-10 19:00:00.000000", 251.22f, 2, 1, "1b10a1f9-delicatessen_creditoRauKrebs02.jpg", true});

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "Nome", "Capacidade", "Data", "ValorIngresso", "EstabelecimentoId", "GeneroId", "ImagemUrl", "Status" },
                values: new object[] { 2, "Ablusadas", 1244, "2022-09-07 20:00:00.000000", 95f, 1, 1, "d0e60970-Design-sem-nome-7.png.webp", true});

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "Nome", "Capacidade", "Data", "ValorIngresso", "EstabelecimentoId", "GeneroId", "ImagemUrl", "Status" },
                values: new object[] { 3, "Capital Inicial", 6354, "2022-07-17 18:30:00.000000", 189.99f, 3, 3, "f59eeb75-capital-inicial-sonora-photo_official-1-web-1.jpg", true});

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "Nome", "Capacidade", "Data", "ValorIngresso", "EstabelecimentoId", "GeneroId", "ImagemUrl", "Status" },
                values: new object[] { 4, "Melim", 4300, "2022-10-15 21:45:00.000000", 89f, 3, 4, "96f84fd0-14861-melim-promo-tour2019-5-1.jpg", true});

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "Nome", "Capacidade", "Data", "ValorIngresso", "EstabelecimentoId", "GeneroId", "ImagemUrl", "Status" },
                values: new object[] { 5, "Alok", 15130, "2022-11-20 00:00:00.000000", 363.49f, 4, 4, "18e60db7-licensed-image.jpg", true});
            
            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "Nome", "Capacidade", "Data", "ValorIngresso", "EstabelecimentoId", "GeneroId", "ImagemUrl", "Status" },
                values: new object[] { 6, "Lulu Santos", 9010, "2022-06-10 19:00:00.000000", 132f, 4, 4, "00bc1c4e-licensed-image (1).jpg", true});
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
