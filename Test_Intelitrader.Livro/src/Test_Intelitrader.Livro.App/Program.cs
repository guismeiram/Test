using Test_Intelitrader.Livro.Core.Service;
using Test_Intelitrader.Livro.Core.Model;

LivrosService service = new LivrosService();
List<Livros> livros = new List<Livros>();
bool exibirMenu = true;




while (exibirMenu)
{
    Console.WriteLine("Insira a posição desejada:");
    int posicao = int.Parse(Console.ReadLine());
    Console.WriteLine("Insira os Valores desejados:");
    double valor = double.Parse(Console.ReadLine());
    Console.WriteLine("Insira a Quantidade:");
    int quantidade = int.Parse(Console.ReadLine());

    //Console.Clear();
    Console.WriteLine("0 - Inserir Livro:");
    Console.WriteLine("1 - Modificar Livro:");
    Console.WriteLine("2 - Deletar Livro:");
    Console.WriteLine("Defina a ação a ser realizada:");
    int acao = int.Parse(Console.ReadLine());

    switch (acao)
    {
        case 0: // Inserir
            service.InserirLivro(livros, posicao, valor, quantidade);
            break;
        case 1: // Modificar
            service.ModificarLivro(livros, posicao, valor, quantidade);
            break;
        case 2: // Deletar
            service.DeletarLivro(posicao, livros);
            break;
    }
}

foreach (var livraria in livros)
{
    Console.WriteLine(livros);
}
