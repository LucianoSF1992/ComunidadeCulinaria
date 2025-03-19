using System.Collections.Generic;
using ComunidadeCulinaria.Models;

namespace ComunidadeCulinaria.Services
{
    public class RecipeService
    {
        private List<Recipe> recipes = new List<Recipe>();

        public void AddRecipe(Recipe recipe)
        {
            recipes.Add(recipe);
        }

        public List<Recipe> GetAllRecipes()
        {
            return recipes;
        }
    }
}
