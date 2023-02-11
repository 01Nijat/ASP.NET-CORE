using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductDetail.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Picture> Pictures { get; set; }
    }
}
