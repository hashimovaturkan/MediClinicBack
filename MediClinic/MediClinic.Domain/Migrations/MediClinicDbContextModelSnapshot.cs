﻿// <auto-generated />
using System;
using MediClinic.Domain.Models.DataContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MediClinic.Domain.Migrations
{
    [DbContext(typeof(MediClinicDbContext))]
    partial class MediClinicDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MediClinic.Domain.Models.Entities.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CreatedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DoctorId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAccepted")
                        .HasColumnType("bit");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("MediClinic.Domain.Models.Entities.AuditLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Action")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Area")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Controller")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CreatedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsHttps")
                        .HasColumnType("bit");

                    b.Property<string>("Method")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QueryString")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RequestTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ResponseTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("StatusCode")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("AuditLogs");
                });

            modelBuilder.Entity("MediClinic.Domain.Models.Entities.BlogCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CreatedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OrderBy")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("BlogCategories");
                });

            modelBuilder.Entity("MediClinic.Domain.Models.Entities.BlogPost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BlogCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CreatedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<string>("ImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("PublishedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BlogCategoryId");

                    b.HasIndex("DoctorId");

                    b.ToTable("BlogPosts");
                });

            modelBuilder.Entity("MediClinic.Domain.Models.Entities.BlogPostComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BlogPostId")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CreatedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("MediClinicUserId")
                        .HasColumnType("int");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BlogPostId");

                    b.HasIndex("MediClinicUserId");

                    b.HasIndex("ParentId");

                    b.ToTable("BlogPostComments");
                });

            modelBuilder.Entity("MediClinic.Domain.Models.Entities.ContactPost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Answer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AnswerByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("AnswerDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CreatedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ContactPosts");
                });

            modelBuilder.Entity("MediClinic.Domain.Models.Entities.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CreatedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("MediClinic.Domain.Models.Entities.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AboutContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CreatedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Education")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Experience")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Room")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Specialty")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WorkTimeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WorkTimeId");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("MediClinic.Domain.Models.Entities.DoctorDepartmentRelation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CreatedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("DoctorId");

                    b.ToTable("DoctorDepartmentRelations");
                });

            modelBuilder.Entity("MediClinic.Domain.Models.Entities.Faq", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Answer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CreatedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Question")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Faqs");
                });

            modelBuilder.Entity("MediClinic.Domain.Models.Entities.Membership.MediClinicRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Roles", "Membership");
                });

            modelBuilder.Entity("MediClinic.Domain.Models.Entities.Membership.MediClinicRoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims", "Membership");
                });

            modelBuilder.Entity("MediClinic.Domain.Models.Entities.Membership.MediClinicUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("ImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("Users", "Membership");
                });

            modelBuilder.Entity("MediClinic.Domain.Models.Entities.Membership.MediClinicUserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims", "Membership");
                });

            modelBuilder.Entity("MediClinic.Domain.Models.Entities.Membership.MediClinicUserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins", "Membership");
                });

            modelBuilder.Entity("MediClinic.Domain.Models.Entities.Membership.MediClinicUserRole", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles", "Membership");
                });

            modelBuilder.Entity("MediClinic.Domain.Models.Entities.Membership.MediClinicUserToken", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens", "Membership");
                });

            modelBuilder.Entity("MediClinic.Domain.Models.Entities.SocialMedia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CreatedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.ToTable("SocialMedia");
                });

            modelBuilder.Entity("MediClinic.Domain.Models.Entities.Subscribe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CreatedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("EmailConfirmedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Subscribes");
                });

            modelBuilder.Entity("MediClinic.Domain.Models.Entities.WorkTime", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CreatedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndedTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("WorkTimes");
                });

            modelBuilder.Entity("MediClinic.Domain.Models.Entities.WorkTimeWeekDayRelation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CreatedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("WeekDay")
                        .HasColumnType("int");

                    b.Property<int>("WorkTimeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WorkTimeId");

                    b.ToTable("WorkTimeWeekDayRelations");
                });

            modelBuilder.Entity("MediClinic.Domain.Models.Entities.Appointment", b =>
                {
                    b.HasOne("MediClinic.Domain.Models.Entities.Doctor", "Doctor")
                        .WithMany("Appointments")
                        .HasForeignKey("DoctorId");

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("MediClinic.Domain.Models.Entities.BlogPost", b =>
                {
                    b.HasOne("MediClinic.Domain.Models.Entities.BlogCategory", "BlogCategory")
                        .WithMany("BlogPosts")
                        .HasForeignKey("BlogCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MediClinic.Domain.Models.Entities.Doctor", "Doctor")
                        .WithMany("BlogPosts")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BlogCategory");

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("MediClinic.Domain.Models.Entities.BlogPostComment", b =>
                {
                    b.HasOne("MediClinic.Domain.Models.Entities.BlogPost", "BlogPost")
                        .WithMany("Comments")
                        .HasForeignKey("BlogPostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MediClinic.Domain.Models.Entities.Membership.MediClinicUser", "MediClinicUser")
                        .WithMany()
                        .HasForeignKey("MediClinicUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MediClinic.Domain.Models.Entities.BlogPostComment", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentId");

                    b.Navigation("BlogPost");

                    b.Navigation("MediClinicUser");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("MediClinic.Domain.Models.Entities.Doctor", b =>
                {
                    b.HasOne("MediClinic.Domain.Models.Entities.WorkTime", "WorkTime")
                        .WithMany()
                        .HasForeignKey("WorkTimeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("WorkTime");
                });

            modelBuilder.Entity("MediClinic.Domain.Models.Entities.DoctorDepartmentRelation", b =>
                {
                    b.HasOne("MediClinic.Domain.Models.Entities.Department", "Department")
                        .WithMany("DoctorDepartmentRelation")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MediClinic.Domain.Models.Entities.Doctor", "Doctor")
                        .WithMany("DoctorDepartmentRelation")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("MediClinic.Domain.Models.Entities.Membership.MediClinicRoleClaim", b =>
                {
                    b.HasOne("MediClinic.Domain.Models.Entities.Membership.MediClinicRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MediClinic.Domain.Models.Entities.Membership.MediClinicUserClaim", b =>
                {
                    b.HasOne("MediClinic.Domain.Models.Entities.Membership.MediClinicUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MediClinic.Domain.Models.Entities.Membership.MediClinicUserLogin", b =>
                {
                    b.HasOne("MediClinic.Domain.Models.Entities.Membership.MediClinicUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MediClinic.Domain.Models.Entities.Membership.MediClinicUserRole", b =>
                {
                    b.HasOne("MediClinic.Domain.Models.Entities.Membership.MediClinicRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MediClinic.Domain.Models.Entities.Membership.MediClinicUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MediClinic.Domain.Models.Entities.Membership.MediClinicUserToken", b =>
                {
                    b.HasOne("MediClinic.Domain.Models.Entities.Membership.MediClinicUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MediClinic.Domain.Models.Entities.SocialMedia", b =>
                {
                    b.HasOne("MediClinic.Domain.Models.Entities.Doctor", "Doctor")
                        .WithMany("SocialMedia")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("MediClinic.Domain.Models.Entities.WorkTimeWeekDayRelation", b =>
                {
                    b.HasOne("MediClinic.Domain.Models.Entities.WorkTime", "WorkTime")
                        .WithMany("WorkTimeWeekDayRelation")
                        .HasForeignKey("WorkTimeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("WorkTime");
                });

            modelBuilder.Entity("MediClinic.Domain.Models.Entities.BlogCategory", b =>
                {
                    b.Navigation("BlogPosts");
                });

            modelBuilder.Entity("MediClinic.Domain.Models.Entities.BlogPost", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("MediClinic.Domain.Models.Entities.BlogPostComment", b =>
                {
                    b.Navigation("Children");
                });

            modelBuilder.Entity("MediClinic.Domain.Models.Entities.Department", b =>
                {
                    b.Navigation("DoctorDepartmentRelation");
                });

            modelBuilder.Entity("MediClinic.Domain.Models.Entities.Doctor", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("BlogPosts");

                    b.Navigation("DoctorDepartmentRelation");

                    b.Navigation("SocialMedia");
                });

            modelBuilder.Entity("MediClinic.Domain.Models.Entities.WorkTime", b =>
                {
                    b.Navigation("WorkTimeWeekDayRelation");
                });
#pragma warning restore 612, 618
        }
    }
}