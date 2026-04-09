using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Film_Koleksiyonu_MVC.Migrations
{
    /// <inheritdoc />
    public partial class updatedata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Approvals_Movies_MovieId",
                table: "Approvals");

            migrationBuilder.DropForeignKey(
                name: "FK_Approvals_Users_ApprovedByUserId",
                table: "Approvals");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieSuggestions_Movies_MovieId",
                table: "MovieSuggestions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Friends",
                table: "Friends");

            migrationBuilder.DropIndex(
                name: "IX_Friends_FriendId",
                table: "Friends");

            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "Approvals");

            migrationBuilder.RenameColumn(
                name: "ApprovedByUserId",
                table: "Approvals",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Approvals_ApprovedByUserId",
                table: "Approvals",
                newName: "IX_Approvals_UserId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Friends",
                table: "Friends",
                column: "FriendId");

            migrationBuilder.AddForeignKey(
                name: "FK_Approvals_Movies_MovieId",
                table: "Approvals",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "MovieId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Approvals_Users_UserId",
                table: "Approvals",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieSuggestions_Movies_MovieId",
                table: "MovieSuggestions",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "MovieId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Approvals_Movies_MovieId",
                table: "Approvals");

            migrationBuilder.DropForeignKey(
                name: "FK_Approvals_Users_UserId",
                table: "Approvals");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieSuggestions_Movies_MovieId",
                table: "MovieSuggestions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Friends",
                table: "Friends");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Approvals",
                newName: "ApprovedByUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Approvals_UserId",
                table: "Approvals",
                newName: "IX_Approvals_ApprovedByUserId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "Approvals",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Friends",
                table: "Friends",
                column: "FriendshipId");

            migrationBuilder.CreateIndex(
                name: "IX_Friends_FriendId",
                table: "Friends",
                column: "FriendId");

            migrationBuilder.AddForeignKey(
                name: "FK_Approvals_Movies_MovieId",
                table: "Approvals",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "MovieId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Approvals_Users_ApprovedByUserId",
                table: "Approvals",
                column: "ApprovedByUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieSuggestions_Movies_MovieId",
                table: "MovieSuggestions",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "MovieId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
