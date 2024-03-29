class Car
{
    public string model;
    public string make;
    public int milesPerGallon;
    public int gallons;
    public Person owner;

    public Car(string make, string model, int milesPerGallon, int gallons)
    {
        this.model = model;
        this.make = make;
        this.milesPerGallon = milesPerGallon;
        this.gallons = gallons;
    }
    public int TotalRange()
    {
        return gallons * milesPerGallon;
    }
    public void Display()
    {
        Console.WriteLine($"Make: {make}. Model: {model}. {owner.DisplayString();} total range = {TotalRange()}");

    }
}