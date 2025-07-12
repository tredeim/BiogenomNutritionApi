using BiogenomNutritionApi.Models;

namespace BiogenomNutritionApi.DTOs;

public class NutrientDto
{
    public NutrientName Name { get; init; }
    public NutrientUnit Unit { get; init; }
    public double CurrentValue { get; init; }
    public double RecommendedMin { get; init; }
    public double RecommendedMax { get; init; }
    public NutrientSource Source { get; init; }
}