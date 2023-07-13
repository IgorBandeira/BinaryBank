using BinaryBank.SistemaInterno;

namespace BinaryBank.ParceiroComercial
{
    public class ParceiroComercial : IAutenticavel
    {
        public string Senha { get; set; } = "";

        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }
    }
}
