namespace XGame.Domain.Entities
{
    internal class MyGame
    {

        public Guid Id { get; set; }

        public GamePlataform GamePlataform { get; set; }

        public bool Wish { get; set; }

        public DateTime DateWish { get; set; }

        public bool Trade { get; set; }

        public bool Sell { get; set; }
    }
}
