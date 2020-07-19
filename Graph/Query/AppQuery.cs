using GraphQL.Types;
using GraphQLObjects.Type;
using Repository.IRepository;

namespace GraphQLObjects.Query
{
    public class AppQuery : ObjectGraphType
    {
        public AppQuery(IVeiculoRepository veiculoRepository) 
        {
            _ = Field<ListGraphType<VeiculoType>>(
              "Veiculos",
              resolve: context => veiculoRepository.GetVeiculos()
          );
        }
    }
}
