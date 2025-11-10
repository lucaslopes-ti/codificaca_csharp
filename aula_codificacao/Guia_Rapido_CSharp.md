# Guia Rápido de Sintaxe C# para Jogos

## 📝 Estrutura Básica de um Programa

```csharp
using System;

namespace MeuJogo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Seu código aqui
        }
    }
}
```

---

## 🔤 Variáveis e Tipos de Dados

```csharp
// Números inteiros
int idade = 25;
int hp = 100;

// Números decimais
float altura = 1.75f;
double precisao = 0.95;

// Texto
string nome = "Jogador";
char inicial = 'J';

// Booleano (verdadeiro/falso)
bool estaVivo = true;
bool temArma = false;
```

---

## ➕ Operadores

### Aritméticos
```csharp
int soma = 10 + 5;        // 15
int subtracao = 10 - 5;   // 5
int multiplicacao = 10 * 5; // 50
int divisao = 10 / 5;     // 2
int resto = 10 % 3;       // 1 (resto da divisão)
```

### Comparação
```csharp
bool igual = (10 == 10);        // true
bool diferente = (10 != 5);     // true
bool maior = (10 > 5);          // true
bool menor = (5 < 10);          // true
bool maiorIgual = (10 >= 10);   // true
bool menorIgual = (5 <= 10);    // true
```

### Lógicos
```csharp
bool e = (true && false);   // false (E)
bool ou = (true || false);  // true (OU)
bool nao = !true;           // false (NÃO)
```

---

## 🔀 Estruturas Condicionais

### if/else
```csharp
if (hp > 0)
{
    Console.WriteLine("Personagem vivo!");
}
else
{
    Console.WriteLine("Personagem morto!");
}
```

### if/else if/else
```csharp
if (pontuacao >= 1000)
{
    Console.WriteLine("Platina!");
}
else if (pontuacao >= 500)
{
    Console.WriteLine("Ouro!");
}
else if (pontuacao >= 100)
{
    Console.WriteLine("Prata!");
}
else
{
    Console.WriteLine("Bronze!");
}
```

### switch/case
```csharp
switch (dificuldade)
{
    case 1:
        Console.WriteLine("Fácil");
        break;
    case 2:
        Console.WriteLine("Normal");
        break;
    case 3:
        Console.WriteLine("Difícil");
        break;
    default:
        Console.WriteLine("Inválido");
        break;
}
```

---

## 🔁 Loops

### for
```csharp
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Contador: {i}");
}
```

### while
```csharp
int contador = 0;
while (contador < 10)
{
    Console.WriteLine($"Contador: {contador}");
    contador++;
}
```

### do-while
```csharp
int contador = 0;
do
{
    Console.WriteLine($"Contador: {contador}");
    contador++;
} while (contador < 10);
```

---

## 📦 Arrays

### Declaração e Inicialização
```csharp
// Array de inteiros
int[] numeros = new int[5];
int[] valores = { 10, 20, 30, 40, 50 };

// Array de strings
string[] itens = new string[10];
string[] nomes = { "João", "Maria", "Pedro" };
```

### Acesso e Manipulação
```csharp
int[] pontos = { 100, 200, 300 };

// Acessar elemento (índice começa em 0)
int primeiro = pontos[0];  // 100
int segundo = pontos[1];   // 200

// Modificar elemento
pontos[0] = 150;

// Tamanho do array
int tamanho = pontos.Length;  // 3
```

### Percorrer Array
```csharp
int[] itens = { 10, 20, 30 };

for (int i = 0; i < itens.Length; i++)
{
    Console.WriteLine(itens[i]);
}
```

---

## 📝 Entrada e Saída

### Saída (Console)
```csharp
Console.WriteLine("Olá, mundo!");           // Com quebra de linha
Console.Write("Digite seu nome: ");        // Sem quebra de linha
Console.WriteLine($"HP: {hp}");            // Interpolação de strings
```

### Entrada (Console)
```csharp
string nome = Console.ReadLine();                    // Lê uma linha
int numero = int.Parse(Console.ReadLine());          // Converte para int
double valor = double.Parse(Console.ReadLine());     // Converte para double
```

---

## 🎲 Números Aleatórios

```csharp
Random random = new Random();

int numero = random.Next(1, 101);      // Entre 1 e 100
int dado = random.Next(1, 7);          // Entre 1 e 6 (dado)
double porcentagem = random.NextDouble(); // Entre 0.0 e 1.0
```

---

## 🔧 Métodos (Funções)

### Método sem retorno (void)
```csharp
static void ExibirStatus(int hp, int nivel)
{
    Console.WriteLine($"HP: {hp}");
    Console.WriteLine($"Nível: {nivel}");
}
```

### Método com retorno
```csharp
static int CalcularDano(int forca, int nivel)
{
    int dano = forca * 2 + nivel * 5;
    return dano;
}
```

### Chamada de métodos
```csharp
ExibirStatus(100, 5);
int danoFinal = CalcularDano(20, 3);
```

---

## 💡 Dicas Importantes

1. **Índices começam em 0**: O primeiro elemento de um array é `[0]`
2. **Case-sensitive**: `HP` é diferente de `hp`
3. **Ponto e vírgula**: Sempre termine instruções com `;`
4. **Chaves**: Use `{ }` para blocos de código
5. **Comentários**: Use `//` para linha única ou `/* */` para múltiplas linhas

---

## 🎮 Exemplo Completo

```csharp
using System;

namespace ExemploJogo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variáveis
            int hp = 100;
            string nome = "Guerreiro";
            
            // Entrada
            Console.Write("Digite o dano recebido: ");
            int dano = int.Parse(Console.ReadLine());
            
            // Cálculo
            hp = hp - dano;
            
            // Condicional
            if (hp > 0)
            {
                Console.WriteLine($"{nome} tem {hp} HP restante!");
            }
            else
            {
                Console.WriteLine($"{nome} foi derrotado!");
            }
        }
    }
}
```

---

**Bons estudos! 🚀**


