using Microsoft.EntityFrameworkCore.Migrations;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

#nullable disable

namespace Doctor.Migrations
{
    /// <inheritdoc />
    public partial class AddAppintment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into Appointment (id, patientName, StartTime, EndTime, IsBooked) values (1, 'Hildagard', '1/25/2025', '6/23/2025', 1);insert into Appointment (id, patientName, StartTime, EndTime, IsBooked) values (2, 'Natalina', '1/18/2025', '10/17/2024', 1);insert into Appointment (id, patientName, StartTime, EndTime, IsBooked) values (3, 'West', '6/30/2025', '5/13/2025', 1);insert into Appointment (id, patientName, StartTime, EndTime, IsBooked) values (4, 'Murdoch', '8/6/2025', '7/3/2025', 0);insert into Appointment (id, patientName, StartTime, EndTime, IsBooked) values (5, 'Jemmie', '4/3/2025', '2/13/2025', 0);insert into Appointment (id, patientName, StartTime, EndTime, IsBooked) values (6, 'Alene', '10/17/2024', '9/16/2025', 1);insert into Appointment (id, patientName, StartTime, EndTime, IsBooked) values (7, 'Rubetta', '4/30/2025', '12/1/2024', 0);insert into Appointment (id, patientName, StartTime, EndTime, IsBooked) values (8, 'Sissy', '10/8/2024', '10/5/2024', 1);insert into Appointment (id, patientName, StartTime, EndTime, IsBooked) values (9, 'Sterling', '11/4/2024', '9/29/2025', 1);insert into Appointment (id, patientName, StartTime, EndTime, IsBooked) values (10, 'Estrellita', '10/4/2024', '11/21/2024', 1);");


        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("TRUNCATE TABLE appointment");
        }
    }
}
