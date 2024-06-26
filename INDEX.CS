using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_Clientes
{
    internal class Program
    {
        enum Menu { listar = 1, adicionar, remover, sair}
        static void Main(string[] args)
        {

            bool escolheuSair = false;

            while (!escolheuSair) {

                Console.WriteLine("  Gestor de Clientes - Bem vindo");
                Console.WriteLine("   1-listar\n   2-adicionar\n   3-remover\n   4-sair");
                int intOp = int.Parse(Console.ReadLine());
                Menu opcao = (Menu)intOp;

                switch (opcao)
                {
                    case Menu.listar:
                        break;

                    case Menu.adicionar:
                        break;

                    case Menu.remover:
                        break;

                    case Menu.sair:
                        escolheuSair = true;
                        break;
                }
                Console.Clear();
            }
        }
        
    }
}
