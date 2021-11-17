﻿// <auto-generated />
using System;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211117100723_init_migration")]
    partial class init_migration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataAccess.Models.Attachment", b =>
                {
                    b.Property<int>("AttachmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AttachmentPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TicketId")
                        .HasColumnType("int");

                    b.HasKey("AttachmentId");

                    b.HasIndex("TicketId");

                    b.ToTable("Attachment");
                });

            modelBuilder.Entity("DataAccess.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Courriel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustomerType")
                        .HasColumnType("int");

                    b.Property<string>("Mobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PosteOccupe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReferenceInterne")
                        .HasColumnType("int");

                    b.Property<string>("SiteWeb")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TVA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telephone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("DataAccess.Models.Module", b =>
                {
                    b.Property<int>("ModuleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ModuleGroup")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModuleNom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ModuleID");

                    b.ToTable("Module");
                });

            modelBuilder.Entity("DataAccess.Models.ModuleAction", b =>
                {
                    b.Property<int>("ModuleActionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Action")
                        .HasColumnType("int");

                    b.Property<string>("ModuleActionNom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ModuleID")
                        .HasColumnType("int");

                    b.Property<int>("Resource")
                        .HasColumnType("int");

                    b.HasKey("ModuleActionID");

                    b.HasIndex("ModuleID");

                    b.ToTable("ModuleAction");
                });

            modelBuilder.Entity("DataAccess.Models.ModuleActionRole", b =>
                {
                    b.Property<int>("ModuleActionRoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ModuleActionId")
                        .HasColumnType("int")
                        .HasColumnName("ModuleAction_ModuleActionID");

                    b.Property<int>("RoleId")
                        .HasColumnType("int")
                        .HasColumnName("Role_RoleID");

                    b.HasKey("ModuleActionRoleId");

                    b.HasIndex("ModuleActionId");

                    b.HasIndex("RoleId");

                    b.ToTable("ModuleActionRole");
                });

            modelBuilder.Entity("DataAccess.Models.Note", b =>
                {
                    b.Property<int>("NoteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TicketId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("NoteId");

                    b.HasIndex("TicketId");

                    b.HasIndex("UserId");

                    b.ToTable("Note");
                });

            modelBuilder.Entity("DataAccess.Models.Permission", b =>
                {
                    b.Property<int>("PermissionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("PermissionId");

                    b.HasIndex("RoleId");

                    b.ToTable("Permission");
                });

            modelBuilder.Entity("DataAccess.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("DataAccess.Models.Ticket", b =>
                {
                    b.Property<int>("TicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateDeResoudre")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Duree")
                        .HasColumnType("datetime2");

                    b.Property<int>("Priorite")
                        .HasColumnType("int");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<int>("TicketTypeId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("TicketId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("TicketTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("Ticket");
                });

            modelBuilder.Entity("DataAccess.Models.TicketType", b =>
                {
                    b.Property<int>("TicketTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TicketTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TicketTypeId");

                    b.ToTable("TicketType");
                });

            modelBuilder.Entity("DataAccess.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CommuneId")
                        .HasColumnType("int");

                    b.Property<int?>("RoleID")
                        .HasColumnType("int");

                    b.Property<int?>("ServiceID")
                        .HasColumnType("int");

                    b.Property<int?>("SpecialiteID")
                        .HasColumnType("int");

                    b.Property<string>("UserAdresse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UserDateNaiss")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserDescript")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserFax")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserMaxCapacity")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserNom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPrenom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserSpec")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserTelFixe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserTelMob")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("WilayaId")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("DataAccess.Models.Attachment", b =>
                {
                    b.HasOne("DataAccess.Models.Ticket", null)
                        .WithMany("Attachments")
                        .HasForeignKey("TicketId");
                });

            modelBuilder.Entity("DataAccess.Models.ModuleAction", b =>
                {
                    b.HasOne("DataAccess.Models.Module", "Module")
                        .WithMany("ModuleActions")
                        .HasForeignKey("ModuleID");

                    b.Navigation("Module");
                });

            modelBuilder.Entity("DataAccess.Models.ModuleActionRole", b =>
                {
                    b.HasOne("DataAccess.Models.ModuleAction", "ModuleAction")
                        .WithMany()
                        .HasForeignKey("ModuleActionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DataAccess.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ModuleAction");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("DataAccess.Models.Note", b =>
                {
                    b.HasOne("DataAccess.Models.Ticket", "Ticket")
                        .WithMany("Notes")
                        .HasForeignKey("TicketId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DataAccess.Models.User", "User")
                        .WithMany("Notes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Ticket");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DataAccess.Models.Permission", b =>
                {
                    b.HasOne("DataAccess.Models.Role", "Role")
                        .WithMany("Permissions")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("DataAccess.Models.Ticket", b =>
                {
                    b.HasOne("DataAccess.Models.Customer", "Customer")
                        .WithMany("Tickets")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DataAccess.Models.TicketType", "TicketType")
                        .WithMany("Tickets")
                        .HasForeignKey("TicketTypeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DataAccess.Models.User", "User")
                        .WithMany("Tickets")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("TicketType");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DataAccess.Models.Customer", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("DataAccess.Models.Module", b =>
                {
                    b.Navigation("ModuleActions");
                });

            modelBuilder.Entity("DataAccess.Models.Role", b =>
                {
                    b.Navigation("Permissions");
                });

            modelBuilder.Entity("DataAccess.Models.Ticket", b =>
                {
                    b.Navigation("Attachments");

                    b.Navigation("Notes");
                });

            modelBuilder.Entity("DataAccess.Models.TicketType", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("DataAccess.Models.User", b =>
                {
                    b.Navigation("Notes");

                    b.Navigation("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}