using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BT2MWG.Models
{
    [Table("HANGDOCHOI")]
    public class HANGDOCHOI
    {
        [Key]
        public int MAHANGDOCHOI { get; set; }

        [Required]
        [StringLength(50)]
        public string TENHANGDOCHOI { get; set; }
    }
}
