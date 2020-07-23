using Graph.Type;
using GraphQL.Types;
using Repository.IRepository;

namespace Graph.Query
{
    public class CondutorQuery : ObjectGraphType
    {
       public CondutorQuery(ICondutorRepository condutorRepository)
        {
            _ = Field<ListGraphType<CondutorType>>(
                   "condutores",
                   resolve: context => condutorRepository.GetCondutores()
               );
        }
    }
}
