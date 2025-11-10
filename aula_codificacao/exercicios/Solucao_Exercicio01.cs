using System;

namespace Exercicios
{
    class Solucao_Exercicio01
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SOLUÇÃO: SISTEMA DE CLASSIFICAÇÃO DE PONTUAÇÃO ===\n");

            Console.Write("Digite a pontuação do jogador: ");
            int pontuacao = int.Parse(Console.ReadLine());

            // Verificar se a pontuação é válida
            if (pontuacao < 0)
            {
                Console.WriteLine("❌ Erro: Pontuação não pode ser negativa!");
                return;
            }

            string classificacao = "";
            string mensagem = "";

            // Classificar a pontuação
            if (pontuacao >= 0 && pontuacao <= 100)
            {
                classificacao = "Bronze";
                mensagem = "Continue praticando! Você está no caminho certo!";
            }
            else if (pontuacao >= 101 && pontuacao <= 500)
            {
                classificacao = "Prata";
                mensagem = "Ótimo progresso! Você está melhorando!";
            }
            else if (pontuacao >= 501 && pontuacao <= 1000)
            {
                classificacao = "Ouro";
                mensagem = "Excelente! Você é um jogador habilidoso!";
            }
            else // 1001 ou mais
            {
                classificacao = "Platina";
                mensagem = "Incrível! Você é um mestre do jogo!";
            }

            // Exibir resultado
            Console.WriteLine($"\n=== RESULTADO ===");
            Console.WriteLine($"Pontuação: {pontuacao}");
            Console.WriteLine($"Classificação: {classificacao}");
            Console.WriteLine($"Mensagem: {mensagem}");
        }
    }
}


