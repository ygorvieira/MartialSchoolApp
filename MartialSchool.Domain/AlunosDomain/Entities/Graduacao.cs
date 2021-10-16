namespace MartialSchool.Domain.Entities
{
    public class Graduacao
    {
        public int ID { get; set; }
        public int Nivel { get; set; }
        public int ModalidadeID { get; set; }
        public string Faixa { get; set; }
        public bool Instrutor { get; set; }
    }
}
