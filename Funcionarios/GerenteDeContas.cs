using BinaryBank.SistemaInterno;

namespace BinaryBank.Funcionarios
{
    public class GerenteDeConta : FuncionarioAutenticavel
    {
        public GerenteDeConta(string cpf) : base(cpf, 4000) { }

        public override double GetBonificacao()
        {
            return Salario * 0.45;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.75;
        }
    }
}
