namespace task4;

public class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public double Mileage { get; set; }
    public double Fuel { get; set; }
    public Car(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }
    public void Drive(double miles)
    {
        Mileage += miles;
        System.Console.WriteLine($"You have driven 100 miles. Current mileage: {Mileage} miles. Remaining fuel: {Fuel} gallons.");
    }
    public void AddFuel(int addingfuel)
    {
        Fuel += addingfuel;
        System.Console.WriteLine($"Added 10 gallons of fuel. Current fuel level: {Fuel} gallons.");
    }
}
