using System;

namespace ExemplosJogos
{
    class JogoAdivinhacao
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== JOGO DE ADIVINHAÇÃO ===\n");
            Console.WriteLine("Tente adivinhar o número secreto entre 1 e 100!");
            Console.WriteLine("Você tem 7 tentativas.\n");

            // Gerar número aleatório
            Random random = new Random();
            int numeroSecreto = random.Next(1, 101);
            int tentativas = 7;
            int tentativaAtual = 0;
            bool acertou = false;

            // Loop principal do jogo
            while (tentativaAtual < tentativas && !acertou)
            {
                tentativaAtual++;
                int tentativasRestantes = tentativas - tentativaAtual;

                Console.WriteLine($"--- Tentativa {tentativaAtual}/{tentativas} ---");
                Console.WriteLine($"Tentativas restantes: {tentativasRestantes}");
                Console.Write("Digite seu palpite: ");

                int palpite = int.Parse(Console.ReadLine());

                // Verificar o palpite
                if (palpite == numeroSecreto)
                {
                    acertou = true;
                    Console.WriteLine("\n🎉 PARABÉNS! Você acertou!");
                    Console.WriteLine($"Número secreto: {numeroSecreto}");
                    Console.WriteLine($"Tentativas usadas: {tentativaAtual}");

                    // Calcular pontuação
                    int pontuacao = (tentativas - tentativaAtual + 1) * 100;
                    Console.WriteLine($"Pontuação: {pontuacao} pontos");
                }
                else if (palpite < numeroSecreto)
                {
                    Console.WriteLine("📈 Muito baixo! Tente um número maior.");
                }
                else
                {
                    Console.WriteLine("📉 Muito alto! Tente um número menor.");
                }

                Console.WriteLine();
            }

            // Verificar se perdeu
            if (!acertou)
            {
                Console.WriteLine("💀 GAME OVER!");
                Console.WriteLine($"O número secreto era: {numeroSecreto}");
                Console.WriteLine("Tente novamente!");
            }

            // Perguntar se quer jogar novamente
            Console.Write("\nDeseja jogar novamente? (s/n): ");
            string resposta = Console.ReadLine().ToLower();

            if (resposta == "s" || resposta == "sim")
            {
                Console.Clear();
                Main(args); // Reiniciar o jogo
            }
            else
            {
                Console.WriteLine("Obrigado por jogar! Até logo!");
            }
        }
    }
}


