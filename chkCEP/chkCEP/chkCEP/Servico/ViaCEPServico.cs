using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using chkCEP.Servico.Modelo;
using Newtonsoft.Json;

namespace chkCEP.Servico
{
	public class ViaCEPServico
	{
		private static string EnderecoURL = "http://viacep.com.br/ws/{0}/json/";

		public static Endereco BuscarEnderecoViaCEP(string cep)
		{
			string NovoEnderecoURL = string.Format(EnderecoURL, cep);

			WebClient wc = new WebClient();
			string Conteudo = wc.DownloadString(NovoEnderecoURL);

			Endereco End = JsonConvert.DeserializeObject<Endereco>(Conteudo);

			if (End.cep == null) return null;

			return End;
		}
	}
}
