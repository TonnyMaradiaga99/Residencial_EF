using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace residencial.Models
{
    public class residente
    {
        [Key]
        public Guid residenteid { get; set; }

        public int ident{ get; set; }

        public string nombre { get; set; }

        public int tel { get; set; }

    }
}