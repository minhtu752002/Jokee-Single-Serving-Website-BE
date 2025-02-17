﻿// <auto-generated />
using JokeBackEnd.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JokeBackEnd.Migrations
{
    [DbContext(typeof(JokesDbContext))]
    [Migration("20240401064113_init-jokes")]
    partial class initjokes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("JokeBackEnd.Models.Joke", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Contentstory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("jokes", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Contentstory = "A child asked his father, \"How were people born?\" So his father said, \"Adam and Eve made babies, then their babies became adults and made babies, and so on.\"\r\n\r\nThe child then went to his mother, asked her the same question and she told him, \"We were monkeys then we evolved to become like we are now.\"\r\n\r\nThe child ran back to his father and said, \"You lied to me!\" His father replied, \"No, your mom was talking about her side of the family.\""
                        },
                        new
                        {
                            Id = 2,
                            Contentstory = "Teacher: \"Kids,what does the chicken give you?\" Student: \"Meat!\" Teacher: \"Very good! Now what does the pig give you?\" Student: \"Bacon!\" Teacher: \"Great! And what does the fat cow give you?\" Student: \"Homework!\"\r\n\r\n"
                        },
                        new
                        {
                            Id = 3,
                            Contentstory = "The teacher asked Jimmy, \"Why is your cat at school today Jimmy?\" Jimmy replied crying, \"Because I heard my daddy tell my mommy, 'I am going to eat that pussy once Jimmy leaves for school today!'\"\r\n\r\n"
                        },
                        new
                        {
                            Id = 4,
                            Contentstory = "A housewife, an accountant and a lawyer were asked \"How much is 2+2?\" The housewife replies: \"Four!\". The accountant says: \"I think it's either 3 or 4. Let me run those figures through my spreadsheet one more time.\" The lawyer pulls the drapes, dims the lights and asks in a hushed voice, \"How much do you want it to be?\""
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
