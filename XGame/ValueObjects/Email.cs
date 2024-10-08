﻿using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using XGame.Domain.Resources;

namespace XGame.Domain.ValueObjects
{
    public class Email : Notifiable
    {
        public Email(string address)
        {
            Address = address;

            new AddNotifications<Email>(this).IfNotEmail(x => x.Address, Message.X0_INVALID.ToFormat("Email"));
                }

        public string Address { get; private set; }
    }
}
