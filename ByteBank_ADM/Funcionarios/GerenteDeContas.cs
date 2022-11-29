using System;
using ByteBank_ADM.SistemaInternoU;

namespace ByteBank_ADM.Funcionarios
{
	public class GerenteDeContas : Autenticavel
	{
		public GerenteDeContas(string cpf) : base (cpf,4000M)
		{

		}
		public override decimal GetBonificacao()
		{
			return Salario * 0.25M;
		}

		public override void AumentarSalario()
		{
			Salario *= 1.05M;
		}

		public override bool Autenticar(string senha, string login)
		{
			return (Senha == senha) && (Login == Login);
		}
	}
}
