using GraphQL;
using GraphQL.Types;
using Graph.Query;

namespace Graph.Scheme
{
    public class AppScheme : Schema
    {
        public AppScheme(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<AppQuery>();
        }
    }
}
