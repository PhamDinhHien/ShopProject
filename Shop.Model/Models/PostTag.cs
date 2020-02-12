using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Model.Models
{
    [Table("PostTags")]
    public class PostTag
    {
        [Key]
        public int PostID { get; set; }

        [Key]
        [MaxLength(50)]
        public int TagID { get; set; }

        [ForeignKey("TagID")]
        public virtual Tag Tags { get; set; }

        [ForeignKey("PostID")]
        public virtual Post Post { get; set; }
    }
}