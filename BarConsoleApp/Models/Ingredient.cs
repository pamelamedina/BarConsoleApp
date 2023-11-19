using System.ComponentModel.DataAnnotations.Schema;

namespace BarConsoleApp.Models
{
    public class Ingredient
    {
        public int IngredientId { get; set; }
        public int RecipeId { get; set; }
        public string IngredientName { get; set; }
        public double Quantity { get; set; }
        public string Unit { get; set; }

    }
}