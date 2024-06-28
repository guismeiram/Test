using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Intelitrader.Livro.Core.Model.Base;

namespace Test_Intelitrader.Livro.Core.Model
{
    public class Livros : Entity
    {
        public int Posicao {  get; set; }
        public int Acao {  get; set; }
        public double Valores {  get; set; }
        public int Quantidade {  get; set; }

        public Livros(int Posicao, double Valores, int Quantidade)
        {
            this.Posicao = Posicao;
            this.Valores = Valores;
            this.Quantidade = Quantidade;
        }


    }
}
