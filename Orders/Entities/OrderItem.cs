namespace Orders.Entities
{
    internal class OrderItem
    {
        public Product Prod { get; set; }
        public int Quantity { get; set; }

        public double GetSubTotal()
        {
            return Quantity * Prod.Price;
        }
    }
}
