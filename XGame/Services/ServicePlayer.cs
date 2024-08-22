using XGame.Domain.Arguments.Player;
using XGame.Domain.Interfaces.Repositories;
using XGame.Domain.Interfaces.Services;
using XGame.Domain.ValueObjects;

namespace XGame.Domain.Services
{
    public class ServicePlayer : IServicePlayer
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
            Guid id = _repositoryPlayer.AddPlayer(request);

            return new AddPlayerResponse() { Id = id, Message = "successful" };
        }

        public AuthenticatePlayerResponse AuthenticatePlayer(AuthenticatePlayerResponse request)
        {

            var response = _repositoryPlayer.AuthenticatePlayer(request);
            return response;
        }

        public object AuthenticatePlayer(AuthenticatePlayerRequest request)
        {
            throw new NotImplementedException();
        }

        private bool IsEmail(string email)
        {

            return false;
        }

    }
}
