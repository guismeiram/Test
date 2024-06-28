using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Intelitrader.Livro.Core.Interface;
using Test_Intelitrader.Livro.Core.Model;

namespace Test_Intelitrader.Livro.Core.Service
{
    public class LivrosService : ILivrosService
    {
        public void DeletarLivro(int posicao, List<Livros> livros)
        {
             livros.RemoveAll(o => o.Posicao == posicao);
             Atualiza(livros);
             Console.WriteLine($"Livros Removidos!");
             Console.WriteLine($"Posição: {posicao}");
             Console.WriteLine($"Livro: {livros}");
            
        }

        public void InserirLivro(List<Livros> livros, int posicao, double valores, int quantidade)
        {
            var novo = new Livros(posicao, valores, quantidade);
            livros.Insert(posicao - 1, novo);
            Atualiza(livros);
            Console.WriteLine($"Posicao: {posicao}");
            Console.WriteLine($"Valores:  {valores}");
            Console.WriteLine($"Quatidade: {quantidade}");
            Console.WriteLine($"Livros Adicionado!");
        }

        public void Atualiza(List<Livros> livros)
        {

            for (int i = 0; i < livros.Count; i++)
            {
                livros[i].Posicao = i + 1;
            }

        }

        public void ModificarLivro(List<Livros> livros, int posicao, double valores, int quantidade)
        {
            if (posicao - 1 < livros.Count)
            {
                var recebe = livros[posicao - 1];
                if (valores != 0)
                {
                    recebe.Valores = valores;
                }
                if (quantidade != 0)
                {
                    recebe.Quantidade = quantidade;
                }
                Console.WriteLine($"Posicao: {posicao}");
                Console.WriteLine($"Valores:  {valores}");
                Console.WriteLine($"Quatidade: {quantidade}");
                Console.WriteLine($"Atualizar Livro!");
            }
        }

        
    }
}
