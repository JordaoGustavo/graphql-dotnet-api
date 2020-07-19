using GraphQL;
using GraphQL.Types;

namespace GraphQLObjects.Scheme
{
    public class AppScheme : Schema
    {
        public AppScheme(IDependencyResolver resolver) : base(resolver)
        {
        }
    }
}
