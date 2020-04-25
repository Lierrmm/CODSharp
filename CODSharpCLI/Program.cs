using System;
using System.Threading.Tasks;
using CODSharp;

namespace CODSharpCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            Login().ConfigureAwait(false);
            Console.ReadKey();
        }

        static async Task Login()
        {
            var requests = new Requests();
            var loggedIn = await requests.Login("<username>", "<password>");
            if (loggedIn) await requests.MWwz("Lierrmm#2364", "battle");
        }
    }
}
