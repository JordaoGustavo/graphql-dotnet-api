using Graph.Type;
using GraphQL.Types;
using Repository.IRepository;

namespace Graph.Query
{
    public class VeiculoQuery : ObjectGraphType
    {
        public VeiculoQuery(IVeiculoRepository veiculoRepository) 
        {
            _ = Field<ListGraphType<VeiculoType>>(
                    "veiculos",
                    resolve: context => veiculoRepository.Get()
                );
        }
    }
}
