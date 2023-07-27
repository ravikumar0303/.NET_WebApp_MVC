using System.ComponentModel.DataAnnotations;
namespace BOL{
    public class Product{
        [Key]
        public int Pid { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public double UnitPrice { get; set; }
    } 
}