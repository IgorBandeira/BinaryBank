namespace BinaryBank.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf) : base(cpf, 2000) { }

        public override double GetBonificacao()
        {
            return Salario * 0.4;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.1;
        }
    }
}
