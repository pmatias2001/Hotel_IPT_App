using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Hotel_IPT_App.Models;
using Microsoft.AspNetCore.Identity;
using Hotel_IPT_App.Data;

namespace Hotel_IPT_App.Data
{
    /// <summary>
    /// classe para recolher os dados particulares dos Utilizadores
    /// </summary>
    public class ApplicationUser : IdentityUser
    {

        /// <summary>
        /// recolhe a data de registo de um utilizador
        /// </summary>
        public DateTime DataRegisto { get; set; }

    }
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            // dados para definição dos 'Roles'
            modelBuilder.Entity<IdentityRole>().HasData(
               new IdentityRole { Id = "c", Name = "Criador", NormalizedName = "CRIADOR" }
               );

            // insert DB seed

            modelBuilder.Entity<Quartos>().HasData(
               new Quartos { IdQuarto = 1, Piso = 1, Descricao = "Quarto 101", Lotacao = 3, Preco = 200 },
               new Quartos { IdQuarto = 2, Piso = 1, Descricao = "Quarto 102", Lotacao = 3, Preco = 400 },
               new Quartos { IdQuarto = 3, Piso = 2, Descricao = "Quarto 201", Lotacao = 3, Preco = 350 },
               new Quartos { IdQuarto = 4, Piso = 2, Descricao = "Quarto 202", Lotacao = 3, Preco = 250 },
               new Quartos { IdQuarto = 5, Piso = 3, Descricao = "Quarto 301", Lotacao = 3, Preco = 500 },
               new Quartos { IdQuarto = 6, Piso = 3, Descricao = "Quarto 302", Lotacao = 3, Preco = 400 },
               new Quartos { IdQuarto = 7, Piso = 4, Descricao = "Quarto 401", Lotacao = 3, Preco = 200 },
               new Quartos { IdQuarto = 8, Piso = 4, Descricao = "Quarto 402", Lotacao = 3, Preco = 350 }
            );

            modelBuilder.Entity<Utilizadores>().HasData(
               new Utilizadores { Id = 1, Nome = "Marisa Vieira", DataNasc = new DateTime(2019, 4, 16), Email = "Marisa.Freitas@ipt.pt", Contacto = "967197885", NIF = "346871334" },
               new Utilizadores { Id = 2, Nome = "Fátima Ribeiro", DataNasc = new DateTime(2019, 4, 16), Email = "Fátima.Machado@ipt.pt", Contacto = "963737476", NIF = "348716334" },
               new Utilizadores { Id = 4, Nome = "Paula Silva", DataNasc = new DateTime(2019, 4, 16), Email = "Paula.Lopes@ipt.pt", Contacto = "967517256", NIF = "346487134" },
               new Utilizadores { Id = 5, Nome = "Mariline Marques", DataNasc = new DateTime(2019, 4, 16), Email = "Mariline.Martins@ipt.pt", Contacto = "967212144", NIF = "346873324" },
               new Utilizadores { Id = 6, Nome = "Marcos Rocha", DataNasc = new DateTime(2019, 4, 16), Email = "Marcos.Rocha@ipt.pt", Contacto = "962125638", NIF = "468711334" },
               new Utilizadores { Id = 7, Nome = "Alexandre Vieira", DataNasc = new DateTime(2019, 4, 16), Email = "Alexandre.Dias@ipt.pt", Contacto = "961493756", NIF = "368714334" },
               new Utilizadores { Id = 8, Nome = "Paula Soares", DataNasc = new DateTime(2019, 4, 16), Email = "Paula.Vieira@ipt.pt", Contacto = "961937768", NIF = "346681334" },
               new Utilizadores { Id = 9, Nome = "Mariline Santos", DataNasc = new DateTime(2019, 4, 16), Email = "Mariline.Ribeiro@ipt.pt", Contacto = "964106478", NIF = "346713334" },
               new Utilizadores { Id = 10, Nome = "Roberto Pinto", DataNasc = new DateTime(2019, 4, 16), Email = "Roberto.Vieira@ipt.pt", Contacto = "964685937", NIF = "934671334" }
            );

