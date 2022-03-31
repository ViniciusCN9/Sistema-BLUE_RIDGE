using Microsoft.EntityFrameworkCore.Migrations;

namespace DesafioMVC.Migrations
{
    public partial class SeedSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount" },
                values: new object[] { "57379288-208b-4be0-a535-7c822ad9ef6a", "admin@admin.com", "ADMIN@ADMIN.COM", "admin@admin.com", "ADMIN@ADMIN.COM", true, "AQAAAAEAACcQAAAAEFcytqJ+zGrp1fe3NBL7ykSPc9o6D/yXwRdzIePCr+uuAUU0A/HfbJ9HM2LZoLAleA==", "L3CMCZZN7H4JQY3WUOIQL6DB4MZ5MFYO", "5c10b021-131c-4b47-addc-0a78c78c3ca4", null, false, false, null, true, 0});

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount" },
                values: new object[] { "cb44887b-65be-4a77-8278-a055e1f49963", "user@user.com", "USER@USER.COM", "user@user.com", "USER@USER.COM", true, "AQAAAAEAACcQAAAAEFagqtcMVJXtW5flt5oQQ+QQhI6inuhHZOoGa3zvJxcdaOqp1z9UMXxAq7qyACiG4Q==", "MOSQJEIUQPJPTKCUMKMRYYMAXT2LZBXB", "5bf54297-4927-4cf9-9f8f-93632748629e", null, false, false, null, true, 0});

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new [] { "Id", "UserId", "ClaimType", "ClaimValue" },
                values: new object[] { 1, "57379288-208b-4be0-a535-7c822ad9ef6a", "Name", "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new [] { "Id", "UserId", "ClaimType", "ClaimValue" },
                values: new object[] { 2, "57379288-208b-4be0-a535-7c822ad9ef6a", "Role", "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new [] { "Id", "UserId", "ClaimType", "ClaimValue" },
                values: new object[] { 3, "57379288-208b-4be0-a535-7c822ad9ef6a", "Name", "user" });

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new [] { "Id", "UserId", "ClaimType", "ClaimValue" },
                values: new object[] { 4, "57379288-208b-4be0-a535-7c822ad9ef6a", "Role", "user" });
        
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
