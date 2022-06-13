using System.ComponentModel.DataAnnotations;

namespace coffeeshop.Models.Enums
{
    public enum OrderState
    {
        [Display(Name = "Оплачен")]
        Payment = 1,

        [Display(Name = "Собирается")]
        Prepared = 2,

        [Display(Name = "Отправлен")]
        Sent = 3,

        [Display(Name = "Получен")]
        Received = 4,

        [Display(Name = "Отменен")]
        Canceled = 5
    }
}
