using XGame.Domain.Interfaces.Arguments;

namespace XGame.Domain.Arguments.Player
{
    public interface AddPlayerResponse : IResponse
    {
        public Guid Id { get; set; }

        public string Message { get; set; }
    }
}
