using mysqlefcore;
using System;
using tela;


namespace projetofinal
{
    class Program
    {
        static void Main(string[] args)
        {


            string nomeUsuario = tela.Program.menu();
            int opcao = tela.Program.opcoes();


            while (opcao != 8)
            {

                switch (opcao)
                {
                    case 0:
                        opcao = tela.Program.opcoes();
                    break;

                    case 1:
                        insercao.Program.feedback(nomeUsuario);
                        opcao = 0;
                    break;

                    case 2:
                        insercao.Program.problema(nomeUsuario);
                        opcao = 0;
                    break;

                    case 3:
                        insercao.Program.reclamacao(nomeUsuario);
                        opcao = 0;
                        break;

                    case 4:
                        Console.Clear();
                        mysqlefcore.FeedBackProgram.PrintData();
                        opcao = 0;
                        break;

                    case 5:
                        Console.Clear();
                        mysqlefcore.ProblemaProgram.PrintData();
                        opcao = 0;
                        break;

                    case 6:
                        Console.Clear();
                        mysqlefcore.ReclamacaoProgram.PrintData();
                        opcao = 0;
                        break;

                    case 7:
                        nomeUsuario = tela.Program.menu();
                        opcao = 0;
                    break;

                    default: 
                        Console.WriteLine("Opção inválida.");
                        opcao = 0;
                    break;
                }
            }
            Console.WriteLine("Saiu do programa");
        }

    }
}