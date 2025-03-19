using System;
using System.Collections.Generic;

class Program
{
    static Queue<string> filaAtendimento = new Queue<string>();

    static void Main()
    {
        int opcao;
        do
        {
            Console.WriteLine("\n=== Sistema de Atendimento ===");
            Console.WriteLine("1 - Adicionar Cliente");
            Console.WriteLine("2 - Atender Cliente");
            Console.WriteLine("3 - Exibir Fila");
            Console.WriteLine("4 - Sair");
            Console.Write("Escolha uma opção: ");

            if (int.TryParse(Console.ReadLine(), out opcao))
            {
                switch (opcao)
                {
                    case 1:
                        AdicionarCliente();
                        break;
                    case 2:
                        AtenderCliente();
                        break;
                    case 3:
                        ExibirFila();
                        break;
                    case 4:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Digite um número válido!");
            }
        } while (opcao != 4);
    }

    static void AdicionarCliente()
    {
        Console.Write("Nome do Cliente: ");
        string nome = Console.ReadLine();
        filaAtendimento.Enqueue(nome);
        Console.WriteLine($"{nome} foi adicionado à fila.");
    }

    static void AtenderCliente()
    {
        if (filaAtendimento.Count > 0)
        {
            string clienteAtendido = filaAtendimento.Dequeue();
            Console.WriteLine($"Cliente {clienteAtendido} foi atendido.");
        }
        else
        {
            Console.WriteLine("A fila está vazia!");
        }
    }

    static void ExibirFila()
    {
        if (filaAtendimento.Count > 0)
        {
            Console.WriteLine("Fila atual:");
            foreach (var cliente in filaAtendimento)
            {
                Console.WriteLine(cliente);
            }
        }
        else
        {
            Console.WriteLine("A fila está vazia!");
        }
    }
}
