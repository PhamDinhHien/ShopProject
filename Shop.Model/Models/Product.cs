using Shop.Model.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Shop.Model.Models
{
    [Table("Products")]
    public class Product : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(256)]
        public string Name { get; set; }

        [Required]
        [MaxLength(256)]
        public string Alias { get; set; }

        public int CategoryID { get; set; }

        [MaxLength(500)]
        public string Image { get; set; }

        [MaxLength(int.MaxValue)]
        public XElement MoreImages { get; set; }

        [Range(18, 2)]
        public decimal Price { get; set; }

        [Range(18, 2)]
        public decimal? Promotion { get; set; }

        public int? Warranty { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [MaxLength(int.MaxValue)]
        public string Content { get; set; }

        public bool HomeFlag { get; set; }
        public bool HotFlag { get; set; }
        public int? ViewCount { get; set; }

        [ForeignKey("CategoryID")]
        public virtual ProductCategory ProductCategory { get; set; }
    }
}