using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; //Required kısmı için eklendi.
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceProject.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string Name { get; set; }

        [Required]
        [MaxLength(150)]
        public string Surname { get; set; }

        [Required]
        [MaxLength(64)]
        public string Password { get; set; }

        [Required]
        [MaxLength(150)]
        public string Email { get; set; }

        public List<Address> Addresses { get; set; } //address.cs de tanımlanan ilişki için bu satır yazılır.

    }
}
