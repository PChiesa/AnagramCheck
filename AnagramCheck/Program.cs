using System;

namespace AnagramCheck
{
    class Program
    {
        static AnagramValidation anagramValidation = new AnagramValidation();

        static void Main(string[] args)
        {
            Console.WriteLine("Escreva uma função que receba duas palavras e diga se elas são anagramas. (Anagrama é um substantivo que significa uma palavra ou frase que é construída através da alteração das letras de uma outra palavra ou frase, ex ATOR = ROTA).");
            Console.WriteLine("Digite a primeira palavra:");
            string word1 = Console.ReadLine();

            Console.WriteLine("Digite a segunda palavra:");
            string word2 = Console.ReadLine();


            bool result = anagramValidation.IsAnagram(word1, word2);

            if (result)
                Console.WriteLine($"As palavras {word1} e {word2} são anagramas");
            else
                Console.WriteLine($"As palavras {word1} e {word2} não são anagramas");

            Console.ReadKey();
        }
    }
}
