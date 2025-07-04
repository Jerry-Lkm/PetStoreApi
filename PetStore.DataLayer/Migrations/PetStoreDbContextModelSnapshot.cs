﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PetStore.DataLayer;

#nullable disable

namespace PetStore.DataLayer.Migrations
{
    [DbContext(typeof(PetStoreDbContext))]
    partial class PetStoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PetStore.DataLayer.DataContext.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Complete")
                        .HasColumnType("bit")
                        .HasColumnName("complete");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2")
                        .HasColumnName("created");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("createdby");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2")
                        .HasColumnName("deleted");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("deletedBy");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("isdeleted");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2")
                        .HasColumnName("modified");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("modifiedby");

                    b.Property<int>("PetId")
                        .HasColumnType("int")
                        .HasColumnName("petId");

                    b.Property<int>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("quantity");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<DateTime>("ShipDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("shipDate");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasColumnName("status");

                    b.HasKey("Id");

                    b.HasIndex("PetId");

                    b.HasIndex("Status");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("PetStore.DataLayer.DataContext.OrderStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2")
                        .HasColumnName("created");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("createdby");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2")
                        .HasColumnName("deleted");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("deletedBy");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("isdeleted");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2")
                        .HasColumnName("modified");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("modifiedby");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("OrderStatus");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "system",
                            IsDeleted = false,
                            Name = "Placed"
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "system",
                            IsDeleted = false,
                            Name = "Processing"
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "system",
                            IsDeleted = false,
                            Name = "Shipped"
                        });
                });

            modelBuilder.Entity("PetStore.DataLayer.DataContext.Pet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Category")
                        .HasColumnType("int")
                        .HasColumnName("category");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2")
                        .HasColumnName("created");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("createdby");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2")
                        .HasColumnName("deleted");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("deletedBy");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("isdeleted");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2")
                        .HasColumnName("modified");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("modifiedby");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasColumnName("status");

                    b.Property<string>("Tags")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("tags");

                    b.HasKey("Id");

                    b.HasIndex("Category");

                    b.HasIndex("Status");

                    b.ToTable("Pet");
                });

            modelBuilder.Entity("PetStore.DataLayer.DataContext.PetCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2")
                        .HasColumnName("created");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("createdby");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2")
                        .HasColumnName("deleted");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("deletedBy");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("isdeleted");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2")
                        .HasColumnName("modified");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("modifiedby");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("PetCategory");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "system",
                            IsDeleted = false,
                            Name = "Dog"
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "system",
                            IsDeleted = false,
                            Name = "Cat"
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "system",
                            IsDeleted = false,
                            Name = "Bunny"
                        });
                });

            modelBuilder.Entity("PetStore.DataLayer.DataContext.PetStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2")
                        .HasColumnName("created");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("createdby");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2")
                        .HasColumnName("deleted");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("deletedBy");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("isdeleted");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2")
                        .HasColumnName("modified");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("modifiedby");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("PetStatus");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "system",
                            IsDeleted = false,
                            Name = "Available"
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "system",
                            IsDeleted = false,
                            Name = "Pending"
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "system",
                            IsDeleted = false,
                            Name = "Sold"
                        });
                });

            modelBuilder.Entity("PetStore.DataLayer.DataContext.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2")
                        .HasColumnName("created");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("createdby");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2")
                        .HasColumnName("deleted");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("deletedBy");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("firstName");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("isdeleted");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("lastName");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2")
                        .HasColumnName("modified");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("modifiedby");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("passwordHash");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("phone");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("salt");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasColumnName("status");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("userName");

                    b.HasKey("Id");

                    b.HasIndex("Status");

                    b.ToTable("User");
                });

            modelBuilder.Entity("PetStore.DataLayer.DataContext.UserStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2")
                        .HasColumnName("created");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("createdby");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2")
                        .HasColumnName("deleted");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("deletedBy");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("isdeleted");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2")
                        .HasColumnName("modified");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("modifiedby");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("UserStatus");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "system",
                            IsDeleted = false,
                            Name = "Active"
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "system",
                            IsDeleted = false,
                            Name = "Inactive"
                        });
                });

            modelBuilder.Entity("PetStore.DataLayer.DataContext.Order", b =>
                {
                    b.HasOne("PetStore.DataLayer.DataContext.Pet", "Pet")
                        .WithMany("Orders")
                        .HasForeignKey("PetId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("PetStore.DataLayer.DataContext.OrderStatus", "OrderStatus")
                        .WithMany("Orders")
                        .HasForeignKey("Status")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("OrderStatus");

                    b.Navigation("Pet");
                });

            modelBuilder.Entity("PetStore.DataLayer.DataContext.Pet", b =>
                {
                    b.HasOne("PetStore.DataLayer.DataContext.PetCategory", "PetCategory")
                        .WithMany("Pets")
                        .HasForeignKey("Category")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("PetStore.DataLayer.DataContext.PetStatus", "PetStatus")
                        .WithMany("Pets")
                        .HasForeignKey("Status")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("PetCategory");

                    b.Navigation("PetStatus");
                });

            modelBuilder.Entity("PetStore.DataLayer.DataContext.User", b =>
                {
                    b.HasOne("PetStore.DataLayer.DataContext.UserStatus", "UserStatus")
                        .WithMany("Users")
                        .HasForeignKey("Status")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("UserStatus");
                });

            modelBuilder.Entity("PetStore.DataLayer.DataContext.OrderStatus", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("PetStore.DataLayer.DataContext.Pet", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("PetStore.DataLayer.DataContext.PetCategory", b =>
                {
                    b.Navigation("Pets");
                });

            modelBuilder.Entity("PetStore.DataLayer.DataContext.PetStatus", b =>
                {
                    b.Navigation("Pets");
                });

            modelBuilder.Entity("PetStore.DataLayer.DataContext.UserStatus", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
