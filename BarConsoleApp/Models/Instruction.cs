using System.ComponentModel.DataAnnotations.Schema;

namespace BarConsoleApp.Models
{
    public class Instruction
    {
        public int Id { get; set; }
        public int RecipeId { get; set; }
        public int StepNumber { get; set; }
        public string Description { get; set; }
    }
}