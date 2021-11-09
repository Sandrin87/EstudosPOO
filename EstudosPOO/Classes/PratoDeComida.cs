using System;
using System.Collections.Generic;

namespace EstudosPOO
{
    public class PratoDeComida
    {
        public string NomePrato { get; set; }
        public double ValorPrato { get; set; }
        public bool PratoVegano { get; set; }
        public Dictionary<string, Fruta> Ingredientes { get; set; }

        public PratoDeComida(string nomePrato, bool pratoVegano, Dictionary<string, Fruta> ingredientes)
        {
            NomePrato = nomePrato;
            PratoVegano = pratoVegano;
            Ingredientes = ingredientes;
        }

        public virtual void SetValorPrato(Dictionary<string, Fruta> ingredientes)
        {
            ValorPrato += 1.5 * ingredientes.Count;
        }
    }

    public class MixDeFrutas : PratoDeComida
    {
        //descobrir como chamar as classes
        private static Banana banana = new Banana();
        private static Morango morango = new Morango();

        private const string NOME_DO_PRATO = "MixDeFrutas";
        private const bool PRATO_VEGANO = true;
        private static Dictionary<string, Fruta> INGREDIENTES = new Dictionary<string, Fruta>() { { banana.Nome, banana }, { morango.Nome, morango } };

        public MixDeFrutas() : base(NOME_DO_PRATO, PRATO_VEGANO, INGREDIENTES)
        {
            SetValorPrato(INGREDIENTES);
        }

        public override void SetValorPrato(Dictionary<string, Fruta> ingredientes)
        {
            foreach (KeyValuePair<string, Fruta> entry in ingredientes)
            {
                if (entry.Key == "Mornago")
                {
                    ValorPrato += 4.5;
                }
                else
                {
                    ValorPrato += 1.5;
                }
            }
        }
    }
}
