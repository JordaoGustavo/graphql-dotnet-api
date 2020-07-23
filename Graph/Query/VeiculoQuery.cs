using GraphQL.Types;
using Graph.Type;
using Repository.IRepository;

namespace Graph.Query
{
    public class VeiculoQuery : ObjectGraphType
    {
        public VeiculoQuery(IVeiculoRepository veiculoRepository) 
        {
            _ = Field<ListGraphType<VeiculoType>>(
                    "veiculos",
                    resolve: context => veiculoRepository.GetVeiculos()
                );
        }
    }
}
