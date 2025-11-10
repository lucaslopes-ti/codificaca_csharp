using System;

namespace ExemplosJogos
{
    class GeradorNomes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== GERADOR DE NOMES ALEATÓRIOS ===\n");

            // Arrays de prefixos e sufixos para nomes
            string[] prefixos = { "Dark", "Light", "Fire", "Ice", "Storm", "Shadow", "Golden", "Silver" };
            string[] sufixos = { "blade", "sword", "shield", "arrow", "mage", "warrior", "knight", "dragon" };

            Random random = new Random();

            Console.WriteLine("Gerando 10 nomes aleatórios:\n");

            for (int i = 0; i < 10; i++)
            {
                string nome = GerarNomeAleatorio(prefixos, sufixos, random);
                Console.WriteLine($"{i + 1}. {nome}");
            }

            // Gerar nome de personagem completo
            Console.WriteLine("\n=== GERADOR DE NOMES DE PERSONAGENS ===");
            string nomePersonagem = GerarNomePersonagem(random);
            Console.WriteLine($"Nome gerado: {nomePersonagem}");
        }

        // Método para gerar nome aleatório simples
        static string GerarNomeAleatorio(string[] prefixos, string[] sufixos, Random random)
        {
            int indicePrefixo = random.Next(0, prefixos.Length);
            int indiceSufixo = random.Next(0, sufixos.Length);

            string prefixo = prefixos[indicePrefixo];
            string sufixo = sufixos[indiceSufixo];

            // Capitalizar primeira letra do sufixo
            sufixo = char.ToUpper(sufixo[0]) + sufixo.Substring(1);

            return prefixo + sufixo;
        }

        // Método para gerar nome de personagem mais complexo
        static string GerarNomePersonagem(Random random)
        {
            string[] primeirosNomes = { "Aragorn", "Legolas", "Gandalf", "Frodo", "Gimli", "Boromir" };
            string[] sobrenomes = { "o Destemido", "o Sábio", "o Valente", "o Imortal", "o Lendário" };

            int indiceNome = random.Next(0, primeirosNomes.Length);
            int indiceSobrenome = random.Next(0, sobrenomes.Length);

            return primeirosNomes[indiceNome] + " " + sobrenomes[indiceSobrenome];
        }
    }
}


