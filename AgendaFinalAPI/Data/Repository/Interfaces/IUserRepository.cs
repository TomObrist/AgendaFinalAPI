using AgendaFinalAPI.Models;
using AgendaFinalAPI.Entities;


namespace AgendaFinalAPI.Data.Repository.Interfaces
{
    public interface IUserRepository
    {//llamamos a la clase user parasu validacion y Autenticacion 
        //el cual la programamos en Controller/AuthenticationController
        public User? ValidateUser(AuthenticationRequestBody authRequestBody);
        //Usamos el ? para que sea obligatorio
        public User? GetById(int userId);//conectamos con el UserRepositori
        public List<User> GetAll();
        public void Create(CreateAndUpdateUserDto dto);
        public void Update(CreateAndUpdateUserDto dto);
        public void Delete(int id);
    }
}