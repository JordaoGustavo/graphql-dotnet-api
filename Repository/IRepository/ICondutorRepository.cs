using System.Collections.Generic;
using Model.Model;

namespace Repository.IRepository
{
    public interface ICondutorRepository
    {
        List<Condutor> GetCondutores();
        Condutor Get(int id);
    }
}
