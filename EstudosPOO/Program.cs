using System;

namespace EstudosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            /***************************************************
            *   Repositorio para estudo
            *   https://github.com/FernandoVendramin/OOP.Studies
            ***************************************************/

            Buffet restaurante = new Buffet("Buffet Girafas", "Gabriel Sandrin");
            

            Console.WriteLine(restaurante.DonoRestaurante);
            
            if(restaurante.Cardapio.Count < 2)
            {
                Console.WriteLine(restaurante.Cardapio[0].NomePrato);
            }
            else
            {
                Console.WriteLine("Os pratos disponíveis são: ");

                foreach(PratoDeComida prato in restaurante.Cardapio)
                {
                    Console.WriteLine(prato.NomePrato+"\n");
                }
            }

            Console.WriteLine(restaurante.NomeRestaurante);

        }
    }
}
