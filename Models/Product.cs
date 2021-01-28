using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoGraviton.Models
{
    [Table("product")]
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public bool Status { get; set; }
    }
}
