using System;

namespace EstudosPOO
{
    public class Aalimento
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public double Custo { get; set; }
        public string Tipo { get; set; }
        public string Unidade { get; set; }
        public double Calorias { get; set; }

        public Alimento(string nome, double preco, double custo, string tipo, string unidade, double calorias)
        {
            Nome = nome;
            Preco = preco;
            Tipo = tipo;
            Unidade = unidade;
            Calorias = calorias;
        }

        public void SetCusto(double quantidade)
        {
            Custo += Preco * quantidade;
        }

        public double GetCustoCompra(double quantidade)
        {
            return Preco * quantidade;
        }

        public void ResetarCusto()
        {
            Custo = 0;
        }
    }

    public class Fruta : Alimento
    {
        private const string TIPO = "Fruta";
        private const string UNIDADE = "Kg";
        public Fruta(string nome, double calorias, double preco) : base(nome, TIPO, calorias, preco, UNIDADE)
        {

        }
    }

    public class Banana : Fruta
    {
        private string const NOME = "Baanana";
        private double const CALORIA = 120;
        private double const PRECO = 1.50;

        public Banana() : base(NOME, CALORIA, PRECO)
        {

        }
    }

    public class Morango : Fruta
    {
        private string const NOME = "Morango";
        private double const CALORIA = 100;
        private double const PRECO = 3.60;

        public Morango() : base(NOME, CALORIA, PRECO)
        {

        }
    }
}