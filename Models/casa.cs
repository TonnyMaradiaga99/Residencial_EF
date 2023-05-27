using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace residencial.Models
{
    public class casa
    {
        [Key]
        public Guid casaid { get; set; }

        public int numero{ get; set; }

        public int bloque  { get; set; }

        public int calle { get; set; }

        public string referencia { get; set; }

    }
}