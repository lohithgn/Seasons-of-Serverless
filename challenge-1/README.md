# Challenge 1 - The Perfect Turkey 🦃 

You can read about the challenge [here](https://github.com/microsoft/Seasons-of-Serverless/blob/main/Nov-23-2020.md).


# CI/CD Status

![Build status](https://dev.azure.com/kashyapas/Seasons-of-Serverless/_apis/build/status/Challenge-1-CI) 
![Deploytment Status](https://vsrm.dev.azure.com/kashyapas/_apis/public/Release/badge/521427f8-9e18-4676-9d3c-2f335d4dffa5/1/1)

# Solution

- Azure Function App targeting .NET Core 3.1 and Azure Functions V3 runtime
- Azure Function with HTTP Trigger.
- Function HTTP route is set to
```
https://<domain>/api/recipes/turkey
```
- Weight of the turkey is passed as a querystring. Example:
```
https://<domain>/api/recipes/turkey?weight=5
``` 
- Output from the function is a JSON document. Structure of JSON is as below:
```
{
  "ingredients": [
    {
      "name": "Salt",
      "measure": 0.25,
      "unit": "cup(s)"
    },
    {
      "name": "Water",
      "measure": 3.3,
      "unit": "gallon(s)"
    },
    {
      "name": "Brown Sugar",
      "measure": 0.65,
      "unit": "cup(s)"
    },
    {
      "name": "Shallots",
      "measure": 1.0,
      "unit": "number(s)"
    },
    {
      "name": "Garlic",
      "measure": 2.0,
      "unit": "clove(s)"
    },
    {
      "name": "Whole Peppercorns",
      "measure": 0.65,
      "unit": "tablespoon(s)"
    },
    {
      "name": "Dried Juniper Berries",
      "measure": 0.65,
      "unit": "tablespoon(s)"
    },
    {
      "name": "Fresh Rosemary",
      "measure": 0.65,
      "unit": "tablespoon(s)"
    },
    {
      "name": "Thyme",
      "measure": 0.3,
      "unit": "tablespoon(s)"
    }
  ],
  "cookingTimes": [
    {
      "name": "Brine Time",
      "measure": 12.0,
      "unit": "hour(s)"
    },
    {
      "name": "Roast Time",
      "measure": 75.0,
      "unit": "minute(s)"
    }
  ]
}
```

# How to run challenge-1

- Go to terminal and navigate to challenge-1 folder
- execute the following command:
```
func host start
```
- Function will be built & available at the following route:
```
http://localhost:7071/api/recipes/turkey
``` 
- Use postman or any http client of your choice and make a HTTP GET call by passing weight of the turkey. Example:
```
http://localhost:7071/api/recipes/turkey?weight=5
```