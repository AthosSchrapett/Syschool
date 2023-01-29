using Syschool.Domain.Entities.Genericos;

namespace Syschool.Domain.Entities
{
    public class Aluno : DadosPrincipais
    {
        public string Matricula { get; set; }
        public DateTime DataMatricula { get; set; }
    }
}
