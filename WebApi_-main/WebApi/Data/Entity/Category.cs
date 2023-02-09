using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Data.Entity
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "don't leave empty")]

        public string Name { get; set; }

        [MinLength(10, ErrorMessage = "Must be less than 100")]

        public string Description { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
