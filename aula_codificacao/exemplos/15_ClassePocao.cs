using System;

namespace ExemplosJogos
{
    // Classe Poção com construtores
    class Pocao
    {
        public string Nome;
        public int Cura;
        public int Quantidade;

        // Construtor padrão (sem parâmetros)
        public Pocao()
        {
            Nome = "Poção Básica";
            Cura = 20;
            Quantidade = 1;
        }

        // Construtor com parâmetros
        public Pocao(string nome, int cura, int quantidade)
        {
            Nome = nome;
            Cura = cura;
            Quantidade = quantidade;
        }

        // Método para usar poção
        public int Usar()
        {
            if (Quantidade > 0)
            {
                Quantidade--;
                return Cura;
            }
            return 0; // Sem poções disponíveis
        }

        // Método para exibir informações
        public void ExibirInfo()
        {
            Console.WriteLine($"Poção: {Nome}");
            Console.WriteLine($"Cura: {Cura} HP");
            Console.WriteLine($"Quantidade: {Quantidade}\n");
        }
    }

    class Programa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SISTEMA DE POÇÕES ===\n");

            // Criar poção usando construtor padrão
            Pocao pocao1 = new Pocao();
            Console.WriteLine("Poção criada com construtor padrão:");
            pocao1.ExibirInfo();

            // Criar poção usando construtor com parâmetros
            Pocao pocao2 = new Pocao("Poção Superior", 50, 3);
            Console.WriteLine("Poção criada com construtor personalizado:");
            pocao2.ExibirInfo();

            // Usar poção
            Console.WriteLine("=== USANDO POÇÃO ===");
            int curaRecebida = pocao2.Usar();
            Console.WriteLine($"Cura recebida: {curaRecebida} HP");
            Console.WriteLine($"Quantidade restante: {pocao2.Quantidade}");
        }
    }
}

