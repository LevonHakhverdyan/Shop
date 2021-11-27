using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Base
{
    public interface IBaseRepository<T>
    {
        void Add(T item);
        bool Remove(T item);
        List<T> GetAll();
        int IndexOf(T item);
        void Update(T item, int index);
    }
}
