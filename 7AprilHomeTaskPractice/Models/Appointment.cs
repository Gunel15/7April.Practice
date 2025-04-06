using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7AprilHomeTaskPractice.Models
{
    class Appointment
    {
        public int No;
        public string Patient;
        public string Doctor;
        public DateTime StartDate;
        public DateTime EndDate;
        public Appointment(int no,string patient,string doctor,DateTime startDate,DateTime endDate)
        {
            No= no;
            Patient= patient;
            Doctor= doctor;
            StartDate= startDate;
            EndDate= endDate;
        }
    }
}
