using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ex3.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agents",
                columns: table => new
                {
                    AgentID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AgentName = table.Column<string>(type: "TEXT", nullable: true),
                    Address = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agents", x => x.AgentID);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ItemID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ItemName = table.Column<string>(type: "TEXT", nullable: true),
                    Size = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ItemID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserName = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Password = table.Column<string>(type: "TEXT", nullable: true),
                    Lock = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrderDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AgentID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Orders_Agents_AgentID",
                        column: x => x.AgentID,
                        principalTable: "Agents",
                        principalColumn: "AgentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrderID = table.Column<int>(type: "INTEGER", nullable: false),
                    ItemID = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    UnitAmount = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Items_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Items",
                        principalColumn: "ItemID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Agents",
                columns: new[] { "AgentID", "Address", "AgentName" },
                values: new object[,]
                {
                    { 1, "Address1", "Agent1" },
                    { 2, "Address2", "Agent2" },
                    { 3, "Address3", "Agent3" },
                    { 4, "Address4", "Agent4" },
                    { 5, "Address5", "Agent5" },
                    { 6, "Address6", "Agent6" },
                    { 7, "Address7", "Agent7" },
                    { 8, "Address8", "Agent8" },
                    { 9, "Address9", "Agent9" },
                    { 10, "Address10", "Agent10" },
                    { 11, "Address11", "Agent11" },
                    { 12, "Address12", "Agent12" },
                    { 13, "Address13", "Agent13" },
                    { 14, "Address14", "Agent14" },
                    { 15, "Address15", "Agent15" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemID", "ItemName", "Size" },
                values: new object[,]
                {
                    { 1, "Item1", "Size1" },
                    { 2, "Item2", "Size2" },
                    { 3, "Item3", "Size3" },
                    { 4, "Item4", "Size4" },
                    { 5, "Item5", "Size5" },
                    { 6, "Item6", "Size6" },
                    { 7, "Item7", "Size7" },
                    { 8, "Item8", "Size8" },
                    { 9, "Item9", "Size9" },
                    { 10, "Item10", "Size10" },
                    { 11, "Item11", "Size11" },
                    { 12, "Item12", "Size12" },
                    { 13, "Item13", "Size13" },
                    { 14, "Item14", "Size14" },
                    { 15, "Item15", "Size15" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Email", "Lock", "Password", "UserName" },
                values: new object[,]
                {
                    { 1, "user1@example.com", false, "password", "User1" },
                    { 2, "user2@example.com", false, "password", "User2" },
                    { 3, "user3@example.com", false, "password", "User3" },
                    { 4, "user4@example.com", false, "password", "User4" },
                    { 5, "user5@example.com", false, "password", "User5" },
                    { 6, "user6@example.com", false, "password", "User6" },
                    { 7, "user7@example.com", false, "password", "User7" },
                    { 8, "user8@example.com", false, "password", "User8" },
                    { 9, "user9@example.com", false, "password", "User9" },
                    { 10, "user10@example.com", false, "password", "User10" },
                    { 11, "user11@example.com", false, "password", "User11" },
                    { 12, "user12@example.com", false, "password", "User12" },
                    { 13, "user13@example.com", false, "password", "User13" },
                    { 14, "user14@example.com", false, "password", "User14" },
                    { 15, "user15@example.com", false, "password", "User15" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderID", "AgentID", "OrderDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, new DateTime(2025, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 3, new DateTime(2025, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 4, new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 5, new DateTime(2025, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 6, new DateTime(2025, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 7, new DateTime(2025, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 8, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 9, new DateTime(2025, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 10, new DateTime(2025, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 11, new DateTime(2025, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 12, new DateTime(2025, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 13, new DateTime(2025, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 14, new DateTime(2025, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 15, new DateTime(2025, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "ID", "ItemID", "OrderID", "Quantity", "UnitAmount" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, 10.0m },
                    { 2, 2, 2, 2, 20.0m },
                    { 3, 3, 3, 3, 30.0m },
                    { 4, 4, 4, 4, 40.0m },
                    { 5, 5, 5, 5, 50.0m },
                    { 6, 6, 6, 6, 60.0m },
                    { 7, 7, 7, 7, 70.0m },
                    { 8, 8, 8, 8, 80.0m },
                    { 9, 9, 9, 9, 90.0m },
                    { 10, 10, 10, 10, 100.0m },
                    { 11, 11, 11, 11, 110.0m },
                    { 12, 12, 12, 12, 120.0m },
                    { 13, 13, 13, 13, 130.0m },
                    { 14, 14, 14, 14, 140.0m },
                    { 15, 15, 15, 15, 150.0m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ItemID",
                table: "OrderDetails",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderID",
                table: "OrderDetails",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AgentID",
                table: "Orders",
                column: "AgentID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Agents");
        }
    }
}
