namespace Laba_2.Models
{
    public class FilmStudio
    {
        public FilmStudio()
        {
            Films = new List <Film> ();
        }
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string? Info { get; set; }
        public virtual ICollection<Film> Films { get; set; }

    }
}
