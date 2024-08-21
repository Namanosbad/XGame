using XGame.Domain.Arguments.Player;
using XGame.Domain.Interfaces.Repositories;
using XGame.Domain.Interfaces.Services;

namespace XGame.Domain.Services
{
    public class ServicePlayer : IServicePlayer
    {
        private readonly IRepositoryPlayer _repositoryPlayer;

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
            if (request == null)
            {
                throw new Exception("AuthenticatePlayer is required");
            }
        }
}
