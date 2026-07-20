using System.Globalization;

namespace Section06;

public class Product
{
    public string? Name {get; set;}
    public int Price {get; set;}
}

public class Listdemo
{
    public static void Run()
    {
        /*
        //create new empty List.
        List<int> ankio = new List<int>();

        //add new items in the list
        ankio.Add(1);
        ankio.Add(2);
        ankio.Add(3);
    
        //read those items or specific items
        //reading a specific item at index
        System.Console.WriteLine(ankio[2]);

        //reading all items 
        foreach(int nums in ankio)
        {
            System.Console.WriteLine(nums);
        }
        
        
        //remove items from a list
        bool isRemoved = ankio.Remove(3);
        if (isRemoved)
        {
            System.Console.WriteLine("Element 3 has been removed");
        }
        
        //create a new list with items when initialized
        List<string> strings = ["This ","List ", "has ","it's ", "elements ","Pre-initialised."];
        foreach(string words in strings)
        {
            System.Console.Write(words);
        }
        System.Console.WriteLine();
        */


        /*
        //sorting a list
        List<int> nums = [63541,23,5432,76547];
        System.Console.WriteLine("List before sort() is called:");
        foreach(var num in nums)
        {
            System.Console.WriteLine(num);
        }
        nums.Sort();
        System.Console.WriteLine("\nList after the sort() is called:");
        foreach(var num in nums)
        {
            System.Console.WriteLine(num);
        }
        

        //using Any func and Find all func together
        List<int> nums = [56,343,123,54,1,78];
        int userChoice;
        System.Console.Write("Enter a number to see higher elements then that: ");
        int.TryParse(Console.ReadLine(), out userChoice);
        bool isHigher = nums.Any(nums => nums > userChoice);
        if (isHigher)
        {
            List<int> higherThenUserChoice = nums.FindAll(nums => nums > userChoice);
            System.Console.WriteLine($"Elements Higher then {userChoice} are:");
            foreach(int num in higherThenUserChoice)
            {
                System.Console.Write($"{num} ");
            }
            System.Console.WriteLine("\n");
        }
        else
        {
            System.Console.WriteLine($"No element in the list is higher then {userChoice}");
        }
        */


        //List of class objects
        List<Product> products = new List<Product>
        {
            new Product{Name = "Wireless Mice", Price = 3500},
            new Product{Name = "Logitech G034", Price = 2500},
            new Product{Name = "MCHOSE G75 Pro", Price = 4800},
            new Product{Name = "AntEsports MK3200", Price = 2200},
            new Product{Name = "White Topographic deskmat L", Price = 399},
            new Product{Name = "White Topographic deskmat XL", Price = 599},
            new Product{Name = "White Topographic deskmat XXL", Price = 999}
        };

        int userChoice;
        System.Console.Write("Enter the highest price range of product you want to see: ");
        int.TryParse(Console.ReadLine(), out userChoice);
        List<Product> priceFilteredProducts = products.Where(p => p.Price <= userChoice).ToList();
        foreach(Product product in priceFilteredProducts)
        {
            System.Console.WriteLine($"{product.Name} is available for Rs. {product.Price}");
        }

    }
}