using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DrakeFanpage.Migrations
{
    /// <inheritdoc />
    public partial class fixingnullables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Albums_AlbumReviews_AlbumReviewId",
                table: "Albums");

            migrationBuilder.DropForeignKey(
                name: "FK_Tracks_Albums_AlbumID",
                table: "Tracks");

            migrationBuilder.AlterColumn<int>(
                name: "AlbumID",
                table: "Tracks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AlbumReviewId",
                table: "Albums",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Albums_AlbumReviews_AlbumReviewId",
                table: "Albums",
                column: "AlbumReviewId",
                principalTable: "AlbumReviews",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tracks_Albums_AlbumID",
                table: "Tracks",
                column: "AlbumID",
                principalTable: "Albums",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Albums_AlbumReviews_AlbumReviewId",
                table: "Albums");

            migrationBuilder.DropForeignKey(
                name: "FK_Tracks_Albums_AlbumID",
                table: "Tracks");

            migrationBuilder.AlterColumn<int>(
                name: "AlbumID",
                table: "Tracks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AlbumReviewId",
                table: "Albums",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Albums_AlbumReviews_AlbumReviewId",
                table: "Albums",
                column: "AlbumReviewId",
                principalTable: "AlbumReviews",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tracks_Albums_AlbumID",
                table: "Tracks",
                column: "AlbumID",
                principalTable: "Albums",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
