using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MBMTrans.ViewModels
{
    public class RegistrationModel
    {
        [Required(ErrorMessage = "Не введено имя пользователя")]
        public string Login { get; set; }

        [Required(ErrorMessage ="Не указан пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage ="Повторите пароль")]
        [Compare("Password", ErrorMessage ="Пароли не совпадают")]
        public string ConfirmPasswd { get; set; }

        [Required(ErrorMessage ="Не указан E-mail")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage ="Не указан номер телефона")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
    }
}
