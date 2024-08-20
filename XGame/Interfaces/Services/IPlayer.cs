using XGame.Domain.Arguments.Player;

namespace XGame.Domain.Interfaces.Services
{
    public interface IPlayer
    {
        AuthenticatePlayerResponse AuthenticatePlayer (string Email, string Password);

        AddPlayerResponse AddPlayer (AddPlayerRequest request)
    }
}
