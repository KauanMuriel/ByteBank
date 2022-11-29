using ByteBank_ADM.Interface;

namespace ByteBank_ADM.Funcionarios
{
	public class Designer : Funcionario, IBonificacao
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
