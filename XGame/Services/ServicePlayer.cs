using XGame.Domain.Arguments.Player;
using XGame.Domain.Entities;
using XGame.Domain.Interfaces.Repositories;
using XGame.Domain.Interfaces.Services;
using XGame.Domain.ValueObjects;
using XGame.Domain.Enums;
using XGame.Domain.Interfaces.Arguments;
using prmToolkit.NotificationPattern;

namespace XGame.Domain.Services
{
    public class ServicePlayer : Notifiable, IServicePlayer
    {
        private readonly IRepositoryPlayer _repositoryPlayer;

        public ServicePlayer()
        {

        }
        public ServicePlayer(IRepositoryPlayer repositoryPlayer)
        {
            _repositoryPlayer = repositoryPlayer;
        }

        public AddPlayerResponse AddPlayer(AddPlayerRequest request)
        {
            Player player = new Player();
            player.Email = request.Email;
            player.Name = request.Name;
            player.statusPlayer = EnumStatusPlayer.InProgress;

            Guid id = _repositoryPlayer.AddPlayer(request);

            return new AddPlayerResponse() { Id = id, Message = "successful" };
        }

        public AuthenticatePlayerResponse AuthenticatePlayer(AuthenticatePlayerResponse request)
        {
            if (request == null)
            {
               AddNotification("AuthenticatePlayerRequest", "AuthenticatePlayerRequest is required");
            }

            var email = new Email("Paulo");
            var player = new Player(email, "222");
            AddNotifications(player, email);

            var response = _repositoryPlayer.AuthenticatePlayer(request);
            return response;
        }

        public object AuthenticatePlayer(AuthenticatePlayerRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
