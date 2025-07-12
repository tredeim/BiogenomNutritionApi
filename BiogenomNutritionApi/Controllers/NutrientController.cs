using BiogenomNutritionApi.DTOs;
using BiogenomNutritionApi.Models;
using BiogenomNutritionApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace BiogenomNutritionApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class NutrientController(INutrientService nutrientService) : ControllerBase
{
    
    [HttpGet]
    [ProducesResponseType(typeof(GetNutrientsResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public async Task<IActionResult> Get(CancellationToken cancellationToken)
    {
        var nutrients = await nutrientService.GetAllAsync(cancellationToken);
        
        if (nutrients.Count == 0)
            return NoContent();
        
        return Ok(new GetNutrientsResponse { Nutrients = nutrients.Select(n => new NutrientUnit{
            Name = n.Name.GetDisplayName(),
            Unit = n.Unit.ToString(),
            CurrentValue = n.CurrentValue,
            RecommendedMin = n.RecommendedMin,
            RecommendedMax = n.RecommendedMax,
            Source = n.Source.ToString()})
            .ToList()});
    }
}

public class GetNutrientsResponse
{
    public List<NutrientUnit> Nutrients { get; init; }
}

public class NutrientUnit
{
    public string Name { get; init; }
    public string Unit { get; init; }
    public double CurrentValue { get; init; }
    public double RecommendedMin { get; init; }
    public double RecommendedMax { get; init; }
    public string Source { get; init; }
}