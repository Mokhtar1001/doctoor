using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Doctor.Migrations
{
    /// <inheritdoc />
    public partial class AddDoctor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Doctors (Name, Specialty, imgUrl) VALUES ('Dr. Ahmed Youssef', 'Cardiology', 'https://randomuser.me/api/portraits/men/11.jpg');INSERT INTO Doctors (Name, Specialty, imgUrl) VALUES ('Dr. Mona Ibrahim', 'Dermatology', 'https://randomuser.me/api/portraits/women/15.jpg');INSERT INTO Doctors (Name, Specialty, imgUrl) VALUES ('Dr. Hany Khaled', 'Neurology', 'https://randomuser.me/api/portraits/men/18.jpg');INSERT INTO Doctors (Name, Specialty, imgUrl) VALUES ('Dr. Sarah Ali', 'Pediatrics', 'https://randomuser.me/api/portraits/women/25.jpg');INSERT INTO Doctors (Name, Specialty, imgUrl) VALUES ('Dr. Mohamed Fathy', 'Orthopedics', 'http");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("TRANCATE TABLE doctor");
        }
    }
}
