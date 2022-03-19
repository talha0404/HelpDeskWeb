using HelpDeskWeb.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskWeb.Services.BaseServices
{
    public class BaseService<T> : IBaseService<T> where T : Entity
    {
    }
}
