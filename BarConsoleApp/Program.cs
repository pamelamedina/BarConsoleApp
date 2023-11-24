using BarConsoleApp.Models;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    //This program implements a functioning Bar App, which takes in a 
    //list of customers and has a bartender that serves drinks
    //recipes are accessed from database tables and built
    //from the RecipeBuilder class which implements IRecipeBuilder
    //implementing the adapter design pattern.  Recipes consist of
    //a Recipe (header) ,  Ingredient list , Instruction list.
    private static async Task Main(string[] args)
    {
        Bar a = new Bar("The Broken Keel Tavern");
        await a.BarProcess(Customer.GetCustomerList(), new Bartender("Adam"), new RecipeBuilder());

        Bar b = new Bar("Cheers ", Customer.GetCustomerList(), new Bartender("Brad"), new RecipeBuilder());
        await b.BarProcess();
        Console.ReadLine();

    }//End Main


    public static async Task DisplayEverything()
    {
        //This method is a development diagnostic
        //to display database information       
        using (var context = new RecipeDbContext())
        {
            //Ingredients
            var IngredientList = await context.Ingredients.ToListAsync();
            foreach (var ingredient in IngredientList)
            {
                Console.WriteLine(ingredient.IngredientName);
            }

            Console.WriteLine();

            //Instructions
            var InstructionList = await context.Instructions.ToListAsync();
            foreach (var instruction in InstructionList)
            {
                Console.WriteLine(instruction.Description);
            }

            Console.WriteLine();

            //Instructions
            var RecipeList = await context.Recipes.ToListAsync();
            foreach (var recipe in RecipeList)
            {
                Console.WriteLine(recipe.Title);
            }

        }//End Using

    }//End method DisplayEverything

}//End Program
