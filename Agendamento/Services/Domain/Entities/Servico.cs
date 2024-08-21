namespace Agendamento.Services.Domain.Entities
{
    public class Servico
    {
        public Guid objID { get; set; } 
        public Guid IdCategoria { get; set; }
        public decimal custo { get; set; }
        public string tempo { get; set; }

        public virtual Categoria Categoria { get; set; } 
        public virtual ICollection<ClienteVeiculo> ClienteVeiculos { get; set; }   
        public virtual ICollection<AgendarServico> AgendarServicos { get; set;}
    }
}
