// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

//DTO : Data Transformation Object
//SOLID
//Open Closed Principle

//ProductManager productManager = new ProductManager(new EfProductDal());

//foreach (var product in productManager.GetByUnitPrice(40, 100))
//{
//    Console.WriteLine(product.ProductName);
//}

//CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

//foreach (var category in categoryManager.GetAll().Data)
//{
//    Console.WriteLine(category.CategoryName);
//}

ProductManager productManager = new ProductManager(new EfProductDal(), new CategoryManager(new EfCategoryDal()));

var result = productManager.GetProductDetails();

if (result.Success)
{
    foreach (var product in result.Data)
    {
        Console.WriteLine(product.ProductName + "/" + product.CategoryName);
    }
}
else
{
    Console.WriteLine(result.Message);
}

