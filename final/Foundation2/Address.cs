// public class Address
// {
//     private string _street;
//     private string _city;
//     private string _state;
//     private string _country;
//     private bool _america;

//     public bool IsAmerica(bool america)
//     {
//         if (america)
//         {
//             return true;
//         }
//         else
//         {
//             return false;
//         }
//     }

//     public string CompleteAddress(string street, string city, string state, string country)
//     {
//         return $"{street}, {city}, {state}, {country}";
//     }
// }
class Address
{
    private string streetAddress;
    private string city;
    private string state;
    private string country;

    public Address(string streetAddress, string city, string state, string country)
    {
        this.streetAddress = streetAddress;
        this.city = city;
        this.state = state;
        this.country = country;
    }

    public bool IsUSA()
    {
        return country.ToLower() == "usa";
    }

    public string GetFullAddress()
    {
        return $"{streetAddress}\n{city}, {state}\n{country}";
    }
}