﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProConvenios.Persistence;
using ProConvenios.Persistence.Contexto;


namespace ProConvenios.Persistence.Migrations
{
    [DbContext(typeof(ProConveniosContext))]
    [Migration("20210308055330_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("ProConvenios.Domain.Convenio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DtFim")
                        .HasColumnType("TEXT");

                    b.Property<string>("DtInicio")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("LinkRedmine")
                        .HasColumnType("TEXT");

                    b.Property<string>("ObjetoAcordo")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProcessoTCE")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefone")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Convenios");
                });
#pragma warning restore 612, 618
        }
    }
}
