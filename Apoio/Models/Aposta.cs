namespace Apoio.Models
{
    public class Aposta
    {
        public int Id { get; set; }
        public decimal Valor { get; set; }
        public decimal PrevisaoDeGanho { get; set; }
        public bool Vencedor { get; set; }
        public int ApostadorId { get; set; }
        public Apostador? Apostador { get; set; }
    }
}
