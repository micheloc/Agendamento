using Agendamento.Services.Domain.Interfaces.Service._Base;
using FluentValidation.Results;

namespace Agendamento.Services.Application.AppService._Base;
public class AppService<TEntity> : IDisposable where TEntity : class
{
    private readonly IService<TEntity> _service;

    protected ValidationResult Result { get; set; }

    #region Ctor
    public AppService(IService<TEntity> service)
    {
        this._service = service;
        this.Result = new ValidationResult();
    }
    #endregion

    #region CRUD
    public ValidationResult Add(TEntity entity)
    {
        Result = _service.Add(entity);
        return Result;
    }

    public ValidationResult Update(TEntity entity)
    {
        Result = _service.Update(entity);
        return Result;
    }

    public ValidationResult Remove(TEntity entity)
    {

        Result = _service.Remove(entity);
        return Result;
    }

    public TEntity Find(Guid objID)
    {
        return _service.Find(objID);
    }

    public IEnumerable<TEntity> GetAll()
    {
        return _service.GetAll();
    }
    #endregion

    public void Dispose()
    {
        _service.Dispose();
        GC.SuppressFinalize(this);
    }
}
