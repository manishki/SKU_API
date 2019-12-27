using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SKU_API.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Catrgories",
                columns: table => new
                {
                    CatrgoryId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catrgories", x => x.CatrgoryId);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationId);
                });

            migrationBuilder.CreateTable(
                name: "SubCatrgories",
                columns: table => new
                {
                    SubCatrgoryId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCatrgories", x => x.SubCatrgoryId);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentCategory",
                columns: table => new
                {
                    CategoryId = table.Column<Guid>(nullable: false),
                    DepartmentId = table.Column<Guid>(nullable: false),
                    CatrgoryId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentCategory", x => new { x.DepartmentId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_DepartmentCategory_Catrgories_CatrgoryId",
                        column: x => x.CatrgoryId,
                        principalTable: "Catrgories",
                        principalColumn: "CatrgoryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DepartmentCategory_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LocationDepartment",
                columns: table => new
                {
                    DepartmentId = table.Column<Guid>(nullable: false),
                    LocationId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationDepartment", x => new { x.LocationId, x.DepartmentId });
                    table.ForeignKey(
                        name: "FK_LocationDepartment_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LocationDepartment_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CatrgorySubCatrgory",
                columns: table => new
                {
                    CatrgoryId = table.Column<Guid>(nullable: false),
                    SubCatrgoryId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatrgorySubCatrgory", x => new { x.CatrgoryId, x.SubCatrgoryId });
                    table.ForeignKey(
                        name: "FK_CatrgorySubCatrgory_Catrgories_CatrgoryId",
                        column: x => x.CatrgoryId,
                        principalTable: "Catrgories",
                        principalColumn: "CatrgoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CatrgorySubCatrgory_SubCatrgories_SubCatrgoryId",
                        column: x => x.SubCatrgoryId,
                        principalTable: "SubCatrgories",
                        principalColumn: "SubCatrgoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CatrgorySubCatrgory_SubCatrgoryId",
                table: "CatrgorySubCatrgory",
                column: "SubCatrgoryId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentCategory_CatrgoryId",
                table: "DepartmentCategory",
                column: "CatrgoryId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationDepartment_DepartmentId",
                table: "LocationDepartment",
                column: "DepartmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CatrgorySubCatrgory");

            migrationBuilder.DropTable(
                name: "DepartmentCategory");

            migrationBuilder.DropTable(
                name: "LocationDepartment");

            migrationBuilder.DropTable(
                name: "SubCatrgories");

            migrationBuilder.DropTable(
                name: "Catrgories");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Locations");
        }
    }
}
