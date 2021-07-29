using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("7fd5abe7-d77a-4826-a323-a26be366914b"), "3d4521d9-b21c-4cc5-8080-0cec552d5c75", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("7fd5abe7-d77a-4826-a323-a26be366914b"), new Guid("d4bdb0d7-2c51-475b-a672-8616f4310055") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("d4bdb0d7-2c51-475b-a672-8616f4310055"), 0, "75f55607-80db-43be-b87a-77f0127b4b5a", new DateTime(1999, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", true, "Van", "Quang", false, null, "admin@gmail.com", "admin", "AQAAAAEAACcQAAAAEEmI2Gn5updyHigmpzif/frg5GaIJWoW9V7eQgiExmb4cSnVTwzr1Oi6L9e1bROlHg==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 7, 23, 21, 37, 7, 985, DateTimeKind.Local).AddTicks(2000));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7fd5abe7-d77a-4826-a323-a26be366914b"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("7fd5abe7-d77a-4826-a323-a26be366914b"), new Guid("d4bdb0d7-2c51-475b-a672-8616f4310055") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d4bdb0d7-2c51-475b-a672-8616f4310055"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 7, 23, 21, 16, 52, 33, DateTimeKind.Local).AddTicks(5392));
        }
    }
}
