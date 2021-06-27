﻿// <auto-generated />
using System;
using Hotel_IPT_App.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Hotel_IPT_App.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Hotel_IPT.Models.Fotos", b =>
                {
                    b.Property<int>("IdFoto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("Fotografia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuartoFK")
                        .HasColumnType("int");

                    b.HasKey("IdFoto");

                    b.HasIndex("QuartoFK");

                    b.ToTable("Fotos");

                    b.HasData(
                        new
                        {
                            IdFoto = 1,
                            Data = new DateTime(2019, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fotografia = "Retriever_do_labrador.jpg",
                            QuartoFK = 1
                        },
                        new
                        {
                            IdFoto = 2,
                            Data = new DateTime(2019, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fotografia = "Retriever_do_labrador_2.jpg",
                            QuartoFK = 1
                        },
                        new
                        {
                            IdFoto = 3,
                            Data = new DateTime(2019, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fotografia = "Retriever_do_labrador_3.jpg",
                            QuartoFK = 2
                        },
                        new
                        {
                            IdFoto = 4,
                            Data = new DateTime(2021, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fotografia = "s.bernardo.jpg",
                            QuartoFK = 3
                        },
                        new
                        {
                            IdFoto = 5,
                            Data = new DateTime(2019, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fotografia = "s.bernardo_2.jpg",
                            QuartoFK = 4
                        },
                        new
                        {
                            IdFoto = 6,
                            Data = new DateTime(2013, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fotografia = "serra_da_estrela.jpg",
                            QuartoFK = 5
                        },
                        new
                        {
                            IdFoto = 7,
                            Data = new DateTime(2012, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fotografia = "serra_da_estrela_2.jpg",
                            QuartoFK = 5
                        },
                        new
                        {
                            IdFoto = 8,
                            Data = new DateTime(2020, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fotografia = "Rafeiro_do_Alentejo.jpg",
                            QuartoFK = 6
                        },
                        new
                        {
                            IdFoto = 9,
                            Data = new DateTime(2011, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fotografia = "pastor_alemao_2.jpg",
                            QuartoFK = 7
                        },
                        new
                        {
                            IdFoto = 10,
                            Data = new DateTime(2020, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fotografia = "pastor_alemao.jpg",
                            QuartoFK = 7
                        },
                        new
                        {
                            IdFoto = 11,
                            Data = new DateTime(2018, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fotografia = "golden-retriever_2.jpg",
                            QuartoFK = 8
                        },
                        new
                        {
                            IdFoto = 12,
                            Data = new DateTime(2017, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fotografia = "golden-retriever.jpg",
                            QuartoFK = 8
                        },
                        new
                        {
                            IdFoto = 13,
                            Data = new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fotografia = "Golden-Retriever-1.jpg",
                            QuartoFK = 5
                        },
                        new
                        {
                            IdFoto = 14,
                            Data = new DateTime(2021, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fotografia = "Dogue_Alemao.jpg",
                            QuartoFK = 7
                        },
                        new
                        {
                            IdFoto = 15,
                            Data = new DateTime(2021, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fotografia = "border_collie.jpg",
                            QuartoFK = 2
                        });
                });

            modelBuilder.Entity("Hotel_IPT.Models.Quartos", b =>
                {
                    b.Property<int>("IdQuarto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Lotacao")
                        .HasColumnType("int");

                    b.Property<int>("Piso")
                        .HasColumnType("int");

                    b.Property<double>("Preco")
                        .HasColumnType("float");

                    b.HasKey("IdQuarto");

                    b.ToTable("Quartos");

                    b.HasData(
                        new
                        {
                            IdQuarto = 1,
                            Descricao = "Retriever do Labrador",
                            Lotacao = 3,
                            Piso = 3,
                            Preco = 20.300000000000001
                        },
                        new
                        {
                            IdQuarto = 2,
                            Descricao = "Serra da Estrela",
                            Lotacao = 3,
                            Piso = 3,
                            Preco = 20.300000000000001
                        },
                        new
                        {
                            IdQuarto = 3,
                            Descricao = "Pastor Alemão",
                            Lotacao = 3,
                            Piso = 3,
                            Preco = 20.300000000000001
                        },
                        new
                        {
                            IdQuarto = 4,
                            Descricao = "Dogue Alemão",
                            Lotacao = 3,
                            Piso = 3,
                            Preco = 20.300000000000001
                        },
                        new
                        {
                            IdQuarto = 5,
                            Descricao = "S. Bernardo",
                            Lotacao = 3,
                            Piso = 3,
                            Preco = 20.300000000000001
                        },
                        new
                        {
                            IdQuarto = 6,
                            Descricao = "Rafeiro do Alentejo",
                            Lotacao = 3,
                            Piso = 3,
                            Preco = 20.300000000000001
                        },
                        new
                        {
                            IdQuarto = 7,
                            Descricao = "Golden Retriever",
                            Lotacao = 3,
                            Piso = 3,
                            Preco = 20.300000000000001
                        },
                        new
                        {
                            IdQuarto = 8,
                            Descricao = "Border Collie",
                            Lotacao = 3,
                            Piso = 3,
                            Preco = 20.300000000000001
                        });
                });

            modelBuilder.Entity("Hotel_IPT.Models.Reservas", b =>
                {
                    b.Property<int>("IdReserva")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataFim")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataInicial")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<int>("NPessoas")
                        .HasColumnType("int");

                    b.Property<int>("UserFK")
                        .HasColumnType("int");

                    b.HasKey("IdReserva");

                    b.HasIndex("UserFK");

                    b.ToTable("Reservas");

                    b.HasData(
                        new
                        {
                            IdReserva = 1,
                            DataFim = new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataInicial = new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = false,
                            NPessoas = 3,
                            UserFK = 1
                        },
                        new
                        {
                            IdReserva = 2,
                            DataFim = new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataInicial = new DateTime(2019, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = false,
                            NPessoas = 3,
                            UserFK = 1
                        },
                        new
                        {
                            IdReserva = 3,
                            DataFim = new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataInicial = new DateTime(2011, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = false,
                            NPessoas = 3,
                            UserFK = 5
                        },
                        new
                        {
                            IdReserva = 4,
                            DataFim = new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataInicial = new DateTime(2008, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = false,
                            NPessoas = 3,
                            UserFK = 5
                        },
                        new
                        {
                            IdReserva = 5,
                            DataFim = new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataInicial = new DateTime(2012, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = false,
                            NPessoas = 3,
                            UserFK = 2
                        },
                        new
                        {
                            IdReserva = 6,
                            DataFim = new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataInicial = new DateTime(2010, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = false,
                            NPessoas = 3,
                            UserFK = 6
                        },
                        new
                        {
                            IdReserva = 7,
                            DataFim = new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataInicial = new DateTime(2010, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = false,
                            NPessoas = 3,
                            UserFK = 6
                        },
                        new
                        {
                            IdReserva = 8,
                            DataFim = new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataInicial = new DateTime(2013, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = false,
                            NPessoas = 3,
                            UserFK = 7
                        },
                        new
                        {
                            IdReserva = 9,
                            DataFim = new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataInicial = new DateTime(2011, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = false,
                            NPessoas = 3,
                            UserFK = 7
                        },
                        new
                        {
                            IdReserva = 10,
                            DataFim = new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataInicial = new DateTime(2017, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = false,
                            NPessoas = 3,
                            UserFK = 4
                        },
                        new
                        {
                            IdReserva = 11,
                            DataFim = new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataInicial = new DateTime(2018, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = false,
                            NPessoas = 3,
                            UserFK = 8
                        });
                });

            modelBuilder.Entity("Hotel_IPT.Models.Utilizadores", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contacto")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.Property<DateTime>("DataNasc")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NIF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Utilizadores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Contacto = "967197885",
                            DataNasc = new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Marisa.Freitas@ipt.pt",
                            NIF = "346871334",
                            Nome = "Marisa Vieira"
                        },
                        new
                        {
                            Id = 2,
                            Contacto = "963737476",
                            DataNasc = new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Fátima.Machado@ipt.pt",
                            NIF = "346871334",
                            Nome = "Fátima Ribeiro"
                        },
                        new
                        {
                            Id = 4,
                            Contacto = "967517256",
                            DataNasc = new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Paula.Lopes@ipt.pt",
                            NIF = "346871334",
                            Nome = "Paula Silva"
                        },
                        new
                        {
                            Id = 5,
                            Contacto = "967212144",
                            DataNasc = new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Mariline.Martins@ipt.pt",
                            NIF = "346871334",
                            Nome = "Mariline Marques"
                        },
                        new
                        {
                            Id = 6,
                            Contacto = "962125638",
                            DataNasc = new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Marcos.Rocha@ipt.pt",
                            NIF = "346871334",
                            Nome = "Marcos Rocha"
                        },
                        new
                        {
                            Id = 7,
                            Contacto = "961493756",
                            DataNasc = new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Alexandre.Dias@ipt.pt",
                            NIF = "346871334",
                            Nome = "Alexandre Vieira"
                        },
                        new
                        {
                            Id = 8,
                            Contacto = "961937768",
                            DataNasc = new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Paula.Vieira@ipt.pt",
                            NIF = "346871334",
                            Nome = "Paula Soares"
                        },
                        new
                        {
                            Id = 9,
                            Contacto = "964106478",
                            DataNasc = new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Mariline.Ribeiro@ipt.pt",
                            NIF = "346871334",
                            Nome = "Mariline Santos"
                        },
                        new
                        {
                            Id = 10,
                            Contacto = "964685937",
                            DataNasc = new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Roberto.Vieira@ipt.pt",
                            NIF = "346871334",
                            Nome = "Roberto Pinto"
                        });
                });

            modelBuilder.Entity("Hotel_IPT_App.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataRegisto")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("QuartosReservas", b =>
                {
                    b.Property<int>("ListaQuartosIdQuarto")
                        .HasColumnType("int");

                    b.Property<int>("ListaReservasIdReserva")
                        .HasColumnType("int");

                    b.HasKey("ListaQuartosIdQuarto", "ListaReservasIdReserva");

                    b.HasIndex("ListaReservasIdReserva");

                    b.ToTable("QuartosReservas");
                });

            modelBuilder.Entity("Hotel_IPT.Models.Fotos", b =>
                {
                    b.HasOne("Hotel_IPT.Models.Quartos", "Quarto")
                        .WithMany("ListaFotos")
                        .HasForeignKey("QuartoFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Quarto");
                });

            modelBuilder.Entity("Hotel_IPT.Models.Reservas", b =>
                {
                    b.HasOne("Hotel_IPT.Models.Utilizadores", "Cliente")
                        .WithMany("ListaReservas")
                        .HasForeignKey("UserFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Hotel_IPT_App.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Hotel_IPT_App.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hotel_IPT_App.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Hotel_IPT_App.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("QuartosReservas", b =>
                {
                    b.HasOne("Hotel_IPT.Models.Quartos", null)
                        .WithMany()
                        .HasForeignKey("ListaQuartosIdQuarto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hotel_IPT.Models.Reservas", null)
                        .WithMany()
                        .HasForeignKey("ListaReservasIdReserva")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Hotel_IPT.Models.Quartos", b =>
                {
                    b.Navigation("ListaFotos");
                });

            modelBuilder.Entity("Hotel_IPT.Models.Utilizadores", b =>
                {
                    b.Navigation("ListaReservas");
                });
#pragma warning restore 612, 618
        }
    }
}
