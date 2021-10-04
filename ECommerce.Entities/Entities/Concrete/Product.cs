using ECommerce.Entities.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entities.Entities.Concrete
{
    public class Product : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        [Required]
        [MaxLength(200)]
        public string ProductTitle { get; set; }
        [Required]
        public string ProductDescription { get; set; }
        [Required]
        [Range(0,int.MaxValue)]
        public int StockQuantity { get; set; }
        [Required]
        public int CategoryId { get; set; }
        //[ForeignKey("CategoryId")]
        public Category Category { get; set; }
    }
}
