using HelpDeskWeb.Domain.Base;
using HelpDeskWeb.EFCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskWeb.Services.BaseServices
{
    public class BaseService<T> : IBaseService<T> where T : Entity
    {
        private readonly HelpDeskWebDbContext _helpDeskWebDbContext;
        private readonly DbSet<T> _dbSet;

        public BaseService(HelpDeskWebDbContext helpDeskWebDbContext)
        {
            _helpDeskWebDbContext = helpDeskWebDbContext;
            _dbSet = _helpDeskWebDbContext.Set<T>(); // We are taking Table to query
        }

        public void Delete(Guid Id)
        {
            throw new NotImplementedException();
        }

        public void DeleteRange(Func<T, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Exist(Guid Id)
        {
            throw new NotImplementedException();
        }

        public bool Exist(Func<T, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAllRecords()
        {
            var query = _dbSet.AsNoTracking().Where(x => !x.IsDeleted);

            return query;
        }

        public IQueryable<T> GetAllRecords(Func<T, bool> predicate)
        {
            var query = _dbSet
                .AsNoTracking()
                .Where(predicate) // We can add condition from out 
                .Where(x => !x.IsDeleted)
                .AsQueryable();

            return query;
        }

        public T GetModel(Guid Id)
        {
            var query = _dbSet
                .AsNoTracking()
                .Where(x => !x.IsDeleted)
                .Where(x => string.Equals(x.Guid.ToString(), Id.ToString(), StringComparison.OrdinalIgnoreCase))
                .FirstOrDefault();

            return query;
        }

        public T GetModel(Func<T, bool> predicate)
        {
            var query = _dbSet
                           .AsNoTracking()
                           .Where(predicate) // We can add condition from out 
                           .Where(x => !x.IsDeleted).FirstOrDefault();
            return query;
        }

        public void Passive(Guid Id)
        {
            var data = _dbSet.Where(x => x.Guid.Equals(Id)).FirstOrDefault();

            if (!object.Equals(data, null))
            {
                data.IsDeleted = true;
                _helpDeskWebDbContext.SaveChanges();
            }
        }

        public T Save(T model)
        {
            throw new NotImplementedException();
        }

        public void SaveRange(IEnumerable<T> inputs)
        {
            throw new NotImplementedException();
        }
    }
}
