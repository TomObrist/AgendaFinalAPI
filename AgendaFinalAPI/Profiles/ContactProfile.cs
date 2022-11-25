using AgendaFinalAPI.Entities;
using AgendaFinalAPI.Models;
using AutoMapper;

namespace AgendaFinalAPI.Profiles
{
    public class ContactProfile : Profile
    {
        public ContactProfile()
        {
            CreateMap<Contact, CreateAndUpdateContact>();
        }
    }
}
