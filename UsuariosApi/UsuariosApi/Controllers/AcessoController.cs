using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace UsuariosApi.Controllers
{
    [Controller]
    [Route("[Controller]")]

    public class AcessoController : ControllerBase
    {
        [HttpGet]
        [Authorize(Policy = "IdadeMinima")] //Authorize é usado como uma condição para poder acessar o método
        public IActionResult Get()
        {
            return Ok("Acesso Permitido");
        }
    }
}
