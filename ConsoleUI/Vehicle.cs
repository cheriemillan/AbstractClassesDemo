using System;

namespace ConsoleUI;

public abstract class Vehicle
{
    /*
     * Create an abstract class called Vehicle
     * The vehicle class shall have three string properties: Year, Make, and Model
     * Set the defaults of the properties to something generic in the Vehicle class
     * Vehicle class shall have an abstract method called DriveAbstract with no implementation.
     * Vehicle class shall have a virtual method called DriveVirtual with a base implementation.
     */
    
    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }

    public Vehicle()
    {
        Year = 2004;
        Make = "Civic";
        Model = "Honda";
    }

    public abstract void DriveAbstract();

    public virtual void DriveVirtual()
    {
        Console.WriteLine($"I am driving a {Model} {Make} virtually");
    }
}