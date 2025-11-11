# Aula de Codificação de Jogos Digitais - Segunda Aula

## 📚 Estrutura do Material

Este material foi desenvolvido para a segunda aula de 4 horas sobre **Programação Orientada a Objetos (POO)** aplicada a **Jogos Digitais** usando **C#**.

### 📁 Organização dos Arquivos

```
aula_codificacao/
│
├── 02_Plano_Aula.md              # Plano detalhado da segunda aula
├── Guia_Apresentacao_Aula02.md  # Guia para o professor
│
├── exemplos/                      # Exemplos práticos para demonstração
│   ├── 11_StatusArma.cs          # Revisão: Sistema de status
│   ├── 12_ClassePersonagem.cs    # Primeira classe simples
│   ├── 13_ClasseItem.cs          # Propriedades e encapsulamento
│   ├── 14_ClasseArma.cs          # Métodos de instância
│   ├── 15_ClassePocao.cs         # Construtores
│   ├── 16_PersonagemInventario.cs # Composição
│   └── 17_CalculadoraJogo.cs     # Métodos estáticos
│
├── exercicios/                    # Exercícios para os alunos
│   ├── Exercicio05_Inimigo.cs    # Exercício 1: Classe Inimigo
│   ├── Exercicio06_Habilidade.cs # Exercício 2: Sistema de Habilidades
│   ├── Exercicio07_SistemaMissao.cs # Exercício 3: Sistema de Missões
│   ├── Exercicio08_SistemaBatalha.cs # Projeto: Sistema de Batalha
│   └── Solucao_Exercicio05.cs    # Solução do exercício 1 (exemplo)
│
└── README_Aula02.md              # Este arquivo
```

---

## 🎯 Objetivos da Aula

- Revisar conceitos fundamentais da primeira aula
- Introduzir Programação Orientada a Objetos (POO)
- Aplicar POO em contextos práticos de jogos
- Desenvolver habilidades de organização de código
- Criar sistemas mais complexos e reutilizáveis

---

## 📖 Conteúdos Abordados

### 1. **Revisão Interativa**
   - Quiz rápido de conceitos
   - Mini desafio prático
   - Consolidação de conhecimentos

### 2. **Introdução a POO**
   - Classes e Objetos
   - Propriedades
   - Métodos de instância
   - Construtores

### 3. **Conceitos Avançados**
   - Encapsulamento básico
   - Composição (relacionamentos entre classes)
   - Métodos estáticos

### 4. **Projeto Integrador**
   - Sistema de Batalha por Turnos
   - Integração de todos os conceitos

---

## 🚀 Como Usar Este Material

### Para o Professor:

1. **Preparação**:
   - Revise o `02_Plano_Aula.md` para entender a estrutura completa
   - Leia o `Guia_Apresentacao_Aula02.md` para dicas de apresentação
   - Teste todos os exemplos antes da aula
   - Prepare o ambiente de desenvolvimento

2. **Durante a Aula**:
   - Siga a sequência do plano de aula
   - **NÃO PULE A REVISÃO** - ela é essencial
   - Demonstre os exemplos em `exemplos/`
   - Oriente os alunos nos exercícios de `exercicios/`
   - Adapte o ritmo conforme o nível da turma

3. **Avaliação**:
   - Observe a participação dos alunos
   - Verifique o progresso nos exercícios
   - O Exercício 8 é o projeto integrador final

### Para os Alunos:

1. **Durante a Aula**:
   - Participe ativamente da revisão
   - Siga junto com os exemplos
   - Complete os exercícios na ordem proposta
   - Peça ajuda quando necessário

2. **Após a Aula**:
   - Revise os exemplos
   - Complete os exercícios que não terminou
   - Experimente criar suas próprias classes
   - Modifique os códigos para aprender mais

---

## 💻 Requisitos Técnicos

### Software Necessário:
- **Visual Studio 2022** (Community é gratuito) OU
- **Visual Studio Code** + extensão C#
- **.NET SDK** (versão 6.0 ou superior)

### Pré-requisitos:
- Ter completado a primeira aula
- Conhecimento básico de:
  - Variáveis e tipos
  - Condicionais (if/else, switch)
  - Loops (for, while)
  - Arrays
  - Métodos básicos

---

## 📝 Exemplos Incluídos

### 11. StatusArma.cs
**Revisão**: Demonstra variáveis, condicionais e cálculos através de um sistema de status de arma.

### 12. ClassePersonagem.cs
**Primeira Classe**: Introduz o conceito de classe e objeto através de personagens simples.

### 13. ClasseItem.cs
**Encapsulamento**: Mostra como proteger dados usando propriedades privadas e públicas.

