
using homework27_02.DAL;
using homework27_02.Models;


//var brands=context.Brands.ToList();

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

