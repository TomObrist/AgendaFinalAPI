using AgendaFinalAPI.Controllers;
using AgendaFinalAPI.Data.Repository.Interfaces;
using AgendaFinalAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace AgendaTest
{
    public class UnitTest1
    {
        private readonly IUserRepository _userRepository;
        private readonly IConfiguration _config;

        [Fact]
        public void AutenticarConUusarioFalso()
        { //preparacion de la prueba 
            AuthenticationController authecontroller = new AuthenticationController(_config, _userRepository);
            AuthenticationRequestBody body = new AuthenticationRequestBody
            {
                Password = "123",
                UserName = "pepito"


            };
            //ejecucion de la prueba 
            var response = authecontroller.Autenticar(body);

            Assert.IsType<UnauthorizedObjectResult>(response);

        }
    }
}