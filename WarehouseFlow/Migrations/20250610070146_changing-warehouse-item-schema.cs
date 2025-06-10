using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WarehouseFlow.Migrations
{
    /// <inheritdoc />
    public partial class changingwarehouseitemschema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_WarehouseItems",
                table: "WarehouseItems");

            migrationBuilder.AlterColumn<int>(
                name: "ShelfLife",
                table: "WarehouseItems",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ProductionDate",
                table: "WarehouseItems",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2")
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<int>(
                name: "ItemId",
                table: "WarehouseItems",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("Relational:ColumnOrder", 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "WarehouseItems",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WarehouseItems",
                table: "WarehouseItems",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_WarehouseItems_ItemId",
                table: "WarehouseItems",
                column: "ItemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_WarehouseItems",
                table: "WarehouseItems");

            migrationBuilder.DropIndex(
                name: "IX_WarehouseItems_ItemId",
                table: "WarehouseItems");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "WarehouseItems");

            migrationBuilder.AlterColumn<int>(
                name: "ShelfLife",
                table: "WarehouseItems",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ProductionDate",
                table: "WarehouseItems",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2")
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<int>(
                name: "ItemId",
                table: "WarehouseItems",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_WarehouseItems",
                table: "WarehouseItems",
                columns: new[] { "ItemId", "ProductionDate", "ShelfLife" });
        }
    }
}
