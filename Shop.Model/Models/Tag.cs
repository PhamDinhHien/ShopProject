using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Model.Models
{
    [Table("Tags")]
    public class Tag
    {
        [Key]
        [MaxLength(50)]
        public int ID { get; set; }

        [Required]
        [MaxLength(250)]
        public string Name { get; set; }

        [StringLength(50)]
        [Required]
        public string Type { get; set; }

        public virtual IEnumerable<ProductTag> ProductTag { get; set; }
        public virtual IEnumerable<PostTag> PostTag { get; set; }
    }
}