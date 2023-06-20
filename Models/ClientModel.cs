using System.ComponentModel.DataAnnotations;

namespace mysqlefcore
{
    public class Usuario
    {
        [Key]
        public int id { get; set; }
        public string? nome { get; set; }
        public virtual ICollection<FeedBack>? FeedBacks { get; set; }
        public virtual ICollection<Reclamacao>? Reclamacoes { get; set; }
        public virtual ICollection<Problema>? Problemas { get; set; }
    }
}
