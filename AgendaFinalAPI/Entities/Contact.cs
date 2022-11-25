using AgendaFinalAPI.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgendaFinalAPI.Entities
{
    public class Contact
    {
        [Key]//es un atributo "principal" se puede decorar una clase, un método, una propiedad 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        // el DatabaseGenerated  indica que el valor de la propiedad seleccionada es generado por la base de datos
        // cada vez que se añade una nueva entidad a la base de datos en este caso seria en Identity
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }

        public string Email { get; set; }
        public int? CelularNumber { get; set; }
        public int? TelephoneNumber { get; set; }

        [ForeignKey("UserId")]//delcramos ForeignKey para que el userid
        //no  se le agreguen o inserten datos que no válidos 
        public User User { get; set; }
        public int UserId { get; set; }
    }
}
