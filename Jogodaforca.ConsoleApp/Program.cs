namespace Jogodaforca.ConsoleApp;
/*
    1. Ao iniciar o jogo, deve ser selecionada uma palavra aleatória à partir de uma lista. 
    2. O jogador poderá chutar a palavra secreta letra por letra, cada letra certa deverá ser apresentada, 
    assim como as letras erradas. 
    3. O jogador poderá cometer até cinco erros, caso erre pela quinta vez, ou acerte a palavra a partida 
    acaba. 
    4. Deve-se apresentar um desenho da forca sendo atualizado a cada erro.
*/
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            System.Console.Clear();
            System.Console.WriteLine("Jogo da Forca");

            string[] palavras = [
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

            System.Console.WriteLine("Deseja continuar? [s/n]: ");
            string? operacaoContinuar = Console.ReadLine()?.ToUpper();

            if (operacaoContinuar != "S")
                break;
        }
    }
}
