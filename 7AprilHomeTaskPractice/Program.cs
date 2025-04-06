using _7AprilHomeTaskPractice.Models;

namespace _7AprilHomeTaskPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hospital hospital = new Hospital();

            while (true)
            {

                Console.WriteLine("Ashagidaki regemlerden birini sechin:\n1. Appointment yarat\r\n2. Appointment-i bitir\r\n3. Butun appointment-lere bax\r\n4. Bu hefteki appointment-lere bax\r\n5. Bugunki appointment-lere bax\r\n6. Bitmemish appointmentlere bax\r\n7. Menudan chıx");
                int number = int.Parse(Console.ReadLine());
                if (number == 1)
                {
                    hospital.AddAppointment(1, "Gunel Shikarova", "Cahid Shahbazov", new DateTime(2025, 4, 7, 14, 00, 00), new DateTime(2025, 4, 7, 17, 00, 00));
                    hospital.AddAppointment(2, "Asif Heydarli", "Cahid Shahbazov", new DateTime(2025, 4, 6, 11, 00, 00), new DateTime(2025, 4, 6, 13, 00, 00));
                    hospital.AddAppointment(3, "Narmin Aliyeva", "Kerim Mehdiyev", new DateTime(2025, 4, 6, 11, 00, 00), new DateTime(2025, 4, 6, 13, 00, 00));
                    hospital.AddAppointment(4, "Ayan Cafarli", "Farid Huseynov", new DateTime(2025, 4, 13, 15, 00, 00), new DateTime(2025, 4, 17, 17, 00, 00));
                    hospital.AddAppointment(5, "Rashid Quliyev", "Durdane Naghizade", new DateTime(2025, 4, 21, 10, 00, 00), new DateTime(2025, 4, 21, 12, 00, 00));
                }
                if (number == 2)
                {
                    Console.WriteLine("Enter appointment's number and get information about end date:\n");
                    int num = int.Parse(Console.ReadLine());
                    hospital.EndAppointment(num);
                }
                if (number == 3)
                {
                    hospital.GetAllAppointments();
                }
                if (number == 4)
                {
                    Console.WriteLine("Get information about weekly appointments.Enter today's date:");
                    int day = int.Parse(Console.ReadLine());
                    hospital.GetWeeklyAppointments(day);
                }
                if (number == 5)
                {
                    Console.WriteLine("Get information about today's appointments. Enter today's date:");
                    int today = int.Parse(Console.ReadLine());
                    hospital.GetTodaysAppointMents(today);

                }
                if (number== 6)
                {
                    Console.WriteLine("Get information about continuing appointments. Enter:");
                    int time = int.Parse(Console.ReadLine());
                    hospital.GetTodaysAppointMents(time);
                }
                if (number == 7)
                    break;

            }

        }
    }
}
