using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Funcionarios
{
	public class GerenteDeContas : Funcionario
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
	}
}
