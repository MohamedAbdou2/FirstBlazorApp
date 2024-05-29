using FirstBlazorApp.Models;

namespace FirstBlazorApp.Pages
{
    public partial class ProductComponent
    {
        public int SelectId { get; set; } = 1;

        public List<Product> ProductList { get; set; }

        public Product Product { get; set; }

        public ProductComponent()
        {

            ProductList = new List<Product>();
            ProductList.Add(new Product()
            {
                Id = 1,
                Name = "Apple",
                Image = "iphone.jpeg",
                Price = 10000
            });
            ProductList.Add(new Product()
            {
                Id = 2,
                Name = "Realme",
                Image = "realme.jpeg",
                Price = 11000
            });

            ProductList.Add(new Product()
            {
                Id = 3,
                Name = "Oppo",
                Image = "oppp.jpeg",
                Price = 12000
            });

            Product = new Product()
            {
                Id = 3,
                Name = "Oppo",
                Image = "oppp.jpeg",
                Price = 12000

            };


        }

        private void LoadProduct()
        {
            Product = ProductList.FirstOrDefault(p => p.Id == SelectId);
        }


    }
}
