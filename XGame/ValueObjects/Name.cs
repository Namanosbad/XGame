using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using XGame.Domain.Resources;

namespace XGame.Domain.ValueObjects
{
    public class Name : Notifiable
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            new AddNotifications<Name>(this)
            .IfNullOrInvalidLength(x => x.FirstName, 3, 50, Message.X0_REQUIRED_AND_MUST_CONTAIN_X1_AND_X2_CHARACTERS.ToFormat("Fist Name", "3", "50"))
            .IfNullOrInvalidLength(x => x.LastName, 3, 50, Message.X0_REQUIRED_AND_MUST_CONTAIN_X1_AND_X2_CHARACTERS.ToFormat("Last Name", "3", "50"));

        }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }
    }
}
