using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using DogeNetCore.DataAccess.lib.implementations.EntityFramework.UserRepository.Entities;

namespace DogeNetCore.DataAccess.lib.implementations.EntityFramework.ClipRepository.Migrations
{
    [DbContext(typeof(UserContext))]
    [Migration("20161007150915_InitialMigration")]
    public partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DogeCore.Entities.Clips.Clip", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<string>("Name")
                    .IsRequired()
                    .HasAnnotation("MaxLength", 24);

                b.Property<string>("Uri")
                    .IsRequired();

                b.Property<string>("SourceType")
                    .IsRequired();

                b.Property<int>("StartTime");

                b.Property<int>("EndTime");

                b.Property<string>("Description");

                b.HasKey("Id");
                b.HasAlternateKey("Name");

                b.ToTable("Clips");
            });
        }
    }
}
