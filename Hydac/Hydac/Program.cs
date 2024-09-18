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
            Console.WriteLine("Logud gæst");
        }

        private static void LogudMedarbejder()
        {
            Console.WriteLine("Logud medarbejder");
        }

        private static void LoginGæst()
        {
            Console.WriteLine("Login gæst");
        }

        private static void LoginMedarbejder()
        {
            Console.Write("Brugernavn");
            string username = Console.ReadLine();

            Console.Write("ID: ");
            string idInput = Console.ReadLine();

            Console.WriteLine("testc add");
        }
    }
}