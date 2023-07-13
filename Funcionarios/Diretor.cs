using BinaryBank.SistemaInterno;

namespace BinaryBank.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        public Diretor(string cpf) : base(cpf, 5000) { }

        public override double GetBonificacao()
        {
            return Salario * 0.8;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }
    }
}
