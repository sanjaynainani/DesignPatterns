using System;
public interface Vehicle
{
    string Make { get; }
    string Model { get; }
    double Price { get; }
}
public class HondaCity : Vehicle
{
    public string Make
    {
        get { return "HondaCity"; }
    }

    public string Model
    {
        get { return "CNG"; }
    }

    public double Price
    {
        get { return 1000000; }
    }
}

public abstract class VehicleDecorator : Vehicle
{
    private Vehicle _vehicle;

    public VehicleDecorator(Vehicle vehicle)
    {
        _vehicle = vehicle;
    }

    public string Make
    {
        get { return _vehicle.Make; }
    }

    public string Model
    {
        get { return _vehicle.Model; }
    }

    public double Price
    {
        get { return _vehicle.Price; }
    }
}

public class SpecialOffer : VehicleDecorator
{
    public SpecialOffer(Vehicle vehicle) : base(vehicle) { }

    public int DiscountPercentage { get; set; }
    public string Offer { get; set; }
    public new double Price
    {
        get
        {
            double price = base.Price;
            int percentage = 100 - DiscountPercentage;
            return Math.Round((price * percentage) / 100, 2);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        HondaCity car = new HondaCity();
        Console.WriteLine("Polo base price are : {0}", car.Price);
        SpecialOffer offer = new SpecialOffer(car);
        offer.DiscountPercentage = 25;
        offer.Offer = "25 % discount";
        Console.WriteLine("{1} Special Offer and price is : {0} ", offer.Price, offer.Offer);
        Console.ReadKey();
    }
}