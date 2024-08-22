using XGame.Domain.Services;
using XGame.Domain.Arguments.Player;

namespace XGame.AppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start ....");

            var service = new ServicePlayer();
            Console.WriteLine("Instancia");
          
            AuthenticatePlayerRequest request = new AuthenticatePlayerRequest();
            Console.WriteLine("Object request");
            request.email = "paulo";

            var response = service.AuthenticatePlayer(request);

            Console.ReadKey();
        }
    }
}