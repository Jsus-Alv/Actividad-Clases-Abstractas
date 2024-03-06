using System;

public abstract class Vehiculo
{
    public virtual string ruedas()
    {
        return "El vehiculo tiene ruedas";
    }
}
public class Carro : Vehiculo
{
    public override string ruedas()
    {
        return "El auto tiene 4 ruedas";
    }
} 
public class Moto : Vehiculo
{
    public override string ruedas()
    {
        return "La moto tiene 2 ruedas";
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Vehiculo vehiculo = new Carro();
        Console.WriteLine(vehiculo.ruedas());

        vehiculo = new Moto();
        Console.WriteLine(vehiculo.ruedas());
    }
}


