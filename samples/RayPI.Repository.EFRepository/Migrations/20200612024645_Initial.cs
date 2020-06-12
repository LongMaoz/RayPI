﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RayPI.Repository.EFRepository.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "ray");

            migrationBuilder.CreateTable(
                name: "AppArticle",
                schema: "ray",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    Title = table.Column<string>(nullable: false),
                    SubTitle = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppArticle", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "ray",
                table: "AppArticle",
                columns: new[] { "Id", "Content", "CreationTime", "CreatorId", "DeleterId", "DeletionTime", "LastModificationTime", "LastModifierId", "SubTitle", "Title" },
                values: new object[] { new Guid("c89b7057-477d-4185-a72c-3725e908e5db"), "这是内容", new DateTime(2020, 6, 12, 10, 46, 45, 565, DateTimeKind.Local).AddTicks(5308), null, null, null, null, null, "来自DbContext的OnModelCreating", "这是一条初始化的数据" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppArticle",
                schema: "ray");
        }
    }
}
