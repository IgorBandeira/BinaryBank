using BinaryBank.SistemaInterno;

namespace BinaryBank.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        protected FuncionarioAutenticavel(string cpf, double salario) : base(cpf, salario)
        {
        }

        public string Senha { get; set; } = "";
        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }
    }
}