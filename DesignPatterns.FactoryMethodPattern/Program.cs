// Factory Method Design Pattern - Creational Category //

PizzaStore izmirPizzaStore = new IzmirPizzaStore();
PizzaStore istanbulPizzaStore = new IstanbulPizzaStore();

IPizza cheesePizza = izmirPizzaStore.OrderPizza("cheese");
Console.WriteLine("Cheese pizza ordered in İzmir Store");

IPizza veggiPizza = istanbulPizzaStore.OrderPizza("veggi");
Console.WriteLine("Veggi pizza ordered in İstanbul Store");



interface IPizza
{
    void Prepare();
    void Bake();
    void Cut();
}
class CheesePizza : IPizza
{
    public void Bake()
    {
        Console.WriteLine("CheesePizza Pizza Baked");
    }

    public void Cut()
    {
        Console.WriteLine("CheesePizza Pizza Cut");
    }

    public void Prepare()
    {
        Console.WriteLine("CheesePizza Pizza Prepared");
    }
}
class VeggiPizza : IPizza
{
    public void Bake()
    {
        Console.WriteLine("VeggiPizza Pizza Baked");
    }

    public void Cut()
    {
        Console.WriteLine("VeggiPizza Pizza Cut");
    }

    public void Prepare()
    {
        Console.WriteLine("VeggiPizza Pizza Prepared");
    }
}

abstract class PizzaStore
{
    protected abstract IPizza CreatePizza(string type);
    public IPizza OrderPizza(string type)
    {
        IPizza pizza = CreatePizza(type);
        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();

        return pizza;
    }

}

class IzmirPizzaStore : PizzaStore
{
    protected override IPizza CreatePizza(string type)
    {
        return type switch
        {
            "cheese" => new CheesePizza(),
            "veggi" => new VeggiPizza(),
            _ => throw new ArgumentException("Invalid pizza type", nameof(type))
        };
    }
}

class IstanbulPizzaStore : PizzaStore
{
    protected override IPizza CreatePizza(string type)
    {
        return type switch
        {
            "cheese" => new CheesePizza(),
            "veggi" => new VeggiPizza(),
            _ => throw new ArgumentException("Invalid pizza type", nameof(type))
        };
    }
}
