using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Reflection;

namespace AfterSchool
{
    class ClassOperations
    {
        // ID текущего пользователя, нужен, чтобы определить, по каким занятиям может отчитаться пользователь
        public static int CurrentUser { get; set; }

        // Заполнение данных формы при загрузке
        public static void FillForm(FormClass Form)
        {
            string CurrentTeacher = DBOperations.GetUserName(CurrentUser);
            Form.WriteName(CurrentTeacher);
            string CurrentGroup = DBOperations.GetGroupByUser(CurrentUser);
            Form.WriteGroup(CurrentGroup);
            Form.WriteChildren(DBOperations.GetChildrenFromGroup(CurrentGroup));
            Form.WriteActivities(ReadTodaysActivities(CurrentGroup, Form.CurrentDay));
        }

        // Считать из расписания для текущей группы, какие занятия проводятся в текущий день
        public static object[] ReadTodaysActivities(string GroupName, DayOfWeek CurrentDay)
        {
            string FilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments), "AfterSchool", GroupName + ".xlsx");

            // Открыть документ Excel только для чтения
            Excel.Application ExcelApp = new Excel.Application();
            Excel.Workbook ExcelWb = ExcelApp.Workbooks.Open(FilePath, Type.Missing, true);
            Excel.Worksheet ExcelWs = (Excel.Worksheet)ExcelWb.Sheets[1];
            //Excel.Range rg = (Excel.Range)ExcelWs.Cells[1, 2];
            //rg.EntireColumn.NumberFormat = "hh:mm";

            string DayToRead = "";
            switch (CurrentDay)
            {
                case DayOfWeek.Monday:
                    DayToRead = "ПН";
                    break;
                case DayOfWeek.Tuesday:
                    DayToRead = "ВТ";
                    break;
                case DayOfWeek.Wednesday:
                    DayToRead = "СР";
                    break;
                case DayOfWeek.Thursday:
                    DayToRead = "ЧТ";
                    break;
                case DayOfWeek.Friday:
                    DayToRead = "ПТ";
                    break;
                case DayOfWeek.Saturday:
                    DayToRead = "СБ";
                    break;
            }

            List<object> ResultArray = new List<object>();
            try
            {
                // Находим строки с занятиями в указанный день
                int i = ExcelWs.Cells.Find(DayToRead).Row;
                while ((string)ExcelWs.Cells[i, 3].Value != "Конец дня")
                {
                    ResultArray.Add(ExcelWs.Cells[i, 3].Value + ";" + ExcelWs.Cells[i++, 2].Text.ToString() + "-" + ExcelWs.Cells[i, 2].Text.ToString());
                }
            }
            // В выбранный день недели нет занятий
            catch (NullReferenceException)
            {

            }
            ExcelWb.Close();
            ExcelApp.Quit();
            return ResultArray.ToArray();
        }

        // Сохранить отчет о проведенном занятии
        public static void SendPeriodReport(string Activity, string Group, DateTime Date, string TimeBegin, int Duration, string Commentary, DataGridView AttendanceTable)
        {
            Dictionary<int, int> AttendanceInfo = new Dictionary<int, int>();
            for (int i = 0; i < AttendanceTable.RowCount; i++)
            {
                AttendanceInfo.Add(Int32.Parse(AttendanceTable.Rows[i].Cells[3].Value.ToString()), Convert.ToInt32(Convert.ToBoolean(AttendanceTable.Rows[i].Cells[2].Value)));
            }
            DBOperations.WriteAttendance(DBOperations.WritePeriod(CurrentUser, Activity, Group, Date, TimeBegin, Duration, Commentary), AttendanceInfo);
        }
    }
}
