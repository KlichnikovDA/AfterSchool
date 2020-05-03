using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Mail;

namespace AfterSchool
{
    static class MailOperations
    {
        static string SettingsPath = "Email.dat"; 

        // Рассылка расписания заинтересованным лицам
        public static void SendTimetable(string FilePath, string GroupName)
        {
            // Считать настройки
            string[] MailSettings = ReadSettings();

            // Адрес SMTP-сервера и порт для отправки письма
            SmtpClient SMTP = new SmtpClient("smtp."+MailSettings[0].Split('@')[1], Int32.Parse(MailSettings[1]));
            SMTP.Credentials = new NetworkCredential(MailSettings[0], "xwmhsbecouzeincn");
            SMTP.EnableSsl = true;

            // Отправитель
            MailAddress Sender = new MailAddress(MailSettings[0]);
            // Получатели-родители
            List<MailAddress> AddressParents = DBOperations.GetParentsEmail(GroupName);
            // Получатели-сотрудники
            List<MailAddress> AddressEmployee = DBOperations.GetEmployeeEmail(GroupName);

            // Письмо
            MailMessage Letter = new MailMessage();
            Letter.From = Sender;
            // тема письма
            Letter.Subject = "Изменение в расписании занятий группы продленного дня";
            Letter.Attachments.Add(new Attachment(FilePath));

            // Для каждого получателя пишем текст письмо
            foreach (MailAddress Recipient in AddressParents)
            {
                // Получатель
                Letter.To.Add(Recipient);
                // Текст письма
                Letter.Body = Recipient.DisplayName + ", доводим до Вашего сведения, что расписание занятий в группе продленного дня, где занимается Ваш ребенок, было изменено. В приложении новое расписание.";
                SMTP.Send(Letter);
                Letter.To.Remove(Recipient);
            }

            // Для каждого получателя создаем письмо
            foreach (MailAddress Recipient in AddressParents)
            {
                // Получатель
                Letter.To.Add(Recipient);
                // Текст письма
                Letter.Body = Recipient.DisplayName + ", доводим до Вашего сведения, что расписание занятий в группе продленного дня, где Вы ведете занятия, было изменено. В приложении новое расписание.";
                SMTP.Send(Letter);
                Letter.To.Remove(Recipient);
            }
        }

        // Считать настройки электронной почты из файла конфигурации
        private static string[] ReadSettings()
        {
            StreamReader sr = new StreamReader(SettingsPath);
            string[] Settings = new string[2];

            Settings[0] = sr.ReadLine().Split('=')[1];
            Settings[1] = sr.ReadLine().Split('=')[1];           

            sr.Close();
            return Settings;
        }
    }
}
