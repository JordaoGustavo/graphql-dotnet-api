using Model.Model;
using GraphQL.Types;

namespace GraphQLObjects.Type
{
    public class VeiculoType : ObjectGraphType<Veiculo>
    {
        public VeiculoType()
        {
            _ = Field(v => v.VeiculoId, type: typeof(IdGraphType))
                .Description("Identificação do veículo");
            _ = Field(v => v.Modelo)
                .Description("Modelo do veículo");
            _ = Field(v => v.Cor)
                .Description("Cor do veículo");
            _ = Field(v => v.AnoFabricacao)
                .Description("Ano de Fabricação do veículo");
            _ = Field(v => v.Hodometro)
                .Description("Hodômetro do veículo");
        }
    }
}
