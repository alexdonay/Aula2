using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2
{
    internal class Program
    {
        public Program()
        {
            Produto product = new Produto();
            Leitor leitor = new Leitor();
            product.Codigo = leitor.Inteiro("Digite um valor Para o id do carro");
            
            
            product.Reajuste(10);
            Console.WriteLine(product.ToString());
            
        }
        static void Main(string[] args)
        {
            
            Program tst= new Program();
            Console.ReadLine();
            
        }
    }
}
