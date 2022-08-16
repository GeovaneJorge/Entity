using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeContatos.Models
{
	public class ContatoModel
	{
		//Criando as tabelas do Banco de Dados com Entity Framework
		public int Id { get; set; }
		public string Nome { get; set; }
		public string Email { get; set; }
		public string Celular { get; set; }
	}
}
