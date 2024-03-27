using Grpc.Net.Client;
using gRPC_Server.Protos;

namespace WinFormsClient;

public partial class Form1 : Form
{
    GrpcChannel channel;
    ProductService.ProductServiceClient productServiceClient;


    public Form1()
    {
        InitializeComponent();
        string Address = "https://localhost:7220/";
        channel = GrpcChannel.ForAddress(Address);
        productServiceClient = new ProductService.ProductServiceClient(channel);
    }

    private void button2_Click(object sender, EventArgs e)
    {
        var response = productServiceClient.GetAllProduct(new RequestAllProduct
        { Page = 1, PageSize = 20 });

        dataGridView1.DataSource = response.Items;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        var response = productServiceClient.AddNewProduct(new RequestAddProductDto
        {
            Brand = TxtBrand.Text,
            Name = TxtName.Text,
            Price = Convert.ToInt32(TxtPrice.Text),
        });
        if (response.IsSuccess)
        {
            MessageBox.Show("محصول جدید ثبت شد");
        }

    }
}
