using BOL;
namespace MyRestApp.Services;

    public interface IProductService
    {
        public List<Product> GetAll();

        public Product GetById(int id);

        public string AddProduct(Product p);

        public string UpdateProduct(int id,Product p);

        public string DeleteProduct(int id);
    }
