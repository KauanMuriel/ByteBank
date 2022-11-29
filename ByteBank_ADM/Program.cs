using System;
using ByteBank_ADM.Funcionarios;
using ByteBank_ADM.Utilitario;
using ByteBank_ADM.Parceria;

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
				ingrid.Senha = "1234";
				ingrid.Login = "Ing";


				GerenteDeContas ursular = new GerenteDeContas("123456");
				ursular.Nome = "Ursulana";
				ursular.Senha = "356";
				ursular.Login = "Urs";

				ParceiroComercial caio = new ParceiroComercial();
				caio.Login = "Caio";
				caio.Senha = "987";

				sistema.Logar(ursular, "356", "Urs");
				sistema.Logar(ingrid, "1234", "Ing");
				sistema.Logar(caio, "987", "Caio");
			}
		}
	}
}
