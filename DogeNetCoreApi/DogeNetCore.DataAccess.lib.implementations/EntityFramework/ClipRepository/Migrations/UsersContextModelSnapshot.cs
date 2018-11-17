using DogeNetCore.DataAccess.lib.implementations.EntityFramework.ClipRepository.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using System;

namespace DogeNetCore.DataAccess.lib.implementations.EntityFramework.ClipRepository.Migrations
{
    [DbContext(typeof(ClipContext))]
    public class ClipContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
