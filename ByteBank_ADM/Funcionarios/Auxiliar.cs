using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Funcionarios
{
	class Auxiliar : Funcionario
	{
		public Auxiliar(string cpf) : base (cpf, 2000)
		{

		}

		public override decimal GetBonificacao()
		{
			return Salario * 0.20M;
		}

		public override void AumentarSalario()
		{
			Salario *= 1.10M;
		}
	}
}
