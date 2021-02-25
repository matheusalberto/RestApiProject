namespace RestApiProject.Domain.Entities
{
    public class Produto : EntidadeBase
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public bool Disponivel { get; set; }
    }
}
