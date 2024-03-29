﻿// <auto-generated />
using System;
using CadastroPessoa.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CadastroPessoa.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CadastroPessoa.Models.Pessoa", b =>
                {
                    b.Property<int>("IdPessoa")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("cpf");

                    b.Property<string>("email")
                        .IsRequired();

                    b.Property<string>("hobby");

                    b.Property<DateTime>("idade");

                    b.Property<string>("localizacao")
                        .IsRequired();

                    b.Property<string>("nome");

                    b.Property<string>("sobrenome");

                    b.Property<string>("telefone")
                        .IsRequired();

                    b.HasKey("IdPessoa");

                    b.ToTable("Pessoas");
                });
#pragma warning restore 612, 618
        }
    }
}
