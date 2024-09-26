using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydac.Handler
{
    internal class LogoutHandler
    {
        public static void LogudGæst()
        {
            // Bed brugeren om at indtaste firmaets navn
            Console.Write("Firma: ");
            string firma = Console.ReadLine();

            // Bed brugeren om at indtaste deres navn
            Console.Write("Navn: ");
            string username = Console.ReadLine();

            // Bekræft logud og vent på brugerens input for at fortsætte
            Console.WriteLine("Logud velykket! Klik for at forsætte");
            Console.ReadKey();

            // Ryd konsollen og gå tilbage til dashboard-siden
            Console.Clear();
            UI.DashPage();
        }

        public static void LogudMedarbejder()
        {
            // Bed brugeren om at indtaste deres email
            Console.Write("Email: ");
            string username = Console.ReadLine();

            // Bed brugeren om at indtaste deres ID
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());

            // Bekræft logud og vent på brugerens input for at fortsætte
            Console.WriteLine("Logud velykket! Klik for at forsætte");
            Console.ReadKey();

            // Ryd konsollen og gå tilbage til dashboard-siden
            Console.Clear();
            UI.DashPage();
        }
    }
}
