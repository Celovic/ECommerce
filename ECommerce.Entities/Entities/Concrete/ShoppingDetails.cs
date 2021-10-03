using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entities.Entities.Concrete
{
    public class ShoppingDetails
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required]
        public string City{ get; set; }
        [Required]
        [MinLength(20)]
        public string Address{ get; set; }
        [Required]
        [Range(15, 70)]
        public int Age { get; set; }
    }
}
