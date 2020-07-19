using GraphQL.Types;
using Graph.Type;
using Repository.IRepository;

namespace Graph.Query
{
    public class AppQuery : ObjectGraphType
    {
        public AppQuery(IVeiculoRepository veiculoRepository, ICondutorRepository condutorRepository) 
        {
            _ = Field<ListGraphType<VeiculoType>>(
                    "veiculos",
                    resolve: context => veiculoRepository.GetVeiculos()
                );
            _ = Field<ListGraphType<CondutorType>>(
                    "condutores",
                    resolve: context => condutorRepository.GetCondutores()
                );

        }
    }
}
