using System;
using System.Collections.Generic;

namespace EstudosPOO
{
	public abstract class Restaurante
	{
		public string NomeRestaurante { get; set; }
		public string DonoRestaurante { get; set; }
		public List<PratoDeComida> Cardapio { get; set; }

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
    }
}
