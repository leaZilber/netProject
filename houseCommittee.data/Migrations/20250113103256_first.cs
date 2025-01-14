using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace houseCommittee.data.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BuildingList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameStreet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumBuilding = table.Column<int>(type: "int", nullable: false),
                    NumTenants = table.Column<int>(type: "int", nullable: false),
                    MonthlyPayment = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildingList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HouseCommitteeList",
                columns: table => new
                {
                    PhoneHouseCommittee = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FamilyHouseCommittee = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstHouseCommittee = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MailHouseCommittee = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseCommitteeList", x => x.PhoneHouseCommittee);
                });

            migrationBuilder.CreateTable(
                name: "MessageList",
                columns: table => new
                {
                    Title = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateTimeMessage = table.Column<DateTime>(type: "datetime2", nullable: false),
                    target = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessageList", x => x.Title);
                });

            migrationBuilder.CreateTable(
                name: "TenantList",
                columns: table => new
                {
                    PhoneTenant = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FamilyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApartmentNumber = table.Column<int>(type: "int", nullable: false),
                    AmounPayments = table.Column<int>(type: "int", nullable: false),
                    MailTenant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodeTenant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BuildingId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TenantList", x => x.PhoneTenant);
                    table.ForeignKey(
                        name: "FK_TenantList_BuildingList_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "BuildingList",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TenantList_BuildingId",
                table: "TenantList",
                column: "BuildingId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HouseCommitteeList");

            migrationBuilder.DropTable(
                name: "MessageList");

            migrationBuilder.DropTable(
                name: "TenantList");

            migrationBuilder.DropTable(
                name: "BuildingList");
        }
    }
}
