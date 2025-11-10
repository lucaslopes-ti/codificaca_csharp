using System;

namespace Exercicios
{
    class Exercicio04_SistemaPersonagemRPG
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== EXERCÍCIO 4: SISTEMA DE PERSONAGEM RPG ===\n");

            /*
             * OBJETIVO FINAL:
             * Criar um sistema completo de personagem RPG com múltiplas funcionalidades
             * 
             * REQUISITOS:
             * 
             * 1. CRIAR PERSONAGEM:
             *    - Nome (entrada do usuário)
             *    - Força (valor inicial: 10)
             *    - Agilidade (valor inicial: 10)
             *    - Inteligência (valor inicial: 10)
             *    - Vitalidade (valor inicial: 10)
             *    - Nível (inicial: 1)
             *    - XP (inicial: 0)
             * 
             * 2. CALCULAR ATRIBUTOS DERIVADOS:
             *    - HP Máximo = Vitalidade * 10
             *    - Dano Físico = Força * 2
             *    - Dano Mágico = Inteligência * 2
             *    - Velocidade = Agilidade * 3
             *    - Defesa = Vitalidade + (Força / 2)
             * 
             * 3. SISTEMA DE LEVEL UP:
             *    - XP necessário para próximo nível = Nível atual * 100
             *    - Quando ganha XP suficiente, aumenta o nível
             *    - Ao subir de nível, adiciona +2 pontos em cada atributo
             * 
             * 4. EXIBIR STATUS COMPLETO:
             *    - Criar um método que exibe todas as informações do personagem
             * 
             * 5. SIMULAR GANHO DE XP:
             *    - Criar um método que adiciona XP e verifica level up
             *    - Simular ganho de XP de uma batalha (ex: 150 XP)
             * 
             * DICAS:
             * - Use métodos para organizar o código
             * - Exemplo de métodos úteis:
             *   * ExibirStatus()
             *   * CalcularAtributosDerivados()
             *   * GanharXP(int xp)
             *   * VerificarLevelUp()
             */

            // TODO: Implemente seu código aqui

            // Variáveis do personagem
            string nome = "";
            int forca = 10;
            int agilidade = 10;
            int inteligencia = 10;
            int vitalidade = 10;
            int nivel = 1;
            int xp = 0;

            // Seu código aqui...

        }

        // TODO: Crie os métodos necessários aqui
        // Exemplo:
        // static void ExibirStatus(...) { ... }
        // static void GanharXP(...) { ... }
    }
}


