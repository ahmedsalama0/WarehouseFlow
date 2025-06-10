using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WarehouseFlow.Migrations
{
    /// <inheritdoc />
    public partial class changereleaseorderschema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReleaseOrders_Clients_ClientId",
                table: "ReleaseOrders");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "ReleaseOrders",
                newName: "SupplierId");

            migrationBuilder.RenameIndex(
                name: "IX_ReleaseOrders_ClientId",
                table: "ReleaseOrders",
                newName: "IX_ReleaseOrders_SupplierId");

            migrationBuilder.AddForeignKey(
                name: "FK_ReleaseOrders_Suppliers_SupplierId",
                table: "ReleaseOrders",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReleaseOrders_Suppliers_SupplierId",
                table: "ReleaseOrders");

            migrationBuilder.RenameColumn(
                name: "SupplierId",
                table: "ReleaseOrders",
                newName: "ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_ReleaseOrders_SupplierId",
                table: "ReleaseOrders",
                newName: "IX_ReleaseOrders_ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_ReleaseOrders_Clients_ClientId",
                table: "ReleaseOrders",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
