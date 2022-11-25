using AgendaFinalAPI.Entities;
using AgendaFinalAPI.Models;
using AutoMapper;

namespace AgendaFinalAPI.Profiles
{
    public class UserProfile : Profile//esta clase yta viene con el nagguet 
    {
        public UserProfile()
        {//metodo defino la clase destino y la clase origen 
         //es un dto que esta en models 
            CreateMap<User, CreateAndUpdateUserDto>();
        }

    }
}