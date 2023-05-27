using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace residencial.Models
{
    public class visitante
    {
        [Key]
        public Guid visitanteid { get; set; }

        [ForeignKey("ident")]
        public Guid ident { get; set; }

        [ForeignKey("nombre")]
        public Guid nombre { get; set; }

        public bool sexo { get; set; }

        public string sexotex => sexo ? "Masculino" : "Femenino";      

        public int edad  { get; set; }

    }
}