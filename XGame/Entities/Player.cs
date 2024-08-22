using prmToolkit.NotificationPattern;
using XGame.Domain.Enums;
using XGame.Domain.Interfaces.Arguments;
using XGame.Domain.ValueObjects;

namespace XGame.Domain.Entities
{
    public class Player : Notifiable
    {
        public Player() { }
        public Player(Email email, string password)
        {
            Email = email;
            Password = password;

            new AddNotifications<Player>(this)
                .IfNotEmail(x => x.Email.Address, "Provide a valid email address")
                .IfNullOrInvalidLength(X=>X.Password, 6, 32, "The password must be between 6 and 32 characters long. ");
        }

        public Guid Id { get; set; }

        public Name Name { get; set; }

        public Email Email { get; set; }

        public string Password { get; set; }

        public EnumStatusPlayer statusPlayer { get; set; }

    }
}
