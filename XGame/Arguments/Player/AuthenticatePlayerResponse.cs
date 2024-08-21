using XGame.Domain.ValueObjects;

namespace XGame.Domain.Arguments.Player
{
    public class AuthenticatePlayerResponse
    {
        public Name name { get; set; }

        public Email Email { get; set; }
        public string? Password { get; internal set; }
    }
}
