using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework27_02.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public int Price { get; set; }  
        public int BrandId { get; set; }  
        public Brand Brand { get; set; }
    }
}
