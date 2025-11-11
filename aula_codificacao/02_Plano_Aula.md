# Plano de Aula - Segunda Aula: Programação Orientada a Objetos em Jogos

## Informações Gerais
- **Duração**: 4 horas
- **Objetivo**: Introduzir Programação Orientada a Objetos (POO) através de exemplos práticos e criativos aplicados a jogos digitais
- **Foco**: Classes, objetos, propriedades e métodos aplicados a sistemas de jogos
- **Pré-requisito**: Primeira aula (variáveis, condicionais, loops, arrays, métodos básicos)

---

## Estrutura da Aula (4 horas)

### **Bloco 1: Revisão Interativa e Aquecimento (40 minutos)**

#### 1.1 Revisão Rápida - Quiz de Conceitos (15 min)
- **Atividade**: Quiz rápido sobre conceitos da primeira aula
  - Variáveis e tipos
  - Condicionais (if/else, switch)
  - Loops (for, while)
  - Arrays
  - Métodos básicos
- **Formato**: Perguntas e respostas rápidas, alunos respondem em voz alta

#### 1.2 Revisão Prática - Mini Desafio (15 min)
- **Desafio Rápido**: Sistema de Status de Arma
  - Criar variáveis para nome, dano, durabilidade
  - Usar condicionais para classificar qualidade (Comum, Raro, Épico, Lendário)
  - Exibir status completo
- **Objetivo**: Reativar conhecimento prévio de forma prática

#### 1.3 Apresentação do Tema (10 min)
- O que é Programação Orientada a Objetos?
- Por que usar POO em jogos?
- Conceitos: Classe, Objeto, Propriedade, Método
- Analogia: "Classe = Molde, Objeto = Bolo feito com o molde"

---

### **Bloco 2: Introdução a Classes e Objetos (50 minutos)**

#### 2.1 Primeira Classe - Personagem Simples (20 min)
- **Exemplo Curto**: Classe `Personagem` com propriedades básicas
  - Nome, HP, Nível
  - Método para exibir status
- **Demonstração**: Criar 2-3 objetos diferentes
- **Código focado**: Apenas o essencial, sem complexidade

#### 2.2 Propriedades e Encapsulamento (15 min)
- **Exemplo Curto**: Classe `Item` com propriedades públicas e privadas
  - Nome, Preço, Quantidade
  - Validação básica (preço não pode ser negativo)
- **Conceito**: Por que proteger dados?

#### 2.3 Exercício Prático 1 (15 min)
- **Exercício**: Criar classe `Inimigo`
  - Propriedades: Nome, HP, Dano
  - Método: `Atacar()` que retorna o dano
  - Criar 3 inimigos diferentes e simular ataques

---

### **Intervalo (15 minutos)**

---

### **Bloco 3: Métodos em Classes e Construtores (50 minutos)**

#### 3.1 Métodos de Instância (20 min)
- **Exemplo Curto**: Classe `Arma` com métodos
  - `Atacar()` - calcula dano
  - `Reparar()` - restaura durabilidade
  - `VerificarEstado()` - retorna status da arma
- **Foco**: Métodos que trabalham com dados do objeto

#### 3.2 Construtores (15 min)
- **Exemplo Curto**: Classe `Pocao` com construtor
  - Construtor padrão e com parâmetros
  - Inicialização de propriedades
- **Demonstração**: Criar poções de diferentes formas

#### 3.3 Exercício Prático 2 (15 min)
- **Exercício**: Sistema de Habilidade
  - Classe `Habilidade` com:
    - Nome, Dano, CustoMana, TempoRecarga
    - Construtor que recebe todos os parâmetros
    - Método `Usar()` que verifica se pode usar e retorna dano
  - Criar 3 habilidades diferentes

---

### **Bloco 4: Relacionamentos entre Classes (50 minutos)**

#### 4.1 Composição - Personagem com Inventário (20 min)
- **Exemplo Curto**: Classe `Personagem` que contém `Item[]`
  - Personagem tem um array de itens
  - Método `AdicionarItem()`
  - Método `ListarInventario()`
- **Conceito**: Um objeto pode conter outros objetos

#### 4.2 Métodos Estáticos (15 min)
- **Exemplo Curto**: Classe `CalculadoraJogo` com métodos estáticos
  - `CalcularDanoTotal()`
  - `CalcularExperiencia()`
  - `GerarNumeroAleatorio()`
- **Conceito**: Métodos que não precisam de objeto

#### 4.3 Exercício Prático 3 (15 min)
- **Exercício**: Sistema de Missão
  - Classe `Missao` com: Nome, Descricao, Experiencia, Concluida
  - Classe `Jogador` com: Nome, Nivel, Experiencia, Lista de Missões
  - Método para adicionar missão e concluir missão
  - Método estático para calcular experiência total

---

### **Bloco 5: Projeto Integrador - Sistema de Batalha (40 minutos)**

#### 5.1 Planejamento do Sistema (10 min)
- Discutir com alunos: O que precisa ter?
- Estrutura: Personagem, Inimigo, Sistema de Batalha

#### 5.2 Implementação Guiada (20 min)
- Criar classes básicas junto com os alunos
- Implementar sistema de turnos simples
- Integrar todos os conceitos aprendidos

#### 5.3 Apresentação e Desafios (10 min)
- Alunos apresentam suas soluções
- Propor melhorias e extensões

---

### **Encerramento (10 minutos)**
- Revisão dos conceitos de POO aprendidos
- Diferenças entre programação procedural e orientada a objetos
- Próximos passos: Herança e Polimorfismo
- Dúvidas e feedback

---

## Recursos Necessários
- Visual Studio ou Visual Studio Code instalado
- .NET SDK instalado
- Exemplos preparados e testados
- Exercícios disponíveis para prática

---

## Metodologia
- **Revisão Ativa**: Quiz e desafio prático para reativar conhecimento
- **Exemplos Curtos**: Código focado, sem complexidade desnecessária
- **Exercícios Criativos**: Contextos de jogos que engajam os alunos
- **Progressão Gradual**: Do simples (classe básica) ao complexo (relacionamentos)
- **Hands-on**: Alunos codificam junto com o professor

---

## Diferenciais desta Aula
- **Revisão Interativa**: Não apenas repetição, mas aplicação prática
- **Exemplos Enxutos**: Código mais curto e direto ao ponto
- **Exercícios Aplicados**: Contextos técnicos e práticos de jogos
- **Criatividade**: Espaço para alunos personalizarem e inovarem

---

## Avaliação
- Participação no quiz de revisão
- Completar pelo menos 2 dos 3 exercícios práticos
- Entregar o projeto integrador (Sistema de Batalha)
- Demonstração de entendimento dos conceitos de POO

---

## Adaptações Possíveis

### Se a turma estiver com dificuldade:
- Estender tempo na revisão
- Simplificar exercícios
- Focar mais em exemplos práticos

### Se a turma estiver avançada:
- Adicionar conceitos de herança básica
- Propor desafios extras nos exercícios
- Introduzir conceitos de encapsulamento avançado

