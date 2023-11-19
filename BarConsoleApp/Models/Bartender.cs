namespace BarConsoleApp.Models
{
    public class Bartender
    {
        public string Name { get; set; }

        public Bartender(string name)
        {
            Name = name;
            Console.WriteLine($"{Name} : Hi, I'm {Name} I'll be your Bartender tonight.");
        }

        public string WhatToDrink(Customer cust)
        {
            Console.WriteLine($"{Name} :  Hi {cust.Name} What would you like to drink?");
            return cust.GetDrink();
        }

        public async Task ServeDrink(string drink, IRecipeBuilder r)
        {
            await r.BuildRecipe(drink);
        }
    }
}
