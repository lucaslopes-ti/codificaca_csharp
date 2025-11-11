using System;

namespace ExerciciosJogos
{
    /*
     * EXERCÍCIO 3: SISTEMA DE MISSÕES
     * 
     * OBJETIVO: Criar sistema de missões com relacionamento entre classes
     * 
     * REQUISITOS:
     * 
     * PARTE 1 - Classe Missao:
     * 1. Propriedades:
     *    - Nome (string)
     *    - Descricao (string)
     *    - Experiencia (int)
     *    - Concluida (bool)
     * 
     * 2. Construtor que recebe Nome, Descricao e Experiencia
     *    - Inicializar Concluida como false
     * 
     * 3. Método Concluir() que:
     *    - Define Concluida como true
     *    - Exibe: "Missão '{Nome}' concluída! Ganhou {Experiencia} XP"
     *    - Retorna a experiência ganha
     * 
     * PARTE 2 - Classe Jogador:
     * 1. Propriedades:
     *    - Nome (string)
     *    - Nivel (int)
     *    - Experiencia (int)
     *    - Lista de Missões (array de Missao)
     *    - Quantidade de missões (int)
     * 
     * 2. Construtor que recebe Nome e Nivel
     *    - Inicializar Experiencia como 0
     *    - Criar array de missões com tamanho 10
     *    - Quantidade de missões começa em 0
     * 
     * 3. Método AdicionarMissao(Missao missao) que:
     *    - Adiciona missão ao array
     *    - Exibe: "Nova missão adicionada: {Nome}"
     * 
     * 4. Método ConcluirMissao(int indice) que:
     *    - Verifica se o índice é válido
     *    - Verifica se a missão não está concluída
     *    - Chama o método Concluir() da missão
     *    - Adiciona experiência ao jogador
     *    - Verifica se o jogador subiu de nível (a cada 100 XP = 1 nível)
     * 
     * 5. Método ListarMissoes() que:
     *    - Exibe todas as missões do jogador
     *    - Mostra status (Concluída ou Pendente)
     * 
     * 6. Método estático CalcularExperienciaTotal(Missao[] missoes) que:
     *    - Recebe array de missões
     *    - Retorna a soma da experiência de todas as missões concluídas
     * 
     * PARTE 3 - No Main:
     * - Criar um jogador
     * - Criar 3-4 missões diferentes
     * - Adicionar missões ao jogador
     * - Listar missões
     * - Concluir algumas missões
     * - Verificar nível e experiência do jogador
     * - Usar método estático para calcular experiência total
     * 
     * DESAFIO EXTRA (opcional):
     * - Adicionar tipo de missão (Principal, Secundária, Diária)
     * - Criar sistema de recompensas além de experiência
     */

    // ESCREVA SEU CÓDIGO AQUI
    class Missao
    {
        // TODO: Propriedades e métodos da classe Missao
    }

    class Jogador
    {
        // TODO: Propriedades e métodos da classe Jogador
    }

    class Programa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SISTEMA DE MISSÕES ===\n");

            // TODO: Implementar o sistema completo
        }
    }
}

