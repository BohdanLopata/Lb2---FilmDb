namespace Laba_2.Models
{
    public class Genre
    {
        public Genre()
        {
            Films = new List <Film> (); 
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Type { get; set; }
        public virtual ICollection<Film> Films { get; set; }
    }
}
