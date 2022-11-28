using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Funcionarios
{
	public class Designer : Funcionario
	{
		public Designer(string cpf) : base (cpf, 3000)
		{ 
		}

		public override decimal GetBonificacao()
		{
			return Salario * 0.17M;
		}

		public override void AumentarSalario()
		{
			Salario *= 1.11M;
		}
	}
}
