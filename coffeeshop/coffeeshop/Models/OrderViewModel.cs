using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace coffeeshop.Models
{
    public class OrderViewModel
    {
        [Display(Name ="Id")]
        [Browsable(false)]
        public Int32 Id { get; set; }

        [Display(Name = "Дата")]
        public String Date { get; set; }

        [Display(Name = "Клиент")]
        public String ClientName { get; set; }

        [Display(Name = "Сотрудник")]
        public String EmployeeName { get; set; }

        [Display(Name = "Стоимость")]
        public Decimal Cost { get; set; }

        [Display(Name = "Тип оплаты")]
        public String PaymentType { get; set; }

        [Display(Name = "Статус")]
        public String State { get; set; }

    }
}
