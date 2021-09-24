using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TARge20.Data.Migrations
{
    public partial class Lasteaed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Grupiajalugu",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupiajalugu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Järjekord",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Queue_Position = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Järjekord", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Köök",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Köök", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Lasteaed",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lasteaed", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tööajalugu",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tööajalugu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kokk",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: false),
                    KitchenID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kokk", x => x.id);
                    table.ForeignKey(
                        name: "FK_Kokk_Köök_KitchenID",
                        column: x => x.KitchenID,
                        principalTable: "Köök",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Menüü",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    dishes = table.Column<string>(nullable: true),
                    KitchenID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menüü", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Menüü_Köök_KitchenID",
                        column: x => x.KitchenID,
                        principalTable: "Köök",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Kasvataja",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    KindergartenId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kasvataja", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kasvataja_Lasteaed_KindergartenId",
                        column: x => x.KindergartenId,
                        principalTable: "Lasteaed",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Grupp",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    GroupType = table.Column<string>(nullable: true),
                    GroupHistoryId = table.Column<Guid>(nullable: true),
                    KindergartenId = table.Column<Guid>(nullable: true),
                    QueueId = table.Column<Guid>(nullable: true),
                    WorkingHistoryId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupp", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Grupp_Grupiajalugu_GroupHistoryId",
                        column: x => x.GroupHistoryId,
                        principalTable: "Grupiajalugu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Grupp_Lasteaed_KindergartenId",
                        column: x => x.KindergartenId,
                        principalTable: "Lasteaed",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Grupp_Järjekord_QueueId",
                        column: x => x.QueueId,
                        principalTable: "Järjekord",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Grupp_Tööajalugu_WorkingHistoryId",
                        column: x => x.WorkingHistoryId,
                        principalTable: "Tööajalugu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Positsioon",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    PositsionTypeId = table.Column<Guid>(nullable: true),
                    PositsionName = table.Column<string>(nullable: true),
                    Cookid = table.Column<Guid>(nullable: true),
                    EducatorId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positsioon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Positsioon_Kokk_Cookid",
                        column: x => x.Cookid,
                        principalTable: "Kokk",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Positsioon_Kasvataja_EducatorId",
                        column: x => x.EducatorId,
                        principalTable: "Kasvataja",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Positsioon_Positsioon_PositsionTypeId",
                        column: x => x.PositsionTypeId,
                        principalTable: "Positsioon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "lapsed",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: false),
                    GroupId = table.Column<Guid>(nullable: true),
                    KindergartenId = table.Column<Guid>(nullable: true),
                    QueueId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lapsed", x => x.Id);
                    table.ForeignKey(
                        name: "FK_lapsed_Grupp_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Grupp",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_lapsed_Lasteaed_KindergartenId",
                        column: x => x.KindergartenId,
                        principalTable: "Lasteaed",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_lapsed_Järjekord_QueueId",
                        column: x => x.QueueId,
                        principalTable: "Järjekord",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Söömisajalugu",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    dish = table.Column<string>(nullable: true),
                    portions = table.Column<int>(nullable: false),
                    GroupId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Söömisajalugu", x => x.id);
                    table.ForeignKey(
                        name: "FK_Söömisajalugu_Grupp_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Grupp",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Puudumine",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    dat = table.Column<DateTime>(nullable: false),
                    reason = table.Column<string>(nullable: true),
                    ChildrenId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Puudumine", x => x.id);
                    table.ForeignKey(
                        name: "FK_Puudumine_lapsed_ChildrenId",
                        column: x => x.ChildrenId,
                        principalTable: "lapsed",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Grupp_GroupHistoryId",
                table: "Grupp",
                column: "GroupHistoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Grupp_KindergartenId",
                table: "Grupp",
                column: "KindergartenId");

            migrationBuilder.CreateIndex(
                name: "IX_Grupp_QueueId",
                table: "Grupp",
                column: "QueueId");

            migrationBuilder.CreateIndex(
                name: "IX_Grupp_WorkingHistoryId",
                table: "Grupp",
                column: "WorkingHistoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Kasvataja_KindergartenId",
                table: "Kasvataja",
                column: "KindergartenId");

            migrationBuilder.CreateIndex(
                name: "IX_Kokk_KitchenID",
                table: "Kokk",
                column: "KitchenID");

            migrationBuilder.CreateIndex(
                name: "IX_lapsed_GroupId",
                table: "lapsed",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_lapsed_KindergartenId",
                table: "lapsed",
                column: "KindergartenId");

            migrationBuilder.CreateIndex(
                name: "IX_lapsed_QueueId",
                table: "lapsed",
                column: "QueueId");

            migrationBuilder.CreateIndex(
                name: "IX_Menüü_KitchenID",
                table: "Menüü",
                column: "KitchenID");

            migrationBuilder.CreateIndex(
                name: "IX_Positsioon_Cookid",
                table: "Positsioon",
                column: "Cookid");

            migrationBuilder.CreateIndex(
                name: "IX_Positsioon_EducatorId",
                table: "Positsioon",
                column: "EducatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Positsioon_PositsionTypeId",
                table: "Positsioon",
                column: "PositsionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Puudumine_ChildrenId",
                table: "Puudumine",
                column: "ChildrenId");

            migrationBuilder.CreateIndex(
                name: "IX_Söömisajalugu_GroupId",
                table: "Söömisajalugu",
                column: "GroupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Menüü");

            migrationBuilder.DropTable(
                name: "Positsioon");

            migrationBuilder.DropTable(
                name: "Puudumine");

            migrationBuilder.DropTable(
                name: "Söömisajalugu");

            migrationBuilder.DropTable(
                name: "Kokk");

            migrationBuilder.DropTable(
                name: "Kasvataja");

            migrationBuilder.DropTable(
                name: "lapsed");

            migrationBuilder.DropTable(
                name: "Köök");

            migrationBuilder.DropTable(
                name: "Grupp");

            migrationBuilder.DropTable(
                name: "Grupiajalugu");

            migrationBuilder.DropTable(
                name: "Lasteaed");

            migrationBuilder.DropTable(
                name: "Järjekord");

            migrationBuilder.DropTable(
                name: "Tööajalugu");
        }
    }
}
