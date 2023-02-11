using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductDetail.Models
{
    public class Picture
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string ImgUrl { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
