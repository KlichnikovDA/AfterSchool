using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace AfterSchool
{
    static class GroupActivitiesOperations
    {
        // Заполнение формы дял редактирования видов деятельности
        public static void FillActForm(FormActivity Form)
        {
            Form.WriteActivities(DBOperations.ReadActivities());
            Form.WriteActivityTypes(DBOperations.ReadTypes());
            Form.WriteEmployees(DBOperations.ReadEmployees());
        }

        // Заполнение формы дял редактирования групп
        public static void FillGroupForm(FormGroup Form)
        {
            Form.WriteGroups(DBOperations.ReadGroups());
            Form.WriteEmployees(DBOperations.ReadEmployees1());
        }

        // Удалить указанный вид деятельности
        public static void RemoveAct(string ActName)
        {
            DBOperations.RemoveActivity(ActName);
        }

        // Добавить новый вид деятельности
        public static void AddAct(string ActName, string ActTypeName, int Employee)
        {
            if (Employee != -1)
                DBOperations.AddActivity(ActName, ActTypeName, Employee);
            else
                DBOperations.AddActivity(ActName, ActTypeName);
        }

        // Добавить новую группу
        public static void AddGroup(string GroupName, int Employee)
        {
            DBOperations.AddGroup(GroupName, Employee);
        }

        // Изменить руководителя указанного вида деятельности
        public static void ChangeActEdu(string Act, int Emp)
        {
            DBOperations.AlterActEdu(Act, Emp);
        }

        // Проверить, не ведет ли уже указанный преподаватель какие-нибудь занятия
        public static bool CheckIsFree(int Employee)
        {
            return DBOperations.GetActByEmp(Employee) < 1;
        }

        // Импорт информации о новой группе из документа Excel
        public static void ImportGroup(string FilePath, DataGridView GroupInfo, string GroupName)
        {
            // Открыть документ Excel только для чтения
            Excel.Application ExcelApp = new Excel.Application();
            Excel.Workbook ExcelWb = ExcelApp.Workbooks.Open(FilePath, Type.Missing, true);
            Excel.Worksheet ExcelWs1 = (Excel.Worksheet)ExcelWb.Sheets[1];
            Excel.Worksheet ExcelWs2 = (Excel.Worksheet)ExcelWb.Sheets[2];

            // Получить ID группы для импорта
            int GroupID = DBOperations.GetGroupID(GroupName);
            // Пройти по всем строкам и считать информацию
            int LastRow = ExcelWs1.Cells.Find("*", System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                Excel.XlSearchOrder.xlByRows, Excel.XlSearchDirection.xlPrevious, false, System.Reflection.Missing.Value, System.Reflection.Missing.Value).Row;
            for (int i = 2; i <= LastRow; i++)
            {
                object[] NewChild = new object[6];
                NewChild[0] = GroupID;
                // Name
                NewChild[1] = ExcelWs1.Cells[i, 2].Text;
                // Grade
                NewChild[2] = Int32.Parse(ExcelWs1.Cells[i, 3].Text);
                // Birthday
                NewChild[3] = DateTime.Parse(ExcelWs1.Cells[i, 4].Text);
                // Privilege
                NewChild[4] = Convert.ToInt32(ExcelWs1.Cells[i, 5].Value != null);
                // Address
                NewChild[5] = ExcelWs1.Cells[i, 6].Text;
                long ChildID = DBOperations.InsertChild(NewChild);
                if (ExcelWs1.Cells[i, 7].Value != null)
                {
                    int ParentRow = ExcelWs2.Cells[System.Reflection.Missing.Value, 1].Find(ExcelWs1.Cells[i, 7].Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                        Excel.XlSearchOrder.xlByRows, Excel.XlSearchDirection.xlPrevious, false, System.Reflection.Missing.Value, System.Reflection.Missing.Value).Row;
                    object[] Parent = new object[3];
                    Parent[0] = ExcelWs2.Cells[ParentRow, 2].Value.ToString();
                    Parent[1] = ExcelWs2.Cells[ParentRow, 3].Value.ToString();
                    Parent[2] = ExcelWs2.Cells[ParentRow, 4].Value.ToString();
                    DBOperations.InsertParent(Parent, ChildID);
                }
                if (ExcelWs1.Cells[i, 8].Value != null)
                {
                    int ParentRow = ExcelWs2.Cells[System.Reflection.Missing.Value, 1].Find(ExcelWs1.Cells[i, 7].Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                        Excel.XlSearchOrder.xlByRows, Excel.XlSearchDirection.xlPrevious, false, System.Reflection.Missing.Value, System.Reflection.Missing.Value).Row;
                    object[] Parent = new object[3];
                    Parent[0] = ExcelWs2.Cells[ParentRow, 2].Value.ToString();
                    Parent[1] = ExcelWs2.Cells[ParentRow, 3].Value.ToString();
                    Parent[2] = ExcelWs2.Cells[ParentRow, 4].Value.ToString();
                    DBOperations.InsertParent(Parent, ChildID);
                }

                ExcelWb.Close();
                ExcelApp.Quit();
            }
        }

        // Добавить ребенка в группу
        public static int AddChild(string GroupName, string Name, string Grade, bool Privilege, string Birthday, string Address)
        {
            object[] Child = new object[6];
            Child[0] = DBOperations.GetGroupID(GroupName);
            // Name
            Child[1] = Name;
            // Grade
            Child[2] = Int32.Parse(Grade);
            // Birthday
            Child[3] = DateTime.Parse(Birthday);
            // Privilege
            Child[4] = Convert.ToInt32(Privilege);
            // Address
            Child[5] = Address;
            return (int)DBOperations.InsertChild(Child);
        }

        // Добавить родителя ребенка
        public static void AddParent(string Name, string Phone, string Email, int ChildID)
        {
            object[] Parent = new object[3];
            Parent[0] = Name;
            Parent[1] = Phone;
            Parent[2] = Email;
            DBOperations.InsertParent(Parent, ChildID);
        }

        // Изменить руководителя группы
        public static void ChangeGroupEdu(string Group, int Emp)
        {
            DBOperations.AlterGroupEdu(Group, Emp);
        }

        public static string GetEdu(string Group)
        {
            return DBOperations.GetUserByGroup(Group);
        }

        // Загрузить информацию о детях, занимающихся в указанной группе, и их родителях
        public static void LoadChildren(string GroupName, DataGridView Info)
        {
            List<int> ChildrenID = DBOperations.GetChildrenIDFromGroup(GroupName);

            for (int i = 0; i < ChildrenID.Count; i++)
            {
                object[] ChildInfo = DBOperations.ReadChildInfo(ChildrenID[i]);
                Info.Rows.Add();
                Info.Rows[i].Cells[0].Value = ChildInfo[0];
                Info.Rows[i].Cells[1].Value = ChildInfo[1];
                Info.Rows[i].Cells[2].Value = ChildInfo[2];
                Info.Rows[i].Cells[3].Value = ChildInfo[3];
                Info.Rows[i].Cells[4].Value = (int)ChildInfo[4] == 1;
                List<int> Parents = DBOperations.GetParentsByChild(ChildrenID[i]);
                for (int j = 0; j < 2; j++)
                {
                    object[] ParentInfo = DBOperations.ReadParentInfo(Parents[j]);
                    Info.Rows[i].Cells[5 + j * 3].Value = ParentInfo[0];
                    Info.Rows[i].Cells[6 + j * 3].Value = ParentInfo[1];
                    Info.Rows[i].Cells[7 + j * 3].Value = ParentInfo[2];
                }
            }
        }

        // Удалить записи о ребенке
        public static void RemoveChild(int ChildID)
        {
            List<int> Parents = DBOperations.GetParentsByChild(ChildID);
            DBOperations.RemoveChild(ChildID);
            foreach(int Parent in Parents)
            if (!DBOperations.ChildrenLeft(Parent))
            {
                DBOperations.RemoveParent(Parent);
            }
        }
    }
}
