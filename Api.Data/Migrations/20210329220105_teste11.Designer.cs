﻿// <auto-generated />
using System;
using Api.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20210329220105_teste11")]
    partial class teste11
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Api.Domain.Entities.EntradaEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<Guid?>("IsFixId")
                        .HasColumnType("char(36)");

                    b.Property<bool>("IsFixa")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsPago")
                        .HasColumnType("tinyint(1)");

                    b.Property<Guid>("MesReferenciaId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Parcelas")
                        .HasColumnType("int");

                    b.Property<Guid?>("PoupancaId")
                        .HasColumnType("char(36)");

                    b.Property<int>("TipoOperacaoEntrada")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("Valor")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("MesReferenciaId");

                    b.HasIndex("PoupancaId");

                    b.ToTable("Entrada");
                });

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

            modelBuilder.Entity("Api.Domain.Entities.PlanejamentoParceladoEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("MesReferenciaId")
                        .HasColumnType("char(36)");

                    b.Property<int>("ParcelaAtual")
                        .HasColumnType("int");

                    b.Property<int>("ParcelaTotal")
                        .HasColumnType("int");

                    b.Property<Guid>("PlanejamentoId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("PlanejamentosId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("Valor")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("MesReferenciaId");

                    b.HasIndex("PlanejamentosId");

                    b.ToTable("PlanejamentoParcelado");
                });

            modelBuilder.Entity("Api.Domain.Entities.PlanejamentosEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Parcelas")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("Valor")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("Planejamentos");
                });

            modelBuilder.Entity("Api.Domain.Entities.PoupancaEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Poupanca");
                });

            modelBuilder.Entity("Api.Domain.Entities.SaidaEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<Guid?>("EntradaId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("IsFixId")
                        .HasColumnType("char(36)");

                    b.Property<bool>("IsFixa")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsPago")
                        .HasColumnType("tinyint(1)");

                    b.Property<Guid>("MesReferenciaId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Parcelas")
                        .HasColumnType("int");

                    b.Property<double?>("Porcentagem")
                        .HasColumnType("double");

                    b.Property<Guid?>("PoupancaId")
                        .HasColumnType("char(36)");

                    b.Property<int>("TipoOperacaoSaida")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("Valor")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("MesReferenciaId");

                    b.HasIndex("PoupancaId");

                    b.ToTable("Saida");
                });

            modelBuilder.Entity("Api.Domain.Entities.EntradaEntity", b =>
                {
                    b.HasOne("Api.Domain.Entities.MesReferenciaEntity", "MesReferencia")
                        .WithMany("TransacoesEntrada")
                        .HasForeignKey("MesReferenciaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Api.Domain.Entities.PoupancaEntity", "Poupanca")
                        .WithMany("TransacoesEntrada")
                        .HasForeignKey("PoupancaId");
                });

            modelBuilder.Entity("Api.Domain.Entities.PlanejamentoParceladoEntity", b =>
                {
                    b.HasOne("Api.Domain.Entities.MesReferenciaEntity", "MesReferencia")
                        .WithMany("PlanejamentoParcelados")
                        .HasForeignKey("MesReferenciaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Api.Domain.Entities.PlanejamentosEntity", "Planejamentos")
                        .WithMany("PlanejamentoParcelados")
                        .HasForeignKey("PlanejamentosId");
                });

            modelBuilder.Entity("Api.Domain.Entities.SaidaEntity", b =>
                {
                    b.HasOne("Api.Domain.Entities.MesReferenciaEntity", "MesReferencia")
                        .WithMany("TransacoesSaida")
                        .HasForeignKey("MesReferenciaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Api.Domain.Entities.PoupancaEntity", "Poupanca")
                        .WithMany("TransacoesSaida")
                        .HasForeignKey("PoupancaId");
                });
#pragma warning restore 612, 618
        }
    }
}
