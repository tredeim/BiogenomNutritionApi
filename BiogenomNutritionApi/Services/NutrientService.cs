using BiogenomNutritionApi.Data;
using BiogenomNutritionApi.DTOs;
using Microsoft.EntityFrameworkCore;

namespace BiogenomNutritionApi.Services;

public class NutrientService(BiogenomDbContext context) : INutrientService
{
    public async Task<List<NutrientDto>> GetAllAsync(CancellationToken cancellationToken)
    {
        return await context.NutrientLevels
            .Select(n => new NutrientDto
            {
                Name = n.Name,
                Unit = n.Unit,
                CurrentValue = n.CurrentValue,
                RecommendedMin = n.RecommendedMin,
                RecommendedMax = n.RecommendedMax,
                Source = n.Source
            }).ToListAsync(cancellationToken);
    }
}