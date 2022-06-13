using System.ComponentModel.DataAnnotations;

namespace coffeeshop.Models.Enums
{
    public enum ProductType
    {
        [Display(Name = "Чай")]
        tea = 1,

        [Display(Name = "Кофе")]
        coffee = 2
    }
}
