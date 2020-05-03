using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AfterSchool
{
    static class LoginOperations
    {
        // Инициализация в системе
        public static void Initialisation(string Login, string Password, Form ParentForm)
        {
            // Проверка введенных логина и пароля
            int UserCat = DBOperations.CheckLoginDB(Login, Password);
            // Открытие приложения
            // Инициализация форм в зависимости от прав доступа
            Form NextForm = new Form();
            if (UserCat == 0)
            {
                NextForm = new FormEmployee();
                NextForm.Owner = ParentForm;
                EmployeeOperations.CurrentUser = DBOperations.GetUserID(Login);
                FormActivity AF = new FormActivity();
                AF.Owner = ParentForm;
                FormGroup GF = new FormGroup();
                GF.Owner = ParentForm;
                FormTimetable TF = new FormTimetable();
                TF.Owner = ParentForm;
            }
            else
            {
                NextForm = new FormClass();
                ClassOperations.CurrentUser = DBOperations.GetUserID(Login);
                NextForm.Owner = ParentForm;
            }
        }
    }
}
