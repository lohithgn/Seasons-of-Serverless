using Kashyapas.SeasonsOfServerless.Models;
using Kashyapas.SeasonsOfServerless.Service;
using System;

namespace Kashyapas.SeasonsOfServerless.Services
{
    public class TurkeyRecipeGenerator : IRecipeGenerator
    {
        public IRecipe GenerateRecipe(double turkeyWeight)
        {
            var recipe = new TurkeyRecipe();
            AddIngredients(recipe, turkeyWeight);
            AddCookingTimes(recipe, turkeyWeight);
            return recipe;
        }

        private void AddCookingTimes(TurkeyRecipe recipe, double turkeyWeight)
        {
            recipe.CookingTimes.Add(new Time{ Name="Brine Time",Measure=2.4 * turkeyWeight,Unit="hour(s)" });
            recipe.CookingTimes.Add(new Time{ Name="Roast Time",Measure=15 * turkeyWeight,Unit="minute(s)" });
        }

        private void AddIngredients(TurkeyRecipe recipe, double turkeyWeight)
        {
            recipe.Ingredients.Add(
                new Ingredient{Name = "Salt",Measure = 0.05 * turkeyWeight,Unit = "cup(s)"}
            );
            recipe.Ingredients.Add(
                new Ingredient{Name = "Water",Measure = Math.Round(0.66 * turkeyWeight,2),Unit = "gallon(s)"}
            );
            recipe.Ingredients.Add(
                new Ingredient{Name = "Brown Sugar",Measure = 0.13 * turkeyWeight,Unit = "cup(s)"}
            );
            recipe.Ingredients.Add(
                new Ingredient{Name = "Shallots",Measure = 0.2 * turkeyWeight,Unit = "number(s)"}
            );
            recipe.Ingredients.Add(
                new Ingredient{Name = "Garlic",Measure = 0.4 * turkeyWeight,Unit = "clove(s)"}
            );
            recipe.Ingredients.Add(
                new Ingredient{Name = "Whole Peppercorns",Measure = 0.13 * turkeyWeight,Unit = "tablespoon(s)"}
            );
            recipe.Ingredients.Add(
                new Ingredient{Name = "Dried Juniper Berries",Measure = 0.13 * turkeyWeight,Unit = "tablespoon(s)"}
            );
            recipe.Ingredients.Add(
                new Ingredient{Name = "Fresh Rosemary",Measure = 0.13 * turkeyWeight,Unit = "tablespoon(s)"}
            );
            recipe.Ingredients.Add(
                new Ingredient{Name = "Thyme",Measure = 0.06 * turkeyWeight,Unit = "tablespoon(s)"}
            );
        }
    }
}
