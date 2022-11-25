using AgendaFinalAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace AgendaFinalAPI.Data
//AgendaContext” que herede de “DbContext”
{//Agregarle un constructor que recibe las opciones desde el program.cs
 //y los data sets de las entidades que queremos guardar en la base de datos.


    //Agregarle un constructor que recibe las opciones desde el program.cs y
    //los data sets de las entidades que queremos guardar en la base de datos.
    public class AgendaContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        //constructor erredado el dbcontext y parametro
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {
            //Acá estamos llamando al constructor de DbContext que es el que acepta las opciones
        }
        //modificacion de accebilidad 
        protected override void OnModelCreating(ModelBuilder modelBuilder)//se usa para construir modelo de contexto invalidando
        {
            User tomas = new User()
            {
                Id = 1,
                Name = "Tomas",
                LastName = "Obrist",
                Password = "12334",
                Email = "tomasobrist@gmail.com",                
            };
            

            Contact jaimitoC = new Contact()
            {
                Id = 1,
                Name = "Jaimito",
                CelularNumber = 341457896,
                Email = "Jaimi@gmail.com",
                TelephoneNumber = null,
                UserId = tomas.Id,
            };

            
            Contact mariaC = new Contact()
            {
                Id = 3,
                Name = "Maria",
                CelularNumber = 011425789,
                Email = "mariaC@gmail.com",
                TelephoneNumber = null,
                UserId = tomas.Id,
            };

            modelBuilder.Entity<User>().HasData(
                tomas );

            modelBuilder.Entity<Contact>().HasData(
                 jaimitoC, mariaC
                 );

            modelBuilder.Entity<User>()
              .HasMany<Contact>(u => u.Contacts)
              .WithOne(c => c.User);

            base.OnModelCreating(modelBuilder);
        }
    }
}

//CON EL DbSet<User>  ESPESIFICANDO MIS ENTIDADES QUE SON TABLAS 
//SE USA EN EL CONCEPTO DBSET SON TABLAS, SON INSTRUCCION DEL ORM MAPE MIS OBJETOS 
//  MIS ENTDIADES A TABLAS. EN ESTE APARTADO TRBAJAMOS LA BASE DE DATO
// SIEMPRE Y CUANDO ESTE EN EL CONTEXTO 
//options es el  parametro 
// poniendo options: base(options) llamo 1 constructor  de la clase padre
// es una sobrecarga 
//dbset es un tipo de dato/clase es muy similar a un objeto 1 tabla tranformado a un objeto 
//