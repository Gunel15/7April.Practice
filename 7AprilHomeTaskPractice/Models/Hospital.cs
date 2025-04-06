using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _7AprilHomeTaskPractice.Exceptions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _7AprilHomeTaskPractice.Models
{
    class Hospital
    {
        public Appointment[] Appointments = [];


        public void AddAppointment(int no, string patient, string doctor, DateTime startDate, DateTime endDate)
        {
            if (startDate > endDate)
                throw new WrongDateInterval("This interval is wrong!");

            Appointment appointment = new Appointment(no, patient, doctor, startDate, endDate);
            foreach (var item in Appointments)
            {
                if (appointment.Doctor == item.Doctor)
                {

                    if (appointment.StartDate > item.StartDate && appointment.StartDate < item.EndDate)
                        throw new ReservedDateInterval("This time is already reserved!");
                    if (appointment.EndDate > item.StartDate && appointment.EndDate < item.EndDate)
                        throw new ReservedDateInterval("This time is already reserved!");
                    if (appointment.StartDate < item.StartDate && appointment.EndDate > item.EndDate)
                        throw new ReservedDateInterval("This time is already reserved!");
                }

            }
            Array.Resize(ref Appointments, Appointments.Length + 1);
            Appointments[^1] = appointment;
            Console.WriteLine($"Appointment successfully added!\n");
        }
        public void EndAppointment(int no)
        {
            foreach (var item in Appointments)
            {
                if (item.No == no)
                    Console.WriteLine($"\nNo-{item.No} Appointment's end date: {item.EndDate}\n");
            }

        }
        public void GetAppointment(int no)
        {
            foreach (var item in Appointments)
            {
                if (item.No == no)
                    Console.WriteLine($"About No-{item.No} Appointment:\nPatient: {item.Patient}\nDoctor: {item.Doctor}\nDate Interval:{item.StartDate}-{item.EndDate}\n");
            }

        }
        public void GetAllAppointments()
        {
            foreach (var item in Appointments)
            {
                Console.WriteLine($"\n{item.No}- Appointment's info:\nNo:{item.No}\nPatient: {item.Patient}\nDoctor: {item.Doctor}\nDate Interval:{item.StartDate}-{item.EndDate}\n");
            }
        }
        public void GetWeeklyAppointments(int day)
        {
            foreach (var item in Appointments)
            {
                if (item.StartDate.Day - 7 <= day && item.StartDate.Day + 7 >= day)
                    Console.WriteLine($"About No-{item.No} Appointment:\nPatient: {item.Patient}\nDoctor: {item.Doctor}\nDate Interval:{item.StartDate}-{item.EndDate}\n");
            }
        }
        public void GetTodaysAppointMents(int today)
        {
         foreach (var item in Appointments)
                {

                    if (item.StartDate.Day == today)
                    { Console.WriteLine($"\nToday's appointments' info:\nNo:{item.No}\nPatient: {item.Patient}\nDoctor: {item.Doctor}\nDate Interval:{item.StartDate}-{item.EndDate}\n"); }
                }
       }
        public void GetAllContinuingAppointments(int time)
        {
            foreach (var item in Appointments)
            {
                if (item.StartDate.Hour< time && item.EndDate.Hour > time)
                    Console.WriteLine($"\nContinuing appointments' info:\nNo:{item.No}\nPatient: {item.Patient}\nDoctor: {item.Doctor}\nDate Interval:{item.StartDate}-{item.EndDate}\n");
            }
        }

        //public void GetWeeklyAppointments()
        //{
        //    foreach (var item in Appointments)
        //    {foreach(var item2 in Appointments)
        //        if (item.StartDate.Day -item2.StartDate.Day ==7)
        //            Console.WriteLine($"About No-{item.No} Appointment:\nPatient: {item.Patient}\nDoctor: {item.Doctor}\nDate Interval:{item.StartDate}-{item.EndDate}\n");
        //    }
        //}
    }
}

