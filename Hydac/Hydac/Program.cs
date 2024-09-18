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
                Console.WriteLine("1. Medarbejder login\n2. Log ind som gæst\n3. Medarbejder logud\n4. Logud som gæst");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine("Login medarbejder");
                    break;
                    case 2:
                        Console.WriteLine("Login gæst");
                    break;
                    case 3:
                        Console.WriteLine("Logud medarbejder");
                    break;
                    case 4:
                        Console.WriteLine("Logud gæst");
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
    }
}
