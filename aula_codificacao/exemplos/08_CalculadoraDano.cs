using System;

namespace ExemplosJogos
{
    class CalculadoraDano
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CALCULADORA DE DANO ===\n");

            // Exemplo de uso dos métodos
            int danoBase = 50;
            int forca = 20;
            int nivel = 5;

            int danoFinal = CalcularDano(danoBase, forca, nivel);
            Console.WriteLine($"Dano Base: {danoBase}");
            Console.WriteLine($"Força: {forca}");
            Console.WriteLine($"Nível: {nivel}");
            Console.WriteLine($"Dano Final: {danoFinal}\n");

            // Testar diferentes tipos de dano
            int danoFisico = CalcularDanoFisico(30, 15, 3);
            int danoMagico = CalcularDanoMagico(40, 25, 4);
            int danoCritico = CalcularDanoCritico(50, 20, 5, 2.5);

            Console.WriteLine("=== TIPOS DE DANO ===");
            Console.WriteLine($"Dano Físico: {danoFisico}");
            Console.WriteLine($"Dano Mágico: {danoMagico}");
            Console.WriteLine($"Dano Crítico: {danoCritico}");
        }

        // Método para calcular dano básico
        static int CalcularDano(int danoBase, int forca, int nivel)
        {
            int multiplicador = 1 + (nivel / 5); // Aumenta a cada 5 níveis
            int danoFinal = (danoBase + forca) * multiplicador;
            return danoFinal;
        }

        // Método para calcular dano físico
        static int CalcularDanoFisico(int danoBase, int forca, int nivel)
        {
            int bonusForca = forca * 2;
            int bonusNivel = nivel * 3;
            return danoBase + bonusForca + bonusNivel;
        }

        // Método para calcular dano mágico
        static int CalcularDanoMagico(int danoBase, int inteligencia, int nivel)
        {
            int bonusInteligencia = inteligencia * 3;
            int bonusNivel = nivel * 2;
            return danoBase + bonusInteligencia + bonusNivel;
        }

        // Método para calcular dano crítico
        static int CalcularDanoCritico(int danoBase, int atributo, int nivel, double multiplicadorCritico)
        {
            int danoNormal = CalcularDano(danoBase, atributo, nivel);
            int danoCritico = (int)(danoNormal * multiplicadorCritico);
            return danoCritico;
        }
    }
}


