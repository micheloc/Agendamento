namespace Agendamento.Services.Domain.Entities
{
    public class Marca
    {
        public Guid objID { get; set; }
        public string fabricante { get; set; }

        public virtual ICollection<Veiculo> Veiculos { get; set; }
    }
}
