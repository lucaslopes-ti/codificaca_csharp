using System;

namespace ExerciciosJogos
{
    /*
     * PROJETO INTEGRADOR: SISTEMA DE BATALHA POR TURNOS
     * 
     * OBJETIVO: Criar um sistema completo de batalha integrando todos os conceitos de POO
     * 
     * REQUISITOS:
     * 
     * PARTE 1 - Classe Personagem:
     * 1. Propriedades:
     *    - Nome (string)
     *    - HP (int)
     *    - HP_Maximo (int)
     *    - Dano (int)
     *    - Nivel (int)
     * 
     * 2. Construtor que recebe Nome, HP_Maximo, Dano, Nivel
     *    - Inicializar HP com HP_Maximo
     * 
     * 3. Método Atacar() que:
     *    - Retorna o dano do personagem
     *    - Exibe: "{Nome} atacou!"
     * 
     * 4. Método ReceberDano(int dano) que:
     *    - Reduz HP
     *    - Se HP < 0, define como 0
     *    - Exibe: "{Nome} recebeu {dano} de dano! HP: {HP}/{HP_Maximo}"
     *    - Retorna true se está vivo, false se morreu
     * 
     * 5. Método EstaVivo() que retorna true se HP > 0
     * 
     * 6. Método ExibirStatus() que mostra todas as informações
     * 
     * PARTE 2 - Classe SistemaBatalha:
     * 1. Propriedades:
     *    - Jogador (Personagem)
     *    - Inimigo (Personagem)
     *    - Turno (int) - conta os turnos
     * 
     * 2. Construtor que recebe dois Personagens
     * 
     * 3. Método IniciarBatalha() que:
     *    - Exibe mensagem de início
     *    - Mostra status inicial de ambos
     *    - Chama LoopBatalha()
     * 
     * 4. Método LoopBatalha() que:
     *    - Enquanto ambos estão vivos:
     *      * Incrementa turno
     *      * Exibe número do turno
     *      * Jogador ataca inimigo
     *      * Verifica se inimigo morreu
     *      * Se inimigo vivo, inimigo ataca jogador
     *      * Verifica se jogador morreu
     *      * Exibe status de ambos
     *      * Pausa (Console.ReadKey())
     *    - Ao final, exibe vencedor
     * 
     * PARTE 3 - No Main:
     * - Criar personagem jogador
     * - Criar personagem inimigo
     * - Criar sistema de batalha
     * - Iniciar batalha
     * 
     * DESAFIO EXTRA (opcional):
     * - Adicionar sistema de defesa (reduz dano recebido)
     * - Adicionar chance de crítico (dano dobrado)
     * - Adicionar sistema de habilidades especiais
     * - Criar múltiplos inimigos
     * - Sistema de experiência e level up após vitória
     */

    // ESCREVA SEU CÓDIGO AQUI
    class Personagem
    {
        // TODO: Implementar classe Personagem completa
    }

    class SistemaBatalha
    {
        // TODO: Implementar classe SistemaBatalha completa
    }

    class Programa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SISTEMA DE BATALHA ===\n");

            // TODO: Criar personagens e iniciar batalha
        }
    }
}

