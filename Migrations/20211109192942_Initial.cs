using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseRegistration.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    C_courseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    C_courseNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C_courseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C_courseDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.C_courseID);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    S_studentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    S_firstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    S_lastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    S_EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    S_phoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.S_studentId);
                });

            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    I_instructorID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    I_firstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    I_lastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    I_emailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C_courseID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.I_instructorID);
                    table.ForeignKey(
                        name: "FK_Instructors_Courses_C_courseID",
                        column: x => x.C_courseID,
                        principalTable: "Courses",
                        principalColumn: "C_courseID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "C_courseID", "C_courseDescription", "C_courseName", "C_courseNumber" },
                values: new object[,]
                {
                    { 1, " DataBase management for beginners", "Database", "64745" },
                    { 2, "Intoduction to Object Oreineted Programming ", "Java Programming", "64746" },
                    { 3, "Introduction to .NET in C# programming", "C# programming", "64747" },
                    { 4, " Basic course on Information Tectnology", "Basic IT", "64748" },
                    { 5, "Basic software testing tool for beginners", "Software Testing", "64749" },
                    { 6, "HTML5 for begginners", " HTML5", "64750" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "S_studentId", "S_EmailAddress", "S_firstName", "S_lastName", "S_phoneNumber" },
                values: new object[,]
                {
                    { 5634, "Bass.Cuppy@gmail.com", "Bass", "Cuppy", "20497845755" },
                    { 6790, "Peter.Jones@gmail.com", "Peter", "Jones", "63669036034" },
                    { 3578, "Tayo.Gbemi@gmail.com", "Tayo", "Gbemi", "64758502002" },
                    { 5989, "Brandy.Brown@gmail.com", "Brandy", "Brown", "67973752652" },
                    { 124, "KoloBenny@gmail.com", "kolo", "Beny", "08598658635" },
                    { 6667, "temiReed@gmail.com", "Temi", "Reed", "08552785953" }
                });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "I_instructorID", "C_courseID", "I_emailAddress", "I_firstName", "I_lastName" },
                values: new object[,]
                {
                    { "7773", 1, "james.B@gmail.com", "James", "Bonjo" },
                    { "7734", 2, "john.P@gmail.com", "John", "Prince" },
                    { "7373", 3, "beth.B@gmail.com", "Beth", "Brand" },
                    { "7883", 4, "Mark.z@gmail.com", "Mark", "Zoe" },
                    { "7353", 5, "ZionC@gmail.com", "Zion", "Cain" },
                    { "7233", 6, "HeatherY@gmail.com", "Heather", "Yari" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_C_courseID",
                table: "Instructors",
                column: "C_courseID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Instructors");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}
