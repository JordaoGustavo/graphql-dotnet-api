using Model.Model;
using GraphQL.Types;

namespace GraphQLObjects.Type
{
    public class CondutorType : ObjectGraphType<Condutor>
    {
        public CondutorType()
        {
            _ = Field(c => c.CondutorId, type: typeof(IdGraphType))
                .Description("Identificação do Condutor");
            _ = Field(c => c.Nome)
                .Description("Nome do Condutor");
            _ = Field(v => v.SobreNome)
                .Description("Sobrenome do Condutor");
            _ = Field(v => v.Idade)
                .Description("Idade do Condutor");
            _ = Field(v => v.VeiculoId)
                .Description("Vinculo com o veiculo");
        }
    }
}
