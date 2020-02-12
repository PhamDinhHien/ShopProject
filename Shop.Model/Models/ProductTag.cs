using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Model.Models
{
    [Table("ProductTags")]
    public class ProductTag
    {
        [Key]
        public int PostID { get; set; }

        [Key]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public int TagID { get; set; }

        [ForeignKey("TagID")]
        public virtual Tag Tags { get; set; }

        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }
    }
}