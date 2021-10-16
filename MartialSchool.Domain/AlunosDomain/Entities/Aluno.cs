using System.Collections.Generic;

namespace MartialSchool.Domain.Entities
{
    public class Aluno
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public List<int> ModalidadeIDs { get; set; }
        public List<int> GraduacaoIDs { get; set; }
    }
}
