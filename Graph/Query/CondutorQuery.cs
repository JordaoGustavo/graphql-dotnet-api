using System.Linq;
using Graph.Type;
using GraphQL.Types;
using Repository.IRepository;

namespace Graph.Query
{
    public class CondutorQuery : ObjectGraphType
    {
       public CondutorQuery(ICondutorRepository condutorRepository, IVeiculoRepository veiculoRepository)
        {
            _ = Field<ListGraphType<CondutorType>>(
                   "condutores",
                   resolve: context => {
                       var condutores = condutorRepository.Get();

                       var veiculosId = condutores.Select(c => c.VeiculoId);

                       var veiculos = veiculoRepository.Get(veiculosId);

                       foreach (var condutor in condutores)
                       {
                           condutor.Veiculo = veiculos.FirstOrDefault(v => v.VeiculoId == condutor.VeiculoId);
                       }

                       return condutores;
                   }
               );
        }
    }
}
