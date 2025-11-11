using System;

namespace ExemplosJogos
{
    // Classe Item com encapsulamento básico
    class Item
    {
        // Propriedades públicas
        public string Nome;
        public int Quantidade;

        // Propriedade privada com validação
        private int _preco;

        public int Preco
        {
            get { return _preco; }
            set
            {
                if (value < 0)
                {
                    _preco = 0;
                    Console.WriteLine("⚠️ Preço não pode ser negativo! Definido como 0.");
                }
                else
                {
                    _preco = value;
                }
            }
        }

        // Método para exibir informações
        public void ExibirInfo()
        {
            Console.WriteLine($"Item: {Nome}");
            Console.WriteLine($"Quantidade: {Quantidade}");
            Console.WriteLine($"Preço: {Preco} moedas\n");
        }
    }

    class Programa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SISTEMA DE ITENS ===\n");

            // Criar item válido
            Item pocao = new Item();
            pocao.Nome = "Poção de Cura";
            pocao.Quantidade = 5;
            pocao.Preco = 50;
            pocao.ExibirInfo();

            // Tentar criar item com preço negativo (será corrigido)
            Item itemInvalido = new Item();
            itemInvalido.Nome = "Item Quebrado";
            itemInvalido.Quantidade = 1;
            itemInvalido.Preco = -10; // Será corrigido para 0
            itemInvalido.ExibirInfo();
        }
    }
}

