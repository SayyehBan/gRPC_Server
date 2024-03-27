using Grpc.Core;
using gRPC_Server.Protos;

namespace gRPC_Server.GRPC;

public class ProductWebService : ProductService.ProductServiceBase
{
    static List<Products> Products = new List<Products>()
    {
        new Products{ Brand="سامسونگ",Name="نمایشگر",Price=12000},
    };
    public override Task<ResponseAddNewProduct> AddNewProduct(RequestAddProductDto request, ServerCallContext context)
    {
        Products.Add(new GRPC.Products
        {
            Brand = request.Brand,
            Name = request.Name,
            Price = request.Price,
        });
        Console.WriteLine($"Brand is : {request.Brand}");
        Console.WriteLine($"Name is : {request.Name}");
        Console.WriteLine($"Price is : {request.Price}");
        return Task.FromResult(new ResponseAddNewProduct
        {
            IsSuccess = true,
        });
    }
    public override Task<ResponseAllProduct> GetAllProduct(RequestAllProduct request, ServerCallContext context)
    {
        ResponseAllProduct response = new ResponseAllProduct();
        foreach (var item in Products)
        {
            response.Items.Add(new ProductItem
            {
                Brand = item.Brand,
                Name = item.Name,
                Price = item.Price,
            });
        }
        return Task.FromResult(response);
    }
}

public class Products
{
    public string Name { get; set; }
    public string Brand { get; set; }
    public int Price { get; set; }

}