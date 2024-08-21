﻿using Agendamento.Services.Data.Context.Interfaces;
using Agendamento.Services.Data.Repository._Base;
using Agendamento.Services.Domain.Entities;
using Agendamento.Services.Domain.Interfaces.Repository;

namespace Agendamento.Services.Data.Repository;

public class EspecialidadeRepository : RepositoryBase<Especialidade>, IEspecialidadeRepository
{
    public EspecialidadeRepository(IDbContext dbContext) : base(dbContext)
    {
    }
}