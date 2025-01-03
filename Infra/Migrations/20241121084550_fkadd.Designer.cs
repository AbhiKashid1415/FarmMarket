﻿// <auto-generated />
using System;
using Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infra.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20241121084550_fkadd")]
    partial class fkadd
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Core.Admin", b =>
                {
                    b.Property<long>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("AdminId"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactPerson")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdminId");

                    b.ToTable("AdminTbl");

                    b.HasData(
                        new
                        {
                            AdminId = 1L,
                            EmailID = "pravinchavan@gmail.com",
                            FirstName = "Pravin",
                            LastName = "Chavan",
                            MobileNo = "98745635487",
                            Password = "abcd"
                        });
                });

            modelBuilder.Entity("Core.Cart", b =>
                {
                    b.Property<long>("CartID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("CartID"));

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<long>("ProductID")
                        .HasColumnType("bigint");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.Property<long>("UserID")
                        .HasColumnType("bigint");

                    b.HasKey("CartID");

                    b.HasIndex("ProductID");

                    b.HasIndex("UserID");

                    b.ToTable("CartTbl");
                });

            modelBuilder.Entity("Core.Category", b =>
                {
                    b.Property<long>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("CategoryID"));

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("MainCategoryID")
                        .HasColumnType("bigint");

                    b.Property<int>("PurchaseLimitInQty")
                        .HasColumnType("int");

                    b.HasKey("CategoryID");

                    b.HasIndex("MainCategoryID");

                    b.ToTable("CategoryTbl");
                });

            modelBuilder.Entity("Core.City", b =>
                {
                    b.Property<long>("CityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("CityID"));

                    b.Property<string>("CityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("StateID")
                        .HasColumnType("bigint");

                    b.HasKey("CityID");

                    b.HasIndex("StateID");

                    b.ToTable("CityTbl");

                    b.HasData(
                        new
                        {
                            CityID = 1L,
                            CityName = "Pune",
                            StateID = 1L
                        });
                });

            modelBuilder.Entity("Core.ComplaintRefund", b =>
                {
                    b.Property<long>("ComplaintRefundID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ComplaintRefundID"));

                    b.Property<int>("PaymentMode")
                        .HasColumnType("int");

                    b.Property<decimal>("RefundAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("ReundDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("UserOrderComplaintSolutionID")
                        .HasColumnType("bigint");

                    b.HasKey("ComplaintRefundID");

                    b.HasIndex("UserOrderComplaintSolutionID");

                    b.ToTable("ComplaintRefundTbl");
                });

            modelBuilder.Entity("Core.Country", b =>
                {
                    b.Property<long>("CountryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("CountryID"));

                    b.Property<string>("CountryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryID");

                    b.ToTable("CountryTbl");

                    b.HasData(
                        new
                        {
                            CountryID = 1L,
                            CountryName = "India"
                        });
                });

            modelBuilder.Entity("Core.DispatchAgency", b =>
                {
                    b.Property<long>("DispatchAgencyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("DispatchAgencyID"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AgencyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactPerson")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DispatchAgencyID");

                    b.ToTable("DispatchAgencyTbl");
                });

            modelBuilder.Entity("Core.MainCategory", b =>
                {
                    b.Property<long>("MainCategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("MainCategoryID"));

                    b.Property<string>("MainCategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MainCategoryID");

                    b.ToTable("MainCategoryTbl");
                });

            modelBuilder.Entity("Core.OrderDispatch", b =>
                {
                    b.Property<long>("OrderDispatchID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("OrderDispatchID"));

                    b.Property<long>("DispatchAgencyID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DispatchDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DocketNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ExpectedReachDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("UserOrderID")
                        .HasColumnType("bigint");

                    b.HasKey("OrderDispatchID");

                    b.HasIndex("DispatchAgencyID");

                    b.HasIndex("UserOrderID");

                    b.ToTable("OrderDispatchTbl");
                });

            modelBuilder.Entity("Core.Product", b =>
                {
                    b.Property<long>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ProductID"));

                    b.Property<long>("CategoryID")
                        .HasColumnType("bigint");

                    b.Property<string>("MainPhotoPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.Property<long>("TraderFarmerID")
                        .HasColumnType("bigint");

                    b.Property<long>("UnitID")
                        .HasColumnType("bigint");

                    b.HasKey("ProductID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("TraderFarmerID");

                    b.HasIndex("UnitID");

                    b.ToTable("ProductTbl");
                });

            modelBuilder.Entity("Core.ProductDiscount", b =>
                {
                    b.Property<long>("ProductDiscountID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ProductDiscountID"));

                    b.Property<decimal>("DiscountAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("DiscountName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsPercentile")
                        .HasColumnType("bit");

                    b.Property<long>("ProductID")
                        .HasColumnType("bigint");

                    b.HasKey("ProductDiscountID");

                    b.HasIndex("ProductID");

                    b.ToTable("ProductDiscountTbl");
                });

            modelBuilder.Entity("Core.ProductPhoto", b =>
                {
                    b.Property<long>("ProudctPhotoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ProudctPhotoID"));

                    b.Property<string>("PhotoPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("ProductID")
                        .HasColumnType("bigint");

                    b.HasKey("ProudctPhotoID");

                    b.HasIndex("ProductID");

                    b.ToTable("ProductPhotoTbl");
                });

            modelBuilder.Entity("Core.ProductReview", b =>
                {
                    b.Property<long>("ProductReviewID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ProductReviewID"));

                    b.Property<long>("ProductID")
                        .HasColumnType("bigint");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("ReviewDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("UserID")
                        .HasColumnType("bigint");

                    b.HasKey("ProductReviewID");

                    b.HasIndex("ProductID");

                    b.HasIndex("UserID");

                    b.ToTable("ProductReviewTbl");
                });

            modelBuilder.Entity("Core.State", b =>
                {
                    b.Property<long>("StateID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("StateID"));

                    b.Property<long>("CountryID")
                        .HasColumnType("bigint");

                    b.Property<string>("StateName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StateID");

                    b.HasIndex("CountryID");

                    b.ToTable("StateTbl");

                    b.HasData(
                        new
                        {
                            StateID = 1L,
                            CountryID = 1L,
                            StateName = "Maharashtra"
                        });
                });

            modelBuilder.Entity("Core.TraderFarmer", b =>
                {
                    b.Property<long>("TraderFarmerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("TraderFarmerID"));

                    b.Property<bool>("ActiveFlag")
                        .HasColumnType("bit");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("CityID")
                        .HasColumnType("bigint");

                    b.Property<string>("ContactPerson")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PinCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("TradeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TraderFarmerID");

                    b.HasIndex("CityID");

                    b.ToTable("TraderFarmerTbl");

                    b.HasData(
                        new
                        {
                            TraderFarmerID = 1L,
                            ActiveFlag = true,
                            Address = "Kolhapur",
                            CityID = 1L,
                            ContactPerson = "Minal",
                            EmailID = "rahul@gmail.com",
                            MobileNo = "9874587658",
                            Password = "acbd",
                            PinCode = "416209",
                            RegistrationDate = new DateTime(2024, 11, 21, 14, 15, 46, 888, DateTimeKind.Local).AddTicks(3008),
                            TradeName = "Rahul"
                        });
                });

            modelBuilder.Entity("Core.TraderFarmerTermsCondition", b =>
                {
                    b.Property<long>("TraderFarmerTermsConditionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("TraderFarmerTermsConditionID"));

                    b.Property<string>("TermsConditionDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TermsConditionTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TraderFarmerTermsConditionID");

                    b.ToTable("FarmerTermsConditionTbl");
                });

            modelBuilder.Entity("Core.Unit", b =>
                {
                    b.Property<long>("UnitID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("UnitID"));

                    b.Property<int>("QtyPerUnit")
                        .HasColumnType("int");

                    b.Property<string>("UnitName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UnitID");

                    b.ToTable("UnitTbl");
                });

            modelBuilder.Entity("Core.User", b =>
                {
                    b.Property<long>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("UserID"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("CityID")
                        .HasColumnType("bigint");

                    b.Property<string>("EmailId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Occupation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PinCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.HasIndex("CityID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Core.UserOrder", b =>
                {
                    b.Property<long>("UserOrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("UserOrderID"));

                    b.Property<bool>("IsPaid")
                        .HasColumnType("bit");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("TraderFarmerID")
                        .HasColumnType("bigint");

                    b.Property<long>("UserID")
                        .HasColumnType("bigint");

                    b.HasKey("UserOrderID");

                    b.HasIndex("TraderFarmerID");

                    b.HasIndex("UserID");

                    b.ToTable("UserOrderTbl");
                });

            modelBuilder.Entity("Core.UserOrderComplaint", b =>
                {
                    b.Property<long>("UserOrderComplaintID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("UserOrderComplaintID"));

                    b.Property<DateTime>("ComplaintDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ComplaintDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("UserOrderID")
                        .HasColumnType("bigint");

                    b.HasKey("UserOrderComplaintID");

                    b.HasIndex("UserOrderID");

                    b.ToTable("UserOrderComplaintTbl");
                });

            modelBuilder.Entity("Core.UserOrderComplaintSolution", b =>
                {
                    b.Property<long>("UserOrderComplaintSolutionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("UserOrderComplaintSolutionID"));

                    b.Property<DateTime>("SolutionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SolutionDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("UserOrderComplaintID")
                        .HasColumnType("bigint");

                    b.HasKey("UserOrderComplaintSolutionID");

                    b.HasIndex("UserOrderComplaintID");

                    b.ToTable("UserOrderComplaintSolutionTbl");
                });

            modelBuilder.Entity("Core.UserOrderDet", b =>
                {
                    b.Property<long>("UserOrderDetID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("UserOrderDetID"));

                    b.Property<decimal>("ActualDiscountAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("DiscountApplied")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("DiscountName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsPercentile")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<long>("ProductID")
                        .HasColumnType("bigint");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.Property<long>("UserOrderID")
                        .HasColumnType("bigint");

                    b.HasKey("UserOrderDetID");

                    b.HasIndex("ProductID");

                    b.HasIndex("UserOrderID");

                    b.ToTable("UserOrderDetTbl");
                });

            modelBuilder.Entity("Core.UserOrderPayment", b =>
                {
                    b.Property<long>("UserOrderPaymentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("UserOrderPaymentID"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PaymentMode")
                        .HasColumnType("int");

                    b.Property<long>("UserOrderID")
                        .HasColumnType("bigint");

                    b.HasKey("UserOrderPaymentID");

                    b.HasIndex("UserOrderID");

                    b.ToTable("UserOrderPaymentTbl");
                });

            modelBuilder.Entity("Core.UserTermsCondition", b =>
                {
                    b.Property<long>("UserTermsConditionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("UserTermsConditionID"));

                    b.Property<string>("TermsConditionDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TermsConditionTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserTermsConditionID");

                    b.ToTable("UserTermsConditionTbl");
                });

            modelBuilder.Entity("Core.WishList", b =>
                {
                    b.Property<long>("WishListID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("WishListID"));

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("ProductID")
                        .HasColumnType("bigint");

                    b.Property<long>("UserOrderID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("WishListDate")
                        .HasColumnType("datetime2");

                    b.HasKey("WishListID");

                    b.HasIndex("ProductID");

                    b.HasIndex("UserOrderID");

                    b.ToTable("WishListTbl");
                });

            modelBuilder.Entity("Core.Cart", b =>
                {
                    b.HasOne("Core.Product", "Product")
                        .WithMany("Carts")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Core.User", "User")
                        .WithMany("Carts")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Core.Category", b =>
                {
                    b.HasOne("Core.MainCategory", "MainCategory")
                        .WithMany("Categories")
                        .HasForeignKey("MainCategoryID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("MainCategory");
                });

            modelBuilder.Entity("Core.City", b =>
                {
                    b.HasOne("Core.State", "State")
                        .WithMany("Cities")
                        .HasForeignKey("StateID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("State");
                });

            modelBuilder.Entity("Core.ComplaintRefund", b =>
                {
                    b.HasOne("Core.UserOrderComplaintSolution", "UserOrderComplaintSolution")
                        .WithMany()
                        .HasForeignKey("UserOrderComplaintSolutionID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("UserOrderComplaintSolution");
                });

            modelBuilder.Entity("Core.OrderDispatch", b =>
                {
                    b.HasOne("Core.DispatchAgency", "DispatchAgency")
                        .WithMany("OrderDispatches")
                        .HasForeignKey("DispatchAgencyID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Core.UserOrder", "UserOrder")
                        .WithMany("OrderDispatches")
                        .HasForeignKey("UserOrderID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("DispatchAgency");

                    b.Navigation("UserOrder");
                });

            modelBuilder.Entity("Core.Product", b =>
                {
                    b.HasOne("Core.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Core.TraderFarmer", "TraderFarmer")
                        .WithMany("Products")
                        .HasForeignKey("TraderFarmerID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Core.Unit", "Unit")
                        .WithMany("Products")
                        .HasForeignKey("UnitID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("TraderFarmer");

                    b.Navigation("Unit");
                });

            modelBuilder.Entity("Core.ProductDiscount", b =>
                {
                    b.HasOne("Core.Product", "Product")
                        .WithMany("ProductDiscounts")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Core.ProductPhoto", b =>
                {
                    b.HasOne("Core.Product", "Product")
                        .WithMany("ProductPhotos")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Core.ProductReview", b =>
                {
                    b.HasOne("Core.Product", "Product")
                        .WithMany("ProductReviews")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Core.User", "User")
                        .WithMany("ProductReviews")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Core.State", b =>
                {
                    b.HasOne("Core.Country", "Country")
                        .WithMany("States")
                        .HasForeignKey("CountryID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Core.TraderFarmer", b =>
                {
                    b.HasOne("Core.City", "City")
                        .WithMany("TraderFarmers")
                        .HasForeignKey("CityID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("Core.User", b =>
                {
                    b.HasOne("Core.City", "City")
                        .WithMany("Users")
                        .HasForeignKey("CityID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("Core.UserOrder", b =>
                {
                    b.HasOne("Core.TraderFarmer", "TraderFarmer")
                        .WithMany("UserOrders")
                        .HasForeignKey("TraderFarmerID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Core.User", "User")
                        .WithMany("UserOrders")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("TraderFarmer");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Core.UserOrderComplaint", b =>
                {
                    b.HasOne("Core.UserOrder", "UserOrder")
                        .WithMany("UserOrderComplaints")
                        .HasForeignKey("UserOrderID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("UserOrder");
                });

            modelBuilder.Entity("Core.UserOrderComplaintSolution", b =>
                {
                    b.HasOne("Core.UserOrderComplaint", "UserOrderComplaint")
                        .WithMany("UserOrderComplaintSolutions")
                        .HasForeignKey("UserOrderComplaintID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("UserOrderComplaint");
                });

            modelBuilder.Entity("Core.UserOrderDet", b =>
                {
                    b.HasOne("Core.Product", "Product")
                        .WithMany("UserOrderDets")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Core.UserOrder", "UserOrder")
                        .WithMany("UserOrderDets")
                        .HasForeignKey("UserOrderID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("UserOrder");
                });

            modelBuilder.Entity("Core.UserOrderPayment", b =>
                {
                    b.HasOne("Core.UserOrder", "UserOrder")
                        .WithMany("UserOrderPayments")
                        .HasForeignKey("UserOrderID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("UserOrder");
                });

            modelBuilder.Entity("Core.WishList", b =>
                {
                    b.HasOne("Core.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Core.UserOrder", "UserOrder")
                        .WithMany()
                        .HasForeignKey("UserOrderID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("UserOrder");
                });

            modelBuilder.Entity("Core.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Core.City", b =>
                {
                    b.Navigation("TraderFarmers");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Core.Country", b =>
                {
                    b.Navigation("States");
                });

            modelBuilder.Entity("Core.DispatchAgency", b =>
                {
                    b.Navigation("OrderDispatches");
                });

            modelBuilder.Entity("Core.MainCategory", b =>
                {
                    b.Navigation("Categories");
                });

            modelBuilder.Entity("Core.Product", b =>
                {
                    b.Navigation("Carts");

                    b.Navigation("ProductDiscounts");

                    b.Navigation("ProductPhotos");

                    b.Navigation("ProductReviews");

                    b.Navigation("UserOrderDets");
                });

            modelBuilder.Entity("Core.State", b =>
                {
                    b.Navigation("Cities");
                });

            modelBuilder.Entity("Core.TraderFarmer", b =>
                {
                    b.Navigation("Products");

                    b.Navigation("UserOrders");
                });

            modelBuilder.Entity("Core.Unit", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Core.User", b =>
                {
                    b.Navigation("Carts");

                    b.Navigation("ProductReviews");

                    b.Navigation("UserOrders");
                });

            modelBuilder.Entity("Core.UserOrder", b =>
                {
                    b.Navigation("OrderDispatches");

                    b.Navigation("UserOrderComplaints");

                    b.Navigation("UserOrderDets");

                    b.Navigation("UserOrderPayments");
                });

            modelBuilder.Entity("Core.UserOrderComplaint", b =>
                {
                    b.Navigation("UserOrderComplaintSolutions");
                });
#pragma warning restore 612, 618
        }
    }
}
