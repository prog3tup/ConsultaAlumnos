using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsultaAlumnos.API.Migrations
{
    public partial class AddUserTableReference : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProfessorSubject_User_ProfessorsId",
                table: "ProfessorSubject");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_User_CreatorStudentId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_User_ProfessorId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Responses_User_CreatorId",
                table: "Responses");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentsSubjectsAttended_User_StudentsId",
                table: "StudentsSubjectsAttended");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProfessorSubject_Users_ProfessorsId",
                table: "ProfessorSubject",
                column: "ProfessorsId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Users_CreatorStudentId",
                table: "Questions",
                column: "CreatorStudentId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Users_ProfessorId",
                table: "Questions",
                column: "ProfessorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Responses_Users_CreatorId",
                table: "Responses",
                column: "CreatorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentsSubjectsAttended_Users_StudentsId",
                table: "StudentsSubjectsAttended",
                column: "StudentsId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProfessorSubject_Users_ProfessorsId",
                table: "ProfessorSubject");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Users_CreatorStudentId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Users_ProfessorId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Responses_Users_CreatorId",
                table: "Responses");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentsSubjectsAttended_Users_StudentsId",
                table: "StudentsSubjectsAttended");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProfessorSubject_User_ProfessorsId",
                table: "ProfessorSubject",
                column: "ProfessorsId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_User_CreatorStudentId",
                table: "Questions",
                column: "CreatorStudentId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_User_ProfessorId",
                table: "Questions",
                column: "ProfessorId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Responses_User_CreatorId",
                table: "Responses",
                column: "CreatorId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentsSubjectsAttended_User_StudentsId",
                table: "StudentsSubjectsAttended",
                column: "StudentsId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
