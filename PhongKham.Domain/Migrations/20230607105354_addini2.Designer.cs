﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PhongKham.Infrastructure.Data.Context;

namespace PhongKham.Infrastructure.Migrations
{
    [DbContext(typeof(PhongKhamDbContext))]
    [Migration("20230607105354_addini2")]
    partial class addini2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PhongKham.Core.Entities.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DoctorId")
                        .HasColumnType("int");

                    b.Property<int?>("PatientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("appDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("appNote")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("appType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("PhongKham.Core.Entities.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SpecializeId")
                        .HasColumnType("int");

                    b.Property<string>("docName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SpecializeId");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("PhongKham.Core.Entities.Invoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AppointmentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("InDatetime")
                        .HasColumnType("datetime2");

                    b.Property<string>("InNote")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AppointmentId")
                        .IsUnique()
                        .HasFilter("[AppointmentId] IS NOT NULL");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("PhongKham.Core.Entities.Medicine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("InvoiceId")
                        .HasColumnType("int");

                    b.Property<int>("SpecializeId")
                        .HasColumnType("int");

                    b.Property<string>("medName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("medOutdate")
                        .HasColumnType("datetime2");

                    b.Property<double>("medPrice")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("InvoiceId");

                    b.HasIndex("SpecializeId");

                    b.ToTable("Medicines");
                });

            modelBuilder.Entity("PhongKham.Core.Entities.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("patAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("patBirthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("patName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("patPhone")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("PhongKham.Core.Entities.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("InvoiceId")
                        .HasColumnType("int");

                    b.Property<int?>("PatientId")
                        .HasColumnType("int");

                    b.Property<int>("PaymentMethod")
                        .HasColumnType("int");

                    b.Property<double>("payAmount")
                        .HasColumnType("float");

                    b.Property<DateTime>("payDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("InvoiceId")
                        .IsUnique();

                    b.HasIndex("PatientId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("PhongKham.Core.Entities.Specialize", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("specName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Specializes");
                });

            modelBuilder.Entity("PhongKham.Core.Entities.Appointment", b =>
                {
                    b.HasOne("PhongKham.Core.Entities.Doctor", "Doctor")
                        .WithMany("Appointments")
                        .HasForeignKey("DoctorId");

                    b.HasOne("PhongKham.Core.Entities.Patient", "Patient")
                        .WithMany("Appointments")
                        .HasForeignKey("PatientId");

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("PhongKham.Core.Entities.Doctor", b =>
                {
                    b.HasOne("PhongKham.Core.Entities.Specialize", "Specialize")
                        .WithMany()
                        .HasForeignKey("SpecializeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Specialize");
                });

            modelBuilder.Entity("PhongKham.Core.Entities.Invoice", b =>
                {
                    b.HasOne("PhongKham.Core.Entities.Appointment", "Appointment")
                        .WithOne("Invoice")
                        .HasForeignKey("PhongKham.Core.Entities.Invoice", "AppointmentId");

                    b.Navigation("Appointment");
                });

            modelBuilder.Entity("PhongKham.Core.Entities.Medicine", b =>
                {
                    b.HasOne("PhongKham.Core.Entities.Invoice", null)
                        .WithMany("Medicines")
                        .HasForeignKey("InvoiceId");

                    b.HasOne("PhongKham.Core.Entities.Specialize", "Specialize")
                        .WithMany("Medicines")
                        .HasForeignKey("SpecializeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Specialize");
                });

            modelBuilder.Entity("PhongKham.Core.Entities.Payment", b =>
                {
                    b.HasOne("PhongKham.Core.Entities.Invoice", "Invoice")
                        .WithOne("Payment")
                        .HasForeignKey("PhongKham.Core.Entities.Payment", "InvoiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PhongKham.Core.Entities.Patient", "Patient")
                        .WithMany("Payments")
                        .HasForeignKey("PatientId");

                    b.Navigation("Invoice");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("PhongKham.Core.Entities.Appointment", b =>
                {
                    b.Navigation("Invoice");
                });

            modelBuilder.Entity("PhongKham.Core.Entities.Doctor", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("PhongKham.Core.Entities.Invoice", b =>
                {
                    b.Navigation("Medicines");

                    b.Navigation("Payment");
                });

            modelBuilder.Entity("PhongKham.Core.Entities.Patient", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Payments");
                });

            modelBuilder.Entity("PhongKham.Core.Entities.Specialize", b =>
                {
                    b.Navigation("Medicines");
                });
#pragma warning restore 612, 618
        }
    }
}
