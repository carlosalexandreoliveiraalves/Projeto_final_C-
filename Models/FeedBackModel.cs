using System.ComponentModel.DataAnnotations;

namespace mysqlefcore
{
    public class FeedBack
    {
        [Key]
        public int id { get; set; }
        public string? desc { get; set; }
        public string? status { get; set; }
        public decimal valor { get; set; }
        public int id_usuario_feedback { get; set; }
        public virtual Usuario? Usuario { get; set; }
    }

}
