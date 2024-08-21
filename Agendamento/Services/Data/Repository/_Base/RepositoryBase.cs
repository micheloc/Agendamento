using Agendamento.Services.Data.Context.Interfaces;
using Agendamento.Services.Domain.Interfaces.Repository._Base;
using Dapper;
using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agendamento.Services.Data.Repository._Base
{
    public class RepositoryBase<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly IDbContext _dbContext;
        public RepositoryBase(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        protected DbContext Context
        {
            get { return (DbContext)_dbContext; }
        }
        protected T GetValueFromQuery<T>(string query)
        {
            var connection = Context.Database.GetDbConnection();
            return connection.Query<T>(query).FirstOrDefault();
        }
        protected List<T> GetLstObjectFromQuery<T>(string query) where T : new()
        {
            var connection = Context.Database.GetDbConnection();
            // Usa Dapper para executar a consulta e mapear os resultados para uma lista de objetos T
            return connection.Query<T>(query).AsList();
        }
        public ValidationResult Add(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);

            ValidationResult vr = _dbContext.SaveChanges();

            return vr;
        }
        public TEntity Find(Guid objID)
        {
            return _dbContext.Set<TEntity>().Find(objID);
        }
        public IEnumerable<TEntity> GetAll()
        {
            return _dbContext.Set<TEntity>().ToList();
        }
        public ValidationResult Remove(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);
            return (_dbContext.SaveChanges());
        }
        public ValidationResult Update(TEntity entity)
        {
            var db_entries = _dbContext.Entry<TEntity>(entity).CurrentValues;
            _dbContext.Entry<TEntity>(entity).State = EntityState.Modified;

            //Use reflection to get the properties of the entity type
            var properties = typeof(TEntity).GetProperties();
            var identityProperty = properties.FirstOrDefault(p => p.GetCustomAttributes(typeof(DatabaseGeneratedAttribute), false).Cast<DatabaseGeneratedAttribute>().Any(a => a.DatabaseGeneratedOption == DatabaseGeneratedOption.Identity));
            if (identityProperty != null)
                _dbContext.Entry(entity).Property(identityProperty.Name).IsModified = false;


            //Ficar de olho caso geo sumir descomentar o codigo abaixo
            var geoProperty = properties.FirstOrDefault(p => p.GetCustomAttributes(typeof(ColumnAttribute), false).Cast<ColumnAttribute>().Any(a => a.TypeName == "geography"));
            if (geoProperty != null)
                _dbContext.Entry(entity).Property(geoProperty.Name).IsModified = false;

            return _dbContext.SaveChanges();
        }
    }
}
