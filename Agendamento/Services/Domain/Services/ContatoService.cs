using Agendamento.Services.Domain.Entities;
using Agendamento.Services.Domain.Interfaces.Repository;
using Agendamento.Services.Domain.Interfaces.Service;
using Agendamento.Services.Domain.Services._Base;

namespace Agendamento.Services.Domain.Services
{
    public class ContatoService : Service<Contato>, IContatoService
    {
        private readonly IContatoRepository _contatoRepository;
        public ContatoService(IContatoRepository repository)
            : base(repository)
        {
            _contatoRepository = repository;
        }
    }

}
