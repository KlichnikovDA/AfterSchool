using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;

namespace AfterSchool
{
    static class TimetableOperations
    {
        private static string RecomendationsPath { get { return "SanPIN_Recomendations.dat"; } }

        // Заполнение данных формы при загрузке
        public static void FillForm(FormTimetable Form)
        {
            // Заполняем список видов деятельности
            ListBox LB = new ListBox();
            Form.WriteActivities(new ListBox.ObjectCollection(LB, DBOperations.GetActivityNamesArray()));
            // Заполняем выпадающий список для выбора группы
            Form.WriteGroups(DBOperations.GetGroupNamesArray());
        }

        // Проверка корректности составленного расписания
        public static bool CheckTimetable(DataGridView Timetable, string GroupName)
        {
            // Загрузить из БД данные о видах деятельности
            Dictionary<string, int> ActivityTypes = DBOperations.GetActivityDictionary();
            // Загрузить из БД данные о возрасте воспитанников группы
            int GroupGrade = DBOperations.GetGroupGrade(GroupName);
            // Загрузить рекомендации СанПИН по организации занятий
            int[] Recomendations = ReadSanPIN();

            // День недели, для которого осуществляется проверка
            string Day = Timetable.Rows[0].Cells[0].Value.ToString();
            // Общая продолжительность занятий
            int TotalDuration = 0;
            // Количество приемов пищи, предусмотренное расписанием
            int HasMeal = 0;
            // Длительность предусмотренного расписанием перерыва на отдых и прогулку в частности
            int RestDuration = 0;
            int WalkDuration = 0;
            // Длительность предусмотренного расписанием перерыва на сон
            int SleepDuration = 0;
            // Длительность учебной деятельности
            int StudyDuration = 0;
            // Длительность внеучебной деятельности
            int ExtraStudyDuration = 0;


            for (int i = 0; i < Timetable.RowCount; i++)
            {
                int Duration = Int32.Parse((string)Timetable.Rows[i].Cells[2].Value);

                if (Timetable.Rows[i].Cells[3].Value.ToString() != "Конец дня")
                // Суммируем итоговые длительности для дня
                {
                    TotalDuration += Duration;
                    switch (ActivityTypes.FirstOrDefault(x => x.Key == (string)Timetable.Rows[i].Cells[3].Value).Value)
                    {
                        case 1:
                            HasMeal++;
                            break;
                        case 2:
                            RestDuration += Duration;
                            break;
                        case 3:
                            StudyDuration += Duration;
                            break;
                        case 4:
                            ExtraStudyDuration += Duration;
                            break;
                        case 5:
                            WalkDuration += Duration;
                            RestDuration += Duration;
                            break;
                        case 6:
                            SleepDuration += Duration;
                            break;
                    }
                }

                if (Timetable.Rows[i].Cells[3].Value.ToString() == "Конец дня" || i == Timetable.RowCount - 1)
                // Проверка полученных значений на соответствие рекомендациям СанПИН
                {
                    if (TotalDuration > Recomendations[0])
                    {
                        MessageBox.Show("Общая длительность занятий в " + Day + " превышает рекомендуемую СанПИНом.");
                        return false;
                    }
                    if (HasMeal < 2)
                    {
                        MessageBox.Show("В " + Day + " должно быть предусмотрено два перерыва для приема пищи.");
                        return false;
                    }
                    if (RestDuration < Recomendations[1])
                    {
                        MessageBox.Show("Для восстановления работоспособности учащихся в " + Day + " должен быть организован отдых длительностью не менее " + (Recomendations[1] / 60.0) + " часов.");
                        return false;
                    }
                    if (WalkDuration < Recomendations[1])
                    {
                        MessageBox.Show("Основная часть отдыха в " + Day + " не менее " + (Recomendations[1] / 60.0) + " двух часов должна быть проведена на свежем воздухе.");
                        return false;
                    }
                    if (GroupGrade == 1 && SleepDuration < Recomendations[2])
                    {
                        MessageBox.Show("Для обучающихся первых классов в " + Day + " должен быть предусмотрен перерыв на сон не менее " + (Recomendations[2] / 60.0) + " часов.");
                        return false;
                    }
                    if (StudyDuration > Recomendations[6] ||
                        (GroupGrade < 9 && ExtraStudyDuration > Recomendations[5]) ||
                        (GroupGrade < 6 && ExtraStudyDuration > Recomendations[4]) ||
                        (GroupGrade < 4 && ExtraStudyDuration > Recomendations[3]))
                    {
                        MessageBox.Show("Длительность выполнения учебных заданий в " + Day + " превышает рекомендуемую СанПИНом.");
                        return false;
                    }
                    if (ExtraStudyDuration > Recomendations[8] ||
                        (GroupGrade < 2 && ExtraStudyDuration > Recomendations[7]))
                    {
                        MessageBox.Show("Длительность внеучебной деятельности в " + Day + " превышает рекомендуемую СанПИНом.");
                        return false;
                    }
                    Day = Timetable.Rows[i].Cells[0].Value.ToString();
                    TotalDuration = 0;
                    HasMeal = 0;
                    RestDuration = 0;
                    WalkDuration = 0;
                    SleepDuration = 0;
                    StudyDuration = 0;
                    ExtraStudyDuration = 0;
                }

            }
            return true;
        }

