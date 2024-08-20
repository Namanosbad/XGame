namespace XGame.Domain.Entities
{
    internal class GamePlataform
    {
        public Guid Id { get; set; }
    
        public Game Game { get; set; }

        public Plataform Plataform {  get; set; }

        public DateTime ReleaseDate { get; set; }

    }
}
