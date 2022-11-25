using AgendaFinalAPI.Data.Repository.Interfaces;
using AgendaFinalAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AgendaFinalAPI.Controllers
{//decorardor 
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserController : ControllerBase
    {//instaciamos para accedor a los datos del repositorio        
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]//decorador para crear un endepoint tipo get 
        public IActionResult GetAll()//el OK es el estutus code 200
        {//es una clase lo detecta como una repons 
            {
                return Ok(_userRepository.GetAll());
                
            }
         }

        [HttpDelete]
        [Route("{Id}")]
        public IActionResult DeleteUser(int Id)
        {
            try
            {
                _userRepository.Delete(Id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
            return Ok();
        }
        

        public IActionResult UpdateUser(CreateAndUpdateUserDto dto)
        {
            try
            {
                _userRepository.Update(dto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
            return NoContent();
        }

        public IActionResult CreateUser(CreateAndUpdateUserDto dto)
        {
            try
            {
                _userRepository.Create(dto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
            return Created("Created", dto);
        }

        public IActionResult GetOneById(int Id)
        {
            try
            {
                return Ok(_userRepository.GetById(Id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
//Permite endpoints
//preguntar al profe
//bodi repons,inyeccion de dependencia 
                //try
                //{
                //    return Ok(_userRepository.GetAll());
                //}
                //catch (Exception ex)
                //{
                //    return BadRequest(ex.Message);
                //}
