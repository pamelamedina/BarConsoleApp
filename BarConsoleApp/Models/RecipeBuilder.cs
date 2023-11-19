using BarConsoleApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BarConsoleApp.Models
{
    public class RecipeBuilder : IRecipeBuilder
    {
        private Recipe _recipe { get; set; }
        private List<Ingredient> _ingredientList { get; set; }
        private List<Instruction> _instructionList { get; set; }


        public async Task BuildRecipe(string recipeName)
        {
            using (var context = new RecipeDbContext())
            {
                _recipe = await context.Recipes.FirstOrDefaultAsync(x => recipeName.Equals(x.Title));
                _ingredientList = await context.Ingredients.Where(x => x.RecipeId == _recipe.RecipeId).ToListAsync();
                _instructionList = await context.Instructions.Where(x => x.RecipeId == _recipe.RecipeId).OrderBy(x => x.StepNumber).ToListAsync();

            }
            DisplayRecipe();
        }

        public void DisplayRecipe()
        {

            Console.WriteLine($"-----------------{_recipe.Title}----------------");

            foreach (var ingredient in _ingredientList)
            {
                Console.Write($"{ingredient.Quantity}  ");
                Console.Write($"{ingredient.Unit}   ");
                Console.WriteLine($"{ingredient.IngredientName}  ");
            }

            foreach (var instruction in _instructionList)
            {
                Console.WriteLine($"{instruction.Description.Trim()}  ");
            }
            Console.WriteLine("---------------------------------------------------");

        }
    }
}

