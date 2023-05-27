using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace residencial.Models
{
    public class visita
    {
        [Key]
        public Guid visitaid { get; set; }

        public string fechaent { get; set; }

        public string fechasal { get; set; }

        [ForeignKey("visitanteid")]
        public Guid visitanteid { get; set; }

        [ForeignKey("casaid")]
        public Guid casaid{ get; set; }

        public string codigoqr  { get; set; }

        public bool estado { get; set; }

        public string estadotex => estado ? "Activo" : "inactivo";

    }
}