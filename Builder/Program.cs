﻿using System;
using System.Collections.Generic;

public interface IVehicleBuilder
{
    void SetModel();
    void SetEngine();
    void SetTransmission();
    void SetBody();

    Vehicle GetVehicle();
}


public class HeroBuilder : IVehicleBuilder
{
    Vehicle objVehicle = new Vehicle();
    public void SetModel()
    {
        objVehicle.Model = "Hero";
    }

    public void SetEngine()
    {
        objVehicle.Engine = "4 Stroke";
    }

    public void SetTransmission()
    {
        objVehicle.Transmission = "120 km/hr";
    }

    public void SetBody()
    {
        objVehicle.Body = "Plastic";
    }

    public Vehicle GetVehicle()
    {
        return objVehicle;
    }
}

public class HondaBuilder : IVehicleBuilder
{
    Vehicle objVehicle = new Vehicle();
    public void SetModel()
    {
        objVehicle.Model = "Honda";
    }

    public void SetEngine()
    {
        objVehicle.Engine = "4 Stroke";
    }

    public void SetTransmission()
    {
        objVehicle.Transmission = "125 Km/hr";
    }

    public void SetBody()
    {
        objVehicle.Body = "Plastic";
    }

    public Vehicle GetVehicle()
    {
        return objVehicle;
    }
}

public class Vehicle
{
    public string Model { get; set; }
    public string Engine { get; set; }
    public string Transmission { get; set; }
    public string Body { get; set; }
    public List<string> Accessories { get; set; }

    public Vehicle()
    {
        Accessories = new List<string>();
    }

    public void ShowInfo()
    {
        Console.WriteLine("Model: {0}", Model);
        Console.WriteLine("Engine: {0}", Engine);
        Console.WriteLine("Body: {0}", Body);
        Console.WriteLine("Transmission: {0}", Transmission);
    }
}

public class VehicleCreator
{
    private readonly IVehicleBuilder objBuilder;

    public VehicleCreator(IVehicleBuilder builder)
    {
        objBuilder = builder;
    }

    public void CreateVehicle()
    {
        objBuilder.SetModel();
        objBuilder.SetEngine();
        objBuilder.SetBody();
        objBuilder.SetTransmission();
    }

    public Vehicle GetVehicle()
    {
        return objBuilder.GetVehicle();
    }
}

class Program
{
    static void Main(string[] args)
    {
        var vehicleCreator = new VehicleCreator(new HeroBuilder());
        vehicleCreator.CreateVehicle();
        var vehicle = vehicleCreator.GetVehicle();
        vehicle.ShowInfo();

        vehicleCreator = new VehicleCreator(new HondaBuilder());
        vehicleCreator.CreateVehicle();
        vehicle = vehicleCreator.GetVehicle();
        vehicle.ShowInfo();

        Console.ReadKey();
    }
}