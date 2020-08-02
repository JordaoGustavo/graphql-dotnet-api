using System.Collections.Generic;
using Model.Model;

namespace Repository.IRepository
{
    public interface IVeiculoRepository
    {
        IEnumerable<Veiculo> Get();
        Veiculo Get(int id);
        IEnumerable<Veiculo> Get(IEnumerable<int> veiculosId);
    }
}
