using System.ComponentModel.DataAnnotations;

namespace mysqlefcore
{
    public class Problema
    {
        [Key]
        public int id { get; set; }
        public string? desc { get; set; }
        public string? data { get; set; }
        public int id_usuario_problema { get; set; }
        public virtual Usuario? Usuario { get; set; }
    }

}