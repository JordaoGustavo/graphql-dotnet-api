using System;

namespace Model.Model
{
    public class Condutor
    {
        public int CondutorId { get; private set; }

        public string Nome { get; set; }

        public string SobreNome { get; set; }

        public DateTime DataNascimento { get; set; }

        public int VeiculoId { get; private set; }

        public Veiculo Veiculo { get; set; }

        public override string ToString() => $"{Nome} {SobreNome}";
    }
}
