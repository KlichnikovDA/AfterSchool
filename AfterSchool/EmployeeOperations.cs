using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfterSchool
{
    static class EmployeeOperations
    {
        // ID текущего пользователя, нужен, чтобы пользователь не мог удалить самого себя
        public static int CurrentUser { get; set; }

        public static void FillForm(FormEmployee Form)
        {
            Form.WriteEmployee(DBOperations.GetEmployee(CurrentUser));                
        }

        public static string[] RandomLogPass()
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            string[] ResultArray = new string[2];
            ResultArray[0] = new string(Enumerable.Repeat(chars, 15)
                  .Select(s => s[random.Next(s.Length)]).ToArray());
            ResultArray[1] = new string(Enumerable.Repeat(chars, 15)
              .Select(s => s[random.Next(s.Length)]).ToArray());

            return ResultArray;
        }

        // Проверить логин на уникальность
        public static bool CheckLogin(string Login)
        {
            return !DBOperations.GetLogins().Contains(Login);
        }

        public static void AddNewEmp(string Name, string Phone, string Email, string Position, string Login, string Password, int Category)
        {
            DBOperations.AddEmployee(Name, Phone, Email, Position, Login, Password, Category);
        }

        public static void RemoveEmp(string Login)
        {
            DBOperations.RemoveEmployee(Login);
        }
    }
}
