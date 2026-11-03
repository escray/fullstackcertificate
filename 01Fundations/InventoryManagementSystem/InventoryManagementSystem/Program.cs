using System.Runtime.CompilerServices;

class InventoryManagement
{
    class Product
    {
        public string Name;
        public decimal Price;
        public int StockQuantity;
        public string StockUnit;

        public Product()
        {

        }

        public override string ToString()
        {
            return string.Format("The Product Name is {0}, Price at {1}, Stock: {2} - {3}", Name, Price, StockQuantity, StockUnit);
        }
    }

    static List<Product> products = new List<Product>();

    static void Main(string[] args)
    {
        while (true)
        {
            System.Console.WriteLine("Inventory Management");
            System.Console.WriteLine("1. Add Product");
            System.Console.WriteLine("2. Update Stock");
            System.Console.WriteLine("3. View Products");
            System.Console.WriteLine("4. Exit");
            System.Console.WriteLine("Please input a number of your choice: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    AddProduct();
                    break;
                case "2":
                    UpdateStock();
                    break;
                case "3":
                    ViewProducts();
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    System.Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }

    private static void AddProduct()
    {
        System.Console.WriteLine("Enter product name:");
        string name = Console.ReadLine();
        System.Console.WriteLine("Enter product price:");
        decimal price = decimal.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter product stock quantity:");
        int quantity = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter product stock unit:");
        string unit = Console.ReadLine();

        if (string.IsNullOrEmpty(name) && decimal.IsNegative(price) && int.IsNegative(quantity))
        {
            System.Console.WriteLine("The detail product is invalid.");
            return;
        }
        foreach (var item in products)
        {
            if (item.Name == name)
            {
                System.Console.WriteLine("The inventory has same name product.");
                return;
            }
        }

        Product product = new()
        {
            Name = name,
            Price = price,
            StockQuantity = quantity,
            StockUnit = unit
        };

        products.Add(product);
        System.Console.WriteLine("Product Added Successfully");
    }

    private static void UpdateStock()
    {
        if (products.Count == 0)
        {
            System.Console.WriteLine("No products available to update.");
            return;
        }
        System.Console.WriteLine("Enter product name to update:");
        string name = Console.ReadLine();
        foreach (var item in products)
        {
            if (item.Name == name)
            {
                System.Console.WriteLine("Please input quanlity to update.");
                int quantity = int.Parse(Console.ReadLine());
                item.StockQuantity = quantity;
                return;
            }
        }
        System.Console.WriteLine("Cannot find the product you need want to update.");
    }

    private static void ViewProducts()
    {
        if (products.Count == 0)
        {
            System.Console.WriteLine("No product available.");
            return;
        }
        System.Console.WriteLine("Products: ");
        for (int i = 0; i < products.Count; i++)
        {
            System.Console.WriteLine(products[i].ToString());;
        }
    }
}
