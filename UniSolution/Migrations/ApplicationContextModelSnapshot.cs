﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UniSolution.Models;

namespace UniSolution.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("UniSolution.Models.Tanque", b =>
                {
                    b.Property<string>("Deposito")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("Capacidade")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("TipoDeProduto")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Deposito");

                    b.ToTable("Tanque");
                });
#pragma warning restore 612, 618
        }
    }
}
