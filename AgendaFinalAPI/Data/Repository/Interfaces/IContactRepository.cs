using AgendaFinalAPI.Entities;
using AgendaFinalAPI.Models;
//Las interfaces son como contratos en este caso son  implementación predeterminada  
namespace AgendaFinalAPI.Data.Repository.Interfaces
{//el interface
 //contiene la definicion de la funcionalidad de una classe 
    public interface IContactRepository
    {
        public List<Contact> GetAll();
        public void Create(CreateAndUpdateContact dto);
        public void Update(CreateAndUpdateContact dto);
        public void Delete(int id);
    }
}

//aca invocamos y traemos la funcionalidad necesitada  de los controllers
