namespace Hydac.Handler
{
    internal class LoginHandling
    {
        public static void LoginGæst()
        {
            // Ryd konsollen og bed brugeren om at indtaste firmaets navn
            Console.Clear();
            Console.Write("Firma: ");
            string email = Console.ReadLine();

            // Bed brugeren om at indtaste deres navn
            Console.Write("Navn: ");
            string navn = Console.ReadLine();

            // Bed brugeren om at indtaste den ansvarliges navn
            Console.Write("Ansvarligs navn: ");
            string Accountable = Console.ReadLine();

            // Bekræft login og vent på brugerens input for at fortsætte
            Console.WriteLine("Login velykket! Klik for at forsætte");
            Console.ReadKey();

            // Ryd konsollen og gå tilbage til dashboard-siden
            Console.Clear();
            UI.DashPage();
        }

        public static void LoginMedarbejder()
        {
            // Ryd konsollen og bed brugeren om at udfylde felterne
            Console.Clear();
            Console.WriteLine("Udfyld felterne");
            Console.Write("Email: ");
            string username = Console.ReadLine();

            // Bed brugeren om at indtaste deres ID
            Console.Write("ID: ");
            int ID = int.Parse(Console.ReadLine());

            // Bekræft login og vent på brugerens input for at fortsætte
            Console.WriteLine("Login velykket! Klik for at forsætte");
            Console.ReadKey();

            // Ryd konsollen og gå tilbage til dashboard-siden
            Console.Clear();
            UI.DashPage();
        }
    }
}