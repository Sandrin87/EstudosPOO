using System;
using System.Collections.Generic;

namespace EstudosPOO
{
	public abstract class Restaurante
	{
		public string NomeRestaurante { get; set; }
		public string DonoRestaurante { get; set; }
		public List<PratoDeComida> Cardapio { get; set; }

		public abstract List<string> PratosDisponiveis() { }
	}

	public class Buffet : Restaurante
	{
		private MixDeFrutas prato = new MixDeFrutas();

		public Buffet(string nomeRestaurante, string donoRestaurante, List<string> cardapio)
        {
			NomeRestaurante = nomeRestaurante;
			DonoRestaurante = donoRestaurante;
			Cardapio = cardapio;
        }

        public override List<string> PratosDisponiveis()
        {
			return prato.Nome;
        }
    }
}
