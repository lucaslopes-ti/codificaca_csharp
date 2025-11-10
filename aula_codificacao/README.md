# Aula de Codificação de Jogos Digitais - Primeira Aula

## 📚 Estrutura do Material

Este material foi desenvolvido para a primeira aula de 4 horas sobre **Codificação de Sistemas de Jogos Digitais** usando **C#**.

### 📁 Organização dos Arquivos

```
aula_codificacao/
│
├── 01_Plano_Aula.md          # Plano detalhado da aula de 4 horas
│
├── exemplos/                  # Exemplos práticos para demonstração
│   ├── 01_CalculadoraHP.cs
│   ├── 02_SistemaDificuldade.cs
│   ├── 03_StatusPersonagem.cs
│   ├── 04_CombatePorTurnos.cs
│   ├── 05_GeradorInimigos.cs
│   ├── 06_InventarioItens.cs
│   ├── 07_RankingJogadores.cs
│   ├── 08_CalculadoraDano.cs
│   └── 09_GeradorNomes.cs
│
├── exercicios/                # Exercícios para os alunos
│   ├── Exercicio01_ClassificacaoPontuacao.cs
│   ├── Exercicio02_SimuladorBatalha.cs
│   ├── Exercicio03_LojaItens.cs
│   ├── Exercicio04_SistemaPersonagemRPG.cs
│   └── Solucao_Exercicio01.cs (exemplo de solução)
│
└── README.md                  # Este arquivo
```

---

## 🎯 Objetivos da Aula

- Introduzir os alunos à linguagem C#
- Aplicar lógica de programação básica em contextos de jogos
- Desenvolver habilidades práticas através de exemplos e exercícios
- Criar uma base sólida para desenvolvimento de jogos digitais

---

## 📖 Conteúdos Abordados

### 1. **Fundamentos do C#**
   - Variáveis e tipos de dados
   - Operadores
   - Entrada e saída de dados

### 2. **Estruturas de Controle**
   - Condicionais (if/else, switch)
   - Loops (for, while, do-while)

### 3. **Arrays e Coleções**
   - Arrays unidimensionais
   - Manipulação de arrays
   - Introdução a Listas

### 4. **Métodos e Funções**
   - Criação de métodos
   - Parâmetros e retorno
   - Organização de código

---

## 🚀 Como Usar Este Material

### Para o Professor:

1. **Preparação**:
   - Revise o `01_Plano_Aula.md` para entender a estrutura completa
   - Teste todos os exemplos antes da aula
   - Prepare o ambiente de desenvolvimento (Visual Studio ou VS Code)

2. **Durante a Aula**:
   - Siga a sequência do plano de aula
   - Demonstre os exemplos em `exemplos/`
   - Oriente os alunos nos exercícios de `exercicios/`
   - Adapte o ritmo conforme o nível da turma

3. **Avaliação**:
   - Observe a participação dos alunos
   - Verifique o progresso nos exercícios
   - O Exercício 4 é o projeto integrador final

### Para os Alunos:

1. **Durante a Aula**:
   - Siga junto com os exemplos
   - Complete os exercícios na ordem proposta
   - Peça ajuda quando necessário

2. **Após a Aula**:
   - Revise os exemplos
   - Complete os exercícios que não terminou
   - Experimente modificar os códigos

---

## 💻 Requisitos Técnicos

### Software Necessário:
- **Visual Studio 2022** (Community é gratuito) OU
- **Visual Studio Code** + extensão C#
- **.NET SDK** (versão 6.0 ou superior)

### Instalação Rápida:

1. Baixe o Visual Studio Community: https://visualstudio.microsoft.com/
2. Durante a instalação, selecione a carga de trabalho "Desenvolvimento para desktop com .NET"
3. Ou instale o .NET SDK: https://dotnet.microsoft.com/download

---

## 📝 Exemplos Incluídos

### 1. CalculadoraHP.cs
Demonstra variáveis, operações matemáticas e condicionais através de um sistema de pontos de vida.

### 2. SistemaDificuldade.cs
Mostra o uso de switch/case para configurar diferentes níveis de dificuldade.

### 3. StatusPersonagem.cs
Aplica condicionais e cálculos para exibir status completo de um personagem.

### 4. CombatePorTurnos.cs
Implementa loops while para simular um sistema de combate por turnos.

### 5. GeradorInimigos.cs
Usa loops for e arrays para gerar inimigos aleatórios.

### 6. InventarioItens.cs
Demonstra manipulação de arrays e busca de elementos.

### 7. RankingJogadores.cs
Mostra ordenação de arrays e cálculos estatísticos.

### 8. CalculadoraDano.cs
Introduz métodos e funções com diferentes tipos de cálculo de dano.

### 9. GeradorNomes.cs
Aplica métodos para gerar nomes aleatórios de personagens.

---

## 🎮 Exercícios Propostos

### Exercício 1: Classificação de Pontuação
**Dificuldade**: ⭐  
**Foco**: Condicionais (if/else)  
**Tempo estimado**: 20 minutos

### Exercício 2: Simulador de Batalha
**Dificuldade**: ⭐⭐  
**Foco**: Loops e aleatoriedade  
**Tempo estimado**: 25 minutos

### Exercício 3: Loja de Itens
**Dificuldade**: ⭐⭐⭐  
**Foco**: Arrays e manipulação de dados  
**Tempo estimado**: 30 minutos

### Exercício 4: Sistema de Personagem RPG
**Dificuldade**: ⭐⭐⭐⭐  
**Foco**: Integração de todos os conceitos + Métodos  
**Tempo estimado**: 40 minutos

---

## 🔧 Como Compilar e Executar

### Usando Visual Studio:
1. Abra o arquivo `.cs`
2. Pressione `F5` para executar
3. Ou use `Ctrl + F5` para executar sem depuração

### Usando Terminal (PowerShell/CMD):
```bash
# Navegue até a pasta do arquivo
cd exemplos

# Compile
csc 01_CalculadoraHP.cs

# Execute
01_CalculadoraHP.exe
```

### Usando .NET CLI:
```bash
# Crie um novo projeto console
dotnet new console -n NomeDoProjeto

# Copie o código para Program.cs
# Execute
dotnet run
```

---

## 📚 Próximos Passos

Após esta primeira aula, os alunos estarão preparados para:
- Trabalhar com Programação Orientada a Objetos
- Entender conceitos de Unity (se for o caso)
- Desenvolver sistemas mais complexos de jogos
- Aplicar padrões de projeto em jogos digitais

---

## 💡 Dicas para o Professor

1. **Mantenha o ritmo**: Ajuste conforme a turma, mas tente manter o cronograma
2. **Incentive experimentação**: Deixe os alunos modificarem os exemplos
3. **Use analogias de jogos**: Relacione sempre com jogos conhecidos
4. **Celebre pequenas vitórias**: Reconheça quando um aluno completa um exercício
5. **Crie um ambiente colaborativo**: Incentive que os alunos se ajudem

---

## 🐛 Solução de Problemas Comuns

### Erro de compilação:
- Verifique se o .NET SDK está instalado
- Confirme que está usando a sintaxe correta do C#

### Programa não executa:
- Verifique se há um método `Main`
- Confirme que não há erros de sintaxe

### Dúvidas dos alunos:
- Revise os exemplos básicos primeiro
- Use o método de "debugging mental" (explicar linha por linha)

---

## 📞 Suporte

Para dúvidas ou sugestões sobre este material, entre em contato com o coordenador do curso.

---

**Boa aula! 🎮🚀**


