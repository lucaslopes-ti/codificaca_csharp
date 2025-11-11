using System;

namespace ExemplosJogos
{
    // Classe com métodos estáticos
    class CalculadoraJogo
    {
        // Método estático para calcular dano total
        public static int CalcularDanoTotal(int danoBase, int forca, int nivel)
        {
            return danoBase + (forca * 2) + (nivel * 3);
        }

        // Método estático para calcular experiência
        public static int CalcularExperiencia(int nivelInimigo, int nivelJogador)
        {
            int expBase = nivelInimigo * 10;
            if (nivelInimigo > nivelJogador)
            {
                // Bônus por derrotar inimigo mais forte
                int diferenca = nivelInimigo - nivelJogador;
                expBase += diferenca * 5;
            }
            return expBase;
        }

        // Método estático para gerar número aleatório
        public static int GerarNumeroAleatorio(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max + 1);
        }
    }

    class Programa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CALCULADORA DE JOGO ===\n");

            // Usar métodos estáticos sem criar objeto
            int dano = CalculadoraJogo.CalcularDanoTotal(30, 15, 5);
            Console.WriteLine($"Dano Total: {dano}");

            int experiencia = CalculadoraJogo.CalcularExperiencia(8, 5);
            Console.WriteLine($"Experiência Ganha: {experiencia} XP");

            Console.WriteLine("\n=== NÚMEROS ALEATÓRIOS ===");
            for (int i = 0; i < 5; i++)
            {
                int numero = CalculadoraJogo.GerarNumeroAleatorio(1, 100);
                Console.WriteLine($"Número {i + 1}: {numero}");
            }
        }
    }
}

