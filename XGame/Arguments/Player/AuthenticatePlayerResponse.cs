using XGame.Domain.ValueObjects;

namespace XGame.Domain.Arguments.Player
{
    public class AuthenticatePlayerResponse
    {
        public Name name { get; set; }

        public Email email { get; set; }
    }
}
