using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITI_Project_MVC.Migrations
{
    /// <inheritdoc />
    public partial class init1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Results_Courses_Course_Id",
                table: "Course_Results");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_Results_Trainees_Trainee_Id",
                table: "Course_Results");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Departments_Dept_Id",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Courses_Course_Id",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_Dept_Id",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Trainees_Departments_Dept_Id",
                table: "Trainees");

            migrationBuilder.AlterColumn<int>(
                name: "Dept_Id",
                table: "Trainees",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Dept_Id",
                table: "Instructors",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Course_Id",
                table: "Instructors",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Dept_Id",
                table: "Courses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Trainee_Id",
                table: "Course_Results",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Course_Id",
                table: "Course_Results",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Results_Courses_Course_Id",
                table: "Course_Results",
                column: "Course_Id",
                principalTable: "Courses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Results_Trainees_Trainee_Id",
                table: "Course_Results",
                column: "Trainee_Id",
                principalTable: "Trainees",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Departments_Dept_Id",
                table: "Courses",
                column: "Dept_Id",
                principalTable: "Departments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Courses_Course_Id",
                table: "Instructors",
                column: "Course_Id",
                principalTable: "Courses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_Dept_Id",
                table: "Instructors",
                column: "Dept_Id",
                principalTable: "Departments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Trainees_Departments_Dept_Id",
                table: "Trainees",
                column: "Dept_Id",
                principalTable: "Departments",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Results_Courses_Course_Id",
                table: "Course_Results");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_Results_Trainees_Trainee_Id",
                table: "Course_Results");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Departments_Dept_Id",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Courses_Course_Id",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_Dept_Id",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Trainees_Departments_Dept_Id",
                table: "Trainees");

            migrationBuilder.AlterColumn<int>(
                name: "Dept_Id",
                table: "Trainees",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Dept_Id",
                table: "Instructors",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Course_Id",
                table: "Instructors",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Dept_Id",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Trainee_Id",
                table: "Course_Results",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Course_Id",
                table: "Course_Results",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Results_Courses_Course_Id",
                table: "Course_Results",
                column: "Course_Id",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Results_Trainees_Trainee_Id",
                table: "Course_Results",
                column: "Trainee_Id",
                principalTable: "Trainees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Departments_Dept_Id",
                table: "Courses",
                column: "Dept_Id",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Courses_Course_Id",
                table: "Instructors",
                column: "Course_Id",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_Dept_Id",
                table: "Instructors",
                column: "Dept_Id",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Trainees_Departments_Dept_Id",
                table: "Trainees",
                column: "Dept_Id",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
