﻿// <auto-generated />
using System;
using Api.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Api.Domain.Entities.MesReferenciaEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("Ano")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Mes")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("MesReferencia");
                });

            modelBuilder.Entity("Api.Domain.Entities.TransacaoEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("IsFixa")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsPago")
                        .HasColumnType("tinyint(1)");

                    b.Property<Guid?>("MesReferenciaEntityId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Parcelas")
                        .HasColumnType("int");

                    b.Property<int>("TipoOperacao")
                        .HasColumnType("int");

                    b.Property<int>("TipoOperacaoEntrada")
                        .HasColumnType("int");

                    b.Property<int>("TipoOperacaoSaida")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("Valor")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("MesReferenciaEntityId");

                    b.ToTable("Transacao");
                });

            modelBuilder.Entity("Api.Domain.Entities.TransacaoEntity", b =>
                {
                    b.HasOne("Api.Domain.Entities.MesReferenciaEntity", null)
                        .WithMany("Transacoes")
                        .HasForeignKey("MesReferenciaEntityId");
                });
#pragma warning restore 612, 618
        }
    }
}
