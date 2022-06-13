using System.ComponentModel.DataAnnotations;

namespace coffeeshop.Models.Enums
{
    public enum PaymentType
    {
        [Display(Name = "Карта")]
        Card = 1,

        [Display(Name = "Наличные")]
        Cash = 2
    }
}
