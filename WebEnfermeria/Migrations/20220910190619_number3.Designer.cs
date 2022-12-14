// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebEnfermeria.AppDbContext;

#nullable disable

namespace WebEnfermeria.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220910190619_number3")]
    partial class number3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebEnfermeria.Entities.CompaniesRecord.CompanyRecordEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<long?>("CompanyIdId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("Egress")
                        .HasColumnType("Date");

                    b.Property<long?>("EmployeeEntityId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Income")
                        .HasColumnType("Date");

                    b.HasKey("Id");

                    b.HasIndex("CompanyIdId");

                    b.HasIndex("EmployeeEntityId");

                    b.ToTable("CompanyRecordEntities");
                });

            modelBuilder.Entity("WebEnfermeria.Entities.Company.CompanyEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("WebEnfermeria.Entities.Employee.EmployeeEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("CardNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Code")
                        .HasColumnType("int");

                    b.Property<long>("PersonIdId")
                        .HasColumnType("bigint");

                    b.Property<Guid?>("StatusId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PersonIdId");

                    b.HasIndex("StatusId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("WebEnfermeria.Entities.MedicalRecord.MedicalRecordEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("BloodGroup")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MedicalRecord");
                });

            modelBuilder.Entity("WebEnfermeria.Entities.Person.PersonEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Birday")
                        .HasColumnType("Date");

                    b.Property<string>("CUI")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone2")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("WebEnfermeria.Entities.Status.StatusEmployeeEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Status")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("StatusEmployees");
                });

            modelBuilder.Entity("WebEnfermeria.Entities.Status.StatusEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Status")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Status");
                });

            modelBuilder.Entity("WebEnfermeria.Entities.CompaniesRecord.CompanyRecordEntity", b =>
                {
                    b.HasOne("WebEnfermeria.Entities.Company.CompanyEntity", "CompanyId")
                        .WithMany()
                        .HasForeignKey("CompanyIdId");

                    b.HasOne("WebEnfermeria.Entities.Employee.EmployeeEntity", null)
                        .WithMany("CompaniesRecordId")
                        .HasForeignKey("EmployeeEntityId");

                    b.Navigation("CompanyId");
                });

            modelBuilder.Entity("WebEnfermeria.Entities.Employee.EmployeeEntity", b =>
                {
                    b.HasOne("WebEnfermeria.Entities.Person.PersonEntity", "PersonId")
                        .WithMany()
                        .HasForeignKey("PersonIdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebEnfermeria.Entities.Status.StatusEmployeeEntity", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId");

                    b.Navigation("PersonId");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("WebEnfermeria.Entities.Employee.EmployeeEntity", b =>
                {
                    b.Navigation("CompaniesRecordId");
                });
#pragma warning restore 612, 618
        }
    }
}
