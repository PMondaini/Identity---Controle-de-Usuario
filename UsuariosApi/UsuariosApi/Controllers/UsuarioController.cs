using Microsoft.AspNetCore.Mvc;
using UsuariosApi.Data.DTO;
using UsuariosApi.Services;

namespace UsuariosApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private CadastroService _cadastroService;

        public UsuarioController(CadastroService cadastroService)
        {
            _cadastroService = cadastroService;
        }

        [HttpPost]
        public async Task<IActionResult> CadastraUsuario(CreateUsuarioDTO dto)
        {
            await _cadastroService.Cadastrar(dto);

            return Ok("Usuário cadastrado!");
        }
    }
}
