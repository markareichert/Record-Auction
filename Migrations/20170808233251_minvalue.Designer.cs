using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using RecordAuction.Data;

namespace RecordAuction.Migrations
{
    [DbContext(typeof(RecordDbContext))]
    [Migration("20170808233251_minvalue")]
    partial class minvalue
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RecordAuction.Models.Customer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address1");

                    b.Property<string>("Address2");

                    b.Property<string>("Address3");

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("State");

                    b.Property<string>("ZIPCode");

                    b.HasKey("ID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("RecordAuction.Models.Record", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Artist");

                    b.Property<int>("ConditionID");

                    b.Property<string>("Label");

                    b.Property<decimal>("MinValue");

                    b.Property<string>("Notes");

                    b.Property<int>("RecordNumber");

                    b.Property<string>("SideA");

                    b.Property<string>("SideB");

                    b.HasKey("ID");

                    b.HasIndex("ConditionID");

                    b.ToTable("Records");
                });

            modelBuilder.Entity("RecordAuction.Models.RecordCondition", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("RecordConditions");
                });

            modelBuilder.Entity("RecordAuction.Models.Record", b =>
                {
                    b.HasOne("RecordAuction.Models.RecordCondition", "Condition")
                        .WithMany()
                        .HasForeignKey("ConditionID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
