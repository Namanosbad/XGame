using XGame.Domain.Arguments.Player;

namespace XGame.Domain.Interfaces.Services
{
    public interface IServicePlayer
    {
        AuthenticatePlayerResponse AuthenticatePlayer (AuthenticatePlayerResponse request);

        AddPlayerResponse AddPlayer(AddPlayerRequest request);
    }
}
