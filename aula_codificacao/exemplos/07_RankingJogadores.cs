using System;

namespace ExemplosJogos
{
    class RankingJogadores
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== RANKING DE JOGADORES ===\n");

            // Arrays paralelos para armazenar dados
            string[] nomes = { "Player1", "Player2", "Player3", "Player4", "Player5" };
            int[] pontuacoes = { 1250, 890, 2100, 450, 1750 };
            int[] niveis = { 15, 12, 25, 8, 20 };

            // Exibir ranking original
            Console.WriteLine("=== RANKING ORIGINAL ===");
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine($"{i + 1}º - {nomes[i]} | Pontuação: {pontuacoes[i]} | Nível: {niveis[i]}");
            }

            // Ordenar por pontuação (Bubble Sort simples)
            Console.WriteLine("\nOrdenando por pontuação...\n");

            for (int i = 0; i < pontuacoes.Length - 1; i++)
            {
                for (int j = 0; j < pontuacoes.Length - 1 - i; j++)
                {
                    if (pontuacoes[j] < pontuacoes[j + 1])
                    {
                        // Trocar pontuações
                        int tempPontuacao = pontuacoes[j];
                        pontuacoes[j] = pontuacoes[j + 1];
                        pontuacoes[j + 1] = tempPontuacao;

                        // Trocar nomes
                        string tempNome = nomes[j];
                        nomes[j] = nomes[j + 1];
                        nomes[j + 1] = tempNome;

                        // Trocar níveis
                        int tempNivel = niveis[j];
                        niveis[j] = niveis[j + 1];
                        niveis[j + 1] = tempNivel;
                    }
                }
            }

            // Exibir ranking ordenado
            Console.WriteLine("=== RANKING ORDENADO (Maior para Menor) ===");
            for (int i = 0; i < nomes.Length; i++)
            {
                string medalha = "";
                if (i == 0) medalha = "🥇";
                else if (i == 1) medalha = "🥈";
                else if (i == 2) medalha = "🥉";
                else medalha = "  ";

                Console.WriteLine($"{medalha} {i + 1}º - {nomes[i]} | Pontuação: {pontuacoes[i]} | Nível: {niveis[i]}");
            }

            // Estatísticas
            int maiorPontuacao = pontuacoes[0];
            int menorPontuacao = pontuacoes[pontuacoes.Length - 1];
            int somaPontuacoes = 0;

            for (int i = 0; i < pontuacoes.Length; i++)
            {
                somaPontuacoes += pontuacoes[i];
            }

            double mediaPontuacoes = (double)somaPontuacoes / pontuacoes.Length;

            Console.WriteLine("\n=== ESTATÍSTICAS ===");
            Console.WriteLine($"Maior pontuação: {maiorPontuacao}");
            Console.WriteLine($"Menor pontuação: {menorPontuacao}");
            Console.WriteLine($"Média de pontuações: {mediaPontuacoes:F2}");
        }
    }
}


