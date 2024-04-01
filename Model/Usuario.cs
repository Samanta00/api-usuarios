
namespace api_usuarios.Model
{
    public class Usuario
    {
        public int ID { get; set; }

        public string Nome{ get; set; }

        public string Profissao { get; set;}
        public string Departamento{ get; set;}

        public string Cidade{ get; set;}



        public DateTime DataNascimento { get; set; }
    
    }
}