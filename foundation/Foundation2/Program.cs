using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();

        Adress adress1 = new Adress("123 Main St", "Anytown", "New Mexico", "USA");
        Customer customer1 = new Customer("John Doe", adress1);
        List<Product> products1 = new List<Product>();
        products1.Add(new Product("Product 1", "00123", 10, 2));
        products1.Add(new Product("Product 2", "00067", 20, 4));
        Order order1 = new Order(products1, customer1);
        orders.Add(order1);

        Adress adress2 = new Adress("321 Main St", "San Miguel de Tucuman", "Tucuman", "Argentina");
        Customer customer2 = new Customer("Jaime Doe", adress2);
        List<Product> products2 = new List<Product>();
        products2.Add(new Product("Product 3", "00012", 10, 3));
        products2.Add(new Product("Product 4", "00006", 20, 1));

        Order order2 = new Order(products2, customer2);
        orders.Add(order2);

        foreach (Order order in orders)
        {
            order.ShippingLabel();
            Console.WriteLine("====================");
        }
    }
}