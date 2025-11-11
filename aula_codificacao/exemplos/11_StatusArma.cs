using System;

namespace ExemplosJogos
{
    class StatusArma
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SISTEMA DE STATUS DE ARMA ===\n");

            // Variáveis da arma
            string nome = "Espada de Ferro";
            int dano = 25;
            int durabilidade = 80;

            // Classificar qualidade baseado no dano
            string qualidade;
            if (dano < 20)
                qualidade = "Comum";
            else if (dano < 40)
                qualidade = "Raro";
            else if (dano < 60)
                qualidade = "Épico";
            else
                qualidade = "Lendário";

            // Exibir status
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Dano: {dano}");
            Console.WriteLine($"Durabilidade: {durabilidade}%");
            Console.WriteLine($"Qualidade: {qualidade}");
        }
    }
}

