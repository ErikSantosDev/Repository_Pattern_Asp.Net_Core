namespace DAL.Entities
{
    public class Cidade
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public int EstadoId { get; set; }

        public string Detalhes { get; set; }

        public virtual Estado Estado { get; set; }
    }
}
