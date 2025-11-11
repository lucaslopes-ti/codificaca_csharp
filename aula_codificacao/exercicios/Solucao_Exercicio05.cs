using System;

namespace ExerciciosJogos
{
    // SOLUÇÃO DO EXERCÍCIO 1: CLASSE INIMIGO
    class Inimigo
    {
        // Propriedades
        public string Nome;
        public int HP;
        public int Dano;

        // Método para atacar
        public int Atacar()
        {
            Console.WriteLine($"{Nome} atacou causando {Dano} de dano!");
            return Dano;
        }

        // Método para receber dano
        public bool ReceberDano(int dano)
        {
            HP -= dano;
            
            if (HP <= 0)
            {
                HP = 0;
                Console.WriteLine($"💀 {Nome} foi derrotado!");
                return true; // Inimigo derrotado
            }
            else
            {
                Console.WriteLine($"{Nome} recebeu {dano} de dano! HP restante: {HP}");
                return false; // Inimigo ainda vivo
            }
        }
    }

    class Programa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SISTEMA DE INIMIGOS ===\n");

            // Criar 3 inimigos diferentes
            Inimigo goblin = new Inimigo();
            goblin.Nome = "Goblin";
            goblin.HP = 30;
            goblin.Dano = 5;

            Inimigo orc = new Inimigo();
            orc.Nome = "Orc";
            orc.HP = 60;
            orc.Dano = 12;

            Inimigo dragão = new Inimigo();
            dragão.Nome = "Dragão";
            dragão.HP = 150;
            dragão.Dano = 25;

            // Simular ataques
            Console.WriteLine("=== SIMULANDO ATAQUES ===\n");
            int danoGoblin = goblin.Atacar();
            int danoOrc = orc.Atacar();
            int danoDragao = dragão.Atacar();

            Console.WriteLine("\n=== SIMULANDO DANO RECEBIDO ===\n");

            // Atacar goblin até derrotá-lo
            while (!goblin.ReceberDano(10))
            {
                // Continua atacando
            }

            Console.WriteLine();

            // Atacar orc até derrotá-lo
            while (!orc.ReceberDano(15))
            {
                // Continua atacando
            }

            Console.WriteLine();

            // Atacar dragão até derrotá-lo
            while (!dragão.ReceberDano(30))
            {
                // Continua atacando
            }
        }
    }
}

