using BinaryBank.Funcionarios;
using BinaryBank.Utilitario;
using BinaryBank.SistemaInterno;
using BinaryBank.ParceiroComercial;
using System.ComponentModel.Design;
using System.IO;

Console.WriteLine("\n");

// Console.WriteLine("### Calculando Bonificação ###");
CalcularBonificacao();

Console.WriteLine("### Usando Sistema Interno ###");
UsarSistema();

Console.ReadKey();

void UsarSistema()
{
    SistemaInterno sistemaInterno = new SistemaInterno();

    Diretor deise = new Diretor("159.753.398-04");
    deise.Nome = "Deise";
    deise.Senha = "123";

    GerenteDeConta helena = new GerenteDeConta("326.985.628-89");
    helena.Nome = "Helena";
    helena.Senha = "321";

    ParceiroComercial parceiro = new ParceiroComercial();
    parceiro.Senha = "123";

    sistemaInterno.Logar(deise, "123");
    sistemaInterno.Logar(deise, "321");

    sistemaInterno.Logar(helena, "123");
    sistemaInterno.Logar(helena, "321");

    sistemaInterno.Logar(parceiro, "123");
}

static void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciadorBonificacao = new GerenciadorDeBonificacao();

    Funcionario jaime = new Designer("833.222.048-39");
    jaime.Nome = "Jaime";

    Funcionario deise = new Diretor("159.753.398-04");
    deise.Nome = "Deise";

    Funcionario igor = new Auxiliar("981.198.778-53");
    igor.Nome = "Igor";

    Funcionario helena = new GerenteDeConta("326.985.628-89");
    helena.Nome = "Helena";

    Desenvolvedor jadson = new Desenvolvedor("456.175.468-20");
    jadson.Nome = "Jadson";

    gerenciadorBonificacao.Registrar(jaime);
    gerenciadorBonificacao.Registrar(deise);
    gerenciadorBonificacao.Registrar(igor);
    gerenciadorBonificacao.Registrar(helena);
    gerenciadorBonificacao.Registrar(jadson);


    Console.WriteLine(
        "Total de bonificações do mês: " + gerenciadorBonificacao.GetTotalBonificacao()
    );
}
