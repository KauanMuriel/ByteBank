using System;
using ByteBank_ADM.Funcionarios;
using ByteBank_ADM.Utilitario;

namespace ByteBank_ADM
{
	class Program
	{
		static void Main(string[] args)
		{
			#region
			//Funcionario pedro = new Auxiliar("222.222.222-22");
			//pedro.Nome = "Pedro";

			//Console.WriteLine(pedro.Nome);
			//Console.WriteLine(pedro.GetBonificacao());

			//Diretor roberta = new Diretor("987654321");

			//roberta.Nome = "Roberta Silva";

			//Console.WriteLine(roberta.Nome);
			//Console.WriteLine(roberta.GetBonificacao());

			//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
			//gerenciador.RegistraBonificacao(pedro);
			//gerenciador.RegistraBonificacao(roberta);

			//Console.WriteLine($"Total de bonificacoes: {gerenciador.TotalBonificacoes}");
			//Console.WriteLine($"Total de funcionarios: {Funcionario.TotalDeFuncionarios}");

			//pedro.AumentarSalario();
			//roberta.AumentarSalario();

			//Console.WriteLine($"Novo salário do Pedro: {pedro.Salario}");
			//Console.WriteLine($"Novo salário da Roberta: {roberta.Salario}");
			#endregion

			UsarSistema();
			//CalcularBonificacao();

			void CalcularBonificacao()
			{
				GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

				Designer ulisses = new Designer("123456");
				ulisses.Nome = "Ulisses Jr.";

				Diretor paula = new Diretor("654321");
				paula.Nome = "Paula Andrade";

				Auxiliar cawan = new Auxiliar("7890123");
				cawan.Nome = "Cawan Bertalha";

				GerenteDeContas igor = new GerenteDeContas("87640891");
				igor.Nome = "Igor Dias";

				gerenciador.RegistraBonificacao(ulisses);
				gerenciador.RegistraBonificacao(paula);
				gerenciador.RegistraBonificacao(cawan);
				gerenciador.RegistraBonificacao(igor);

				Console.WriteLine($"Total de bonificações: {gerenciador.TotalBonificacoes}");
			}

			

			void UsarSistema()
			{
				SistemaInterno.SistemaInterno sistema = new SistemaInterno.SistemaInterno();

				Diretor ingrid = new Diretor("298312");
				ingrid.Nome = "Ingrid Guimarães";

				ingrid.Senha = "123";

				sistema.Logar(ingrid, "123");

				GerenteDeContas ursular = new GerenteDeContas("123456");
				ursular.Nome = "Ursulana";
				ursular.Senha = "356";

				Auxiliar henrique = new Auxiliar("12356");
				henrique.Nome = "Henrique Ayres";
				henrique.Senha = "123";


				sistema.Logar(ursular, "234");
				sistema.Logar(ingrid, "123");
			}
		}
	}
}
