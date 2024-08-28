using XGame.Domain.Services;
using XGame.Domain.Arguments.Player;
using XGame.Domain.ValueObjects;

namespace XGame.AppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start ....");

            var service = new ServicePlayer();
            Console.WriteLine("Instancia");
          
            //AuthenticatePlayerRequest request = new AuthenticatePlayerRequest();
            //Console.WriteLine("Object request");
            //request.Email = "paulo@paulo.com";
            //request.Password = "123456";

            var request = new AddPlayerRequest()
            {
                Email = "matheus.analista@gmail.com",
                FirstName = "Matheus Lima",
                LastName = "Amanda Luiza",
                Password = "123456",
            };

            var response = service.AddPlayer(request);

           // var response = service.AuthenticatePlayer(request);

            Console.WriteLine("Service is valid?" + service.IsValid());

            service.Notifications.ToList().ForEach(x => { Console.WriteLine(x.Message); });
            Console.ReadKey();
        }
    }
}