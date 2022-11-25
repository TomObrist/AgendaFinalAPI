using AgendaFinalAPI.Data.Repository.Interfaces;
using AgendaFinalAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
// EN ESTE AEREA 
//los controllers o controladores son los objetos que se ejecutan al recibir una petición.

namespace AgendaFinalAPI.Controllers
{
    [Route("api/[controller]")] //Con el Route se mapea a una ruta en específico. 
    [ApiController]
    [Authorize]//Sirve para autorizar 
    public class ContactController : ControllerBase
    {//el private reandoli 
     //evita que el campo se reemplace por una instancia diferente del tipo de referencia
     //con el _Nombre se declara 
        private readonly IContactRepository _contactRepository;

        public ContactController(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        [HttpGet]//solicita una peticion de un recurso específico solo recuperan los datos
        public IActionResult GetAll()//es una interfaz que nos permite regresar el estatus de una petición
        {

            return Ok(_contactRepository.GetAll());
        }

        [HttpGet]
        [Route("{Id}")]//En esta parte Routeamos Con el ID Del contacto 
        public IActionResult GetOne(int Id)
        {
            return Ok(_contactRepository.GetAll().Where(x => x.Id == Id));//Codigo LinQ
        }//En esta parte retornamos del repositori id que sea igual al solicitado 


        [HttpPost]//Con esto enviamos los datos o una petucon al "Servidor"
        public IActionResult CreateContact(CreateAndUpdateContact createContactDto)
        {                   //Aca creamo Un nuevo contacto y () hacemos una "acctualizacion de los contactos 
            //y luego lo enlazamos con el createDTO
            try // esto es un bloque 
            {
                _contactRepository.Create(createContactDto);
            }//seguido de una clausula 
            catch (Exception ex)//en te segmento interceptamos la Exceptiones 
            {
                return BadRequest(ex.Message);
            }
            return Created("Created", createContactDto);
        }

        [HttpPut]
        public IActionResult UpdateContact(CreateAndUpdateContact dto)
        {
            try
            {
                _contactRepository.Update(dto); // usamos la private.update para acctulizar el DTO
            }
            catch (Exception ex)
            {// con el Return devolvemos la peticin colisitada 
                return BadRequest(ex);
            }
            return NoContent();
        }

        [HttpDelete]//Realizamos la eliminacion del contacto 
        public IActionResult DeleteContactById(int id)
        {//Lo eliminamos por el ID del Contactacto 
            try
            {
                _contactRepository.Delete(id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);// indica que no se puede o no se quiere  
            }// procesar la solicitud pedida por el cliente 
            return Ok();
        }
    }
}
