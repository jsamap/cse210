using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Customer customer1 = new Customer("Jared", new Address("15 Avenida A 2078", "Zona 13", "Guatemala", "Guatemala"));
        Product product1 = new Product("Omen 16 Laptop", "OM16", 2000, 1);
        Product product2 = new Product("Xbox Series X", "XBSX", 500, 2);
        Order order1 = new Order(customer1, [product1, product2]);


        Customer customer2 = new Customer("Eva", new Address("5725 S 2050 W", "Roy", "Utah", "United States"));
        Product product3 = new Product("Spector Ethos 5 Bass", "SE5B", 1500, 1);
        Product product4 = new Product("Fender Rumble 40 Amplifier", "FR40", 200, 1);
        Product product5 = new Product("Ernie Ball Instrument Cable", "EBIC", 25, 4);
        Order order2 = new Order(customer2, [product3, product4, product5]);

        Console.WriteLine(" ----- ORDER #1 ----- ");
        Console.WriteLine("\n"+order1.GetPackingLabel());
        Console.WriteLine("\n"+order1.GetShippingLabel());
        Console.WriteLine($"\nOrder Total: {order1.GetOrderTotal().ToString("F2")}\n");

        Console.WriteLine(" ----- ORDER #2 ----- ");
        Console.WriteLine("\n"+order2.GetPackingLabel());
        Console.WriteLine("\n"+order2.GetShippingLabel());
        Console.WriteLine($"\nOrder Total: {order2.GetOrderTotal().ToString("F2")}\n");

    }
}