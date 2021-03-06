﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaskListWebAPI.Db;

namespace TaskListWebAPI.Migrations
{
    [DbContext(typeof(TaskDbContext))]
    [Migration("20190505191604_TaskItems")]
    partial class TaskItems
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TaskListWebAPI.Model.TaskItem", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("done");

                    b.Property<string>("name")
                        .HasMaxLength(50);

                    b.Property<string>("nescription");

                    b.HasKey("id");

                    b.ToTable("TaskItems");
                });
#pragma warning restore 612, 618
        }
    }
}
