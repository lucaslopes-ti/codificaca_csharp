using System;

namespace ExemplosJogos
{
    // Classe Item simples
    class Item
    {
        public string Nome;
        public int Quantidade;
    }

    // Classe Personagem com inventário (composição)
    class Personagem
    {
        public string Nome;
        public int Nivel;
        private Item[] inventario;
        private int quantidadeItens;

        // Construtor
        public Personagem(string nome, int nivel)
        {
            Nome = nome;
            Nivel = nivel;
            inventario = new Item[10]; // Inventário com 10 slots
            quantidadeItens = 0;
        }

        // Método para adicionar item
        public void AdicionarItem(string nome, int quantidade)
        {
            if (quantidadeItens < inventario.Length)
            {
                Item novoItem = new Item();
                novoItem.Nome = nome;
                novoItem.Quantidade = quantidade;
                inventario[quantidadeItens] = novoItem;
                quantidadeItens++;
                Console.WriteLine($"✅ {nome} adicionado ao inventário!");
            }
            else
            {
                Console.WriteLine("❌ Inventário cheio!");
            }
        }

        // Método para listar inventário
        public void ListarInventario()
        {
            Console.WriteLine($"\n=== INVENTÁRIO DE {Nome} ===");
            if (quantidadeItens == 0)
            {
                Console.WriteLine("Inventário vazio.");
            }
            else
            {
                for (int i = 0; i < quantidadeItens; i++)
                {
                    Console.WriteLine($"{i + 1}. {inventario[i].Nome} x{inventario[i].Quantidade}");
                }
            }
            Console.WriteLine();
        }
    }

    class Programa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SISTEMA DE INVENTÁRIO ===\n");

            // Criar personagem
            Personagem heroi = new Personagem("Aragorn", 10);

            // Adicionar itens
            heroi.AdicionarItem("Poção de Cura", 5);
            heroi.AdicionarItem("Espada", 1);
            heroi.AdicionarItem("Escudo", 1);
            heroi.AdicionarItem("Flechas", 20);

            // Listar inventário
            heroi.ListarInventario();
        }
    }
}

