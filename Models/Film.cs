namespace Laba_2.Models
{
    public class Film
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public int Year { get; set; }
        public decimal Budget { get; set; }
        public int FilmStudioId { get; set; }
        public int DirectorId { get; set; }
        public int GenreId { get; set; }
        public int ActorId { get; set; }
        public virtual FilmStudio FilmStudio { get; set; }
        public virtual Director Director { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual Actor Actor { get; set; }


    }
}
