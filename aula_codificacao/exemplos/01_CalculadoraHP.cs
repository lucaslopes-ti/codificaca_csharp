using System;

namespace ExemplosJogos
{
    class CalculadoraHP
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CALCULADORA DE PONTOS DE VIDA ===\n");

            // Variáveis para armazenar os dados
            int hpMaximo = 100;
            int hpAtual = 100;
            int danoRecebido = 0;

            // Exibir status inicial
            Console.WriteLine($"HP Máximo: {hpMaximo}");
            Console.WriteLine($"HP Atual: {hpAtual}");
            Console.WriteLine($"Porcentagem de vida: {(hpAtual * 100) / hpMaximo}%\n");

            // Simular dano
            Console.Write("Digite o dano recebido: ");
            string entrada = Console.ReadLine();
            danoRecebido = int.Parse(entrada);

            // Calcular novo HP
            hpAtual = hpAtual - danoRecebido;

            // Verificar se o personagem morreu
            if (hpAtual < 0)
            {
                hpAtual = 0;
                Console.WriteLine("\n💀 PERSONAGEM MORTO!");
            }
            else if (hpAtual == 0)
            {
                Console.WriteLine("\n⚠️ PERSONAGEM INCONSCIENTE!");
            }
            else
            {
                int porcentagem = (hpAtual * 100) / hpMaximo;
                Console.WriteLine($"\n❤️ HP Restante: {hpAtual}/{hpMaximo} ({porcentagem}%)");

                // Classificar status de vida
                if (porcentagem > 75)
                {
                    Console.WriteLine("Status: Saudável");
                }
                else if (porcentagem > 50)
                {
                    Console.WriteLine("Status: Ferido");
                }
                else if (porcentagem > 25)
                {
                    Console.WriteLine("Status: Gravemente Ferido");
                }
                else
                {
                    Console.WriteLine("Status: Crítico");
                }
            }
        }
    }
}


