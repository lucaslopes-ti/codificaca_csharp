using System;

namespace ExemplosJogos
{
    class SistemaDificuldade
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SISTEMA DE DIFICULDADE ===\n");

            // Menu de seleção
            Console.WriteLine("Escolha a dificuldade:");
            Console.WriteLine("1 - Fácil");
            Console.WriteLine("2 - Normal");
            Console.WriteLine("3 - Difícil");
            Console.WriteLine("4 - Pesadelo");
            Console.Write("\nOpção: ");

            int escolha = int.Parse(Console.ReadLine());
            string dificuldade = "";
            int multiplicadorDano = 1;
            int multiplicadorXP = 1;
            int multiplicadorOuro = 1;

            // Usando switch para determinar configurações
            switch (escolha)
            {
                case 1:
                    dificuldade = "Fácil";
                    multiplicadorDano = 1;
                    multiplicadorXP = 1;
                    multiplicadorOuro = 1;
                    break;
                case 2:
                    dificuldade = "Normal";
                    multiplicadorDano = 2;
                    multiplicadorXP = 2;
                    multiplicadorOuro = 2;
                    break;
                case 3:
                    dificuldade = "Difícil";
                    multiplicadorDano = 3;
                    multiplicadorXP = 3;
                    multiplicadorOuro = 3;
                    break;
                case 4:
                    dificuldade = "Pesadelo";
                    multiplicadorDano = 5;
                    multiplicadorXP = 5;
                    multiplicadorOuro = 5;
                    break;
                default:
                    Console.WriteLine("Opção inválida! Usando dificuldade Normal.");
                    dificuldade = "Normal";
                    multiplicadorDano = 2;
                    multiplicadorXP = 2;
                    multiplicadorOuro = 2;
                    break;
            }

            // Exibir configurações
            Console.WriteLine($"\n=== CONFIGURAÇÕES DE {dificuldade.ToUpper()} ===");
            Console.WriteLine($"Dano dos inimigos: {multiplicadorDano}x");
            Console.WriteLine($"XP ganho: {multiplicadorXP}x");
            Console.WriteLine($"Ouro ganho: {multiplicadorOuro}x");

            // Exemplo prático: calcular recompensas
            int xpBase = 100;
            int ouroBase = 50;
            int danoInimigoBase = 20;

            int xpGanho = xpBase * multiplicadorXP;
            int ouroGanho = ouroBase * multiplicadorOuro;
            int danoInimigo = danoInimigoBase * multiplicadorDano;

            Console.WriteLine($"\n=== EXEMPLO DE RECOMPENSAS ===");
            Console.WriteLine($"XP por vitória: {xpGanho}");
            Console.WriteLine($"Ouro por vitória: {ouroGanho}");
            Console.WriteLine($"Dano do inimigo: {danoInimigo}");
        }
    }
}


