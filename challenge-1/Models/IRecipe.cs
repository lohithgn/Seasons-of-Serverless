using System.Collections.Generic;

namespace Kashyapas.SeasonsOfServerless.Models
{
    public interface IRecipe
    {
        List<Ingredient> Ingredients { get; set; }
        List<Time> CookingTimes { get; set; }
    }
}
