using XGame.Domain.Arguments.Player;

namespace XGame.Domain.Interfaces.Repositories
{
    public interface IRepositoryPlayer
    {
        AuthenticatePlayerResponse AuthenticatePlayer(AuthenticatePlayerResponse request);

        Guid AddPlayer(AddPlayerRequest request);
    }
}
