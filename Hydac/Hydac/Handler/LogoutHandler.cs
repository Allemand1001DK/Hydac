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
            Console.Write("Firma: ");
            string firma = Console.ReadLine(); ;

            Console.Write("Navn: ");
            string username = Console.ReadLine();

            Console.WriteLine("Logud velykket! Klik for at forsætte");
            Console.ReadKey();

            Console.Clear();
            Program.DashPage();
        }

        public static void LogudMedarbejder()
        {
            Console.Write("Email: ");
            string username = Console.ReadLine();

            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Logud velykket! Klik for at forsætte");
            Console.ReadKey();

            Console.Clear();
            Program.DashPage();
        }
    }
}
