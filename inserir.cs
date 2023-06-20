using mysqlefcore;
using System;

namespace insercao
{
    class Program
    {

        public static void feedback(string nomeUsuario) {
            Console.Clear();

            Console.WriteLine("Insira o feedback:");
            string? desc = Console.ReadLine();

            Console.WriteLine("Insira o status:");
            string? status = Console.ReadLine() ?? "------";

            Console.WriteLine("Insira o custo para conserto:");
            decimal valor = Convert.ToDecimal(Console.ReadLine());

            mysqlefcore.FeedBackProgram.InsertData(nomeUsuario, status, desc, valor);
            
        }

        public static void problema(string nomeUsuario) {
            Console.Clear();
            Console.WriteLine("Insira a descrição do problema:");
            string? desc = Console.ReadLine();

            Console.WriteLine("Insira o data:");
            string? data = Console.ReadLine();

            mysqlefcore.ProblemaProgram.InsertData(nomeUsuario, desc, data);
        }


        public static void reclamacao(string nomeUsuario) {
            Console.Clear();
            Console.WriteLine("Insira o feedback:");
            string? desc = Console.ReadLine();

            Console.WriteLine("Insira a data:");
            string? data = Console.ReadLine();

            mysqlefcore.ReclamacaoProgram.InsertData(nomeUsuario, desc, data);
           
        }
    
    }
    
}