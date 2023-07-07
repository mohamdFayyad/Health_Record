﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UserManagment2.Data;

#nullable disable

namespace UserManagment2.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230707031709_AddHisDatabase")]
    partial class AddHisDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserClaim", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderKey")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("UserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("UserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens", (string)null);
                });

            modelBuilder.Entity("UserManagment2.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<byte[]>("ProfilePicture")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("UserManagment2.Models.Diagnosis", b =>
                {
                    b.Property<int>("DiagnosisId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("diagnosis_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DiagnosisId"));

                    b.Property<string>("Diagnosis1")
                        .HasMaxLength(4000)
                        .HasColumnType("nvarchar(4000)")
                        .HasColumnName("diagnosis");

                    b.Property<DateTime>("DiagnosisDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("diagnosis_date");

                    b.Property<string>("DiagnosisLocation")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("diagnosis_location");

                    b.Property<string>("DoctorDecision")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)")
                        .HasColumnName("doctor_decision");

                    b.Property<string>("Drugs")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("drugs");

                    b.Property<string>("Examiation")
                        .HasMaxLength(4000)
                        .HasColumnType("nvarchar(4000)")
                        .HasColumnName("examiation");

                    b.Property<string>("Tests")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("tests");

                    b.Property<int?>("VisitId")
                        .HasColumnType("int")
                        .HasColumnName("visit_id");

                    b.HasKey("DiagnosisId");

                    b.HasIndex("VisitId");

                    b.ToTable("diagnosis", (string)null);
                });

            modelBuilder.Entity("UserManagment2.Models.DiagnosisDrug", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("DiagnosisId")
                        .HasColumnType("int")
                        .HasColumnName("diagnosis_id");

                    b.Property<int?>("DrugId")
                        .HasColumnType("int")
                        .HasColumnName("drug_id");

                    b.HasKey("Id");

                    b.HasIndex("DiagnosisId");

                    b.ToTable("diagnosis_drugs", (string)null);
                });

            modelBuilder.Entity("UserManagment2.Models.DiagnosisTest", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int?>("DiagnosisId")
                        .HasColumnType("int")
                        .HasColumnName("diagnosis_id");

                    b.Property<int?>("TestId")
                        .HasColumnType("int")
                        .HasColumnName("test_id");

                    b.HasKey("Id");

                    b.HasIndex("DiagnosisId");

                    b.HasIndex("TestId");

                    b.ToTable("diagnosis_tests", (string)null);
                });

            modelBuilder.Entity("UserManagment2.Models.Drug", b =>
                {
                    b.Property<int>("DrugId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("drug_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DrugId"));

                    b.Property<string>("Concentration")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("concentration");

                    b.Property<string>("GenericName")
                        .HasMaxLength(300)
                        .IsUnicode(false)
                        .HasColumnType("varchar(300)")
                        .HasColumnName("generic_name");

                    b.Property<int>("TreatmentId")
                        .HasColumnType("int")
                        .HasColumnName("treatment_id");

                    b.Property<string>("Type")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("type");

                    b.HasKey("DrugId");

                    b.ToTable("drugs", (string)null);
                });

            modelBuilder.Entity("UserManagment2.Models.Patient", b =>
                {
                    b.Property<int>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("patient_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PatientId"));

                    b.Property<string>("NationalId")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("national_id");

                    b.Property<string>("PatientAddress")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("patient_address");

                    b.Property<int>("PatientAge")
                        .HasColumnType("int")
                        .HasColumnName("patient_age");

                    b.Property<string>("PatientName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("patient_name");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("phone_number");

                    b.Property<string>("Umn")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("umn");

                    b.HasKey("PatientId")
                        .HasName("PK_patient_1");

                    b.HasIndex(new[] { "PatientId" }, "UNQ_National_id")
                        .IsUnique();

                    b.HasIndex(new[] { "Umn" }, "UNQ_Patient_UMN")
                        .IsUnique();

                    b.ToTable("patient", (string)null);
                });

            modelBuilder.Entity("UserManagment2.Models.TestsXRay", b =>
                {
                    b.Property<int>("TestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("test_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TestId"));

                    b.Property<string>("Category")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("category");

                    b.Property<string>("TestName")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("test_name");

                    b.HasKey("TestId");

                    b.ToTable("tests_x-rays", (string)null);
                });

            modelBuilder.Entity("UserManagment2.Models.Visit", b =>
                {
                    b.Property<int>("VisitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("visit_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VisitId"));

                    b.Property<string>("CurrentLocation")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("current_location");

                    b.Property<DateTime>("EntryDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("entry_date");

                    b.Property<string>("EntryPlace")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("entry_place");

                    b.Property<int>("PatientId")
                        .HasColumnType("int")
                        .HasColumnName("patient_id");

                    b.Property<string>("PaymentType")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("payment_type");

                    b.Property<int?>("TicketNumber")
                        .HasColumnType("int")
                        .HasColumnName("ticket_number");

                    b.Property<string>("Umn")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("umn");

                    b.HasKey("VisitId");

                    b.HasIndex("PatientId");

                    b.ToTable("visits", (string)null);
                });

            modelBuilder.Entity("UserManagment2.Models.Diagnosis", b =>
                {
                    b.HasOne("UserManagment2.Models.Visit", "Visit")
                        .WithMany("Diagnoses")
                        .HasForeignKey("VisitId")
                        .HasConstraintName("FK_diagnosis_visits");

                    b.Navigation("Visit");
                });

            modelBuilder.Entity("UserManagment2.Models.DiagnosisDrug", b =>
                {
                    b.HasOne("UserManagment2.Models.Diagnosis", "Diagnosis")
                        .WithMany("DiagnosisDrugs")
                        .HasForeignKey("DiagnosisId")
                        .HasConstraintName("FK_diagnosisDrugs_diagnosis");

                    b.HasOne("UserManagment2.Models.Drug", "DiagnosisNavigation")
                        .WithMany("DiagnosisDrugs")
                        .HasForeignKey("DiagnosisId")
                        .HasConstraintName("FK_diagnosisDrugs_drugs");

                    b.Navigation("Diagnosis");

                    b.Navigation("DiagnosisNavigation");
                });

            modelBuilder.Entity("UserManagment2.Models.DiagnosisTest", b =>
                {
                    b.HasOne("UserManagment2.Models.Diagnosis", "Diagnosis")
                        .WithMany("DiagnosisTests")
                        .HasForeignKey("DiagnosisId")
                        .HasConstraintName("FK_diagnosisTests_diagnosis");

                    b.HasOne("UserManagment2.Models.TestsXRay", "Test")
                        .WithMany("DiagnosisTests")
                        .HasForeignKey("TestId")
                        .HasConstraintName("FK_diagnosisTests_tests_x-rays");

                    b.Navigation("Diagnosis");

                    b.Navigation("Test");
                });

            modelBuilder.Entity("UserManagment2.Models.Visit", b =>
                {
                    b.HasOne("UserManagment2.Models.Patient", "Patient")
                        .WithMany("Visits")
                        .HasForeignKey("PatientId")
                        .IsRequired()
                        .HasConstraintName("FK_visits_patient");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("UserManagment2.Models.Diagnosis", b =>
                {
                    b.Navigation("DiagnosisDrugs");

                    b.Navigation("DiagnosisTests");
                });

            modelBuilder.Entity("UserManagment2.Models.Drug", b =>
                {
                    b.Navigation("DiagnosisDrugs");
                });

            modelBuilder.Entity("UserManagment2.Models.Patient", b =>
                {
                    b.Navigation("Visits");
                });

            modelBuilder.Entity("UserManagment2.Models.TestsXRay", b =>
                {
                    b.Navigation("DiagnosisTests");
                });

            modelBuilder.Entity("UserManagment2.Models.Visit", b =>
                {
                    b.Navigation("Diagnoses");
                });
#pragma warning restore 612, 618
        }
    }
}