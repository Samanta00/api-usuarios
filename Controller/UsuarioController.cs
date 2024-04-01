using api_usuarios.Model;
using api_usuarios.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_usuarios.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController: ControllerBase
    {
        private readonly IUsuarioRepository _repository;

        public UsuarioController(IUsuarioRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var usuariosGet= await _repository.BuscaUsuarios();
            return usuariosGet.Any()
            ? Ok(usuariosGet)
            : NoContent();
            
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var usuariosGet= await _repository.BuscaUsuarioPorId(id);
            return usuariosGet != null
            ? Ok(usuariosGet)
            : NotFound("Usuário não encontrado");
        }
    }
}