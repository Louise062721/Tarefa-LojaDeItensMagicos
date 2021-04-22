using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_de_itens_mágicos_tentativa_2
{
    public class Item
    {
        public string Name_Item;
        public int Price_Item;
        public string Category_Item;
        public string Description_Item;

        public Item(string nome, int preço, string categoria, string descrição)
        {
            this.Name_Item = nome;
            this.Price_Item = preço;
            this.Category_Item = categoria;
            this.Description_Item = descrição;
        }

        public static List<Item> AdicionarItem()
        {
            List<Item> Caderninho = new List<Item>();

            Item i1 = new Item("Capa de invisibilidade", 100, "Vestuário", "Te deixa invisível por 1 hora");
            Caderninho.Add(i1);

            Item i2 = new Item("Elmo de teletransporte", 450, "Vestuário", "Te leva pra qualquer lugar com a força do pensamento");
            Caderninho.Add(i2);

            Item i3 = new Item("Armadura de resistência", 800, "Vestuário", "Diminui o impacto de ataques em 30%");
            Caderninho.Add(i3);

            Item i4 = new Item("Respiração em baixo d'água", 200, "Poções", "Te faz respirar em baixo d'água por 1 hora");
            Caderninho.Add(i4);

            Item i5 = new Item("Velocidade", 300, "Poções", "Aumenta sua velocidade em 10x por 30 minutos");
            Caderninho.Add(i5);

            Item i6 = new Item("Vôo", 1000, "Poções", "Te dá o poder ilimitado de voar");
            Caderninho.Add(i6);

            Item i7 = new Item("Espada das almas", 800, "Espadas", "Captura a alma da sua vítima dentro de si");
            Caderninho.Add(i7);

            Item i8 = new Item("Espada dupla", 350, "Espadas", "Permite atingir 2 inimigos de uma só vez");
            Caderninho.Add(i8);

            Item i9 = new Item("Espada Laser", 500, "Espadas", "Dispara feiches de laser que causam 12% de dano no inimigo");
            Caderninho.Add(i9);

            Item i10 = new Item("Dragão protetor", 1200, "Animais", "Capaz de criar um campo de força inatingível por 15 minutos");
            Caderninho.Add(i10);

            Item i11 = new Item("Enguia de choque", 1000, "Animais", "Dá um raio de choque em quem tentar te atacar no mundo aquático");
            Caderninho.Add(i11);

            Item i12 = new Item("Lobo amigo", 1100, "Animais", "Seu fiel companheiro");
            Caderninho.Add(i12);


            return Caderninho;
        }

        public static void SomenteItens(List<Item> Caderninho)
        {
            Console.WriteLine();
            foreach (var iten in Caderninho)
            {
                Console.WriteLine();
                Console.WriteLine("Nome: " + iten.Name_Item);
                Console.WriteLine("Descrição: " + iten.Description_Item);
            }

        }

        public static void ImprimirCatalogo(List<Item> Caderninho)
        {
            Console.WriteLine();
            foreach (var item in Caderninho)
            {
                Console.WriteLine();
                Console.WriteLine("Nome: " + item.Name_Item);
                Console.WriteLine("Preço: " + item.Price_Item);
                Console.WriteLine("Categoria: " + item.Category_Item);
                Console.WriteLine("Descrição: " + item.Description_Item);
            }

        }

    }

}
