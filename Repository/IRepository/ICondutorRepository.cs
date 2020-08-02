using System.Collections.Generic;
using Model.Model;

namespace Repository.IRepository
{
    public interface ICondutorRepository
    {
        IEnumerable<Condutor> Get();
        Condutor Get(int id);
    }
}
