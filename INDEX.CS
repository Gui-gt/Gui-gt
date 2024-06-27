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
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_Clientes
{
    public class Program
    {
        

        struct Cliente
        {
            public string nome;
            public string email;
            public string cpf;
        }

       static List<Cliente> clientes = new List<Cliente>();

        enum Menu { listagem = 1, adicionar, remover, sair }

        

        
        
        
        static void Main()
        {

            bool escolheuSair = false;
            while (!escolheuSair)
            {

                Console.WriteLine("Gestor de Clientes - seja bem vindo");
                Console.WriteLine("1-listagem\n2-adicionar\n3-remover\n4-sair");
                int IntOp = int.Parse(Console.ReadLine());
                Menu opcao = (Menu)IntOp;

                switch (opcao)
                {
                    case Menu.listagem:
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
            Console.WriteLine("Nome de cliente: ");
            cliente.nome = Console.ReadLine();  

            Console.WriteLine("Email de cliente: ");
            cliente.email = Console.ReadLine(); 

            Console.WriteLine("CPF de cliente: ");
            cliente.cpf = Console.ReadLine();

            clientes.Add(cliente);

            Console.WriteLine("cliente cadastrado com sucesso, aperte enter para voltar para ao menu");
            Console.ReadLine();
            
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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

        enum Menu { listagem = 1, adicionar, remover, sair }

        

        
        
        
        static void Main()
        {
            Carregar();

            bool escolheuSair = false;
            while (!escolheuSair)
            {

                Console.WriteLine("Gestor de Clientes - seja bem vindo");
                Console.WriteLine("1-listagem\n2-adicionar\n3-remover\n4-sair");
                int IntOp = int.Parse(Console.ReadLine());
                Menu opcao = (Menu)IntOp;

                switch (opcao)
                {
                    case Menu.listagem:
                        Listagem();
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
            Console.WriteLine("Nome de cliente: ");
            cliente.nome = Console.ReadLine();  

            Console.WriteLine("Email de cliente: ");
            cliente.email = Console.ReadLine(); 

            Console.WriteLine("CPF de cliente: ");
            cliente.cpf = Console.ReadLine();

            clientes.Add(cliente);
            Salvar();

            Console.WriteLine("cliente cadastrado com sucesso, aperte enter para voltar para ao menu");
            Console.ReadLine();
            
        }

        static void Listagem()
        {

            if(clientes.Count > 0)
            {
                Console.WriteLine("Listagem de clientes");

                foreach (Cliente cliente in clientes)
                {
                    int i = 0;
                    Console.WriteLine($"ID: {i}");
                    Console.WriteLine($"Nome:{cliente.nome}");
                    Console.WriteLine($"Email:{cliente.email}");
                    Console.WriteLine($"CPF: {cliente.cpf}");
                    i++;
                    Console.WriteLine("=================================================|");
                    
                }
            }
            else
            {
                Console.WriteLine("Nenhum cliente cadastrado, Adicione clientes no menu!");
            }
            Console.WriteLine("aperte enter para voltar ao menu.");
            Console.ReadLine();
            
        }

        static void Salvar()
        {
            FileStream stream = new FileStream("clientes.dados", FileMode.OpenOrCreate);
            BinaryFormatter encoder = new BinaryFormatter();

            encoder.Serialize(stream, clientes);

            stream.Close(); 
        }

        static void Carregar()
        {
            FileStream stream = new FileStream("clientes.dados", FileMode.OpenOrCreate);
            try
            {
                BinaryFormatter encoder = new BinaryFormatter();

                clientes = (List<Cliente>)encoder.Deserialize(stream);

               if(clientes == null)
                {
                    clientes = new List<Cliente>();
                }
            }
            catch (Exception ex)
            { 
                clientes = new List<Cliente>(); 
            }
            stream.Close();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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

        enum Menu { listagem = 1, adicionar, remover, sair }

        

        
        
        
        static void Main()
        {
            Carregar();

            bool escolheuSair = false;
            while (!escolheuSair)
            {

                Console.WriteLine("Gestor de Clientes - seja bem vindo");
                Console.WriteLine("1-listagem\n2-adicionar\n3-remover\n4-sair");
                int IntOp = int.Parse(Console.ReadLine());
                Menu opcao = (Menu)IntOp;

                switch (opcao)
                {
                    case Menu.listagem:
                        Listagem();
                        break;

                    case Menu.adicionar:
                        Adicionar();
                        break;

                    case Menu.remover:
                        Remover();
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
            Console.WriteLine("Nome de cliente: ");
            cliente.nome = Console.ReadLine();  

            Console.WriteLine("Email de cliente: ");
            cliente.email = Console.ReadLine(); 

            Console.WriteLine("CPF de cliente: ");
            cliente.cpf = Console.ReadLine();

            clientes.Add(cliente);
            Salvar();

            Console.WriteLine("cliente cadastrado com sucesso, aperte enter para voltar para ao menu");
            Console.ReadLine();
            
        }

        static void Listagem()
        {

            if(clientes.Count > 0)
            {
                Console.WriteLine("Listagem de clientes");

                foreach (Cliente cliente in clientes)
                {
                    int i = 0;
                    Console.WriteLine($"ID: {i}");
                    Console.WriteLine($"Nome:{cliente.nome}");
                    Console.WriteLine($"Email:{cliente.email}");
                    Console.WriteLine($"CPF: {cliente.cpf}");
                    i++;
                    Console.WriteLine("=================================================|");
                    
                }
            }
            else
            {
                Console.WriteLine("Nenhum cliente cadastrado, Adicione clientes no menu!");
            }
            Console.WriteLine("aperte enter para voltar ao menu.");
            Console.ReadLine();
            
        }

        static void Remover()
        {
            Listagem();
            Console.WriteLine("Digite o ID do cliente que você quer remover.");
           int id = int.Parse(Console.ReadLine());
            if(id > 0 && clientes.Count < id)
            {
                clientes.RemoveAt(id);
                Salvar();
            }
            else
            {
                Console.WriteLine("ID inválido, digite um id válido e tente novamente!");
                Console.WriteLine();
            }


        }

        static void Salvar()
        {
            FileStream stream = new FileStream("clientes.dados", FileMode.OpenOrCreate);
            BinaryFormatter encoder = new BinaryFormatter();

            encoder.Serialize(stream, clientes);

            stream.Close(); 
        }

        static void Carregar()
        {
            FileStream stream = new FileStream("clientes.dados", FileMode.OpenOrCreate);
            try
            {
                BinaryFormatter encoder = new BinaryFormatter();

                clientes = (List<Cliente>)encoder.Deserialize(stream);

               if(clientes == null)
                {
                    clientes = new List<Cliente>();
                }
            }
            catch (Exception ex)
            { 
                clientes = new List<Cliente>(); 
            }
            stream.Close();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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

        enum Menu { listagem = 1, adicionar, remover, sair }

        

        
        
        
        static void Main()
        {
            Carregar();

            bool escolheuSair = false;
            while (!escolheuSair)
            {

                Console.WriteLine("Gestor de Clientes - seja bem vindo");
                Console.WriteLine("1-listagem\n2-adicionar\n3-remover\n4-sair");
                int IntOp = int.Parse(Console.ReadLine());
                Menu opcao = (Menu)IntOp;

                switch (opcao)
                {
                    case Menu.listagem:
                        Listagem();
                        break;

                    case Menu.adicionar:
                        Adicionar();
                        break;

                    case Menu.remover:
                        Remover();
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
            Console.WriteLine("Nome de cliente: ");
            cliente.nome = Console.ReadLine();  

            Console.WriteLine("Email de cliente: ");
            cliente.email = Console.ReadLine(); 

            Console.WriteLine("CPF de cliente: ");
            cliente.cpf = Console.ReadLine();

            clientes.Add(cliente);
            Salvar();

            Console.WriteLine("cliente cadastrado com sucesso, aperte enter para voltar para ao menu");
            Console.ReadLine();
            
        }

        static void Listagem()
        {

            if(clientes.Count > 0)
            {
                Console.WriteLine("Listagem de clientes");
                int i = 0;

                foreach (Cliente cliente in clientes)
                {
                    
                    Console.WriteLine($"ID: {i}");
                    Console.WriteLine($"Nome:{cliente.nome}");
                    Console.WriteLine($"Email:{cliente.email}");
                    Console.WriteLine($"CPF: {cliente.cpf}");
                    i++;
                    Console.WriteLine("=================================================|");
                    
                }
            }
            else
            {
                Console.WriteLine("Nenhum cliente cadastrado, Adicione clientes no menu!");
            }
            Console.WriteLine("aperte enter para voltar ao menu.");
            Console.ReadLine();
            
        }

        static void Remover()
        {
            Listagem();
            Console.WriteLine("Digite o ID do cliente que você quer remover.");
           int id = int.Parse(Console.ReadLine());
            if(id >= 0 && id < clientes.Count)
            {
                clientes.RemoveAt(id);
                Salvar();
            }
            else
            {
                Console.WriteLine("ID inválido, digite um id válido e tente novamente!");
                Console.ReadLine();
            }


        }

        static void Salvar()
        {
            FileStream stream = new FileStream("clientes.dados", FileMode.OpenOrCreate);
            BinaryFormatter encoder = new BinaryFormatter();

            encoder.Serialize(stream, clientes);

            stream.Close(); 
        }

        static void Carregar()
        {
            FileStream stream = new FileStream("clientes.dados", FileMode.OpenOrCreate);
            try
            {
                BinaryFormatter encoder = new BinaryFormatter();

                clientes = (List<Cliente>)encoder.Deserialize(stream);

               if(clientes == null)
                {
                    clientes = new List<Cliente>();
                }
            }
            catch (Exception ex)
            { 
                clientes = new List<Cliente>(); 
            }
            stream.Close();
        }
    }
}


