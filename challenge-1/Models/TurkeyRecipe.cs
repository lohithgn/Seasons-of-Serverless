using System.Collections.Generic;

namespace Kashyapas.SeasonsOfServerless.Models
{
    public class TurkeyRecipe : IRecipe
    {
        public TurkeyRecipe()
        {
            Ingredients = new List<Ingredient>();
            CookingTimes = new List<Time>();
        }
        public List<Ingredient> Ingredients { get; set; }
        public List<Time> CookingTimes { get; set; }
    }
}
