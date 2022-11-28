using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Funcionarios
{
	public class Diretor : Funcionario
	{
		public Diretor(string cpf) : base(cpf, 5000M)
		{

		}

		public string Senha { get; set; }
		public override decimal GetBonificacao()
		{
			return Salario * 0.5M;
		}

		public override void AumentarSalario()
		{
			Salario *= 0.15M;
		}
	}
}
