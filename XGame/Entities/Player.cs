using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using XGame.Domain.Enums;
using XGame.Domain.Extensions;
using XGame.Domain.Interfaces.Arguments;
using XGame.Domain.Resources;
using XGame.Domain.ValueObjects;

namespace XGame.Domain.Entities
{
    public class Player : Notifiable
    {
        public Player(Email email, string password)
        {
            Email = email;
            Password = password;

            new AddNotifications<Player>(this)
                .IfNullOrInvalidLength(X=>X.Password, 6, 32, "The password must be between 6 and 32 characters long. ");
        }

        public Player(Name name, Email email, string password)
        {
            Name = name;
            Email = email;
            Password = password;

            new AddNotifications<Player>(this).IfNullOrInvalidLength(X => X.Password, 6, 32, Message.X0_REQUIRED_AND_MUST_CONTAIN_X1_AND_X2_CHARACTERS.ToFormat("Password", "6", "32"));
            Password = Password.ConvertToMD5();

            AddNotifications(name, email);
        }

        public Guid Id { get; private set; }

        public Name Name { get; private set; }

        public Email Email { get; private set; }

        public string Password { get; private set; }

        public EnumStatusPlayer statusPlayer { get; private set; }

    }
}
