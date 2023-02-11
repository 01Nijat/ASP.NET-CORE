using ProductDetail.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductDetail.ViewModels
{
    public class HomeVm
    {
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Picture> Pictures { get; set; }
    }
}
