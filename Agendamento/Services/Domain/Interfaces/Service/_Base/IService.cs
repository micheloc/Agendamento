using FluentValidation.Results;

namespace Agendamento.Services.Domain.Interfaces.Service._Base;
public interface IService<TEntity> where TEntity : class
{
    TEntity Find(Guid objID);
    IEnumerable<TEntity> GetAll();
    ValidationResult Add(TEntity entity);
    ValidationResult Update(TEntity entity);
    ValidationResult Remove(TEntity entity);
    void Dispose();
}
