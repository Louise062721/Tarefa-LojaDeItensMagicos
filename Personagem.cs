using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_de_itens_mágicos_tentativa_2
{
    public class Personagem
    {
        public string Name_P;
        public int Coins_P;
        public List<Item> Inventory = new List<Item>();

        

        public Personagem(string nomeP, int moedas, List<Item> Inventario)
        {
            this.Name_P = nomeP;
            this.Coins_P = moedas;
            this.Inventory = Inventario;
        }

        public static void Compra(List<Item> Caderninho, Personagem persona)
        {
            Console.WriteLine();
            Console.Write("Qual item deseja comprar? Escreva conforme lhe foi apresentado  ");
            string itemCompra = Convert.ToString(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Quantos itens deseja comprar?  ");
            int QtdItens = Convert.ToInt32(Console.ReadLine());

            foreach (var items in Caderninho)
            {
                if (itemCompra == items.Name_Item)
                {
                    int PreçoFinal = QtdItens *items.Price_Item;

                    if (PreçoFinal <= persona.Coins_P)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Preço Final: {0}", PreçoFinal);
                        Console.Write("Confirmar compra? (1)Sim (2)Não  ");
                        int opcao3 = Convert.ToInt32(Console.ReadLine());

                        if (opcao3 == 1)
                        {
                            persona.Inventory.Add(items);
                            persona.Coins_P = persona.Coins_P - PreçoFinal;

                            Console.WriteLine();
                            Console.WriteLine("O item foi adicionado ao seu inventário! ");
                            Console.WriteLine("Saldo de moedas atual: {0}", persona.Coins_P);

                        }
                        else if (opcao3 <= 0 || opcao3 > 2)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Essa opção não existe");
                        }

                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Seu saldo é insuficiente para essa compra. ");
                    }
                }
                
            }



        }
    }
}
