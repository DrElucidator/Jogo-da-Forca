using System.Runtime.InteropServices;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            string randomWord = RandomWordChoosen();

            char[] rightLetter = FillLetter(randomWord);

            RunGame(rightLetter, randomWord);

            if (!Retry())
                break;
        }
    }
    static string RandomWordChoosen()
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
    static char[] FillLetter(string randomWord)
    {
        char[] rightLetter = new char[randomWord.Length];

        for (int Character = 0; Character < rightLetter.Length; Character++)
            rightLetter[Character] = '_';

        return rightLetter;
    }
    static void RunGame(char[] rightLetter, string randomWord)
    {
        bool wordGuessed = false;
        bool roundLost = false;
        int Mistakes = 0;

        while (!wordGuessed && !roundLost)
        {
            System.Console.Clear();
            drawForca(Mistakes);

            System.Console.WriteLine("Letras acertadas: " + string.Join("", rightLetter));
            System.Console.WriteLine("Erros cometidos: " + Mistakes);

            System.Console.WriteLine("Digite uma letra: ");
            string? strWord = Console.ReadLine()?.ToUpper();

            if (string.IsNullOrWhiteSpace(strWord))
            {
                System.Console.WriteLine("Digite um caractere válido.");
                Console.ReadLine();
                continue;
            }
            if (strWord.Length > 1)
            {
                if (strWord == randomWord)
                {
                    rightLetter = randomWord.ToCharArray();
                }
                else
                    Mistakes++;
            }
            else
            {
                char Guess = strWord[0];

                bool wordFound = false;

                for (int contador = 0; contador < randomWord.Length; contador++)
                {
                    char currentLetter = randomWord[contador];

                    if (Guess == currentLetter)
                    {
                        rightLetter[contador] = currentLetter;
                        wordFound = true;
                    }
                }
                if (!wordFound)
                    Mistakes++;
            }
            wordGuessed = randomWord == string.Join("", rightLetter);
            roundLost = Mistakes > 6;

            if (wordGuessed)
            {
                System.Console.WriteLine();
                System.Console.WriteLine($"Você venceu! A palavra secreta era {randomWord}.");
                System.Console.WriteLine();
            }
            else if (roundLost)
            {
                System.Console.WriteLine();
                System.Console.WriteLine($"Você perdeu! Mais sorte na próxima vez! A palavra secreta era {randomWord}.");
                System.Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
    static void drawForca(int Mistakes)
    {
        Console.Clear();
        System.Console.WriteLine();
        System.Console.WriteLine("Jogo da Forca");
        System.Console.WriteLine();

        if (Mistakes == 0)
        {
            System.Console.Write("\n");
            System.Console.WriteLine(@"_________          ");
            System.Console.WriteLine(@"|/      |          ");
            System.Console.WriteLine(@"|                  ");
            System.Console.WriteLine(@"|                  ");
            System.Console.WriteLine(@"|                  ");
            System.Console.WriteLine(@"|                  ");
            System.Console.WriteLine(@"|                  ");
            System.Console.WriteLine(@"|                  ");
            System.Console.WriteLine(@"|_____             ");
        }
        else if (Mistakes == 1)
        {
            System.Console.Write("\n");
            System.Console.WriteLine(@"_________          ");
            System.Console.WriteLine(@"|/      |          ");
            System.Console.WriteLine(@"|       O          ");
            System.Console.WriteLine(@"|                  ");
            System.Console.WriteLine(@"|                  ");
            System.Console.WriteLine(@"|                  ");
            System.Console.WriteLine(@"|                  ");
            System.Console.WriteLine(@"|                  ");
            System.Console.WriteLine(@"|_____             ");
        }
        else if (Mistakes == 2)
        {
            System.Console.Write("\n");
            System.Console.WriteLine(@"_________          ");
            System.Console.WriteLine(@"|/      |          ");
            System.Console.WriteLine(@"|       O          ");
            System.Console.WriteLine(@"|       |          ");
            System.Console.WriteLine(@"|                  ");
            System.Console.WriteLine(@"|                  ");
            System.Console.WriteLine(@"|                  ");
            System.Console.WriteLine(@"|                  ");
            System.Console.WriteLine(@"|_____             ");
        }
        else if (Mistakes == 3)
        {
            System.Console.Write("\n");
            System.Console.WriteLine(@"_________          ");
            System.Console.WriteLine(@"|/      |          ");
            System.Console.WriteLine(@"|       O          ");
            System.Console.WriteLine(@"|      /|          ");
            System.Console.WriteLine(@"|                  ");
            System.Console.WriteLine(@"|                  ");
            System.Console.WriteLine(@"|                  ");
            System.Console.WriteLine(@"|                  ");
            System.Console.WriteLine(@"|_____             ");
        }
        else if (Mistakes == 4)
        {
            System.Console.Write("\n");
            System.Console.WriteLine(@"_________          ");
            System.Console.WriteLine(@"|/      |          ");
            System.Console.WriteLine(@"|       O          ");
            System.Console.WriteLine(@"|      /|\         ");
            System.Console.WriteLine(@"|                  ");
            System.Console.WriteLine(@"|                  ");
            System.Console.WriteLine(@"|                  ");
            System.Console.WriteLine(@"|                  ");
            System.Console.WriteLine(@"|_____             ");
        }
        else if (Mistakes == 5)
        {
            System.Console.Write("\n");
            System.Console.WriteLine(@"_________          ");
            System.Console.WriteLine(@"|/      |          ");
            System.Console.WriteLine(@"|       O          ");
            System.Console.WriteLine(@"|      /|\         ");
            System.Console.WriteLine(@"|       |          ");
            System.Console.WriteLine(@"|                  ");
            System.Console.WriteLine(@"|                  ");
            System.Console.WriteLine(@"|                  ");
            System.Console.WriteLine(@"|_____             ");
        }
        else if (Mistakes == 6)
        {
            System.Console.Write("\n");
            System.Console.WriteLine(@"_________          ");
            System.Console.WriteLine(@"|/      |          ");
            System.Console.WriteLine(@"|       O          ");
            System.Console.WriteLine(@"|      /|\         ");
            System.Console.WriteLine(@"|       |          ");
            System.Console.WriteLine(@"|      /           ");
            System.Console.WriteLine(@"|                  ");
            System.Console.WriteLine(@"|                  ");
            System.Console.WriteLine(@"|_____             ");
        }
        else if (Mistakes == 7)
        {
            System.Console.Write("\n");
            System.Console.WriteLine(@"_________          ");
            System.Console.WriteLine(@"|/      |          ");
            System.Console.WriteLine(@"|       O          ");
            System.Console.WriteLine(@"|      /|\         ");
            System.Console.WriteLine(@"|       |          ");
            System.Console.WriteLine(@"|      / \         ");
            System.Console.WriteLine(@"|                  ");
            System.Console.WriteLine(@"|                  ");
            System.Console.WriteLine(@"|_____             ");
        }
        return;
    }
    static bool Retry()
    {
        System.Console.WriteLine("Deseja continuar? [s/n]: ");
        string? Continue = Console.ReadLine()?.ToUpper();

        if (Continue != "S")
            return false;
        return true;
    }
}