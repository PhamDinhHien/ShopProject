using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Model.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [MaxLength(256)]
        public string CustomerName { get; set; }

        [MaxLength(256)]
        public string CustomerAddress { get; set; }

        [MaxLength(256)]
        public string CustomerEmail { get; set; }

        [MaxLength(256)]
        public string CustomerMobile { get; set; }

        [MaxLength(256)]
        public string CustomerMessage { get; set; }

        [MaxLength(256)]
        public string PaymentMethod { get; set; }

        public DateTime? CreateDate { get; set; }
        public string CreatedBy { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(256)]
        public int PaymentStatus { get; set; }

        public string Status { get; set; }
        public virtual IEnumerable<OrderDetail> OrderDetail { get; set; }
    }
}