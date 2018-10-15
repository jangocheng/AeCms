using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Ator.Entity.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sys_Dictionary",
                columns: table => new
                {
                    SysDictionaryId = table.Column<string>(maxLength: 32, nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: true),
                    CreateUser = table.Column<string>(maxLength: 32, nullable: true),
                    EditTime = table.Column<DateTime>(nullable: true),
                    EditUser = table.Column<string>(maxLength: 32, nullable: true),
                    Remark = table.Column<string>(maxLength: 200, nullable: true),
                    Sort = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: true),
                    SysDictionaryName = table.Column<string>(maxLength: 32, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_Dictionary", x => x.SysDictionaryId);
                });

            migrationBuilder.CreateTable(
                name: "Sys_LinkType",
                columns: table => new
                {
                    SysLinkTypeId = table.Column<string>(maxLength: 32, nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: true),
                    CreateUser = table.Column<string>(maxLength: 32, nullable: true),
                    EditTime = table.Column<DateTime>(nullable: true),
                    EditUser = table.Column<string>(maxLength: 32, nullable: true),
                    Group = table.Column<string>(maxLength: 32, nullable: true),
                    Remark = table.Column<string>(maxLength: 200, nullable: true),
                    Sort = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: true),
                    SysLinkTypeName = table.Column<string>(maxLength: 32, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_LinkType", x => x.SysLinkTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Sys_Page",
                columns: table => new
                {
                    SysPageId = table.Column<string>(maxLength: 32, nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: true),
                    CreateUser = table.Column<string>(maxLength: 32, nullable: true),
                    EditTime = table.Column<DateTime>(nullable: true),
                    EditUser = table.Column<string>(maxLength: 32, nullable: true),
                    Remark = table.Column<string>(maxLength: 200, nullable: true),
                    Sort = table.Column<int>(maxLength: 255, nullable: false),
                    Status = table.Column<int>(nullable: true),
                    SysPageImg = table.Column<string>(maxLength: 255, nullable: true),
                    SysPageName = table.Column<string>(maxLength: 50, nullable: true),
                    SysPageNum = table.Column<string>(maxLength: 50, nullable: true),
                    SysPageParent = table.Column<string>(maxLength: 32, nullable: true),
                    SysPageUrl = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_Page", x => x.SysPageId);
                });

            migrationBuilder.CreateTable(
                name: "Sys_Role",
                columns: table => new
                {
                    SysRoleId = table.Column<string>(maxLength: 32, nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: true),
                    CreateUser = table.Column<string>(maxLength: 32, nullable: true),
                    EditTime = table.Column<DateTime>(nullable: true),
                    EditUser = table.Column<string>(maxLength: 32, nullable: true),
                    Remark = table.Column<string>(maxLength: 200, nullable: true),
                    RoleName = table.Column<string>(maxLength: 32, nullable: true),
                    Sort = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_Role", x => x.SysRoleId);
                });

            migrationBuilder.CreateTable(
                name: "Sys_Setting",
                columns: table => new
                {
                    SysSettingId = table.Column<string>(maxLength: 32, nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: true),
                    CreateUser = table.Column<string>(maxLength: 32, nullable: true),
                    EditTime = table.Column<DateTime>(nullable: true),
                    EditUser = table.Column<string>(maxLength: 32, nullable: true),
                    Remark = table.Column<string>(maxLength: 200, nullable: true),
                    SetValue = table.Column<string>(maxLength: 500, nullable: true),
                    Sort = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: true),
                    SysSettingGroup = table.Column<string>(maxLength: 50, nullable: true),
                    SysSettingName = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_Setting", x => x.SysSettingId);
                });

            migrationBuilder.CreateTable(
                name: "Sys_User",
                columns: table => new
                {
                    SysUserId = table.Column<string>(maxLength: 32, nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: true),
                    CreateUser = table.Column<string>(maxLength: 32, nullable: true),
                    EditTime = table.Column<DateTime>(nullable: true),
                    EditUser = table.Column<string>(maxLength: 32, nullable: true),
                    Email = table.Column<string>(maxLength: 100, nullable: true),
                    Mobile = table.Column<string>(maxLength: 20, nullable: true),
                    NikeName = table.Column<string>(maxLength: 32, nullable: true),
                    Password = table.Column<string>(maxLength: 255, nullable: true),
                    QQ = table.Column<string>(maxLength: 20, nullable: true),
                    Remark = table.Column<string>(maxLength: 200, nullable: true),
                    Status = table.Column<int>(nullable: true),
                    TrueName = table.Column<string>(maxLength: 32, nullable: true),
                    UserName = table.Column<string>(maxLength: 32, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_User", x => x.SysUserId);
                });

            migrationBuilder.CreateTable(
                name: "Sys_Dictionary_Item",
                columns: table => new
                {
                    SysDictionaryItemId = table.Column<string>(maxLength: 32, nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: true),
                    Sort = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    SysDictionaryId = table.Column<string>(maxLength: 32, nullable: true),
                    SysDictionaryName = table.Column<string>(maxLength: 32, nullable: true),
                    SysDictionaryValue = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_Dictionary_Item", x => x.SysDictionaryItemId);
                    table.ForeignKey(
                        name: "FK_Sys_Dictionary_Item_Sys_Dictionary_SysDictionaryId",
                        column: x => x.SysDictionaryId,
                        principalTable: "Sys_Dictionary",
                        principalColumn: "SysDictionaryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sys_LinkItem",
                columns: table => new
                {
                    SysLinkItemId = table.Column<string>(maxLength: 32, nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: true),
                    CreateUser = table.Column<string>(maxLength: 32, nullable: true),
                    EditTime = table.Column<DateTime>(nullable: true),
                    EditUser = table.Column<string>(maxLength: 32, nullable: true),
                    Remark = table.Column<string>(maxLength: 200, nullable: true),
                    Sort = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: true),
                    SysLinkImg = table.Column<string>(maxLength: 255, nullable: true),
                    SysLinkName = table.Column<string>(maxLength: 32, nullable: true),
                    SysLinkTypeId = table.Column<string>(maxLength: 32, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_LinkItem", x => x.SysLinkItemId);
                    table.ForeignKey(
                        name: "FK_Sys_LinkItem_Sys_LinkType_SysLinkTypeId",
                        column: x => x.SysLinkTypeId,
                        principalTable: "Sys_LinkType",
                        principalColumn: "SysLinkTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sys_RolePage",
                columns: table => new
                {
                    SysRolePageId = table.Column<string>(maxLength: 32, nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: true),
                    SysPageId = table.Column<string>(maxLength: 32, nullable: true),
                    SysRoleId = table.Column<string>(maxLength: 32, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_RolePage", x => x.SysRolePageId);
                    table.ForeignKey(
                        name: "FK_Sys_RolePage_Sys_Page_SysPageId",
                        column: x => x.SysPageId,
                        principalTable: "Sys_Page",
                        principalColumn: "SysPageId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sys_RolePage_Sys_Role_SysRoleId",
                        column: x => x.SysRoleId,
                        principalTable: "Sys_Role",
                        principalColumn: "SysRoleId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sys_UserRole",
                columns: table => new
                {
                    SysUserRoleId = table.Column<string>(maxLength: 32, nullable: false),
                    SysRoleId = table.Column<string>(maxLength: 32, nullable: true),
                    SysUserId = table.Column<string>(maxLength: 32, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_UserRole", x => x.SysUserRoleId);
                    table.ForeignKey(
                        name: "FK_Sys_UserRole_Sys_Role_SysRoleId",
                        column: x => x.SysRoleId,
                        principalTable: "Sys_Role",
                        principalColumn: "SysRoleId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sys_UserRole_Sys_User_SysUserId",
                        column: x => x.SysUserId,
                        principalTable: "Sys_User",
                        principalColumn: "SysUserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sys_Dictionary_Item_SysDictionaryId",
                table: "Sys_Dictionary_Item",
                column: "SysDictionaryId");

            migrationBuilder.CreateIndex(
                name: "IX_Sys_LinkItem_SysLinkTypeId",
                table: "Sys_LinkItem",
                column: "SysLinkTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Sys_RolePage_SysPageId",
                table: "Sys_RolePage",
                column: "SysPageId");

            migrationBuilder.CreateIndex(
                name: "IX_Sys_RolePage_SysRoleId",
                table: "Sys_RolePage",
                column: "SysRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Sys_UserRole_SysRoleId",
                table: "Sys_UserRole",
                column: "SysRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Sys_UserRole_SysUserId",
                table: "Sys_UserRole",
                column: "SysUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sys_Dictionary_Item");

            migrationBuilder.DropTable(
                name: "Sys_LinkItem");

            migrationBuilder.DropTable(
                name: "Sys_RolePage");

            migrationBuilder.DropTable(
                name: "Sys_Setting");

            migrationBuilder.DropTable(
                name: "Sys_UserRole");

            migrationBuilder.DropTable(
                name: "Sys_Dictionary");

            migrationBuilder.DropTable(
                name: "Sys_LinkType");

            migrationBuilder.DropTable(
                name: "Sys_Page");

            migrationBuilder.DropTable(
                name: "Sys_Role");

            migrationBuilder.DropTable(
                name: "Sys_User");
        }
    }
}
