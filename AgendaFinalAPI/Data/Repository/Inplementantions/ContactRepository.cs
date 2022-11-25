using AgendaFinalAPI.Data.Repository.Interfaces;
using AgendaFinalAPI.Entities;
using AgendaFinalAPI.Models;
using AutoMapper;
//Creamos los repository de la API
//y los inyectamos a los controladores usando inyeccion de dependencia.
//Los respository se encargan de proveer contacto con la Fakedata a los controladores
namespace AgendaFinalAPI.Data.Repository.Implementations
{
    public class ContactRepository : IContactRepository
    {
        private readonly AgendaContext _context;
        private readonly IMapper _mapper;

        public ContactRepository(AgendaContext context, IMapper autoMapper)
        {
            _context = context;
            _mapper = autoMapper;
        }
        public List<Contact> GetAll()
        {
            return _context.Contacts.ToList();
        }

        public void Create(CreateAndUpdateContact dto)
        {
            _context.Contacts.Add(_mapper.Map<Contact>(dto));
        }

        public void Update(CreateAndUpdateContact dto)
        {
            _context.Contacts.Update(_mapper.Map<Contact>(dto));
        }
        public void Delete(int id)
        {
            _context.Contacts.Remove(_context.Contacts.Single(c => c.Id == id));
        }
    }
}
