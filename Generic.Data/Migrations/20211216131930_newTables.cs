using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Generic.Data.Migrations
{
    public partial class newTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ActionName",
                table: "Actions",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Action1",
                table: "Actions",
                newName: "MethodName");

            migrationBuilder.AddColumn<int>(
                name: "ActionTypeId",
                table: "Actions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AdapterId",
                table: "Actions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Actions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MethodJson",
                table: "Actions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "MethodOrder",
                table: "Actions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ActionAdapters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActionId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsSource = table.Column<bool>(type: "bit", nullable: true),
                    IsTargate = table.Column<bool>(type: "bit", nullable: true),
                    TimeOut = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Query = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateTimeFormat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RootPathOrUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthenticationType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Domain = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cartificate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActionAdapters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ActionHeaders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActionId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActionHeaders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ActionTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActionTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemKeys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActionId = table.Column<int>(type: "int", nullable: false),
                    SourceKey = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NewKey = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KeyLevel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemKeys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Parent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "RequestTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Token = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestTypes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActionAdapters");

            migrationBuilder.DropTable(
                name: "ActionHeaders");

            migrationBuilder.DropTable(
                name: "ActionTypes");

            migrationBuilder.DropTable(
                name: "ItemKeys");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "RequestTypes");

            migrationBuilder.DropColumn(
                name: "ActionTypeId",
                table: "Actions");

            migrationBuilder.DropColumn(
                name: "AdapterId",
                table: "Actions");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Actions");

            migrationBuilder.DropColumn(
                name: "MethodJson",
                table: "Actions");

            migrationBuilder.DropColumn(
                name: "MethodOrder",
                table: "Actions");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Actions",
                newName: "ActionName");

            migrationBuilder.RenameColumn(
                name: "MethodName",
                table: "Actions",
                newName: "Action1");
        }
    }
}
