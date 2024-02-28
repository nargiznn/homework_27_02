
using homework27_02.DAL;
using homework27_02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Text.RegularExpressions;


//var brands=context.Brands.ToList();

string opt;
do
{
    Console.WriteLine("1. Add brand");
    Console.WriteLine("2. Get brand by id");
    Console.WriteLine("3. Get all brands");
    Console.WriteLine("4. Add product");
    Console.WriteLine("5. Get all products");
    Console.WriteLine("Select opt");


    opt = Console.ReadLine();
    AppDbContext context = new AppDbContext();

    switch (opt)
    {
        case "1":
            Console.Write("Name:");
            string name = Console.ReadLine();
            var newBrand1 = new Brand
            {
                Name = name,
              
            };
            context.Brands.Add(newBrand1);
            context.SaveChanges();
            break;
        case "2":
            Console.Write("Id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            var brand1 = context.Brands.Find(id);
            Console.WriteLine(brand1.Id + "-" + brand1.Name );
            break;
        case "3":
            var brands = context.Brands.ToList();

            foreach (var item in brands)
            {
                Console.WriteLine(item.Id + "-" + item.Name);
            }

            break;
        case "4":
            Console.Write("Name: ");
            string name1 = Console.ReadLine();
            Console.Write("Price: ");
            int price = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("All brands:");
            foreach (var item in context.Brands.ToList())
                Console.WriteLine(item.Id + "-" + item.Name);

            Console.Write("BrandId: ");
            int brandId = Convert.ToInt32(Console.ReadLine());

            Product newprd = new Product
            {
                Name = name1,
                Price = price,
                BrandId = brandId
            };
            context.Products.Add(newprd);
            context.SaveChanges();
            break;
        case "5":
            var products = context.Products.Include(x => x.Brand).ToList();

            foreach (var prd in products)
            {
                Console.WriteLine(prd.Id + "-" + prd.Name + "-" + prd.Price + "-" + prd.Brand.Name);
            }

            break;
        case "0":
            Console.WriteLine("Finished");
            break;
        default:
            Console.WriteLine("Opt is wrong");
            break;
    }
} while (opt != "0");
void AddBrands()
{
    AppDbContext context = new AppDbContext();
    Brand newbrands = new Brand
    {
        Name = "Brand1"
    };
    context.Brands.Add(newbrands);
    context.SaveChanges();
}


List<Brand> GetBrands()
{
    AppDbContext context = new AppDbContext();
    return context.Brands.ToList();
};
void UpdateNameBrands()
{
    AppDbContext context = new AppDbContext();
    var brand = context.Brands.First();
    brand.Name = "Brands2";
    context.SaveChanges();
}
void DeleteBrands()
{
    AppDbContext context = new AppDbContext();
    var brand = context.Brands.First();
    context.Brands.Remove(brand);
    context.SaveChanges();
}