            modelBuilder.Entity<Reservas>().HasData(
               new Reservas { IdReserva = 1, DataInicial = new DateTime(2019, 4, 16), DataFim = new DateTime(2019, 4, 16), NPessoas = 2, UserFK = 1 },
               new Reservas { IdReserva = 2, DataInicial = new DateTime(2019, 10, 10), DataFim = new DateTime(2019, 4, 16), NPessoas = 4, UserFK = 1 },
               new Reservas { IdReserva = 3, DataInicial = new DateTime(2011, 3, 22), DataFim = new DateTime(2019, 4, 16), NPessoas = 4, UserFK = 5 },
               new Reservas { IdReserva = 4, DataInicial = new DateTime(2008, 6, 8), DataFim = new DateTime(2019, 4, 16), NPessoas = 6, UserFK = 5 },
               new Reservas { IdReserva = 5, DataInicial = new DateTime(2012, 8, 21), DataFim = new DateTime(2019, 4, 16), NPessoas = 4, UserFK = 2 },
               new Reservas { IdReserva = 6, DataInicial = new DateTime(2010, 10, 1), DataFim = new DateTime(2019, 4, 16), NPessoas = 4, UserFK = 6 },
               new Reservas { IdReserva = 7, DataInicial = new DateTime(2010, 10, 1), DataFim = new DateTime(2019, 4, 16), NPessoas = 2, UserFK = 6 },
               new Reservas { IdReserva = 8, DataInicial = new DateTime(2013, 4, 22), DataFim = new DateTime(2019, 4, 16), NPessoas = 6, UserFK = 7 },
               new Reservas { IdReserva = 9, DataInicial = new DateTime(2011, 5, 10), DataFim = new DateTime(2019, 4, 16), NPessoas = 4, UserFK = 7 },
               new Reservas { IdReserva = 10, DataInicial = new DateTime(2017, 3, 21), DataFim = new DateTime(2019, 4, 16), NPessoas = 2, UserFK = 4 },
               new Reservas { IdReserva = 11, DataInicial = new DateTime(2018, 1, 4), DataFim = new DateTime(2019, 4, 16), NPessoas = 4, UserFK = 8 }
            );

            modelBuilder.Entity<Fotos>().HasData(
               new Fotos { IdFoto = 1, Fotografia = "hotel.jpg", Data = new DateTime(2019, 5, 20), QuartoFK = 1 },
               new Fotos { IdFoto = 2, Fotografia = "single_duplo.jpg", Data = new DateTime(2019, 11, 18), QuartoFK = 2 },
               new Fotos { IdFoto = 3, Fotografia = "kingsize_chill.jpg", Data = new DateTime(2021, 1, 17), QuartoFK = 3 },
               new Fotos { IdFoto = 4, Fotografia = "kingsize_vista.jpg", Data = new DateTime(2019, 3, 7), QuartoFK = 4 },
               new Fotos { IdFoto = 5, Fotografia = "single.jpg", Data = new DateTime(2013, 10, 21), QuartoFK = 5 },
               new Fotos { IdFoto = 6, Fotografia = "kingsize_huge.jpg", Data = new DateTime(2020, 10, 1), QuartoFK = 6 },
               new Fotos { IdFoto = 7, Fotografia = "kingsize_duplo.jpg", Data = new DateTime(2011, 1, 4), QuartoFK = 7 },
               new Fotos { IdFoto = 8, Fotografia = "kingsize_love.jpg", Data = new DateTime(2018, 12, 23), QuartoFK = 8 }
            );
        }
        public DbSet<Utilizadores> Utilizadores { get; set; }
        public DbSet<Quartos> Quartos { get; set; }
        public DbSet<Reservas> Reservas { get; set; }
        public DbSet<Fotos> Fotos { get; set; }
    }
}
