using System;

namespace ExemplosJogos
{
    // Classe Arma com métodos de instância
    class Arma
    {
        public string Nome;
        public int Dano;
        public int Durabilidade;

        // Método para atacar
        public int Atacar()
        {
            if (Durabilidade > 0)
            {
                Durabilidade -= 5; // Perde durabilidade ao atacar
                return Dano;
            }
            return 0; // Arma quebrada não causa dano
        }

        // Método para reparar
        public void Reparar(int pontos)
        {
            Durabilidade += pontos;
            if (Durabilidade > 100)
                Durabilidade = 100; // Máximo 100%
        }

        // Método para verificar estado
        public string VerificarEstado()
        {
            if (Durabilidade > 75)
                return "Excelente";
            else if (Durabilidade > 50)
                return "Bom";
            else if (Durabilidade > 25)
                return "Desgastada";
            else if (Durabilidade > 0)
                return "Quase Quebrada";
            else
                return "Quebrada";
        }
    }

    class Programa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SISTEMA DE ARMAS ===\n");

            Arma espada = new Arma();
            espada.Nome = "Espada Flamejante";
            espada.Dano = 30;
            espada.Durabilidade = 80;

            Console.WriteLine($"Arma: {espada.Nome}");
            Console.WriteLine($"Estado: {espada.VerificarEstado()}\n");

            // Simular ataques
            Console.WriteLine("=== SIMULANDO ATAQUES ===");
            for (int i = 1; i <= 3; i++)
            {
                int dano = espada.Atacar();
                Console.WriteLine($"Ataque {i}: {dano} de dano | Durabilidade: {espada.Durabilidade}%");
            }

            Console.WriteLine($"\nEstado após ataques: {espada.VerificarEstado()}");

            // Reparar arma
            Console.WriteLine("\n=== REPARANDO ARMA ===");
            espada.Reparar(20);
            Console.WriteLine($"Durabilidade após reparo: {espada.Durabilidade}%");
            Console.WriteLine($"Estado: {espada.VerificarEstado()}");
        }
    }
}

