using task4;
// Creating a Car object
Car myCar = new Car("Toyota", "Camry", 2022);

// Printing initial information
Console.WriteLine($"Make: {myCar.Make}");
Console.WriteLine($"Model: {myCar.Model}");
Console.WriteLine($"Year: {myCar.Year}");
Console.WriteLine($"Mileage: {myCar.Mileage = 100} miles");
Console.WriteLine($"Fuel level: {myCar.Fuel = 5} gallons");

// Driving the car
myCar.Drive(100);

// Adding fuel
myCar.AddFuel(10);

// Printing updated information
Console.WriteLine($"\nAfter the trip and refueling:");
Console.WriteLine($"Mileage: {myCar.Mileage} miles");
Console.WriteLine($"Fuel level: {myCar.Fuel} gallons");