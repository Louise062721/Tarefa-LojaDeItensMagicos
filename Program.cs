using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_de_itens_mágicos_tentativa_2
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<Item> Caderninho = Item.AdicionarItem();
            List<Item> inventario = new List<Item>();

            Console.WriteLine();
            Console.Write("Insira seu nome: ");
            string nomeDoUsuario = Convert.ToString(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Seja bem vindo(a) " + nomeDoUsuario + "! ");
            Console.Write("Quantas moedas você possui?  ");
            int Moedas = Convert.ToInt32(Console.ReadLine());

            Personagem character = new Personagem(nomeDoUsuario, Moedas, inventario);

            Console.WriteLine("Segue uma lista de nossos itens. Fique à vontade!");
            Item.SomenteItens(Caderninho);

            int alternativa = 0;

            do
            {
                Console.WriteLine();
                Console.Write("Gostaria de continuar na loja? (1)Sim (0)Não, encerrar sessão   ");
                alternativa = Convert.ToInt32(Console.ReadLine());

                if (alternativa == 1)
                {
                    Console.WriteLine();
                    Console.Write("Gostaria de ver nosso catálogo completo? (1)Sim (2)Não   ");
                    int opcao1 = Convert.ToInt32(Console.ReadLine());

                    if (opcao1 == 1)
                    {
                        Item.ImprimirCatalogo(Caderninho);
                    }
                    else if (opcao1 <= 0 || opcao1 > 2)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Essa opção não existe");
                    }

                    Console.WriteLine();
                    Console.Write("Gostaria de comprar algum item? (1)Sim (2)Não   ");
                    int opcao2 = Convert.ToInt32(Console.ReadLine());

                    if (opcao2 == 1)
                    {
                        Personagem.Compra(Caderninho, character);

                    }
                    else if (opcao2 <= 0 || opcao2 > 2)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Essa opção não existe");
                    }
                }
                else if (alternativa == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Obrigado pela visita. Volte sempre!");
                }
                else 
                {
                    Console.WriteLine();
                    Console.WriteLine("Opção inexistente");
                }

            } while (alternativa != 0);

            

            Console.ReadKey();
        }
    }
}
