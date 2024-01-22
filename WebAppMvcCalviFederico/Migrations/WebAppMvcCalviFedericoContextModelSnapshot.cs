﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAppMvcCalviFederico.Data;

#nullable disable

namespace WebAppMvcCalviFederico.Migrations
{
    [DbContext(typeof(WebAppMvcCalviFedericoContext))]
    partial class WebAppMvcCalviFedericoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebAppMvcCalviFederico.Models.Anagrafica", b =>
                {
                    b.Property<string>("CodFiscale")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Cap")
                        .HasColumnType("int");

                    b.Property<string>("Citta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cognome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataNascita")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumCivico")
                        .HasColumnType("int");

                    b.Property<string>("Provincia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Social")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telefono")
                        .HasColumnType("int");

                    b.Property<string>("Via")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CodFiscale");

                    b.ToTable("Anagrafica");
                });
#pragma warning restore 612, 618
        }
    }
}