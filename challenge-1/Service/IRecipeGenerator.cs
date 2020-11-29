using Kashyapas.SeasonsOfServerless.Models;

namespace Kashyapas.SeasonsOfServerless.Service
{
    public interface IRecipeGenerator
    {
        IRecipe GenerateRecipe(double weight);
    }
}
