namespace ExeAula241.Entities
{
    class Product
    {
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }

        public Product(string productName, double productPrice)
        {
            ProductName = productName;
            ProductPrice = productPrice;
        }
    }
}
