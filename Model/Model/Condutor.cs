namespace Model.Model
{
    public class Condutor
    {
        public int CondutorId { get; private set; }

        public string Nome { get; set; }

        public string SobreNome { get; set; }

        public int Idade { get; set; }

        public int VeiculoId { get; private set; }

        public override string ToString() => $"{Nome} {SobreNome}";
    }
}
