using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MBMTrans.ViewModels
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Не верное имя пользователя")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Не вереный пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
