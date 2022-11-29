using System;
using System.Collections.Generic;
using ByteBank_ADM.Funcionarios;
namespace ByteBank_ADM.SistemaInternoU
{
	public interface IAutenticavel
	{
		string Senha { get; set; }
		string Login { get; set; }
		bool Autenticar(string senha, string login);
	}
}
