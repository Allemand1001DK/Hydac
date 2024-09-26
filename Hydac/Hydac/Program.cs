using Hydac.Handler;
using System.ComponentModel.Design;

namespace Hydac
{
    internal class Program : LoginHandling
    {
        UI UI = new UI();
        static void Main(string[] args)
        {
            UI.DashPage();
        }        
    }
}