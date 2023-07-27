using DAL;
using BOL;
namespace SAL{
    public class ProductService{

        public readonly CollectionContext _context;

        public ProductService(CollectionContext context){
            _context = context;
        }

        public List<Product> GetAll(){
            var plist = from product in _context.Products select product;
            return plist.ToList<Product>();
        }

        public Product GetById(int id){
            var prod = from product in _context.Products where product.Pid == id select product;
            Product p = prod.FirstOrDefault(pr => pr.Pid == id);
            return p;
        }

        public string AddProduct(Product p){
            _context.Products.Add(p);
            _context.SaveChanges();
            return "Added Sucessfully";
        }

        public string UpdateProduct(int id,Product p){
            _context.Products.Update(p);
            _context.SaveChanges();
            return "Updated Sucessfully";
        }

        public string DeleteProduct(int id){
            Product p = new Product{Pid=id};
            _context.Products.Remove(p);
            _context.SaveChanges();
            return "DeletedSucessfully";
        }
    }
}