using HelpDeskWeb.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskWeb.Services.BaseServices
{
    public interface IBaseService<T> where T : Entity
    {
        IQueryable<T> GetAllRecords();
        IQueryable<T> GetAllRecords(Func<T, bool> predicate);
        T GetModel(Guid Id);
        T GetModel(Func<T, bool> predicate);
        T Save(T model);
        void Delete(Guid Id);
        void DeleteRange(Func<T, bool> predicate);
        void Passive(Guid Id);
        //SelectList GetSelectList(string columnName);
        void SaveRange(IEnumerable<T> inputs);
        bool Exist(Guid Id);
        bool Exist(Func<T, bool> predicate);
    }
}
