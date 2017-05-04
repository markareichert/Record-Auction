using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using RecordAuction.Data;

namespace RecordAuction.Migrations
{
    [DbContext(typeof(RecordDbContext))]
    [Migration("20170504030627_RecordAuction")]
    partial class RecordAuction
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RecordAuction.Models.Record", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Artist");

                    b.Property<int>("ConditionID");

                    b.Property<string>("Label");

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
