﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrabYago.Models;

namespace TrabYago.Migrations
{
    [DbContext(typeof(TrabYagoContext))]
    partial class TrabYagoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TrabYago.Models.Jogador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("Nacionalidade")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Jogador");
                });

            modelBuilder.Entity("TrabYago.Models.Placar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataPontuacao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("JogadorNome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<uint>("TotalPontos")
                        .HasColumnType("int unsigned");

                    b.HasKey("Id");

                    b.ToTable("Placar");
                });
#pragma warning restore 612, 618
        }
    }
}
