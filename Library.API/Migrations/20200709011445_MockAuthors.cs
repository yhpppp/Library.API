using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.API.Migrations
{
    public partial class MockAuthors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("72d5b5f5-3008-49b7-b0d6-cc337f1a6666"),
                column: "Name",
                value: "Author X");

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[,]
                {
                    { new Guid("72d5b5f5-3008-49b7-b0d6-cc337f1a6661"), new DateTimeOffset(new DateTime(1999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "America", "whh@flower.com", "王花花" },
                    { new Guid("72d5b5f5-3008-49b7-b0d6-cc337f1a6675"), new DateTimeOffset(new DateTime(1999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "America", "whh@flower.com", "Author X" },
                    { new Guid("72d5b5f5-3008-49b7-b0d6-cc337f1a6674"), new DateTimeOffset(new DateTime(1999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "America", "whh@flower.com", "Author X" },
                    { new Guid("72d5b5f5-3008-49b7-b0d6-cc337f1a6673"), new DateTimeOffset(new DateTime(1999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "America", "whh@flower.com", "Author X" },
                    { new Guid("72d5b5f5-3008-49b7-b0d6-cc337f1a6672"), new DateTimeOffset(new DateTime(1999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "America", "whh@flower.com", "Author X" },
                    { new Guid("72d5b5f5-3008-49b7-b0d6-cc337f1a6671"), new DateTimeOffset(new DateTime(1999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "America", "whh@flower.com", "Author X" },
                    { new Guid("72d5b5f5-3008-49b7-b0d6-cc337f1a6670"), new DateTimeOffset(new DateTime(1999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "America", "whh@flower.com", "Author X" },
                    { new Guid("72d5b5f5-3008-49b7-b0d6-cc337f1a6669"), new DateTimeOffset(new DateTime(1999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "America", "whh@flower.com", "Author X" },
                    { new Guid("72d5b5f5-3008-49b7-b0d6-cc337f1a6668"), new DateTimeOffset(new DateTime(1999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "America", "whh@flower.com", "Author X" },
                    { new Guid("72d5b5f5-3008-49b7-b0d6-cc337f1a6667"), new DateTimeOffset(new DateTime(1999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "America", "whh@flower.com", "Author X" },
                    { new Guid("72d5b5f5-3008-49b7-b0d6-cc337f1a6665"), new DateTimeOffset(new DateTime(1999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "America", "whh@flower.com", "Author X" },
                    { new Guid("72d5b5f5-3008-49b7-b0d6-cc337f1a6664"), new DateTimeOffset(new DateTime(1999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "America", "whh@flower.com", "Author X" },
                    { new Guid("72d5b5f5-3008-49b7-b0d6-cc337f1a6663"), new DateTimeOffset(new DateTime(1999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "America", "whh@flower.com", "Author X" },
                    { new Guid("72d5b5f5-3008-49b7-b0d6-cc337f1a6662"), new DateTimeOffset(new DateTime(1999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "America", "whh@flower.com", "Author 2" },
                    { new Guid("72d5b5f5-3008-49b7-b0d6-cc337f1a6676"), new DateTimeOffset(new DateTime(1999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "America", "whh@flower.com", "Author X" },
                    { new Guid("72d5b5f5-3008-49b7-b0d6-cc337f1a6677"), new DateTimeOffset(new DateTime(1999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "America", "whh@flower.com", "Author X" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("72d5b5f5-3008-49b7-b0d6-cc337f1a6661"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("72d5b5f5-3008-49b7-b0d6-cc337f1a6662"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("72d5b5f5-3008-49b7-b0d6-cc337f1a6663"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("72d5b5f5-3008-49b7-b0d6-cc337f1a6664"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("72d5b5f5-3008-49b7-b0d6-cc337f1a6665"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("72d5b5f5-3008-49b7-b0d6-cc337f1a6667"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("72d5b5f5-3008-49b7-b0d6-cc337f1a6668"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("72d5b5f5-3008-49b7-b0d6-cc337f1a6669"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("72d5b5f5-3008-49b7-b0d6-cc337f1a6670"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("72d5b5f5-3008-49b7-b0d6-cc337f1a6671"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("72d5b5f5-3008-49b7-b0d6-cc337f1a6672"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("72d5b5f5-3008-49b7-b0d6-cc337f1a6673"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("72d5b5f5-3008-49b7-b0d6-cc337f1a6674"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("72d5b5f5-3008-49b7-b0d6-cc337f1a6675"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("72d5b5f5-3008-49b7-b0d6-cc337f1a6676"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("72d5b5f5-3008-49b7-b0d6-cc337f1a6677"));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("72d5b5f5-3008-49b7-b0d6-cc337f1a6666"),
                column: "Name",
                value: "王花花");
        }
    }
}
