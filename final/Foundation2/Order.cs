// public class Order
// {
//     private List<Product> _products;
//     private string _customer;
//     private float _totalCost;
    
//     public string Packing()
//     {
//         return "aaaa";
//     }

//     public string Shipping()
//     {
//         return "aaaa";
//     }

//     public void Display()
//     {

//     }
// }
class Order
{
    private Customer customer;
    private List<Product> products;

    public Order(Customer customer)
    {
        this.customer = customer;
        this.products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public decimal CalculateTotalCost()
    {
        decimal totalCost = 0;
        foreach (Product product in products)
        {
            totalCost += product.GetTotalCost();
        }

        decimal shippingCost = customer.IsUSA() ? 5 : 35;
        return totalCost + shippingCost;
    }

    public string GeneratePackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in products)
        {
            packingLabel += $"Name: {product.GetName()}, Product ID: {product.GetProductId()}\n";
        }
        return packingLabel;
    }

    public string GenerateShippingLabel()
    {
        string customerName = customer.GetName();
        string customerAddress = customer.GetAddress().GetFullAddress();
        return $"Name: {customerName}\nAddress: {customerAddress}";
    }
}