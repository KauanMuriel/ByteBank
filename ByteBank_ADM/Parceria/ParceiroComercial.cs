using System;
using System.Collections.Generic;
using ByteBank_ADM.SistemaInternoU;

namespace ByteBank_ADM.Parceria
{
	public class ParceiroComercial : IAutenticavel
	{
		public string Senha { get; set; }
		public string Login { get; set; }
		public bool Autenticar(string senha, string login)
		{
			return (Senha == senha) && (Login == login);
		}
	}
}