        // Экспорт расписания в файл Excel
        public static void ExportTimetable(DataGridView Timetable, string GroupName)
        {
            // Открытие документа Excel
            Excel.Application ExcelApp = new Excel.Application();
            Excel.Workbook ExcelWb;
            Excel.Worksheet ExcelWs;
            ExcelWb = ExcelApp.Workbooks.Add(1);
            ExcelWs = (Excel.Worksheet)ExcelWb.Sheets[1];
            ExcelApp.DisplayAlerts = false;
            Excel.Range rg = (Excel.Range)ExcelWs.Cells[1, 2];
            rg.EntireColumn.NumberFormat = "hh:mm";

            int[] DayRows = new int[] { 3, 3 };
            string Day = Timetable.Rows[0].Cells[0].Value.ToString();
            // Заголовок таблицы
            ExcelApp.Cells[2, 1] = "День";
            ExcelApp.Cells[2, 2] = "Начало занятия";
            ExcelApp.Cells[2, 3] = "Занятие";

            for (int i = 0; i < Timetable.Rows.Count; i++)
            {
                ExcelApp.Cells[i+3, 1] = Timetable.Rows[i].Cells[0].Value;
                ExcelApp.Cells[i+3, 2] = Timetable.Rows[i].Cells[1].Value;
                ExcelApp.Cells[i+3, 3] = Timetable.Rows[i].Cells[3].Value;
                // Объединить ячейки для дня недели
                if (Timetable.Rows[i].Cells[3].Value.ToString() == "Конец дня")
                {
                    DayRows[1] = i + 3;
                    Excel.Range ColumnRange = ExcelWs.Range["A" + DayRows[0], "A" + DayRows[1]];
                    ColumnRange.Merge();
                    ColumnRange.VerticalAlignment = Excel.XlVAlign.xlVAlignTop;
                    ColumnRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    DayRows[0] = i + 4;
                    DayRows[1] = i + 4;
                }
                //ExcelApp.Cells[i + 1, 2] = Timetable.Rows[i].Cells[1].Value;
                //ExcelApp.Cells[i + 1, 3] = Timetable.Rows[i].Cells[3].Value;
            }
            ExcelWs.Columns["A:C"].AutoFit();
            ExcelApp.Cells[1, 1] = "Расписание занятий в группе продленного дня для группы \"" + GroupName + "\"";

            // Сохранить документ и Отправить по почте
            string SavedFile = SaveTimetable(ExcelWb, GroupName);
            ExcelWb.Close(0);
            ExcelApp.Quit();
            MailOperations.SendTimetable(SavedFile, GroupName);
        }

        // Сохранение расписания в документ Excel
        private static string SaveTimetable(Excel.Workbook Timetable, string Name)
        {
            string DirPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments), "AfterSchool");
            Directory.CreateDirectory(DirPath);

            DirectoryInfo DirInfo = new DirectoryInfo(DirPath);
            DirectorySecurity DirSecurity = DirInfo.GetAccessControl();

            DirSecurity.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null), FileSystemRights.Modify, AccessControlType.Allow));
            DirInfo.SetAccessControl(DirSecurity);

            string FilePath = Path.Combine(DirPath, Name+".xlsx");
            Timetable.SaveAs(FilePath);
            return FilePath;
        }

        // Считать из файла рекомендации СанПИН по длительностям деятельности воспитанников
        private static int[] ReadSanPIN()
        {
            StreamReader sr = new StreamReader(RecomendationsPath);
            int[] ResultArray = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
            sr.Close();
            return ResultArray;
        }
    }
}