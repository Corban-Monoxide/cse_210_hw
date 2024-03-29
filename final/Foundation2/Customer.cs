// public class Customer
// {
//     private string _customerName;
//     private Address _address;

//      // Constructor
//     public Customer(string customerName, Address address)
//     {
//         _customerName = customerName;
//         _address = address;
//     }

//     // Getter for Customer Name
//     public string GetCustomerName()
//     {
//         return _customerName;
//     }

//     // Setter for Customer Name
//     public void SetCustomerName(string customerName)
//     {
//         _customerName = customerName;
//     }

//     // Getter for Address
//     public Address GetAddress()
//     {
//         return _address;
//     }

//     // Setter for Address
//     public void SetAddress(Address address)
//     {
//         _address = address;
//     }
//     public bool IsAmerica()
//     {
//         return true;
//     }
//     public void Display()
//     {

//     }
// }
class Customer
{
    private string name;
    private Address address;

    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    public bool IsUSA()
    {
        return address.IsUSA();
    }

    public string GetName()
    {
        return name;
    }

    public Address GetAddress()
    {
        return address;
    }
}