﻿namespace BarConsoleApp.Models
{
    public class Bar
    {
        public string Name { get; set; }
        public List<Customer> Customers { get; set; }
        public Bartender Bartender { get; set; }
        public IRecipeBuilder RecipeBuilder { get; set; }


        public Bar(string name, List<Customer> customers, Bartender bartender, IRecipeBuilder recipeBuilder)
        {
            Name = name;
            Customers = customers;
            RecipeBuilder = recipeBuilder;
            Bartender = bartender;
            Console.WriteLine($"Welcome to {Name}");
        }

        public async Task BarProcess()
        {
            foreach (var customer in Customers)
            {
                Console.WriteLine();
                Console.WriteLine(customer.Hello());
                var drink = Bartender.WhatToDrink(customer);
                await Bartender.ServeDrink(drink, RecipeBuilder);
                Console.WriteLine();
            }
        }

    }
}
