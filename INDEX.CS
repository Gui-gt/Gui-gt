using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        struct Produto
        {
            public string nome;
            public float preco;

            public Produto(string nome, float preco)
            {
                this.nome = nome;
                this.preco = preco;
            }

            public void ExibirInfo()
            {
                Console.WriteLine($"Nome: {nome}");
                Console.WriteLine($"Nome: {preco}");
            }

            public float AddDesc(float porc)
            {
                float desconto = preco * porc / 100f;
                return preco - desconto;
            }
        }


        static void Main(string[] args)
        {

            Produto faca = new Produto("Faca", 100);

            float vALORfINAL = faca.AddDesc(50F);

            Console.WriteLine(vALORfINAL);
            


            Console.ReadLine();
        }
    }
}
