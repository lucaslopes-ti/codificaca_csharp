using System;

namespace ExemplosJogos
{
    class StatusPersonagem
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== VERIFICADOR DE STATUS DO PERSONAGEM ===\n");

            // Atributos do personagem
            int forca = 0;
            int agilidade = 0;
            int inteligencia = 0;
            int vitalidade = 0;

            // Coletar atributos
            Console.Write("Digite a Força: ");
            forca = int.Parse(Console.ReadLine());

            Console.Write("Digite a Agilidade: ");
            agilidade = int.Parse(Console.ReadLine());

            Console.Write("Digite a Inteligência: ");
            inteligencia = int.Parse(Console.ReadLine());

            Console.Write("Digite a Vitalidade: ");
            vitalidade = int.Parse(Console.ReadLine());

            // Calcular atributos derivados
            int hpMaximo = vitalidade * 10;
            int danoFisico = forca * 2;
            int danoMagico = inteligencia * 2;
            int velocidade = agilidade * 3;
            int defesa = vitalidade + (forca / 2);

            // Exibir status completo
            Console.WriteLine("\n=== STATUS DO PERSONAGEM ===");
            Console.WriteLine($"Força: {forca}");
            Console.WriteLine($"Agilidade: {agilidade}");
            Console.WriteLine($"Inteligência: {inteligencia}");
            Console.WriteLine($"Vitalidade: {vitalidade}");

            Console.WriteLine("\n=== ATRIBUTOS DERIVADOS ===");
            Console.WriteLine($"HP Máximo: {hpMaximo}");
            Console.WriteLine($"Dano Físico: {danoFisico}");
            Console.WriteLine($"Dano Mágico: {danoMagico}");
            Console.WriteLine($"Velocidade: {velocidade}");
            Console.WriteLine($"Defesa: {defesa}");

            // Classificar o personagem
            int totalAtributos = forca + agilidade + inteligencia + vitalidade;
            string classe = "";

            if (totalAtributos < 20)
            {
                classe = "Iniciante";
            }
            else if (totalAtributos < 40)
            {
                classe = "Aventureiro";
            }
            else if (totalAtributos < 60)
            {
                classe = "Veterano";
            }
            else if (totalAtributos < 80)
            {
                classe = "Mestre";
            }
            else
            {
                classe = "Lendário";
            }

            Console.WriteLine($"\n=== CLASSIFICAÇÃO ===");
            Console.WriteLine($"Total de Atributos: {totalAtributos}");
            Console.WriteLine($"Classe: {classe}");

            // Determinar especialização
            string especializacao = "";
            if (forca > agilidade && forca > inteligencia)
            {
                especializacao = "Guerreiro";
            }
            else if (agilidade > forca && agilidade > inteligencia)
            {
                especializacao = "Ladino";
            }
            else if (inteligencia > forca && inteligencia > agilidade)
            {
                especializacao = "Mago";
            }
            else
            {
                especializacao = "Equilibrado";
            }

            Console.WriteLine($"Especialização: {especializacao}");
        }
    }
}


