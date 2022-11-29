using ByteBank_ADM.Interface;

namespace ByteBank_ADM.Funcionarios
{
	class Auxiliar : Funcionario, IBonificacao
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
