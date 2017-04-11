using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        [Required(ErrorMessage ="Please enter name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter description")]
        public string Description { get; set; }
        [Required]
        [Range(0.01,double.MaxValue, ErrorMessage ="Price")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Please enter description")]
        public string Category { get; set; }
    }
}
