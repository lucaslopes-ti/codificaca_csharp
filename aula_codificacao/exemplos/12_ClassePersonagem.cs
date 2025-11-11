using System;

namespace ExemplosJogos
{
    // Classe Personagem - Primeira classe simples
    class Personagem
    {
        // Propriedades (características do personagem)
        public string Nome;
        public int HP;
        public int Nivel;

        // Método para exibir status
        public void ExibirStatus()
        {
            Console.WriteLine($"=== {Nome} ===");
            Console.WriteLine($"HP: {HP}");
            Console.WriteLine($"Nível: {Nivel}\n");
        }
    }

    class Programa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SISTEMA DE PERSONAGENS ===\n");

            // Criar primeiro personagem
            Personagem heroi = new Personagem();
            heroi.Nome = "Aragorn";
            heroi.HP = 150;
            heroi.Nivel = 10;
            heroi.ExibirStatus();

            // Criar segundo personagem
            Personagem mago = new Personagem();
            mago.Nome = "Gandalf";
            mago.HP = 100;
            mago.Nivel = 15;
            mago.ExibirStatus();

            // Criar terceiro personagem
            Personagem guerreiro = new Personagem();
            guerreiro.Nome = "Conan";
            guerreiro.HP = 200;
            guerreiro.Nivel = 8;
            guerreiro.ExibirStatus();
        }
    }
}

