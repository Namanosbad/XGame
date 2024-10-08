﻿namespace XGame.Domain.Entities
{
    public class Game
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        
        public string Publisher { get; set; }

        public string Developer { get; set; }

        public string Genre { get; set; }

        public int Site { get; set; }

    }
}
