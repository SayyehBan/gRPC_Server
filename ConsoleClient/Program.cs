// https://localhost:7220/
using Grpc.Net.Client;
using gRPC_Server.Protos;
string Address = "https://localhost:7220/";
var channel = GrpcChannel.ForAddress(Address);
var productClient = new ProductService.ProductServiceClient(channel);
var response = productClient.AddNewProduct(new RequestAddProductDto
{
    Name = "PocoX3",
    Brand = "Xamia",
    Price = 10000000
});
Console.WriteLine("IsSuccess : "+response.IsSuccess);
Console.ReadLine();