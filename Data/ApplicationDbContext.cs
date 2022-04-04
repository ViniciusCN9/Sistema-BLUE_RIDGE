using System;
using System.Collections.Generic;
using System.Text;
using DesafioMVC.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DesafioMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Estabelecimento> Estabelecimentos { get; set; }
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
