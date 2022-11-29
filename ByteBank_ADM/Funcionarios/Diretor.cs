using ByteBank_ADM.Interface;

namespace ByteBank_ADM.Funcionarios
{
	public class Diretor : FuncionarioAutenticavel, IBonificacao
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
	}
}
