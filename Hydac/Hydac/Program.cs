using Hydac.Handler;
using System.ComponentModel.Design;

namespace Hydac
{
    internal class Program : LoginHandling
    {
        LoginHandling loginUser = new LoginHandling();
        LogoutHandler LogoutUser = new LogoutHandler();
        static void Main(string[] args)
        {
            DashPage();
        }

        public static void DashPage()
        {
            try
            {
                Console.WriteLine("1. Medarbejder login\n2. Log ind som gæst\n3. Medarbejder logud\n4. Logud som gæst\n5. Log");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        LoginHandling.LoginMedarbejder();
                        break;
                    case 2:
                        LoginHandling.LoginGæst();
                        break;
                    case 3:
                        LogoutHandler.LogudMedarbejder();
                        break;
                    case 4:
                        LogoutHandler.LogudGæst();
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
                Console.Clear();
                DashPage();

            }
        }

        private static void OpenLog()
        {
            Console.WriteLine("Log\nKlik for at gå tilbage!");
        }

        
    }
}