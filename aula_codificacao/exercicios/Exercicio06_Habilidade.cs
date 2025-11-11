using System;

namespace ExerciciosJogos
{
    /*
     * EXERCÍCIO 2: SISTEMA DE HABILIDADES
     * 
     * OBJETIVO: Criar uma classe Habilidade com construtor e métodos
     * 
     * REQUISITOS:
     * 1. Criar classe Habilidade com:
     *    - Nome (string)
     *    - Dano (int)
     *    - CustoMana (int)
     *    - TempoRecarga (int) - em segundos
     *    - Disponivel (bool) - indica se pode usar
     * 
     * 2. Criar construtor que recebe:
     *    - Nome, Dano, CustoMana, TempoRecarga
     *    - Inicializar Disponivel como true
     * 
     * 3. Criar método Usar(int manaAtual) que:
     *    - Verifica se tem mana suficiente (manaAtual >= CustoMana)
     *    - Verifica se está disponível (Disponivel == true)
     *    - Se puder usar:
     *      * Retorna o dano
     *      * Define Disponivel como false
     *      * Exibe: "{Nome} usada! Causou {Dano} de dano!"
     *    - Se não puder usar:
     *      * Retorna 0
     *      * Exibe mensagem apropriada (sem mana ou em recarga)
     * 
     * 4. Criar método Recarregar() que:
     *    - Define Disponivel como true
     *    - Exibe: "{Nome} recarregada e pronta para uso!"
     * 
     * 5. No Main:
     *    - Criar 3 habilidades diferentes
     *    - Testar usar cada habilidade com diferentes valores de mana
     *    - Testar recarregar habilidades
     * 
     * DESAFIO EXTRA (opcional):
     * - Adicionar propriedade Tipo (Física, Mágica, Especial)
     * - Criar método que calcula dano baseado no tipo
     */

    // ESCREVA SEU CÓDIGO AQUI
    class Habilidade
    {
        // TODO: Adicionar propriedades
        
        // TODO: Criar construtor
        
        // TODO: Criar método Usar()
        
        // TODO: Criar método Recarregar()
    }

    class Programa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SISTEMA DE HABILIDADES ===\n");

            // TODO: Criar habilidades e testar
        }
    }
}

