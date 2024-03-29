﻿// <auto-generated />
using Client.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Client.Data.Migrations
{
    [DbContext(typeof(ClientEntities))]
    [Migration("20190819110522_111")]
    partial class _111
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Client.Model.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(500);

                    b.Property<string>("ClientEmail")
                        .HasMaxLength(500);

                    b.Property<string>("ClientName")
                        .HasMaxLength(500);

                    b.Property<string>("Mobile")
                        .HasMaxLength(50);

                    b.Property<string>("WebSite");

                    b.HasKey("ClientId");

                    b.ToTable("Client");
                });
#pragma warning restore 612, 618
        }
    }
}
