using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject_Winform.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Item_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Item_unit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Item_barcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Item_type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Item_amount = table.Column<long>(type: "bigint", nullable: false),
                    Item_baseLine = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Process",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Process_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Process_status = table.Column<bool>(type: "bit", nullable: false),
                    Process_checkRight = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Process", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PUser",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PUser_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PUser_password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PUser_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PUser_phoneNum = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lot",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemId = table.Column<long>(type: "bigint", nullable: true),
                    Lot_barcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lot_amount = table.Column<long>(type: "bigint", nullable: false),
                    Lot_status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lot_break = table.Column<bool>(type: "bit", nullable: false),
                    Lot_regDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lot", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lot_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemId = table.Column<long>(type: "bigint", nullable: true),
                    Order_startDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Order_endDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Order_sendDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Order_status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Order_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Order_count = table.Column<long>(type: "bigint", nullable: false),
                    Order_account = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Stock",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemId = table.Column<long>(type: "bigint", nullable: true),
                    Stock_amount = table.Column<long>(type: "bigint", nullable: false),
                    Stock_regAmount = table.Column<long>(type: "bigint", nullable: false),
                    Stock_regDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Stock_status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stock", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stock_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Check",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProcessId = table.Column<long>(type: "bigint", nullable: true),
                    Check_item = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Check_value = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Check", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Check_Process_ProcessId",
                        column: x => x.ProcessId,
                        principalTable: "Process",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LotHistory",
                columns: table => new
                {
                    LotHistoryId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LotId = table.Column<long>(type: "bigint", nullable: false),
                    ProcessId = table.Column<long>(type: "bigint", nullable: false),
                    LotHistory_startDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LotHistory_endDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LotHistory", x => x.LotHistoryId);
                    table.ForeignKey(
                        name: "FK_LotHistory_Lot_LotId",
                        column: x => x.LotId,
                        principalTable: "Lot",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LotHistory_Process_ProcessId",
                        column: x => x.ProcessId,
                        principalTable: "Process",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Check_ProcessId",
                table: "Check",
                column: "ProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_Lot_ItemId",
                table: "Lot",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_LotHistory_LotId",
                table: "LotHistory",
                column: "LotId");

            migrationBuilder.CreateIndex(
                name: "IX_LotHistory_ProcessId",
                table: "LotHistory",
                column: "ProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_ItemId",
                table: "Order",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Stock_ItemId",
                table: "Stock",
                column: "ItemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Check");

            migrationBuilder.DropTable(
                name: "LotHistory");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "PUser");

            migrationBuilder.DropTable(
                name: "Stock");

            migrationBuilder.DropTable(
                name: "Lot");

            migrationBuilder.DropTable(
                name: "Process");

            migrationBuilder.DropTable(
                name: "Item");
        }
    }
}
