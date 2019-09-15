using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IServiceTemplate<T>
    {

        Task Add(T dto);
        Task Delete(int id);
        Task Update(T dto);

        Task<T> GetById(int id);
        Task<IList<T>> GetAll();
        Task<IList<T>> GetRange(int startPosition, int numberOfItems);


    }
}
