namespace BLL;
using BOL;
using DAL;

public class CatlogManager{

    public List<Product> getAllProducts(){

       List<Product> allProducts=new List<Produnts>();
       allProducts=DBManager.getAllProducts();
       return allProducts;

    }
  public Product GetProdunt(int id){
      List<Product> allProducts=getAllProducts();
      Product FoundProduct=allProducts.Find((Product)=>Product.ProductID==id);
  
     return FoundProduct;
  }


}

