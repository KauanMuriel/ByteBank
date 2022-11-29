using ByteBank_ADM.Interface;

namespace ByteBank_ADM.Funcionarios
{
	public class GerenteDeContas : FuncionarioAutenticavel, IBonificacao
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
