﻿using XGame.Domain.ValueObjects;

namespace XGame.Domain.Arguments.Player
{
    public class AuthenticatePlayerRequest
    {
        public string email { get; set; }

        public string Password { get; set; }
    }
}
