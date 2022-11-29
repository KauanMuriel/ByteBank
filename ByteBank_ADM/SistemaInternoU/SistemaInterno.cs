using System;
using ByteBank_ADM.Funcionarios;
using ByteBank_ADM.SistemaInternoU;
using ByteBank_ADM.Parceria;

namespace ByteBank_ADM.SistemaInterno
{
	public class SistemaInterno
	{
		public bool Logar(IAutenticavel funcionario, string senha, string login)
		{
			bool usuarioAutenticado = funcionario.Autenticar(senha, login);

			if (usuarioAutenticado)
			{
				Console.WriteLine($"Boas vindas ao sistema.");
				return true;
			}
			else
			{
				Console.WriteLine($"Senha incorreta.");
				return false;
			}
		}
	}
}
