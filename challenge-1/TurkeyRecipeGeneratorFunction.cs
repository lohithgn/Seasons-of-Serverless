using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Kashyapas.SeasonsOfServerless.Services;
using Kashyapas.SeasonsOfServerless.Service;

namespace Kashyapas.SeasonsOfServerless
{
    public class TurkeyRecipeGeneratorFunction
    {
        private readonly IRecipeGenerator _turkeyRecipeGenerator;

        public TurkeyRecipeGeneratorFunction(IRecipeGenerator recipeGenerator)
        {
            _turkeyRecipeGenerator = recipeGenerator;
        }

        [FunctionName(nameof(TurkeyRecipeGeneratorFunction))]
        public IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "recipes/turkey")] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");
            string payload = req.Query["weight"];
            if(string.IsNullOrEmpty(payload))
            {
                return new BadRequestObjectResult("Turkey weight not provided.");
            }
            double turkeyWeight;
            if (!double.TryParse(payload, out turkeyWeight))
            {
                return new BadRequestObjectResult("Invalid Turkey weight provided.");
            }
            var recipe = _turkeyRecipeGenerator.GenerateRecipe(turkeyWeight);
            return new OkObjectResult(recipe);
        }
    }
}
