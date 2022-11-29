using System;
using System.Collections.Generic;
using ByteBank_ADM.Funcionarios;
namespace ByteBank_ADM.SistemaInternoU
{
	public abstract class Autenticavel : Funcionario
	{
		public string Senha { get; set; }
		public string Login { get; set; }
		public Autenticavel(string cpf, decimal salario) : base (cpf, salario)
		{
		}
		public abstract bool Autenticar(string senha, string login);
	}
}
