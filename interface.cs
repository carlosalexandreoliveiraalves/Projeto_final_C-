using mysqlefcore;
using System;

namespace tela
{
    class Program
    {

        public static string menu() {
            Console.Clear();
            Console.WriteLine("Olá, bem-vindo ao ClientManager. Para continuar faça login.");
            Console.WriteLine("Insira o seu nome:");
            string? nomeUsuario = Console.ReadLine();

            if ((nomeUsuario == null) || (nomeUsuario == "")) {
                Console.Clear();
                Console.WriteLine("Precisa inserir um nome.");
                return menu();
            } else {
                 return nomeUsuario;
            }
        }

        public static int opcoes() {
            

            Console.WriteLine("Escolha uma opção.");
            Console.WriteLine("1 - Adicionar um feedback.");
            Console.WriteLine("2 - Adicionar um problema técnico.");
            Console.WriteLine("3 - Adicionar uma reclamação.");
            Console.WriteLine("4 - Mostrar feedbacks.");
            Console.WriteLine("5 - Mostrar problemas técnicos.");
            Console.WriteLine("6 - Mostrar reclamações.");
            Console.WriteLine("7 - Voltar para a tela de login.");
            Console.WriteLine("8 - Encerra o programa.");

            

            int opcao = Convert.ToInt32(Console.ReadLine());
            return opcao;
        }
    
    }

    
}