using Microsoft.AspNetCore.Mvc.Formatters;

namespace Laba_2.Models
{
    public class Director
    {
        public Director() 
        {
            Films = new List <Film> ();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string BirthPlace { get; set; }
        public string Info { get; set; }
        public virtual ICollection<Film> Films { get; set; }

    }
}
