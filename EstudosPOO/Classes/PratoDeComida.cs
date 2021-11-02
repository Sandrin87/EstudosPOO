using System;
using System.Collections.Generic;

namespace EstudosPOO
{
    public class PratoDeComida
    {
        public string NomePrato { get; set; }
        public double ValorPrato { get; set; }
        public bool PratoVegano { get; set; }
        public Dictionary<string, Alimento> Ingredientes { get; set; }

        public PratoDeComida(string nomePrato, bool pratoVegano, Dictionary<string, Alimento> ingredientes)
        {
            NomePrato = nomePrato;
            PratoVegano = pratoVegano;
            Ingredientes = ingredientes;
        }

        public virtual void SetValorPrato(Dictionary<string, Alimento> ingredientes)
        {
            ValorPrato += 1.5 * ingredientes.Count();
        }
    }

    public class MixDeFrutas : PratoDeComida
    {
        //descobrir como chamar as classes
        private Banana banana = new Banana();
        private Morango morango = new Morango();

        private const string NOME_DO_PRATO = "MixDeFrutas";
        private const bool PRATO_VEGANO = true;
        private const Dictionary<string, Alimento> INGREDIENTES = { { banana.Nome, banana }, { morango.Nome, morango } };

        public MixDeFrutas() : base(NOME_DO_PRATO, PRATO_VEGANO, INGREDIENTES)
        {

        }

        public override void SetValorPrato(Dictionary<string, Alimento> ingredientes)
        {
            foreach (Dictionary<string, Alimento> entry in ingredientes)
            {
                if (entry.ContainsKey("Mornago"))
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
