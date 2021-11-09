using System;
using System.Collections.Generic;

namespace EstudosPOO
{
	public abstract class Restaurante
	{
		public string NomeRestaurante { get; set; }
		public string DonoRestaurante { get; set; }
		public List<PratoDeComida> Cardapio { get; set; }

		public abstract List<string> PratosDisponiveis();

		public abstract List<PratoDeComida> SetPratoComida();
	}

	public class Buffet : Restaurante
	{
		private MixDeFrutas prato = new MixDeFrutas();
		

		public Buffet(string nomeRestaurante, string donoRestaurante)
        {
			NomeRestaurante = nomeRestaurante;
			DonoRestaurante = donoRestaurante;
			Cardapio = SetPratoComida();
        }

		public override List<PratoDeComida> SetPratoComida()
		{
			return new List<PratoDeComida>() {prato};	
		}

        public override List<string> PratosDisponiveis()
        {
			return new List<string>() {prato.NomePrato};
        }
    }
}
