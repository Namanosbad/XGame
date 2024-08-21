using XGame.Domain.Arguments.Player;
using XGame.Domain.Interfaces.Repositories;
using XGame.Domain.Interfaces.Services;
using XGame.Domain.ValueObjects;

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

            if (string.IsNullOrEmpty(request.Email.Address))
            { throw new Exception("sada");
            } 

            if (IsEmail(request.Email))
            { throw new Exception(""); 
            }

            if (string.IsNullOrEmpty(request.Password))
            { throw new Exception("");
            }

            if (request.Password.Length < 6) {
                throw new Exception("");
        }
            var response = _repositoryPlayer.AuthenticatePlayer(request);
            return response;
        }

        private bool IsEmail(Email email)
        {

            return false;
        }

    }
}
