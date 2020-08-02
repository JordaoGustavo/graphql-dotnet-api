using Model.Model;
using GraphQL.Types;

namespace Graph.Type
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
            _ = Field(v => v.DataNascimento)
                .Description("Data Nascimento");
            _ = Field(
                    name: "Veiculo",
                    type: typeof(VeiculoType),
                    resolve: context => context.Source.Veiculo,
                    description: "Veiculo"
                );
        }
    }
}
