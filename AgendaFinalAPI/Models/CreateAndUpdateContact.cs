using AgendaFinalAPI.Entities;
using System.ComponentModel.DataAnnotations;

namespace AgendaFinalAPI.Models
{
    public class CreateAndUpdateContact
    {
        [Required]
        public string Name { get; set; }
        public string Lastname { get; set; }

        public string Eamil { get; set; }
        public int? CelularNumber { get; set; }
        public int? TelephoneNumber { get; set; }

 
        public User? User;
    }
}
