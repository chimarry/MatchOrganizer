using Services.ErrorHandling;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IServiceTemplate<T>
    {

        Task<Status> Add(T dto);
        Task<Status> Delete(int id);
        Task<Status> Update(T dto);

        Task<T> GetById(int id);
        Task<List<T>> GetAll();
        Task<List<T>> GetRange(int startPosition, int numberOfItems);


    }
}
