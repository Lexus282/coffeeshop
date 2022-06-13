using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace coffeeshop.Models
{
    public class ClientViewModel
    {
        [Display(Name ="Id")]
        [Browsable(false)]
        public String Id { get; set; }

        [Display(Name = "ФИО")]
        public String Name { get; set; }

        [Display(Name = "Эл. почта")]
        public String Email { get; set; }

        [Display(Name = "Телефон")]
        public String PhoneNumber { get; set; }
    }
}
