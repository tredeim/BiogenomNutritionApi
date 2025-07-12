using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace BiogenomNutritionApi.Models;

public enum NutrientName
{
    [Display(Name = "Неизвестно")] Unknown = 0,
    [Display(Name = "Витамин A")] VitaminA,
    [Display(Name = "Витамин B1 (тиамин)")] VitaminB1,
    [Display(Name = "Витамин B2 (рибофлавин)")] VitaminB2,
    [Display(Name = "Витамин B3 (ниацин)")] VitaminB3,
    [Display(Name = "Витамин B5 (пантотеновая кислота)")] VitaminB5,
    [Display(Name = "Витамин B6 (пиридоксин)")] VitaminB6,
    [Display(Name = "Витамин B9 (фолиевая кислота)")] VitaminB9,
    [Display(Name = "Витамин B12 (кобаламин)")] VitaminB12,
    [Display(Name = "Витамин C (аскорбиновая кислота)")] VitaminC,
    [Display(Name = "Витамин D (кальциферол)")] VitaminD,
    [Display(Name = "Витамин E (альфа-токоферол)")] VitaminE,
    [Display(Name = "Бета-каротин")] BetaCarotene,
    [Display(Name = "Ретинол")] Retinol,
    [Display(Name = "Кальций")] Calcium,
    [Display(Name = "Магний")] Magnesium,
    [Display(Name = "Натрий")] Sodium,
    [Display(Name = "Калий")] Potassium,
    [Display(Name = "Фосфор")] Phosphorus,
    [Display(Name = "Железо")] Iron,
    [Display(Name = "Цинк")] Zinc,
    [Display(Name = "Селен")] Selenium,
    [Display(Name = "Йод")] Iodine,
    [Display(Name = "Хлор")] Chloride,
    [Display(Name = "Белки")] Protein,
    [Display(Name = "Жиры")] Fat,
    [Display(Name = "Углеводы")] Carbohydrates,
    [Display(Name = "Сахара")] Sugars,
    [Display(Name = "Пищевые волокна")] Fiber,
    [Display(Name = "Вода")] Water,
    [Display(Name = "Крахмал")] Starch,
    [Display(Name = "Алкоголь (спирт)")] Alcohol,
    [Display(Name = "Энергия")] Energy
}

public static class EnumExtensions
{
    public static string GetDisplayName(this Enum value)
    {
        var type = value.GetType();
        var memberInfo = type.GetMember(value.ToString());
        if (memberInfo.Length > 0)
        {
            var attr = memberInfo[0].GetCustomAttribute<DisplayAttribute>();
            if (attr != null)
            {
                return attr.Name;
            }
        }

        return value.ToString();
    }
}