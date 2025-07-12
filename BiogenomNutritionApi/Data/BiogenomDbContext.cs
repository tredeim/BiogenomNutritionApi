using BiogenomNutritionApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BiogenomNutritionApi.Data;

public class BiogenomDbContext(DbContextOptions<BiogenomDbContext> options) : DbContext(options)
{
    public DbSet<NutrientLevel> NutrientLevels { get; set; }
}