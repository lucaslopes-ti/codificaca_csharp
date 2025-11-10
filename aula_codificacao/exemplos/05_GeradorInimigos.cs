using System;

namespace ExemplosJogos
{
    class GeradorInimigos
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== GERADOR DE INIMIGOS ===\n");

            // Tipos de inimigos
            string[] tiposInimigos = { "Goblin", "Orc", "Esqueleto", "Dragão", "Lobo" };
            int[] hpInimigos = { 30, 50, 40, 200, 25 };
            int[] danoInimigos = { 5, 10, 8, 50, 4 };

            // Gerar 5 inimigos aleatórios
            Random random = new Random();
            int quantidadeInimigos = 5;

            Console.WriteLine($"Gerando {quantidadeInimigos} inimigos...\n");

            for (int i = 0; i < quantidadeInimigos; i++)
            {
                // Selecionar tipo aleatório
                int indiceAleatorio = random.Next(0, tiposInimigos.Length);
                string tipo = tiposInimigos[indiceAleatorio];
                int hp = hpInimigos[indiceAleatorio];
                int dano = danoInimigos[indiceAleatorio];

                // Adicionar variação aleatória
                int variacaoHP = random.Next(-5, 6);
                int variacaoDano = random.Next(-2, 3);

                hp += variacaoHP;
                dano += variacaoDano;

                // Garantir valores mínimos
                if (hp < 1) hp = 1;
                if (dano < 1) dano = 1;

                Console.WriteLine($"Inimigo #{i + 1}:");
                Console.WriteLine($"  Tipo: {tipo}");
                Console.WriteLine($"  HP: {hp}");
                Console.WriteLine($"  Dano: {dano}");
                Console.WriteLine();
            }

            // Contar quantos de cada tipo foram gerados
            Console.WriteLine("=== ESTATÍSTICAS ===");
            for (int i = 0; i < tiposInimigos.Length; i++)
            {
                int contador = 0;
                for (int j = 0; j < quantidadeInimigos; j++)
                {
                    // Simular contagem (em um caso real, você guardaria os inimigos gerados)
                    int indiceAleatorio = random.Next(0, tiposInimigos.Length);
                    if (indiceAleatorio == i) contador++;
                }
                Console.WriteLine($"{tiposInimigos[i]}: {contador} inimigo(s)");
            }
        }
    }
}


