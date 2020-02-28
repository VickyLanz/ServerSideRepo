using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirstAssessment
{
    class Program
    {
        static void Main(string[] args)
        {
           

        }
    }
    public class ProductDBContext : DbContext
    {
        public ProductDBContext() : base("name=Products")
        { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }       
        public int CategoryID { get; set; }

        public virtual Category Category { get; set; }
    }
    public class Category
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Product { get; set; }
    }
}
