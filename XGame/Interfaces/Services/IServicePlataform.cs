using XGame.Domain.Arguments.Plataform;
using XGame.Domain.Arguments.Player;

namespace XGame.Domain.Interfaces.Services
{
    public interface IServicePlataform
    {
        AddPlataformResponse AddPlataform(AddPlataformRequest request);
    }
}
