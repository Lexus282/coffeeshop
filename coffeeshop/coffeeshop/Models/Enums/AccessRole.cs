
using System.ComponentModel.DataAnnotations;

namespace coffeeshop.Models.Enums
{
    public enum AccessRole
    {
        [Display(Name = "Администратор")]
        Admin = 1,

        [Display(Name = "Сотрудник")]
        Employee = 2
    }
}
