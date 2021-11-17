using System;

namespace EstudosPOO
{
    public abstract class Alimento
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public double Custo { get; set; }
        public string Tipo { get; set; }
        public string Unidade { get; set; }
        public double Calorias { get; set; }

        public Alimento(string nome, double preco, string tipo, string unidade, double calorias)
        {
            Nome = nome;
            Preco = preco;
            Tipo = tipo;
            Unidade = unidade;
            Calorias = calorias;
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

    public class Geladeira
    {
        public void Congelar(Fruta frutaNaoCongelada)
        {
            
        }

    }

    public abstract class Fruta : Alimento
    {
        private const string TIPO = "Fruta";
        private const string UNIDADE = "Kg";

        public Fruta(string nome, double calorias, double preco) : base(nome, preco, TIPO, UNIDADE, calorias)
        {

        }
    }

    public class Banana : Fruta
    {
        private const string NOME = "Banana";
        private const double CALORIA = 120;
        private const double PRECO = 1.50;

        public Banana() : base(NOME, CALORIA, PRECO)
        {

        }
    }

    public class Morango : Fruta
    {
        private const string NOME = "Morango";
        private const double CALORIA = 100;
        private const double PRECO = 3.60;

        public Morango() : base(NOME, CALORIA, PRECO)
        {

        }
    }
}