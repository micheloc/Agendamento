using FluentValidation.Results;
namespace Agendamento.Services.Application.Interfaces._Base
{
    public interface IAppService<TEntity> where TEntity : class
    {
        ValidationResult Add(TEntity entity);
        ValidationResult Update(TEntity entity);
        ValidationResult Remove(TEntity entity);
        TEntity Find(Guid objID);
        IEnumerable<TEntity> GetAll();
        void Dispose();
    }
}
