using System;

namespace Model.Model
{
    public class Veiculo
    {
        public int VeiculoId { get; private set; }

        public string Modelo { get; set; }

        public string Cor { get; set; }

        public DateTime AnoFabricacao { get; set; }

        public int Hodometro { get; private set; }

        public override string ToString() => $"{Modelo} - {AnoFabricacao.Year} :{Hodometro}";
    }
}
