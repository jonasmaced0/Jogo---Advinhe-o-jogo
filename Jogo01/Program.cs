// Para criar um número aleatório entre 0 e 100 usando o o C#:

Random aleatorio = new Random();
int numeroSecreto = aleatorio.Next(0, 100);

// função para deixar bonitinho o logo do jogo:
void ExibirMensagemDeBoasVindas()
{
    Console.WriteLine(@"
░█▀▀█ ░█─░█ ─█▀▀█ ░█─── 　 ░█▀▀▀ 　 ░█▀▀▀█ 　 ░█▄─░█ ░█─░█ ░█▀▄▀█ ░█▀▀▀ ░█▀▀█ ░█▀▀▀█ ▀█ 
░█─░█ ░█─░█ ░█▄▄█ ░█─── 　 ░█▀▀▀ 　 ░█──░█ 　 ░█░█░█ ░█─░█ ░█░█░█ ░█▀▀▀ ░█▄▄▀ ░█──░█ █▀ 
─▀▀█▄ ─▀▄▄▀ ░█─░█ ░█▄▄█ 　 ░█▄▄▄ 　 ░█▄▄▄█ 　 ░█──▀█ ─▀▄▄▀ ░█──░█ ░█▄▄▄ ░█─░█ ░█▄▄▄█ ▄─");
}

ExibirMensagemDeBoasVindas();

// Pediremos para o jogador digitar um número e criaremos um loop que só será interrompido se ele acertar o
// o número aleatório criado.

do
{
    Console.Write("\nDigite um número de 0 a 100: ");
    int numeroEscolhido = Convert.ToInt32(Console.ReadLine());

    if (numeroEscolhido == numeroSecreto)
    {
        Console.WriteLine("\nParabéns, você acertou o número secreto, mas é uma pena também, pois o jogo acabou :( ");
        break;
    }
    else if (numeroEscolhido > numeroSecreto)
    {
        Console.WriteLine("\nVocê chutou um número alto demais, escolha um número menor");
    }
    else
    {
        Console.WriteLine("\nVocê chutou um número muito baixo, escolha um número maior");
    }
} while (true);


Console.ReadKey();




