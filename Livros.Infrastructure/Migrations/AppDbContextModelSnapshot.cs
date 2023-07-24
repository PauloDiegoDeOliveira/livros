﻿// <auto-generated />
using System;
using Livros.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Livros.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ListaObra", b =>
                {
                    b.Property<Guid>("ListasId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ObrasId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ListasId", "ObrasId");

                    b.HasIndex("ObrasId");

                    b.ToTable("ListaObra");
                });

            modelBuilder.Entity("Livros.Domain.Entities.Autor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("AlteradoEm")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("Nome");

                    b.Property<Guid>("ObraId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Status")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasDefaultValue("Ativo")
                        .HasColumnName("Status");

                    b.Property<Guid>("UsuarioId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UsuarioId1")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ObraId");

                    b.HasIndex("UsuarioId1");

                    b.ToTable("Autores", (string)null);
                });

            modelBuilder.Entity("Livros.Domain.Entities.Editora", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("AlteradoEm")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("Nome");

                    b.Property<Guid>("ObraId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Status")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasDefaultValue("Ativo")
                        .HasColumnName("Status");

                    b.Property<Guid>("UsuarioId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UsuarioId1")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ObraId");

                    b.HasIndex("UsuarioId1");

                    b.ToTable("Editoras", (string)null);
                });

            modelBuilder.Entity("Livros.Domain.Entities.Genero", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("AlteradoEm")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("Nome");

                    b.Property<Guid>("ObraId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Status")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasDefaultValue("Ativo")
                        .HasColumnName("Status");

                    b.Property<Guid>("UsuarioId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UsuarioId1")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ObraId");

                    b.HasIndex("UsuarioId1");

                    b.ToTable("Generos", (string)null);
                });

            modelBuilder.Entity("Livros.Domain.Entities.Idioma", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Alias")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("Alias");

                    b.Property<DateTime?>("AlteradoEm")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("Nome");

                    b.Property<string>("Status")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasDefaultValue("Ativo")
                        .HasColumnName("Status");

                    b.HasKey("Id");

                    b.ToTable("Idiomas", (string)null);
                });

            modelBuilder.Entity("Livros.Domain.Entities.Imagem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("AlteradoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("CaminhoAbsoluto")
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)")
                        .HasColumnName("CaminhoAbsoluto");

                    b.Property<string>("CaminhoFisico")
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)")
                        .HasColumnName("CaminhoFisico");

                    b.Property<string>("CaminhoRelativo")
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)")
                        .HasColumnName("CaminhoRelativo");

                    b.Property<string>("ContentType")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("ContentType");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("ExtensaoArquivo")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("ExtensaoArquivo");

                    b.Property<DateTime>("HoraEnvio")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("NomeArquivoBanco")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("NomeArquivoBanco")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("NomeArquivoOriginal")
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)")
                        .HasColumnName("NomeArquivoOriginal");

                    b.Property<string>("Status")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasDefaultValue("Ativo")
                        .HasColumnName("Status");

                    b.Property<string>("TamanhoEmBytes")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("TamanhoEmBytes");

                    b.Property<string>("TipoUpload")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasDefaultValue("Imagem")
                        .HasColumnName("TipoUpload");

                    b.HasKey("Id");

                    b.ToTable("Imagens", (string)null);
                });

            modelBuilder.Entity("Livros.Domain.Entities.Lista", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("AlteradoEm")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("Nome");

                    b.Property<string>("Publico")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasDefaultValue("Publico")
                        .HasColumnName("Publico");

                    b.Property<string>("Status")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasDefaultValue("Ativo")
                        .HasColumnName("Status");

                    b.Property<Guid>("UsuarioId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UsuarioId1")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId1");

                    b.ToTable("Listas", (string)null);
                });

            modelBuilder.Entity("Livros.Domain.Entities.Obra", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("AlteradoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("Anotacao")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("Anotacao");

                    b.Property<int>("AvaliacaoTotal")
                        .HasColumnType("int");

                    b.Property<bool>("Concluido")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("IdiomaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ImagemId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("PaginaTotal")
                        .HasColumnType("int");

                    b.Property<decimal>("PrecoTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasDefaultValue("Ativo")
                        .HasColumnName("Status");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasDefaultValue("Obra")
                        .HasColumnName("Tipo");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("Titulo");

                    b.Property<Guid>("UsuarioId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UsuarioId1")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("VolumeUnico")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("IdiomaId");

                    b.HasIndex("ImagemId");

                    b.HasIndex("UsuarioId1");

                    b.ToTable("Obras", (string)null);
                });

            modelBuilder.Entity("Livros.Domain.Entities.Usuario", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<DateTime?>("AlteradoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Genero")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Genero");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("Nome");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("Notificar")
                        .HasColumnType("bit");

                    b.Property<string>("PasswordHash")
                        .HasMaxLength(1000)
                        .HasColumnType("varchar(1000)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sobrenome")
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("Sobrenome");

                    b.Property<string>("Status")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasDefaultValue("Ativo")
                        .HasColumnName("Status");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("UltimoAcesso")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<long>("VersaoToken")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Livros.Domain.Entities.Volume", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("AlteradoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("Anotacao")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("Anotacao");

                    b.Property<int>("Avaliacao")
                        .HasColumnType("int");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataCompra")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataLeitura")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Lido")
                        .HasColumnType("bit");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<Guid>("ObraId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Paginas")
                        .HasColumnType("int");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasDefaultValue("Ativo")
                        .HasColumnName("Status");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("Titulo");

                    b.HasKey("Id");

                    b.HasIndex("ObraId");

                    b.ToTable("Volumes", (string)null);
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

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
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

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
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

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ListaObra", b =>
                {
                    b.HasOne("Livros.Domain.Entities.Lista", null)
                        .WithMany()
                        .HasForeignKey("ListasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Livros.Domain.Entities.Obra", null)
                        .WithMany()
                        .HasForeignKey("ObrasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Livros.Domain.Entities.Autor", b =>
                {
                    b.HasOne("Livros.Domain.Entities.Obra", "Obra")
                        .WithMany("Autores")
                        .HasForeignKey("ObraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Livros.Domain.Entities.Usuario", "Usuario")
                        .WithMany("Autores")
                        .HasForeignKey("UsuarioId1");

                    b.Navigation("Obra");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Livros.Domain.Entities.Editora", b =>
                {
                    b.HasOne("Livros.Domain.Entities.Obra", "Obra")
                        .WithMany("Editoras")
                        .HasForeignKey("ObraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Livros.Domain.Entities.Usuario", "Usuario")
                        .WithMany("Editoras")
                        .HasForeignKey("UsuarioId1");

                    b.Navigation("Obra");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Livros.Domain.Entities.Genero", b =>
                {
                    b.HasOne("Livros.Domain.Entities.Obra", "Obra")
                        .WithMany("Generos")
                        .HasForeignKey("ObraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Livros.Domain.Entities.Usuario", "Usuario")
                        .WithMany("Generos")
                        .HasForeignKey("UsuarioId1");

                    b.Navigation("Obra");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Livros.Domain.Entities.Lista", b =>
                {
                    b.HasOne("Livros.Domain.Entities.Usuario", "Usuario")
                        .WithMany("Listas")
                        .HasForeignKey("UsuarioId1");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Livros.Domain.Entities.Obra", b =>
                {
                    b.HasOne("Livros.Domain.Entities.Idioma", "Idioma")
                        .WithMany("Obras")
                        .HasForeignKey("IdiomaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Livros.Domain.Entities.Imagem", "Imagem")
                        .WithMany("Obras")
                        .HasForeignKey("ImagemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Livros.Domain.Entities.Usuario", "Usuario")
                        .WithMany("Obras")
                        .HasForeignKey("UsuarioId1");

                    b.Navigation("Idioma");

                    b.Navigation("Imagem");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Livros.Domain.Entities.Volume", b =>
                {
                    b.HasOne("Livros.Domain.Entities.Obra", "Obra")
                        .WithMany("Volumes")
                        .HasForeignKey("ObraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Obra");
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
                    b.HasOne("Livros.Domain.Entities.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Livros.Domain.Entities.Usuario", null)
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

                    b.HasOne("Livros.Domain.Entities.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Livros.Domain.Entities.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Livros.Domain.Entities.Idioma", b =>
                {
                    b.Navigation("Obras");
                });

            modelBuilder.Entity("Livros.Domain.Entities.Imagem", b =>
                {
                    b.Navigation("Obras");
                });

            modelBuilder.Entity("Livros.Domain.Entities.Obra", b =>
                {
                    b.Navigation("Autores");

                    b.Navigation("Editoras");

                    b.Navigation("Generos");

                    b.Navigation("Volumes");
                });

            modelBuilder.Entity("Livros.Domain.Entities.Usuario", b =>
                {
                    b.Navigation("Autores");

                    b.Navigation("Editoras");

                    b.Navigation("Generos");

                    b.Navigation("Listas");

                    b.Navigation("Obras");
                });
#pragma warning restore 612, 618
        }
    }
}
