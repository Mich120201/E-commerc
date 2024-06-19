﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ecommerce.Database.DBContext;

#nullable disable

namespace ecommerce.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("ecommerce.Models.Option.Models.Option", b =>
                {
                    b.Property<Guid>("OptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("OptionGroupId")
                        .HasColumnType("char(36)");

                    b.Property<string>("OptionName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("OptionId");

                    b.HasIndex("OptionGroupId");

                    b.ToTable("Options");
                });

            modelBuilder.Entity("ecommerce.Models.Option.Models.OptionGroup", b =>
                {
                    b.Property<Guid>("OptionGroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("OptionGroupName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("OptionGroupId");

                    b.ToTable("OptionsGroups");
                });

            modelBuilder.Entity("ecommerce.Models.Option.Models.ProductOption", b =>
                {
                    b.Property<Guid>("ProductOptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("OptionGroupId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("OptionId")
                        .HasColumnType("char(36)");

                    b.Property<double>("OptionPriceIncrement")
                        .HasColumnType("double");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("char(36)");

                    b.HasKey("ProductOptionId");

                    b.HasIndex("OptionId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductOptions");
                });

            modelBuilder.Entity("ecommerce.Models.Order.Models.Order", b =>
                {
                    b.Property<Guid>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<float>("OrderAmount")
                        .HasColumnType("float");

                    b.Property<string>("OrderCity")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("OrderCountry")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("OrderEmail")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("OrderFax")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("OrderPhone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("OrderShipAddress")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("OrderShipAddress2")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("OrderShipName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<byte>("OrderShipped")
                        .HasColumnType("tinyint unsigned");

                    b.Property<float>("OrderShipping")
                        .HasColumnType("float");

                    b.Property<string>("OrderState")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<float>("OrderTax")
                        .HasColumnType("float");

                    b.Property<string>("OrderTrackingNumber")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<string>("OrderZip")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("OrderId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ecommerce.Models.Order.Models.OrderDetail", b =>
                {
                    b.Property<Guid>("DetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("DetailName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)");

                    b.Property<float>("DetailPrice")
                        .HasColumnType("float");

                    b.Property<uint>("DetailQuantity")
                        .HasColumnType("int unsigned");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("char(36)");

                    b.HasKey("DetailId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("ecommerce.Models.Product.Models.Product", b =>
                {
                    b.Property<Guid>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("ProductDescription")
                        .HasMaxLength(5000)
                        .HasColumnType("varchar(5000)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<float>("ProductSizeX")
                        .HasColumnType("float");

                    b.Property<float>("ProductSizeY")
                        .HasColumnType("float");

                    b.Property<float>("ProductSizeZ")
                        .HasColumnType("float");

                    b.Property<uint>("ProductStock")
                        .HasColumnType("int unsigned");

                    b.Property<float>("ProductTotalPrice")
                        .HasColumnType("float");

                    b.Property<float>("ProductWeight")
                        .HasColumnType("float");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("ProductId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ecommerce.Models.Product.Models.ThumbImage", b =>
                {
                    b.Property<Guid>("ThumbImagesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("char(36)");

                    b.Property<string>("ThumbImageLink")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("ThumbImagesId");

                    b.HasIndex("ProductId");

                    b.ToTable("Thumbs");
                });

            modelBuilder.Entity("ecommerce.Models.User.Models.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("UserAddress1")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("UserAddress2")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("UserCity")
                        .HasMaxLength(90)
                        .HasColumnType("varchar(90)");

                    b.Property<string>("UserCountry")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<byte>("UserEmailVerified")
                        .HasColumnType("tinyint unsigned");

                    b.Property<string>("UserFirstName")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("UserIP")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("UserLastName")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<string>("UserPhone")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("UserRegistrationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("UserState")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("UserVerificationCode")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("UserZip")
                        .HasMaxLength(12)
                        .HasColumnType("varchar(12)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ecommerce.Models.Option.Models.Option", b =>
                {
                    b.HasOne("ecommerce.Models.Option.Models.OptionGroup", "OptionGroup")
                        .WithMany("Options")
                        .HasForeignKey("OptionGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OptionGroup");
                });

            modelBuilder.Entity("ecommerce.Models.Option.Models.ProductOption", b =>
                {
                    b.HasOne("ecommerce.Models.Option.Models.Option", "Option")
                        .WithMany("ProductOptions")
                        .HasForeignKey("OptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ecommerce.Models.Product.Models.Product", "Product")
                        .WithMany("ProductOption")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Option");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ecommerce.Models.Order.Models.Order", b =>
                {
                    b.HasOne("ecommerce.Models.User.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ecommerce.Models.Order.Models.OrderDetail", b =>
                {
                    b.HasOne("ecommerce.Models.Order.Models.Order", "Order")
                        .WithMany("OrderDetail")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ecommerce.Models.Product.Models.Product", "Product")
                        .WithMany("OrderDetail")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ecommerce.Models.Product.Models.ThumbImage", b =>
                {
                    b.HasOne("ecommerce.Models.Product.Models.Product", "Product")
                        .WithMany("ThumbImages")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ecommerce.Models.Option.Models.Option", b =>
                {
                    b.Navigation("ProductOptions");
                });

            modelBuilder.Entity("ecommerce.Models.Option.Models.OptionGroup", b =>
                {
                    b.Navigation("Options");
                });

            modelBuilder.Entity("ecommerce.Models.Order.Models.Order", b =>
                {
                    b.Navigation("OrderDetail");
                });

            modelBuilder.Entity("ecommerce.Models.Product.Models.Product", b =>
                {
                    b.Navigation("OrderDetail");

                    b.Navigation("ProductOption");

                    b.Navigation("ThumbImages");
                });

            modelBuilder.Entity("ecommerce.Models.User.Models.User", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
