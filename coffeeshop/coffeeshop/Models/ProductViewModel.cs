using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace coffeeshop.Models
{
    public class ProductViewModel
    {
        [Display(Name ="Id")]
        [Browsable(false)]
        public Int32 Id { get; set; }

        [Display(Name = "Название")]
        public String Name { get; set; }

        [Display(Name = "Тип продукта")]
        public String ProductType { get; set; }

        [Display(Name = "Вид")]
        public String Type { get; set; }

        [Display(Name = "Описание")]
        public String Description { get; set; }

        [Display(Name = "Страна")]
        public String Origin { get; set; }

        [Display(Name = "Стоимость")]
        public Decimal Price { get; set; }

        [Display(Name = "Количество")]
        public Int32 Count { get; set; }

    }
}
