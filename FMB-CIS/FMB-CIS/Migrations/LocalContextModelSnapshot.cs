﻿// <auto-generated />
using System;
using FMB_CIS.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FMB_CIS.Migrations
{
    [DbContext(typeof(LocalContext))]
    partial class LocalContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FMB_CIS.Models.tbl_access_right", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("createdBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("date_created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("date_modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("is_active")
                        .HasColumnType("bit");

                    b.Property<int>("modifiedBy")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("parent_id")
                        .HasColumnType("int");

                    b.Property<string>("scope")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("tbl_access_right");
                });

            modelBuilder.Entity("FMB_CIS.Models.tbl_announcement", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("announcement_content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("announcement_subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("created_by")
                        .HasColumnType("int");

                    b.Property<DateTime>("date_created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("date_expiry")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("date_publish")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("date_published")
                        .HasColumnType("datetime2");

                    b.Property<bool>("is_active")
                        .HasColumnType("bit");

                    b.Property<int>("modified_by")
                        .HasColumnType("int");

                    b.Property<int>("tbl_announcement_type_id")
                        .HasColumnType("int");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("tbl_announcement");
                });

            modelBuilder.Entity("FMB_CIS.Models.tbl_announcement_type", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("created_by")
                        .HasColumnType("int");

                    b.Property<DateTime>("date_created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("date_modified")
                        .HasColumnType("datetime2");

                    b.Property<bool>("is_active")
                        .HasColumnType("bit");

                    b.Property<int>("modified_by")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("tbl_announcement_type");
                });

            modelBuilder.Entity("FMB_CIS.Models.tbl_application", b =>
                {
                    b.Property<int?>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("id"));

                    b.Property<bool?>("coordinatedWithEnforcementDivision")
                        .HasColumnType("bit");

                    b.Property<int?>("created_by")
                        .HasColumnType("int");

                    b.Property<DateTime?>("date_created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("date_due_for_officers")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("date_modified")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("date_of_expiration")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("date_of_inspection")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("date_of_registration")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("expected_time_arrival")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("expected_time_release")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("is_active")
                        .HasColumnType("bit");

                    b.Property<int?>("modified_by")
                        .HasColumnType("int");

                    b.Property<string>("origin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("others")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("purpose")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("qty")
                        .HasColumnType("int");

                    b.Property<int?>("status")
                        .HasColumnType("int");

                    b.Property<string>("supplier_address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("supplier_contact_no")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("supplier_email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("supplier_fname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("supplier_lname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("supplier_mname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("supplier_suffix")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("tbl_application_type_id")
                        .HasColumnType("int");

                    b.Property<int?>("tbl_permit_type_id")
                        .HasColumnType("int");

                    b.Property<string>("tbl_specification_id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("tbl_user_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("tbl_application");
                });

            modelBuilder.Entity("FMB_CIS.Models.tbl_application_type", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("tbl_application_type");
                });

            modelBuilder.Entity("FMB_CIS.Models.tbl_brgy", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("brgyCode")
                        .HasColumnType("int");

                    b.Property<int>("citymunCode")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("provCode")
                        .HasColumnType("int");

                    b.Property<int>("regCode")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("tbl_brgy");
                });

            modelBuilder.Entity("FMB_CIS.Models.tbl_chainsaw", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Engine")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Power")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("chainsaw_date_of_expiration")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("chainsaw_date_of_registration")
                        .HasColumnType("datetime2");

                    b.Property<string>("chainsaw_serial_number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("created_by")
                        .HasColumnType("int");

                    b.Property<DateTime?>("date_created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("date_modified")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("date_purchase")
                        .HasColumnType("datetime2");

                    b.Property<string>("gb")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("hp")
                        .HasColumnType("int");

                    b.Property<bool?>("is_active")
                        .HasColumnType("bit");

                    b.Property<int?>("modified_by")
                        .HasColumnType("int");

                    b.Property<string>("status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("supplier")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.Property<int?>("watt")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("tbl_chainsaw");
                });

            modelBuilder.Entity("FMB_CIS.Models.tbl_city", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("citymunCode")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("provCode")
                        .HasColumnType("int");

                    b.Property<int>("psgcCode")
                        .HasColumnType("int");

                    b.Property<int>("regCode")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("tbl_city");
                });

            modelBuilder.Entity("FMB_CIS.Models.tbl_comments", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("comment_to")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("created_by")
                        .HasColumnType("int");

                    b.Property<DateTime>("date_created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("date_modified")
                        .HasColumnType("datetime2");

                    b.Property<int>("modified_by")
                        .HasColumnType("int");

                    b.Property<int>("tbl_application_id")
                        .HasColumnType("int");

                    b.Property<int>("tbl_files_id")
                        .HasColumnType("int");

                    b.Property<int>("tbl_user_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("tbl_comments");
                });

            modelBuilder.Entity("FMB_CIS.Models.tbl_division", b =>
                {
                    b.Property<int?>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("id"));

                    b.Property<string>("company_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("created_by")
                        .HasColumnType("int");

                    b.Property<DateTime?>("date_created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("date_modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("is_active")
                        .HasColumnType("bit");

                    b.Property<int?>("modified_by")
                        .HasColumnType("int");

                    b.Property<string>("office_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("province_id")
                        .HasColumnType("int");

                    b.Property<int?>("region_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("tbl_division");
                });

            modelBuilder.Entity("FMB_CIS.Models.tbl_email_template", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("created_by")
                        .HasColumnType("int");

                    b.Property<DateTime>("date_created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("date_modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("email_content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email_subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("is_active")
                        .HasColumnType("bit");

                    b.Property<int>("modified_by")
                        .HasColumnType("int");

                    b.Property<string>("template_description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("template_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("tbl_email_template");
                });

            modelBuilder.Entity("FMB_CIS.Models.tbl_files", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("created_by")
                        .HasColumnType("int");

                    b.Property<DateTime>("date_created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("date_modified")
                        .HasColumnType("datetime2");

                    b.Property<int>("file_size")
                        .HasColumnType("int");

                    b.Property<string>("filename")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("is_active")
                        .HasColumnType("bit");

                    b.Property<bool?>("is_proof_of_payment")
                        .HasColumnType("bit");

                    b.Property<int>("modified_by")
                        .HasColumnType("int");

                    b.Property<string>("path")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("tbl_application_id")
                        .HasColumnType("int");

                    b.Property<string>("tbl_file_sources_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tbl_file_type_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("tbl_user_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("tbl_files");
                });

            modelBuilder.Entity("FMB_CIS.Models.tbl_office_type", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("createdBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("date_created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("date_modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("is_active")
                        .HasColumnType("bit");

                    b.Property<int>("modifiedBy")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("tbl_office_type");
                });

            modelBuilder.Entity("FMB_CIS.Models.tbl_permit_status", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("application_type")
                        .HasColumnType("int");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("tbl_permit_status");
                });

            modelBuilder.Entity("FMB_CIS.Models.tbl_permit_type", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("tbl_permit_type");
                });

            modelBuilder.Entity("FMB_CIS.Models.tbl_province", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("provCode")
                        .HasColumnType("int");

                    b.Property<int>("psgcCode")
                        .HasColumnType("int");

                    b.Property<int>("regCode")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("tbl_province");
                });

            modelBuilder.Entity("FMB_CIS.Models.tbl_region", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("psgcCode")
                        .HasColumnType("int");

                    b.Property<int>("regCode")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("tbl_region");
                });

            modelBuilder.Entity("FMB_CIS.Models.tbl_site_settings", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("scope")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("tbl_site_settings");
                });

            modelBuilder.Entity("FMB_CIS.Models.tbl_user", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("birth_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("company_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contact_no")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("date_created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("date_modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("first_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("is_active")
                        .HasColumnType("bit");

                    b.Property<string>("last_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("middle_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("status")
                        .HasColumnType("bit");

                    b.Property<string>("street_address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("suffix")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("tbl_brgy_id")
                        .HasColumnType("int");

                    b.Property<int>("tbl_city_id")
                        .HasColumnType("int");

                    b.Property<string>("tbl_division_id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("tbl_province_id")
                        .HasColumnType("int");

                    b.Property<int>("tbl_region_id")
                        .HasColumnType("int");

                    b.Property<int>("tbl_user_types_id")
                        .HasColumnType("int");

                    b.Property<string>("user_classification")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("valid_id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("valid_id_no")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("tbl_user");
                });

            modelBuilder.Entity("FMB_CIS.Models.tbl_user_change_info_request", b =>
                {
                    b.Property<int?>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("id"));

                    b.Property<DateTime?>("birth_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("company_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contact_no")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("created_by")
                        .HasColumnType("int");

                    b.Property<DateTime?>("date_created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("date_modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("first_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("last_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("middle_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("modified_by")
                        .HasColumnType("int");

                    b.Property<string>("street_address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("suffix")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("tbl_brgy_id")
                        .HasColumnType("int");

                    b.Property<int?>("tbl_city_id")
                        .HasColumnType("int");

                    b.Property<int?>("tbl_province_id")
                        .HasColumnType("int");

                    b.Property<int?>("tbl_region_id")
                        .HasColumnType("int");

                    b.Property<int?>("tbl_user_change_info_request_status_id")
                        .HasColumnType("int");

                    b.Property<int?>("tbl_user_id")
                        .HasColumnType("int");

                    b.Property<int?>("tbl_user_types_id")
                        .HasColumnType("int");

                    b.Property<string>("ticket_no")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("user_classification")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("valid_id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("valid_id_no")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("tbl_user_change_info_request");
                });

            modelBuilder.Entity("FMB_CIS.Models.tbl_user_change_info_request_status", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int?>("created_by")
                        .HasColumnType("int");

                    b.Property<int?>("date_created")
                        .HasColumnType("int");

                    b.Property<int?>("date_modified")
                        .HasColumnType("int");

                    b.Property<bool?>("is_active")
                        .HasColumnType("bit");

                    b.Property<int?>("modified_by")
                        .HasColumnType("int");

                    b.Property<string>("status_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("tbl_user_change_info_request_status");
                });

            modelBuilder.Entity("FMB_CIS.Models.tbl_user_temp_passwords", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime?>("date_created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("date_modified")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("is_active")
                        .HasColumnType("bit");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("password_expiry")
                        .HasColumnType("datetime2");

                    b.Property<int?>("tbl_user_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("tbl_user_temp_passwords");
                });

            modelBuilder.Entity("FMB_CIS.Models.tbl_user_type_access_right", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("access_right_id")
                        .HasColumnType("int");

                    b.Property<int?>("created_by")
                        .HasColumnType("int");

                    b.Property<DateTime?>("date_created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("date_modified")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("is_active")
                        .HasColumnType("bit");

                    b.Property<int?>("modified_by")
                        .HasColumnType("int");

                    b.Property<int>("user_type_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("tbl_user_type_access_right");
                });

            modelBuilder.Entity("FMB_CIS.Models.tbl_user_types", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("tbl_user_types");
                });
#pragma warning restore 612, 618
        }
    }
}
