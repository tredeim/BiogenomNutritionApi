using BiogenomNutritionApi.DTOs;

namespace BiogenomNutritionApi.Services;

public interface INutrientService
{
    Task<List<NutrientDto>> GetAllAsync(CancellationToken cancellationToken);
}