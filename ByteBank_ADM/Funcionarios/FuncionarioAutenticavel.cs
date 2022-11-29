using System;
using ByteBank_ADM.SistemaInternoU;

namespace ByteBank_ADM.Funcionarios
{
	public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
	{
		protected FuncionarioAutenticavel(string cpf, decimal salario) : base(cpf, salario)
		{
		}

		public string Senha { get; set; }
		public string Login { get; set; }

		public bool Autenticar(string senha, string login)
		{
			return (Senha == senha) && (Login == login);
		}
	}
}
