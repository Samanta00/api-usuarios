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

        [HttpPost]
        public async Task <IActionResult> Post(Usuario usuario){
            _repository.AdicionarUsuario(usuario);
            return await _repository.SaveChangesAsync()
            ? Ok("Usuario adicionado com sucesso.")
            : BadRequest("Usuário não foi salvo por algum erro");
        }

        [HttpPut("{id}")]
        public async Task <IActionResult> Put(Usuario usuario, int id){
            var buscarUsuarioId = await _repository.BuscaUsuarioPorId(id);
            if(buscarUsuarioId == null)NotFound("Usuário não encontrado");

            buscarUsuarioId.Nome = usuario.Nome ?? buscarUsuarioId.Nome;
            buscarUsuarioId.DataNascimento= usuario.DataNascimento != new DateTime()?
            usuario.DataNascimento : buscarUsuarioId.DataNascimento;
//vai verificar se a data de nascimento está vázia no banco, se estiver vázia ele vai atualizar comparando com a data que estou passando na requisição.
       
            _repository.EditarInfoUsuario(buscarUsuarioId);

            return await _repository.SaveChangesAsync()
            ? Ok("Usuario atualizado com sucesso.")
            : BadRequest("Usuário não foi atualizado por algum erro");     
        }
    }
}