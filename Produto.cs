using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2
{
    internal class Produto
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public Produto(int codigo, string descricao, double valor) { 
            this.Codigo = codigo;
            this.Descricao = descricao;
            this.Valor = valor;
        }
        public void Reajuste(double porcentagem)
        {
            this.Valor = (1+(porcentagem/100)) * this.Valor;
        }
        public override string ToString()
        {
            return Codigo + " - " + Descricao + " - " + Valor;
        }
        public Produto() { }
    }
}
