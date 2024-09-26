using Hydac.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydac
{
    internal class UI
    {
        public static void DashPage()
        {
            try
            {
                // Vis menu muligheder til brugeren
                Console.WriteLine("1. Medarbejder login\n2. Log ind som gæst\n3. Medarbejder logud\n4. Logud som gæst\n5. Log");

                // Læs brugerens input og parse det til en integer
                int input = int.Parse(Console.ReadLine());

                // Håndter brugerens input baseret på den valgte mulighed
                switch (input)
                {
                    case 1:
                        // Kald metode for at håndtere medarbejder login
                        LoginHandling.LoginMedarbejder();
                        break;
                    case 2:
                        // Kald metode for at håndtere gæst login
                        LoginHandling.LoginGæst();
                        break;
                    case 3:
                        // Kald metode for at håndtere medarbejder logud
                        LogoutHandler.LogudMedarbejder();
                        break;
                    case 4:
                        // Kald metode for at håndtere gæst logud
                        LogoutHandler.LogudGæst();
                        break;
                    case 5:
                        // Kald metode for at åbne loggen
                        OpenLog();
                        break;
                    default:
                        // Ryd konsollen og bed brugeren om at vælge en gyldig mulighed
                        Console.Clear();
                        Console.WriteLine("Vælg en mulighed!");
                        DashPage();
                        break;
                }
            }
            catch (Exception ex)
            {
                // Ryd konsollen og genindlæs dashboard-siden i tilfælde af en undtagelse
                Console.Clear();
                DashPage();
            }
        }

        private static void OpenLog()
        {
            // Ryd konsollen og vis log information
            Console.Clear();
            Console.WriteLine("Log\nKlik for at gå tilbage!");

            // Vent på brugerens input før konsollen ryddes og dashboard-siden genindlæses
            Console.ReadKey();
            Console.Clear();
            DashPage();
        }
    }
}
