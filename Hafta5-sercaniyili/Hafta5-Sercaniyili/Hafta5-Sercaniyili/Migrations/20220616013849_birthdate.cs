using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hafta5_Sercaniyili.Migrations
{
    public partial class birthdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_ContentType_TypeId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Posts_PostId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Friendships_FriendshipStatuses_StatusId",
                table: "Friendships");

            migrationBuilder.DropForeignKey(
                name: "FK_GroupMessages_ContentType_TypeId",
                table: "GroupMessages");

            migrationBuilder.DropForeignKey(
                name: "FK_GroupMessages_Groups_Reciever",
                table: "GroupMessages");

            migrationBuilder.DropForeignKey(
                name: "FK_Memberships_Groups_GroupId",
                table: "Memberships");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_ContentType_TypeId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_UserMessages_ContentType_TypeId",
                table: "UserMessages");

            migrationBuilder.AddColumn<DateTime>(
                name: "Birthdate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_ContentType_TypeId",
                table: "Comments",
                column: "TypeId",
                principalTable: "ContentType",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Posts_PostId",
                table: "Comments",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Friendships_FriendshipStatuses_StatusId",
                table: "Friendships",
                column: "StatusId",
                principalTable: "FriendshipStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_GroupMessages_ContentType_TypeId",
                table: "GroupMessages",
                column: "TypeId",
                principalTable: "ContentType",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_GroupMessages_Groups_Reciever",
                table: "GroupMessages",
                column: "Reciever",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Memberships_Groups_GroupId",
                table: "Memberships",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_ContentType_TypeId",
                table: "Posts",
                column: "TypeId",
                principalTable: "ContentType",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_UserMessages_ContentType_TypeId",
                table: "UserMessages",
                column: "TypeId",
                principalTable: "ContentType",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_ContentType_TypeId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Posts_PostId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Friendships_FriendshipStatuses_StatusId",
                table: "Friendships");

            migrationBuilder.DropForeignKey(
                name: "FK_GroupMessages_ContentType_TypeId",
                table: "GroupMessages");

            migrationBuilder.DropForeignKey(
                name: "FK_GroupMessages_Groups_Reciever",
                table: "GroupMessages");

            migrationBuilder.DropForeignKey(
                name: "FK_Memberships_Groups_GroupId",
                table: "Memberships");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_ContentType_TypeId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_UserMessages_ContentType_TypeId",
                table: "UserMessages");

            migrationBuilder.DropColumn(
                name: "Birthdate",
                table: "AspNetUsers");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_ContentType_TypeId",
                table: "Comments",
                column: "TypeId",
                principalTable: "ContentType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Posts_PostId",
                table: "Comments",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Friendships_FriendshipStatuses_StatusId",
                table: "Friendships",
                column: "StatusId",
                principalTable: "FriendshipStatuses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GroupMessages_ContentType_TypeId",
                table: "GroupMessages",
                column: "TypeId",
                principalTable: "ContentType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GroupMessages_Groups_Reciever",
                table: "GroupMessages",
                column: "Reciever",
                principalTable: "Groups",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Memberships_Groups_GroupId",
                table: "Memberships",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_ContentType_TypeId",
                table: "Posts",
                column: "TypeId",
                principalTable: "ContentType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserMessages_ContentType_TypeId",
                table: "UserMessages",
                column: "TypeId",
                principalTable: "ContentType",
                principalColumn: "Id");
        }
    }
}
