using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarConsoleApp.Models
{
    public interface IRecipeBuilder
    {
        public Task BuildRecipe(string recipeName);
        public void DisplayRecipe();
    }
}
