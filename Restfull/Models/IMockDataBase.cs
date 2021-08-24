using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restfull.Models
{
    public interface IMockDataBase<T>
    {
        Boolean Add(T model);
        Boolean Update(T model);
        Boolean Delete(int Place);
    }
}