### 14. ClasseArma.cs
**Métodos de Instância**: Demonstra métodos que trabalham com dados do objeto.

### 15. ClassePocao.cs
**Construtores**: Mostra diferentes formas de inicializar objetos.

### 16. PersonagemInventario.cs
**Composição**: Demonstra relacionamento entre classes (personagem contém itens).

### 17. CalculadoraJogo.cs
**Métodos Estáticos**: Introduz métodos que não precisam de instância de objeto.

---

## 🎮 Exercícios Propostos

### Exercício 1: Classe Inimigo
**Dificuldade**: ⭐  
**Foco**: Classes básicas, propriedades, métodos simples  
**Tempo estimado**: 15 minutos

Criar uma classe Inimigo com propriedades e métodos para atacar e receber dano.

### Exercício 2: Sistema de Habilidades
**Dificuldade**: ⭐⭐  
**Foco**: Construtores, métodos com lógica, validações  
**Tempo estimado**: 20 minutos

Criar sistema de habilidades com custo de mana e tempo de recarga.

### Exercício 3: Sistema de Missões
**Dificuldade**: ⭐⭐⭐  
**Foco**: Relacionamentos entre classes, métodos estáticos  
**Tempo estimado**: 30 minutos

Criar sistema completo de missões com jogador e experiência.

### Exercício 4: Sistema de Batalha
**Dificuldade**: ⭐⭐⭐⭐  
**Foco**: Integração de todos os conceitos  
**Tempo estimado**: 40 minutos

Criar sistema completo de batalha por turnos integrando todas as classes.

---

## 🔧 Como Compilar e Executar

### Usando Visual Studio:
1. Abra o arquivo `.cs`
2. Pressione `F5` para executar
3. Ou use `Ctrl + F5` para executar sem depuração

### Usando .NET CLI:
```bash
# Crie um novo projeto console
dotnet new console -n NomeDoProjeto

# Copie o código para Program.cs
# Execute
dotnet run
```

---

## 🎯 Diferenciais desta Aula

### ✨ Revisão Interativa
- Não apenas repetição, mas aplicação prática
- Quiz rápido para reativar conhecimento
- Mini desafio para consolidar conceitos

### ✨ Exemplos Enxutos
- Código focado e direto ao ponto
- Sem complexidade desnecessária
- Fácil de entender e seguir

### ✨ Exercícios Criativos
- Contextos práticos de jogos
- Aplicados ao curso técnico
- Espaço para criatividade e inovação

### ✨ Progressão Gradual
- Do simples ao complexo
- Cada conceito constrói sobre o anterior
- Integração final com projeto completo

---

## 📚 Próximos Passos

Após esta segunda aula, os alunos estarão preparados para:
- Trabalhar com Herança e Polimorfismo
- Entender conceitos avançados de POO
- Aplicar padrões de projeto em jogos
- Desenvolver sistemas mais complexos
- Trabalhar com Unity (se for o caso)

---

## 💡 Dicas para o Professor

1. **Revisão é Essencial**: Não pule a revisão, ela é fundamental para o sucesso da aula
2. **Use Analogias**: Molde/bolo, receita/prato ajudam muito
3. **Código Junto**: Sempre codifique junto com os alunos
4. **Incentive Experimentação**: Deixe os alunos modificarem os exemplos
5. **Celebre Progressos**: Reconheça quando um aluno completa um exercício
6. **Seja Paciente**: POO pode ser abstrato no início
7. **Use Exemplos Visuais**: Desenhe no quadro se possível

---

## 🐛 Solução de Problemas Comuns

### Erro: "Não consigo criar objeto"
- Verifique se usou `new` antes do nome da classe
- Confirme que a classe existe e está acessível

### Erro: "Propriedade não encontrada"
- Verifique se a propriedade é `public`
- Confirme o nome da propriedade (case-sensitive)

### Erro: "Método não encontrado"
- Verifique se o método é `public`
- Confirme os parâmetros do método

### Dúvidas dos alunos:
- Revise os exemplos básicos primeiro
- Use analogias (molde/bolo)
- Mostre código linha por linha

---

## 🎓 Conceitos-Chave

### Classe vs Objeto
- **Classe**: Molde, template, definição
- **Objeto**: Instância, exemplo concreto

### Propriedades
- Características do objeto
- Podem ser públicas ou privadas
- Armazenam dados do objeto

### Métodos
- Ações que o objeto pode realizar
- Podem modificar propriedades
- Podem retornar valores

### Construtores
- Inicializam o objeto
- Podem receber parâmetros
- Garantem valores válidos

---

## 📞 Suporte

Para dúvidas ou sugestões sobre este material, entre em contato com o coordenador do curso.

---

**Boa aula! 🎮🚀**

