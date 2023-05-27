using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace residencial.Models
{
    public class habitante
    {
        [Key]
        public Guid habitantesid { get; set; }

        [ForeignKey("casaid")]
        public Guid casaid{ get; set; }

        [ForeignKey("residenteid")]
        public Guid residenteid  { get; set; }

        public string parentesco { get; set; }

    }
}