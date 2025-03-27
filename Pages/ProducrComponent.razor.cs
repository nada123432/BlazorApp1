using BlazorApp1.Models;

namespace BlazorApp1.Pages
{
    public partial class ProducrComponent
    {
        public Product prod { get; set; }
        public int productId { get; set; }

        public List<Product> ListProducts { get; set; }
        public ProducrComponent()
        {
                ListProducts = new List<Product>();
            ListProducts.Add(new Product() { Id=1 ,Name = "product1", Price = 1300, imgUrl = "/Images/1.jpg" });
            ListProducts.Add(new Product() { Id=2 ,Name = "product2", Price = 1500, imgUrl = "/Images/1.jpg" });
            ListProducts.Add(new Product() { Id=3 ,Name = "product3", Price = 1400, imgUrl = "/Images/1.jpg" });
            ListProducts.Add(new Product() { Id=4 ,Name = "product4", Price = 1500, imgUrl = "/Images/1.jpg" });

        }
        public void getproduct()
        {
            prod = ListProducts.FirstOrDefault(d => d.Id == productId);
        }
    }
}
