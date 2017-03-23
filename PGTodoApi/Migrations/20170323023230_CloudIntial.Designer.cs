using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using PGTodoApi.Model;

namespace PGTodoApi.Migrations
{
    [DbContext(typeof(TodoContext))]
    [Migration("20170323023230_CloudIntial")]
    partial class CloudIntial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasDefaultSchema("calendar")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752");

            modelBuilder.Entity("PGTodoApi.Model.TodoItem", b =>
                {
                    b.Property<long>("Key")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<DateTime>("CompletionDate");

                    b.Property<bool>("IsComplete");

                    b.Property<string>("Name");

                    b.Property<DateTime>("UpdatedTimestamp");

                    b.HasKey("Key");

                    b.ToTable("TodoItems");
                });
        }
    }
}
