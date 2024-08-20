using XGame.Domain.Arguments.Player;

namespace XGame.Domain.Interfaces.Services
{
    public interface IPlayer
    {
        AuthenticatePlayerResponse AuthenticatePlayer (AuthenticatePlayerResponse request);

        AddPlayerResponse AddPlayer (AddPlayerRequest request)
    }
}
