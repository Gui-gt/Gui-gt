using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_Clientes
{
    public class Program
    {

        [System.Serializable]
        struct Cliente
        {
            public string nome;
            public string email;
            public string cpf;
        }

        static List<Cliente> clientes = new List<Cliente>();

        enum Menu { listar = 1, adicionar = 2, remover = 3, sair = 4}
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
                        Adicionar();
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

        static void Adicionar()
        {
            Cliente cliente = new Cliente();

            Console.WriteLine("Cadastro de clientes");
            Console.WriteLine("Nome do cliente: ");
            cliente.nome = Console.ReadLine();
            Console.WriteLine("Email do cliente: ");
            cliente.email = Console.ReadLine();
            Console.WriteLine("CPF do cliente: ");
            cliente.cpf = Console.ReadLine();

            clientes.Add(cliente);

            Console.WriteLine("cliente cadastrado com sucesso, aperte enter para voltar ao menu");
            Console.ReadLine();
        }
 
    }
}
