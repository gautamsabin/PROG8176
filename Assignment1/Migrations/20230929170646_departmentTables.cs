using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Assignment1.Migrations
{
    /// <inheritdoc />
    public partial class departmentTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    DepartmentName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Budget = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FirstMidName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeID);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ProjectID);
                    table.ForeignKey(
                        name: "FK_Projects_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "Budget", "DepartmentName", "Description", "Location" },
                values: new object[,]
                {
                    { 1, 50000.00m, "HR", "Human Resources Department", "New York" },
                    { 2, 75000.00m, "IT", "Information Technology Department", "San Francisco" },
                    { 3, 60000.00m, "Marketing", "Marketing Department", "Chicago" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeID", "DepartmentId", "Email", "FirstMidName", "Gender", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, 1, "john.smith@gmail.com", "John", 0, "Smith", "555-123-4567" },
                    { 2, 1, "jane.doe@gmail.com", "Jane", 1, "Doe", "555-987-6543" },
                    { 3, 2, "robert.johnson@gmail.com", "Robert", 0, "Johnson", "555-555-5555" },
                    { 4, 2, "sarah.williams@gmail.com", "Sarah", 1, "Williams", "555-222-3333" },
                    { 5, 3, "david.brown@gmail.com", "David", 0, "Brown", "555-789-1234" },
                    { 6, 3, "mary.davis@gmail.com", "Mary", 1, "Davis", "555-456-7890" },
                    { 7, 1, "michael.miller@gmail.com", "Michael", 0, "Miller", "555-111-2222" },
                    { 8, 2, "emily.wilson@gmail.com", "Emily", 1, "Wilson", "555-999-8888" },
                    { 9, 3, "christopher.moore@gmail.com", "Christopher", 0, "Moore", "555-777-6666" },
                    { 10, 1, "jessica.taylor@gmail.com", "Jessica", 1, "Taylor", "555-333-4444" }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectID", "DepartmentId", "Description", "EndDate", "Name", "StartDate" },
                values: new object[,]
                {
                    { 1, 1, "Description for Project A", new DateTime(2023, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Project A", new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, "Description for Project B", new DateTime(2023, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Project B", new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 1, "Description for Project C", new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Project C", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 3, "Description for Project D", new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Project D", new DateTime(2023, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 2, "Description for Project E", new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Project E", new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_DepartmentId",
                table: "Projects",
                column: "DepartmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
