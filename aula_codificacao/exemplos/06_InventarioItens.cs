using System;

namespace ExemplosJogos
{
    class InventarioItens
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SISTEMA DE INVENTÁRIO ===\n");

            // Array de itens no inventário
            string[] inventario = new string[10];
            int quantidadeItens = 0;

            // Adicionar alguns itens iniciais
            inventario[0] = "Espada de Ferro";
            inventario[1] = "Poção de Cura";
            inventario[2] = "Escudo de Madeira";
            quantidadeItens = 3;

            // Exibir inventário
            Console.WriteLine("=== INVENTÁRIO ATUAL ===");
            for (int i = 0; i < inventario.Length; i++)
            {
                if (inventario[i] != null)
                {
                    Console.WriteLine($"Slot {i + 1}: {inventario[i]}");
                }
                else
                {
                    Console.WriteLine($"Slot {i + 1}: [VAZIO]");
                }
            }

            // Adicionar novo item
            Console.WriteLine($"\nSlots ocupados: {quantidadeItens}/{inventario.Length}");
            Console.WriteLine($"Slots disponíveis: {inventario.Length - quantidadeItens}");

            // Buscar item no inventário
            Console.Write("\nDigite o nome do item para buscar: ");
            string itemBuscado = Console.ReadLine();
            bool encontrado = false;
            int posicao = -1;

            for (int i = 0; i < inventario.Length; i++)
            {
                if (inventario[i] != null && inventario[i].Equals(itemBuscado, StringComparison.OrdinalIgnoreCase))
                {
                    encontrado = true;
                    posicao = i;
                    break;
                }
            }

            if (encontrado)
            {
                Console.WriteLine($"✅ Item '{itemBuscado}' encontrado no slot {posicao + 1}!");
            }
            else
            {
                Console.WriteLine($"❌ Item '{itemBuscado}' não encontrado no inventário.");
            }

            // Calcular valor total do inventário (exemplo)
            int[] valores = { 100, 50, 75, 0, 0, 0, 0, 0, 0, 0 }; // Valores dos itens
            int valorTotal = 0;

            for (int i = 0; i < inventario.Length; i++)
            {
                if (inventario[i] != null)
                {
                    valorTotal += valores[i];
                }
            }

            Console.WriteLine($"\n💰 Valor total do inventário: {valorTotal} moedas");
        }
    }
}


