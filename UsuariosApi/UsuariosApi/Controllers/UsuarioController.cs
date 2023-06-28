using Microsoft.AspNetCore.Mvc;
using UsuariosApi.Data.DTO;

namespace UsuariosApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {

        [HttpPost]
        public IActionResult CadastraUsuario(CreateUsuarioDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
