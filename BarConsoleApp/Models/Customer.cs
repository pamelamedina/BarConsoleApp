namespace BarConsoleApp.Models
{
    public class Customer
    {
        public string Name;
        public string Drink;

        public string Hello()
        {
            return $"{Name} : Hi my Name is {Name}";
        }
        public string GetName()
        {
            return Name;
        }
        public string GetDrink()
        {
            Console.WriteLine($"{Name}:  I'd like a {Drink}");
            return Drink;
        }

        public static List<Customer> GetCustomerList()
        {
            List<Customer> customerList = new List<Customer>()
            {
              new Customer {Name ="Amy" ,     Drink="Tom Collins" },
              new Customer {Name ="Bill",     Drink="Screw Driver" },
              new Customer {Name ="Chuck",    Drink="Martini" },
              new Customer {Name ="SaraJane", Drink="Rum and Coke" },
             };

            return customerList;
        }
    }
}

