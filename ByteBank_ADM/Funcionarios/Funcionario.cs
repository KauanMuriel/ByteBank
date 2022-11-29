using System;

namespace ByteBank_ADM.Funcionarios
{
	public abstract class Funcionario
	{
		public string Nome { get; set; }
		public string CPF { get; private set; }
		public decimal Salario { get; protected set; }
		public static int TotalDeFuncionarios { get; private set; }
		public Funcionario(string cpf, decimal salario)
		{
			CPF = cpf;
			Salario = salario;
			TotalDeFuncionarios++;
		}

		public abstract decimal GetBonificacao();

		public abstract void AumentarSalario();
	}
}
