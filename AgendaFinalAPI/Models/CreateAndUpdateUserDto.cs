using System.ComponentModel.DataAnnotations;

namespace AgendaFinalAPI.Models
{
    public class CreateAndUpdateUserDto
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        [Required]//Asegura que el valor debe ser proporcionado a la propiedad del modelo.
        public string Email { get; set; }
        [Required]
        public string UserName { get; set; }
    }
}
