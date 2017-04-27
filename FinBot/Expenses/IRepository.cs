using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinBot.Expenses
{
    public interface IRepository
    {
        IEnumerable<T> Select<T>();
    }
}