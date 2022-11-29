using ByteBank_ADM.SistemaInternoU;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Funcionarios
{
	public class Diretor : Autenticavel
	{
		public Diretor(string cpf) : base(cpf, 5000M)
		{

		}
		public override decimal GetBonificacao()
		{
			return Salario * 0.5M;
		}

		public override void AumentarSalario()
		{
			Salario *= 0.15M;
		}

		public override bool Autenticar(string senha, string login)
		{
			return (Senha == senha) && (Login == login);
		}
	}
}
