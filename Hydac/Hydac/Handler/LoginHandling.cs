namespace Hydac.Handler
{
    internal class LoginHandling
    {

        public static void LoginGæst()
        {
            Console.Clear();
            Console.Write("Firma: ");
            string email = Console.ReadLine();

            Console.Write("Navn: ");
            string navn = Console.ReadLine();

            Console.Write("Ansvarligs navn: ");
            string Accountable = Console.ReadLine();

            Console.WriteLine("Login velykket! Klik for at forsætte");
            Console.ReadKey();

            Console.Clear();
            UI.DashPage();
        }

        public static void LoginMedarbejder()
        {
            Console.Clear();
            Console.WriteLine("Udfyld felterne");
            Console.Write("Email: ");
            string username = Console.ReadLine();

            Console.Write("ID: ");
            int ID = int.Parse(Console.ReadLine());

            Console.WriteLine("Login velykket! Klik for at forsætte");
            Console.ReadKey();

            Console.Clear();
            UI.DashPage();

        }
    }
}