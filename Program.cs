using System;

public class Automobile
{
    public string Name { get; set; }
    public int MaxSpeed { get; set; }

    public Automobile(string name, int maxSpeed)
    {
        Name = name;
        MaxSpeed = maxSpeed;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Назва: {Name}, Максимальна швидкiсть: {MaxSpeed} км/год");
    }
}

public class Car : Automobile
{
    public int PassengerSeats { get; set; }

    public Car(string name, int maxSpeed, int passengerSeats)
        : base(name, maxSpeed)
    {
        PassengerSeats = passengerSeats;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Кiлькiсть мiсць для пасажирiв: {PassengerSeats}");
    }
}

public class Vehicle : Automobile
{
    public int CargoWeight { get; set; }

    public Vehicle(string name, int maxSpeed, int cargoWeight)
        : base(name, maxSpeed)
    {
        CargoWeight = cargoWeight;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Вага вантажу: {CargoWeight} кг");
    }
}

public class Program
{
    public static void Main()
    {
        Automobile[] automobiles = new Automobile[7];
        automobiles[0] = new Car("Tesla Model X", 249, 7);
        automobiles[1] = new Vehicle("Volvo FH", 90, 20000);
        automobiles[2] = new Vehicle("Ford Transit", 160, 20000);
        automobiles[3] = new Car("Mercedes Benz C Class", 250, 5);
        automobiles[4] = new Car("Audi A4", 251, 5);
        automobiles[5] = new Vehicle("Volkswagen Crafter", 140, 1100);
        automobiles[6] = new Car("BMW 3 Series", 270, 4);

        Automobile fastestAutomobile = null;
        int maxSpeed = 0;

        foreach (var auto in automobiles)
        {
            if (auto.MaxSpeed > maxSpeed)
            {
                fastestAutomobile = auto;
                maxSpeed = auto.MaxSpeed;
            }
        }

        Console.WriteLine("Автомобiль з найбiльшою швидкiстю: ");
        fastestAutomobile.DisplayInfo();
    }
}