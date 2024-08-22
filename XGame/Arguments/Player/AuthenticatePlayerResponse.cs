using XGame.Domain.ValueObjects;

namespace XGame.Domain.Arguments.Player
{
    public class AuthenticatePlayerResponse
    {
        public string name { get; set; }

        public string Email { get; set; }
        public string? Password { get; internal set; }
    }
}
