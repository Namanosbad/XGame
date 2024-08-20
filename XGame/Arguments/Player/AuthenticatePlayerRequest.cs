using XGame.Domain.ValueObjects;

namespace XGame.Domain.Arguments.Player
{
    internal class AuthenticatePlayerRequest
    {
        public Email email { get; set; }

        public string Password { get; set; }
    }
}
