using Microsoft.AspNetCore.Mvc;
using UsuariosApi.Data.DTO;
using UsuariosApi.Services;

namespace UsuariosApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private UsuarioService _usuarioService;

        public UsuarioController(UsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost("cadastro")]
        public async Task<IActionResult> CadastraUsuario(CreateUsuarioDTO dto)
        {
            await _usuarioService.Cadastrar(dto);

            return Ok("Usuário cadastrado!");
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginUsuarioDto dto)
        {
            await _usuarioService.Login(dto);
            return Ok("Usuário Autenticado!");
        }
    }
}
