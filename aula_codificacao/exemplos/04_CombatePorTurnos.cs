using System;

namespace ExemplosJogos
{
    class CombatePorTurnos
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SISTEMA DE COMBATE POR TURNOS ===\n");

            // Status dos combatentes
            int hpJogador = 100;
            int hpInimigo = 80;
            int danoJogador = 15;
            int danoInimigo = 12;

            int turno = 1;
            bool combateAtivo = true;

            Console.WriteLine("=== INÍCIO DO COMBATE ===");
            Console.WriteLine($"Jogador: {hpJogador} HP | Dano: {danoJogador}");
            Console.WriteLine($"Inimigo: {hpInimigo} HP | Dano: {danoInimigo}\n");

            // Loop de combate
            while (combateAtivo)
            {
                Console.WriteLine($"--- TURNO {turno} ---");

                // Turno do jogador
                Console.WriteLine(">>> Turno do Jogador");
                hpInimigo -= danoJogador;
                Console.WriteLine($"Jogador ataca! Inimigo recebe {danoJogador} de dano.");
                Console.WriteLine($"HP do Inimigo: {hpInimigo}");

                // Verificar se o inimigo morreu
                if (hpInimigo <= 0)
                {
                    hpInimigo = 0;
                    Console.WriteLine("\n🎉 VITÓRIA! O inimigo foi derrotado!");
                    combateAtivo = false;
                    break;
                }

                // Turno do inimigo
                Console.WriteLine("\n>>> Turno do Inimigo");
                hpJogador -= danoInimigo;
                Console.WriteLine($"Inimigo ataca! Jogador recebe {danoInimigo} de dano.");
                Console.WriteLine($"HP do Jogador: {hpJogador}");

                // Verificar se o jogador morreu
                if (hpJogador <= 0)
                {
                    hpJogador = 0;
                    Console.WriteLine("\n💀 DERROTA! Você foi derrotado!");
                    combateAtivo = false;
                    break;
                }

                Console.WriteLine($"\nStatus após o turno {turno}:");
                Console.WriteLine($"Jogador: {hpJogador} HP | Inimigo: {hpInimigo} HP\n");

                turno++;

                // Pausa para visualização
                Console.WriteLine("Pressione Enter para continuar...");
                Console.ReadLine();
            }

            Console.WriteLine("\n=== FIM DO COMBATE ===");
            Console.WriteLine($"Total de turnos: {turno - 1}");
        }
    }
}


