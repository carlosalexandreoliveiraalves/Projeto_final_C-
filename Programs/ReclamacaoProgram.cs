using Microsoft.EntityFrameworkCore;
using System;
using System.Text;

namespace mysqlefcore
{
    class ReclamacaoProgram
    {
        static void Main(string[] args, string nomeUsuario, string desc, string? data)
        {
            InsertData(nomeUsuario, desc, data);
            PrintData();
        }

        public static void InsertData(string? nomeUsuario, string? desc, string? data)
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

                var reclamacao = new Reclamacao
                {
                    desc = desc,
                    data = data,
                    Usuario = usuario,
                    id_usuario_reclamacoes = usuario.id
                };

                context.Reclamacao?.Add(reclamacao);
                context.SaveChanges();
            }
        }

        public static void PrintData()
        {
        
            // Gets and prints all books in database
            using (var context = new ClientContext())
            {
                var reclamacoes = context.Reclamacao?
                  .Include(p => p.Usuario);
                foreach (var reclamacao in reclamacoes ?? Enumerable.Empty<Reclamacao>())
                {
                    var data = new StringBuilder();
                    data.AppendLine($"desc: {reclamacao.desc}");
                    data.AppendLine($"data: {reclamacao.data}");
                    data.AppendLine($"Usuario: {reclamacao.Usuario?.nome}");
                    Console.WriteLine(data.ToString());
                }
            }
        }
    }
}