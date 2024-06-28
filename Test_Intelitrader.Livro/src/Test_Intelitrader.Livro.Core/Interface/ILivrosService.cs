using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Intelitrader.Livro.Core.Model;

namespace Test_Intelitrader.Livro.Core.Interface
{
    public interface ILivrosService
    {
        public void Atualiza(List<Livros> livros);
        public void InserirLivro(List<Livros> livros, int posicao, double valor, int quantidade);
        public void ModificarLivro(List<Livros> livros, int posicao, double valores, int quantidade);
        public void DeletarLivro(int posicao, List<Livros> livros);


    }
}
