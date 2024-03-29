// public class Product
// {
//     private string _productName;
//     private int _productID;
//     private float _pricePerUnit;
//     private int _quantity;


//     public float TotalCost()
//     {
//         return _pricePerUnit*_quantity;
//     }
// }
class Product
{
    private string name;
    private string productId;
    private decimal pricePerUnit;
    private int quantity;

    public Product(string name, string productId, decimal pricePerUnit, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.pricePerUnit = pricePerUnit;
        this.quantity = quantity;
    }

    public decimal GetTotalCost()
    {
        return pricePerUnit * quantity;
    }

    public string GetName()
    {
        return name;
    }

    public string GetProductId()
    {
        return productId;
    }

    public decimal GetPricePerUnit()
    {
        return pricePerUnit;
    }

    public int GetQuantity()
    {
        return quantity;
    }
}
