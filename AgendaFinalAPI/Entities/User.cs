using AgendaFinalAPI.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgendaFinalAPI.Entities
{
    public class User
    {
        [Key]//clave primaria
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string UserName { get; set; }
        public ICollection<Contact> Contacts { get; set; }
    }
}
//Icollection: Uso la icollection maximo nivel de extraccion, cual quier clase 
// que implemnte es valida, una interfaz 
//En entities se encuentra las 2 clases contac y users$#"!"$$=?¡