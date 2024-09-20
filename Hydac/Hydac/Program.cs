using Hydac;
using System.ComponentModel.Design;

namespace Hydac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DashPage();
        }

        private static void DashPage()
        {
            try
            {
                Console.WriteLine("1. Medarbejder login\n2. Log ind som gæst\n3. Medarbejder logud\n4. Logud som gæst\n5. Log");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        LoginMedarbejder();
                        break;
                    case 2:
                        LoginGæst();
                        break;
                    case 3:
                        LogudMedarbejder();
                        break;
                    case 4:
                        LogudGæst();
                        break;
                    case 5:
                        OpenLog();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Vælg en mulighed!");
                        DashPage();
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Du skal vælge en af mulighederne");
                Console.Clear();
                DashPage();
                
            }
        }

        private static void OpenLog()
        {
            Console.WriteLine("Log\nKlik for at gå tilbage!");
        }

        private static void LogudGæst()
        {
            Console.Write("Navn: ");
            string username = Console.ReadLine();

            Console.Write("ID: ");
            int input = int.Parse(Console.ReadLine());
        }

        private static void LogudMedarbejder()
        {
            Console.Write("Navn: ");
            string username = Console.ReadLine();

            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());
        }

        private static void LoginGæst()
        {
            Console.Write("Navn: ");
            string name = Console.ReadLine();

            Console.Write("Ansvarlig: ");
            string ansvarlig = Console.ReadLine();
        }

        private static void LoginMedarbejder()
        {
            Personal check = new Personal();
            Console.Write("Brugernavn: ");
            string username = Console.ReadLine();

            Console.Write("ID: ");
            int idInput = int.Parse(Console.ReadLine());

            // A form for ID checker has been added, check file "Personal" and edit for new workers (temp solution)
            if (check.id(username, idInput) == true)
            {
                Console.WriteLine("I.D. Valid");
                Console.ReadLine();
                Console.Clear();
                DashPage();
            }
            else if (check.id(username, idInput) != true)
            {
                Console.WriteLine("Error");
                Console.ReadLine();
                Console.Clear();
                DashPage();
            }
        }
    }
}