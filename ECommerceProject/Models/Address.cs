using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceProject.Models
{
    public class Address
    {
        public int Id { get; set; }
        public User User { get; set; } //tablo ilişkilendirmesi bu şekilde yapılıyor.
        public string OpenAddress { get; set; }
    }
}
