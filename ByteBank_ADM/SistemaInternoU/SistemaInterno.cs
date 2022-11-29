using System;
using ByteBank_ADM.Funcionarios;
using ByteBank_ADM.SistemaInternoU;

namespace ByteBank_ADM.SistemaInterno
{
	public class SistemaInterno
	{
		public bool Logar(Autenticavel funcionario, string senha)
		{
			bool usuarioAutenticado = funcionario.Autenticar(senha);

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
