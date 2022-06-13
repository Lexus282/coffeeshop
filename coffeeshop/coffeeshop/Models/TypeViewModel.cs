using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace coffeeshop.Models
{
    public class TypeViewModel
    {
        [Display(Name ="Id")]
        [Browsable(false)]
        public Int32 Id { get; set; }

        [Display(Name = "Название")]
        public String Name { get; set; }
    }
}
