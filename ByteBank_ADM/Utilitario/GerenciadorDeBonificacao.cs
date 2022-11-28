using System;
using System.Collections.Generic;
using ByteBank_ADM.Funcionarios;

namespace ByteBank_ADM.Utilitario
{
	public class GerenciadorDeBonificacao
	{
		public decimal TotalBonificacoes { get; private set; }

		public void RegistraBonificacao(Funcionario funcionario)
		{
			TotalBonificacoes += funcionario.GetBonificacao();
		}
	}
}
