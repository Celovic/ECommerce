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
    public class Category:IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId{ get; set; }
        [Required]
        [MaxLength(200)]
        public string CategoryName{ get; set; }
        public  IEnumerable<Product> Products { get; set; }
    }
}
