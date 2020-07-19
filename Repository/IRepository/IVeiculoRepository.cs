using System.Collections.Generic;
using Model.Model;

namespace Repository.IRepository
{
    public interface IVeiculoRepository
    {
        List<Veiculo> GetVeiculos();
        Veiculo Get(int id);
    }
}
