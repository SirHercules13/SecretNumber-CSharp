int randomNumInt; //Variável que recebe o número pseudo-Aleatório
int minNum = 1; //Número mínimo para o sorteamento
int maxNum = 101; //Número máximo para o sorteamento

//Função para exibir as boas vindas
void ShowMainMenu()
{
    Console.WriteLine(@"

╔═══╗──────────╔╗─╔═╗─╔╗─────╔╗
║╔═╗║─────────╔╝╚╗║║╚╗║║─────║║
║╚══╦══╦══╦═╦═╩╗╔╝║╔╗╚╝╠╗╔╦╗╔╣╚═╦══╦═╗
╚══╗║║═╣╔═╣╔╣║═╣║─║║╚╗║║║║║╚╝║╔╗║║═╣╔╝
║╚═╝║║═╣╚═╣║║║═╣╚╗║║─║║║╚╝║║║║╚╝║║═╣║
╚═══╩══╩══╩╝╚══╩═╝╚╝─╚═╩══╩╩╩╩══╩══╩╝
");
    Console.WriteLine("Bem-vindo ao jogo do número secreto");

}

//Função para gerar o número secreto pseudo-aleatório
int GenerateRandomNum()
{
    Random randomNum = new Random();
    randomNumInt = randomNum.Next(minNum, maxNum);
    //Console.WriteLine(randomNumInt);

    return randomNumInt;
}

//Função para mostrar as mensagens do jogo, se é maior, menor ou se acertou
void ShowOptions()
{
    //loop do/while para que o usuário possa continuar jogando
    do
    {
        Console.Write($"\nDigite um número entre {minNum} e {maxNum}: ");
        int choosenNum = int.Parse(Console.ReadLine());

        if (choosenNum > randomNumInt)
        {
            Console.WriteLine("**O número sorteado é menor**");
            
        }
        else if(choosenNum < randomNumInt)
        {
            Console.WriteLine("**O número sorteado é maior**");
            
        }
        else
        {
            Console.WriteLine(@"

█▀▀█ █▀▀█ █▀▀█ █▀▀█ █▀▀▄ █▀▀ █▀▀▄ █▀▀ 
█░░█ █▄▄█ █▄▄▀ █▄▄█ █▀▀▄ █▀▀ █░░█ ▀▀█ 
█▀▀▀ ▀░░▀ ▀░▀▀ ▀░░▀ ▀▀▀░ ▀▀▀ ▀░░▀ ▀▀▀ 
");
            Console.WriteLine($"Você acertou o número secreto!!! ({randomNumInt})");
            Console.WriteLine("********************************");
            Console.WriteLine("Deseja jogar novamente?");
            Console.Write("Digite: S(sim) ou N(não)");
            string option = Console.ReadLine();

            //Condicional para escolher se quer continuar o jogo ou não (Botão restart)
            if(option == "s")
            {
                Console.Clear();
                Game();
            }

            Console.WriteLine("\n*************************************");
            Console.WriteLine("Obrigado por jogar e até a próxima ;D");
            Console.WriteLine("*************************************");
            break;

        }
        
        
    } while (true);
   

}

//jogo em si, com todas as funçoes, serve como ponto de restart
void Game()
{
    ShowMainMenu();
    GenerateRandomNum();
    ShowOptions();

}

//Função instanciada
Game();