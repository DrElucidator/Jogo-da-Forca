using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Jogodaforca.ConsoleApp;
/*
    1. [x] Ao iniciar o jogo, deve ser selecionada uma palavra aleatória à partir de uma lista.
    2. [] O jogador poderá chutar a palavra secreta letra por letra, cada letra certa deverá ser apresentada, 
    assim como as letras erradas. 
    3. [] O jogador poderá cometer até cinco erros, caso erre pela quinta vez, ou acerte a palavra a partida 
    acaba. 
    4. [] Deve-se apresentar um desenho da forca sendo atualizado a cada erro.
*/
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            System.Console.WriteLine();
            System.Console.WriteLine("Jogo da Forca");
            System.Console.WriteLine();

            string randomWord = randomWordChoosen();
            
            char[] rightLetter = new char[randomWord.Length];

            for (int Character = 0; Character < rightLetter.Length; Character++)
                rightLetter[Character] = '_';

            bool wordGuessed = false;

            while (wordGuessed == false)
            {
                System.Console.Clear();
                System.Console.WriteLine(rightLetter);

                System.Console.WriteLine("Digite uma letra: ");
                string? strWord = Console.ReadLine();

                if(string.IsNullOrWhiteSpace(strWord))
                {
                    System.Console.WriteLine("Digite um caractere válido.");
                    Console.ReadLine();
                    continue;
                }

                char Guess = char.ToUpper(Convert.ToChar(strWord));

                for(int contador = 0; contador < randomWord.Length; contador++)
                {
                    char currentLetter = randomWord[contador];

                    if(Guess == currentLetter)
                        rightLetter[contador] = currentLetter;
                }
                wordGuessed = randomWord == string.Join("", rightLetter);
            }

            System.Console.WriteLine("Deseja continuar? [s/n]: ");
            string? Continue = Console.ReadLine()?.ToUpper();

            if (Continue != "S")
                break;
        }
    }
    static string randomWordChoosen()
    {
        string[] Words = [
            "ABACATE",
            "ABACAXI",
            "ACEROLA",
            "AÇAÍ",
            "ARAÇÁ",
            "ABACATE",
            "BACABA",
            "BACURI",
            "BANANA",
            "CAJÁ",
            "CAJU",
            "CARAMBOLA",
            "CUPUAÇU",
            "GRAVIOLA",
            "GOIABA",
            "JABUTICABA",
            "JENIPAPO",
            "MAÇÃ",
            "MANGABA",
            "MANGA",
            "MARACUJÁ",
            "MURICI",
            "PEQUI",
            "PITANGA",
            "PITAYA",
            "SAPOTI",
            "TANGERINA",
            "UMBU",
            "UVA",
            "UVAIA"
        ];
        int randomIndex = RandomNumberGenerator.GetInt32(Words.Length);
        string randomWord = Words[randomIndex];
        return randomWord;
    }
}