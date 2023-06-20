using Microsoft.EntityFrameworkCore;
using System;
using System.Text;

namespace mysqlefcore
{
    class FeedBackProgram
    {
        static void Main(string[] args, string nomeUsuario, string status, string desc, decimal valor)
        {
            InsertData(nomeUsuario, status, desc, valor);
            PrintData();
        }

        public static void InsertData(string? nomeUsuario, string? status, string? desc, decimal valor)
        {
            using (var context = new ClientContext())
            {
                // Creates the database if not exists
                context.Database.EnsureCreated();

                // Adds a publisher
                var usuario = new Usuario
                {
                    nome = nomeUsuario
                };

                context.Usuario?.Add(usuario);
                context.SaveChanges();

                var feedback = new FeedBack
                {
                    desc = desc,
                    status = status,
                    valor = valor,
                    Usuario = usuario,
                    id_usuario_feedback = usuario.id
                };

                context.FeedBack?.Add(feedback);
                context.SaveChanges();
            }
        }

        public static void PrintData()
        {
            
            // Gets and prints all books in database
            using (var context = new ClientContext())
            {
                var feedbacks = context.FeedBack?
                  .Include(p => p.Usuario);
                foreach (var feedBack in feedbacks ?? Enumerable.Empty<FeedBack>())
                {
                    var data = new StringBuilder();
                    data.AppendLine($"desc: {feedBack.desc}");
                    data.AppendLine($"status: {feedBack.status}");
                    data.AppendLine($"valor: {feedBack.valor}");
                    data.AppendLine($"Usuario: {feedBack.Usuario?.nome}");
                    Console.WriteLine(data.ToString());
                }
            }
        }
    }
}