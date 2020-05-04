using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Net.Mail;

namespace AfterSchool
{
    // Класс, реализующий методы для работы с БД
    static class DBOperations
    {
        // Имя файла БД
        public static string DBPath { get { return "AfterSchoolDataBase.db"; } }
        // Имя файла со скриптом создания БД
        public static string DBPathCreate { get { return "AfterSchoolDataBase.txt"; } }
        // Подключение к БД
        public static SQLiteConnection DBConn { get; set; }
        // Команда для выполнения над БД
        public static SQLiteCommand DBComm { get; set; }

        // Создание базы данных
        public static void CreateDB()
        {
            DBConn.Open();

            //DBOperations.DBComm.CommandText = "PRAGMA foreign_keys = ON";
            //DBOperations.DBComm.ExecuteNonQuery();
            DBComm.CommandText = new StreamReader(DBPathCreate).ReadToEnd();
            DBComm.ExecuteNonQuery();

            DBConn.Close();
        }

        // Проверка логина и пароля. Если данные верны, возвращается категория пользователя
        public static int CheckLoginDB(string Login, string Password)
        {
            DBConn.Open();

            // Поиск в БД учетной записи с указанной парой "логин-пароль"
            DBComm.CommandText = "SELECT Category FROM Accounts WHERE Login = @Li AND Password = @Pw";
            DBComm.Parameters.AddWithValue("@Li", Login);
            DBComm.Parameters.AddWithValue("@Pw", Password);

            // Выполнение запроса
            int Result = -1;
            try
            {
                Result = Int32.Parse(DBComm.ExecuteScalar().ToString());
            }
            catch
            {
                DBConn.Close();
                throw new Exception();
            }
            DBConn.Close();
            return Result;
        }

        // Получить имя сотрудника по ID
        public static string GetUserName(int ID)
        {
            DBConn.Open();

            // Поиск в БД сотрудника с указанным логином
            DBComm.CommandText =
                @"SELECT Name FROM Employee 
                  WHERE ID = @ID";
            DBComm.Parameters.AddWithValue("@ID", ID);

            // Выполнение запроса
            SQLiteDataReader Reader = DBComm.ExecuteReader();
            // Если запись обнаружена
            while (Reader.Read())
            {
                string Name = Reader.GetString(0);
                Reader.Close();
                DBConn.Close();
                return Name;
            }
            Reader.Close();
            DBConn.Close();
            return "";
        }

        // Получить ID сотрудника по логину
        public static int GetUserID(string Login)
        {
            DBConn.Open();

            // Поиск в БД сотрудника с указанным логином
            DBComm.CommandText =
                @"SELECT ID FROM Employee 
                  WHERE AccID IN
                  (SELECT ID FROM Accounts WHERE Login = @Li)";
            DBComm.Parameters.AddWithValue("@Li", Login);

            // Выполнение запроса
            int Result = Int32.Parse(DBComm.ExecuteScalar().ToString());
            DBConn.Close();
            return Result;
        }

        // Получить ID сотрудника по логину
        public static int GetGroupID(string Name)
        {
            DBConn.Open();

            // Поиск в БД сотрудника с указанным логином
            DBComm.CommandText =
                @"SELECT ID FROM 'Group'
                  WHERE Name = @GN)";
            DBComm.Parameters.AddWithValue("@GN", Name);

            // Выполнение запроса
            int Result = Int32.Parse(DBComm.ExecuteScalar().ToString());
            DBConn.Close();
            return Result;
        }

        // Получить название группы по воспитателю
        public static string GetGroupByUser(int ID)
        {
            DBConn.Open();

            // Поиск в БД сотрудника с указанным логином
            DBComm.CommandText =
                @"SELECT Name FROM 'Group' 
                  WHERE EduID = @ID";
            DBComm.Parameters.AddWithValue("@ID", ID);

            // Выполнение запроса
            SQLiteDataReader Reader = DBComm.ExecuteReader();
            // Если запись обнаружена
            while (Reader.Read())
            {
                string Name = Reader.GetString(0);
                Reader.Close();
                DBConn.Close();
                return Name;
            }
            Reader.Close();
            DBConn.Close();
            return "";
        }

        // Получить имя воспитателя по названию группы
        public static string GetUserByGroup(string Name)
        {
            DBConn.Open();

            // Поиск в БД сотрудника с указанным логином
            DBComm.CommandText =
                  @"SELECT Name FROM 'Employee' 
                    WHERE ID IN
                    (SELECT EduID FROM 'Group' WHERE Name == @GN)";
            DBComm.Parameters.AddWithValue("@GN", Name);

            // Выполнение запроса
            SQLiteDataReader Reader = DBComm.ExecuteReader();
            // Если запись обнаружена
            while (Reader.Read())
            {
                string Res = Reader.GetString(0);
                Reader.Close();
                DBConn.Close();
                return Name;
            }
            Reader.Close();
            DBConn.Close();
            return "";
        }

        // Получить массив названий экземпляров сущности
        public static object[] GetActivityNamesArray()
        {
            DBConn.Open();

            // Извлечение из БД количества видов деятельности
            DBComm.CommandText = "SELECT COUNT(*) FROM Activity";
            SQLiteDataReader Reader = DBComm.ExecuteReader();
            int Count = 0;
            while (Reader.Read())
            {
                Count = Reader.GetInt32(0);
            }
            Reader.Close();

            object[] ResultArray = new object[Count];

            // Извлечение из БД списка видов деятельности
            DBComm.CommandText = "SELECT Name FROM Activity";
            Reader = DBComm.ExecuteReader();
            int i = 0;
            while (Reader.Read())
            {
                ResultArray[i++] = Reader.GetString(0);
            }

            Reader.Close();
            DBConn.Close();
            return ResultArray;
        }

        // Получить массив названий экземпляров сущности
        public static object[] GetGroupNamesArray()
        {
            DBConn.Open();

            // Извлечение из БД количества видов деятельности
            DBComm.CommandText = "SELECT COUNT(*) FROM 'Group'";
            SQLiteDataReader Reader = DBComm.ExecuteReader();
            int Count = 0;
            while (Reader.Read())
            {
                Count = Reader.GetInt32(0);
            }
            Reader.Close();

            object[] ResultArray = new object[Count];

            // Извлечение из БД списка видов деятельности
            DBComm.CommandText = @"SELECT Name FROM 'Group'";
            Reader = DBComm.ExecuteReader();
            int i = 0;
            while (Reader.Read())
            {
                ResultArray[i++] = Reader.GetString(0);
            }

            Reader.Close();
            DBConn.Close();
            return ResultArray;
        }

        // Получить словарь видов деятельности и их категорий
        public static Dictionary<string, int> GetActivityDictionary()
        {
            DBConn.Open();

            // Извлечение из БД видов деятельности
            DBComm.CommandText = @"SELECT TypeID, Name FROM Activity";
            SQLiteDataReader Reader = DBComm.ExecuteReader();

            Dictionary<string, int> ResultDictionary = new Dictionary<string, int>();
            while (Reader.Read())
            {
                int Cat = Reader.GetInt32(0);
                string Act = Reader.GetString(1);
                ResultDictionary.Add(Act, Cat);
            }

            Reader.Close();
            DBConn.Close();
            return ResultDictionary;
        }

        // Получить минимальный класс ребенка в группе
        public static int GetGroupGrade(string GroupName)
        {
            DBConn.Open();

            // Поиск детей из группы с указанным названием
            DBComm.CommandText =
                  @"SELECT MIN(Grade) FROM Child 
                    WHERE GroupID IN
                    (SELECT ID FROM 'Group'
                    WHERE Name = @GN)";
            DBComm.Parameters.AddWithValue("@GN", GroupName);
            SQLiteDataReader Reader = DBComm.ExecuteReader();
            int Grade = 0;
            while (Reader.Read())
            {
                Grade = Reader.GetInt32(0);
            }

            Reader.Close();
            DBConn.Close();
            return Grade;
        }

        // Получить контактные данные родителей
        public static List<MailAddress> GetParentsEmail(string GroupName)
        {
            List<MailAddress> ResultList = new List<MailAddress>();

            DBConn.Open();

            // Поиск родителей, указавших адрес электронной почты и чьи дети учатся в группе с измененным расписанием
            DBComm.CommandText =
                  @"SELECT Email, Name FROM Parent 
                    WHERE Email IS NOT NULL AND ID IN
                    (SELECT ParentID FROM Parent_Child
                    WHERE ChildID IN
                    (SELECT ID FROM Child
                    WHERE GroupID IN
                    (SELECT ID FROM 'Group'
                    WHERE Name = @GN)))";
            DBComm.Parameters.AddWithValue("@GN", GroupName);
            SQLiteDataReader Reader = DBComm.ExecuteReader();

            while (Reader.Read())
            {
                ResultList.Add(new MailAddress(Reader.GetString(0), Reader.GetString(1)));
            }

            Reader.Close();
            DBConn.Close();
            return ResultList;
        }

        // Получить контактные данные преподавателей
        public static List<MailAddress> GetEmployeeEmail(string GroupName)
        {
            List<MailAddress> ResultList = new List<MailAddress>();

            DBConn.Open();

            // Поиск родителей, указавших адрес электронной почты и чьи дети учатся в группе с измененным расписанием
            DBComm.CommandText =
                  @"SELECT Email, Name FROM Employee 
                    WHERE Email IS NOT NULL AND ID IN
                    (SELECT EduID FROM 'Group' WHERE Name = @GN)";
            DBComm.Parameters.AddWithValue("@GN", GroupName);
            SQLiteDataReader Reader = DBComm.ExecuteReader();

            while (Reader.Read())
            {
                ResultList.Add(new MailAddress(Reader.GetString(0), Reader.GetString(1)));
            }

            Reader.Close();
            DBConn.Close();
            return ResultList;
        }

        // Получить данные о детях из группы
        public static List<string> GetChildrenFromGroup(string GroupName)
        {
            List<string> ResultList = new List<string>();

            DBConn.Open();

            // Поиск детей, занимающихся в указанной группе
            DBComm.CommandText =
                  @"SELECT Name, Grade, ID FROM Child 
                    WHERE GroupID IN
                    (SELECT ID FROM 'Group' 
                    WHERE Name = @GN)";
            DBComm.Parameters.AddWithValue("@GN", GroupName);
            SQLiteDataReader Reader = DBComm.ExecuteReader();

            while (Reader.Read())
            {
                ResultList.Add(Reader.GetString(0) + ";" + Reader.GetInt32(1).ToString() + ";" + Reader.GetInt32(2).ToString());
            }

            Reader.Close();
            DBConn.Close();
            return ResultList;
        }

        public static List<int> GetChildrenIDFromGroup(string GroupName)
        {
            List<int> ResultList = new List<int>();

            DBConn.Open();

            // Поиск детей, занимающихся в указанной группе
            DBComm.CommandText =
                  @"SELECT ID FROM Child WHERE GroupID IN
                    (SELECT ID FROM 'Group' WHERE Name = @GN)";
            DBComm.Parameters.AddWithValue("@GN", GroupName);
            SQLiteDataReader Reader = DBComm.ExecuteReader();

            while (Reader.Read())
            {
                ResultList.Add(Reader.GetInt32(0));
            }

            Reader.Close();
            DBConn.Close();
            return ResultList;
        }

        public static List<int> GetParentsByChild(int Child)
        {
            List<int> ResultList = new List<int>();

            DBConn.Open();

            // Поиск детей, занимающихся в указанной группе
            DBComm.CommandText =
                  @"SELECT ID FROM Parent WHERE ID IN
                    (SELECT ParentID FROM Parent_Child WHERE ChildID == @CI)";
            DBComm.Parameters.AddWithValue("@CI", Child);
            SQLiteDataReader Reader = DBComm.ExecuteReader();

            while (Reader.Read())
            {
                ResultList.Add(Reader.GetInt32(0));
            }

            Reader.Close();
            DBConn.Close();
            return ResultList;
        }

        // Добавить запись о проведенном занятии
        public static long WritePeriod(int Edu, string ActName, string GroupName, DateTime Date, string Begin, int Dur, string Comm)
        {
            DBConn.Open();

            long InsertID = 0;
            
            SQLiteTransaction DBTrans = DBConn.BeginTransaction();

            DBComm.CommandText =
                  @"INSERT INTO Period (EduID, GroupID, ActivityID, Date, TimeBegin, Duration, WorkDone)
                    VALUES (@EI, (SELECT ID FROM 'Group' WHERE Name == @GN),
                    (SELECT ID FROM Activity WHERE Name = @AN),
                    @DT, @BT, @Dur, @TR)";
            DBComm.Parameters.AddWithValue("@EI", Edu);
            DBComm.Parameters.AddWithValue("@GN", GroupName);
            DBComm.Parameters.AddWithValue("@AN", ActName);
            DBComm.Parameters.AddWithValue("@DT", Date.Date);
            DBComm.Parameters.AddWithValue("@BT", Begin);
            DBComm.Parameters.AddWithValue("@Dur", Dur);
            DBComm.Parameters.AddWithValue("@TR", Comm);
            DBComm.ExecuteNonQuery();

            InsertID = DBConn.LastInsertRowId;

            DBTrans.Commit();
            DBConn.Close();
            return InsertID;
        }

        // Добавить записи о посещаемости проведенного занятия
        public static void WriteAttendance(long PeriodID, Dictionary<int, int> AttendanceInfo)
        {
            DBConn.Open();

            foreach (KeyValuePair<int, int> Pair in AttendanceInfo)
            {
                DBComm.CommandText =
                    @"INSERT INTO Attendance (PeriodID, ChildID, HasAttended)
                    VALUES (@PID, @CID, @HA)";
                DBComm.Parameters.AddWithValue("@PID", (int)PeriodID);
                DBComm.Parameters.AddWithValue("@CID", Pair.Key);
                DBComm.Parameters.AddWithValue("@HA", Pair.Value);
                DBComm.ExecuteNonQuery();
            }

            DBConn.Close();
        }

        // Считать все осуществляемые виды деятельности
        public static object[] ReadActivities()
        {
            DBConn.Open();
            List<object> ResultArray = new List<object>();

            // Извлечение из БД видов деятельности
            DBComm.CommandText = @"SELECT Name FROM Activity";
            SQLiteDataReader Reader = DBComm.ExecuteReader();

            while (Reader.Read())
            {
                ResultArray.Add(Reader.GetString(0));
            }

            Reader.Close();
            DBConn.Close();
            return ResultArray.ToArray();
        }

        // Считать все категории осуществляемых видов деятельности
        public static object[] ReadTypes()
        {
            DBConn.Open();
            List<object> ResultArray = new List<object>();

            // Извлечение из БД видов деятельности
            DBComm.CommandText = @"SELECT TypeName FROM ActivityType";
            SQLiteDataReader Reader = DBComm.ExecuteReader();

            while (Reader.Read())
            {
                ResultArray.Add(Reader.GetString(0));
            }

            Reader.Close();
            DBConn.Close();
            return ResultArray.ToArray();
        }

        // Считать всех воспитателей и преподавателей
        public static object[] ReadEmployees()
        {
            DBConn.Open();
            List<object> ResultArray = new List<object>();

            // Извлечение из БД видов деятельности
            DBComm.CommandText = @"SELECT Name, ID FROM Employee WHERE AccID IN (SELECT ID FROM Accounts WHERE Category IN (1, 2))";
            SQLiteDataReader Reader = DBComm.ExecuteReader();

            while (Reader.Read())
            {
                ResultArray.Add(Reader.GetString(0) + ";" + Reader.GetInt32(1).ToString());
            }

            Reader.Close();
            DBConn.Close();
            return ResultArray.ToArray();
        }

        // Считать всех воспитателей
        public static object[] ReadEmployees1()
        {
            DBConn.Open();
            List<object> ResultArray = new List<object>();

            // Извлечение из БД видов деятельности
            DBComm.CommandText = @"SELECT Name, ID FROM Employee WHERE AccID IN (SELECT ID FROM Accounts WHERE Category == 1)";
            SQLiteDataReader Reader = DBComm.ExecuteReader();

            while (Reader.Read())
            {
                ResultArray.Add(Reader.GetString(0) + ";" + Reader.GetInt32(1).ToString());
            }

            Reader.Close();
            DBConn.Close();
            return ResultArray.ToArray();
        }

        // Считать все группы
        public static object[] ReadGroups()
        {
            DBConn.Open();
            List<object> ResultArray = new List<object>();

            // Извлечение из БД видов деятельности
            DBComm.CommandText =
                @"SELECT Name FROM 'Group'";
            SQLiteDataReader Reader = DBComm.ExecuteReader();

            while (Reader.Read())
            {
                ResultArray.Add(Reader.GetString(0));
            }

            Reader.Close();
            DBConn.Close();
            return ResultArray.ToArray();
        }

        // Удалить указанный вид деятельности
        public static void RemoveActivity(string Name)
        {
            DBConn.Open();

            // Удаление записи о деятельности с указанным названием
            DBComm.CommandText = @"DELETE FROM Activity WHERE Name == @AN";
            DBComm.Parameters.AddWithValue("@AN", Name);
            DBComm.ExecuteNonQuery();

            DBConn.Close();
        }

        // Добавить новый вид деятельности
        public static void AddActivity(string Name, string Type)
        {
            DBConn.Open();

            // Добавление записи о деятельности с указанными параметрами
            DBComm.CommandText = 
                @"INSERT INTO Activity (Name, TypeID) 
                VALUES (@AN, (SELECT ID FROM ActivityType WHERE TypeName == @TN))";
            DBComm.Parameters.AddWithValue("@AN", Name);
            DBComm.Parameters.AddWithValue("@TN", Type);
            DBComm.ExecuteNonQuery();

            DBConn.Close();
        }

        public static void AddActivity(string Name, string Type, int EmpID)
        {
            DBConn.Open();

            // Добавление записи о деятельности с указанными параметрами
            DBComm.CommandText =
                @"INSERT INTO Activity (Name, TypeID, EduID) 
                VALUES (@AN, (SELECT ID FROM ActivityType WHERE TypeName == @TN), @EI)";
            DBComm.Parameters.AddWithValue("@AN", Name);
            DBComm.Parameters.AddWithValue("@TN", Type);
            DBComm.Parameters.AddWithValue("@EI", EmpID);
            DBComm.ExecuteNonQuery();

            DBConn.Close();
        }

        // Добавить новую группу
        public static void AddGroup(string Name, int EmpID)
        {
            DBConn.Open();

            // Добавление записи о группе с указанными параметрами
            DBComm.CommandText =
                @"INSERT INTO 'Group' (Name, EduID) 
                VALUES (@GN, @EI)";
            DBComm.Parameters.AddWithValue("@AN", Name);
            DBComm.Parameters.AddWithValue("@EI", EmpID);
            DBComm.ExecuteNonQuery();

            DBConn.Close();
        }

        // Получить количество групп и деятельностей, руководимых указанным сотрудником
        public static int GetActByEmp(int EmpID)
        {
            DBConn.Open();

            int Oper = 0;
            // Извлечение из БД видов деятельности
            DBComm.CommandText = @"SELECT COUNT(*) FROM Activity WHERE EduID == @EI";
            DBComm.Parameters.AddWithValue("@EI", EmpID);
            SQLiteDataReader Reader = DBComm.ExecuteReader();

            while (Reader.Read())
            {
                Oper += Reader.GetInt32(0);
            }
            Reader.Close();
            DBComm.CommandText = @"SELECT COUNT(*) FROM 'Group' WHERE EduID == @EI";
            DBComm.Parameters.AddWithValue("@EI", EmpID);
            Reader = DBComm.ExecuteReader();

            while (Reader.Read())
            {
                Oper += Reader.GetInt32(0);
            }
            Reader.Close();

            DBConn.Close();
            return Oper;
        }

        // Изменить руководителя указанной деятелньости
        public static void AlterActEdu(string ActName, int EmpID)
        {
            DBConn.Open();

            DBComm.CommandText =
                @"UPDATE Activity
                SET EduID = @EI
                WHERE Name == @AN";
            DBComm.Parameters.AddWithValue("@EI", EmpID);
            DBComm.Parameters.AddWithValue("@AN", ActName);
            DBComm.ExecuteNonQuery();

            DBConn.Close();
        }

        // Изменить руководителя указанной группы
        public static void AlterGroupEdu(string GroupName, int EmpID)
        {
            DBConn.Open();

            DBComm.CommandText =
                @"UPDATE 'Group'
                SET EduID = @EI
                WHERE Name == @GN";
            DBComm.Parameters.AddWithValue("@EI", EmpID);
            DBComm.Parameters.AddWithValue("@GN", GroupName);
            DBComm.ExecuteNonQuery();

            DBConn.Close();
        }

        // Добавить запись о ребенке
        public static long InsertChild(object[] Child)
        {
            DBConn.Open();

            long InsertID = 0;

            SQLiteTransaction DBTrans = DBConn.BeginTransaction();

            DBComm.CommandText =
                  @"INSERT INTO Child (GroupID, Name, Grade, Birthday, Address, Privilege)
                    VALUES (@GI, @CN, @GR, @BD, @AS, @PR)";
            DBComm.Parameters.AddWithValue("@GI", (int)Child[0]);
            DBComm.Parameters.AddWithValue("@CN", Child[1]).ToString();
            DBComm.Parameters.AddWithValue("@GR", (int)Child[2]);
            DBComm.Parameters.AddWithValue("@BD", DateTime.Parse(Child[3].ToString()).Date);
            DBComm.Parameters.AddWithValue("@PR", Child[4]);
            DBComm.Parameters.AddWithValue("@AS", Child[5]);
            DBComm.ExecuteNonQuery();

            InsertID = DBConn.LastInsertRowId;

            DBTrans.Commit();
            DBConn.Close();
            return InsertID;
        }

        // Добавить записи о родителе
        public static void InsertParent(object[] Parent, long ChildID)
        {
            DBConn.Open();

            SQLiteTransaction DBTrans = DBConn.BeginTransaction();

            DBComm.CommandText =
                  @"INSERT INTO Parent (Name, Phone, Email, HasPaid)
                    VALUES (@PN, @PH, @EM, 1)";
            DBComm.Parameters.AddWithValue("@PN", Parent[0].ToString());
            DBComm.Parameters.AddWithValue("@PH", Parent[1]).ToString();
            DBComm.Parameters.AddWithValue("@EM", Parent[2].ToString());
            DBComm.ExecuteNonQuery();

            long InsertID = DBConn.LastInsertRowId;

            DBComm.CommandText =
                  @"INSERT INTO Parent_Child (ParentId, ChildId)
                    VALUES (@PI, @CI)";
            DBComm.Parameters.AddWithValue("@PI", (int)InsertID);
            DBComm.Parameters.AddWithValue("@CI", (int)ChildID);
            DBComm.ExecuteNonQuery();

            DBTrans.Commit();
            DBConn.Close();
        }

        // Получить информацию о родителе
        public static object[] ReadParentInfo(int ID)
        {
            object[] ResultArray = new object[3];
            DBConn.Open();

            DBComm.CommandText =
                @"SELECT Name, Phone, Email FROM Parent
                WHERE ID == @PI";
            DBComm.Parameters.AddWithValue("@PI", ID);
            // Выполнение запроса
            SQLiteDataReader Reader = DBComm.ExecuteReader();

            while (Reader.Read())
            {
                ResultArray[0] = Reader.GetString(0);
                ResultArray[1] = Reader.GetString(1);
                ResultArray[2] = Reader.GetString(2);
            }

            Reader.Close();
            DBConn.Close();
            return ResultArray;
        }

        // Получить информацию о ребенке
        public static object[] ReadChildInfo(int ID)
        {
            object[] ResultArray = new object[5];
            DBConn.Open();

            DBComm.CommandText =
                @"SELECT Name, Grade, Birthdate, Address, Privilege FROM Child
                WHERE ID == @CI";
            DBComm.Parameters.AddWithValue("@CI", ID);
            // Выполнение запроса
            SQLiteDataReader Reader = DBComm.ExecuteReader();

            while (Reader.Read())
            {
                ResultArray[0] = Reader.GetString(0);
                ResultArray[1] = Reader.GetInt32(1);
                ResultArray[2] = DateTime.Parse(Reader.GetString(2)).Date;
                ResultArray[3] = Reader.GetString(3);
                ResultArray[4] = Reader.GetInt32(4);
            }

            Reader.Close();
            DBConn.Close();
            return ResultArray;
        }

        // Удалить записи о ребенке
        public static void RemoveChild(int ID)
        {
            DBConn.Open();

            // Удаление записи о деятельности с указанным названием
            DBComm.CommandText = @"DELETE FROM Child WHERE ID == @CI";
            DBComm.Parameters.AddWithValue("@CI", ID);
            DBComm.ExecuteNonQuery();
            DBComm.CommandText = @"DELETE FROM Parent_Child WHERE ChildID IS NULL";
            DBComm.ExecuteNonQuery();

            DBConn.Close();
        }

        // Удалить записи о родителе
        public static void RemoveParent(int ID)
        {
            DBConn.Open();

            // Удаление записи о деятельности с указанным названием
            DBComm.CommandText = @"DELETE FROM Parent WHERE ID == @PI";
            DBComm.Parameters.AddWithValue("@PI", ID);
            DBComm.ExecuteNonQuery();

            DBConn.Close();
        }

        // Проверить, есть ли у родителя неудаленные дети
        public static bool ChildrenLeft(int ParentID)
        {
            DBConn.Open();
            int Count = 0;
            // Удаление записи о деятельности с указанным названием
            DBComm.CommandText = @"SELECT COUNT(*) FROM Parent_Child WHERE ParentID == @PI";
            DBComm.Parameters.AddWithValue("@PI", ParentID);
            // Выполнение запроса
            SQLiteDataReader Reader = DBComm.ExecuteReader();

            while (Reader.Read())
            {
                Count = Reader.GetInt32(0);
            }

            Reader.Close();
            DBConn.Close();
            return Count > 0;
        }

        // Получить данные о работниках
        public static List<string> GetEmployee(int Current)
        {
            List<string> ResultList = new List<string>();

            DBConn.Open();

            // Поиск работников кроме текущего
            DBComm.CommandText =
                  @"SELECT Name, Login, Position FROM Employee 
                    INNER JOIN Accounts ON Accounts.ID = Employee.AccID 
                    WHERE Employee.ID != @EI";
            DBComm.Parameters.AddWithValue("@EI", Current);
            SQLiteDataReader Reader = DBComm.ExecuteReader();

            while (Reader.Read())
            {
                ResultList.Add(Reader.GetString(0) + ";" + Reader.GetString(1) + ";" + Reader.GetString(2));
            }

            Reader.Close();
            DBConn.Close();
            return ResultList;
        }

        // Получить все логины
        public static List<string> GetLogins()
        {
            List<string> ResultList = new List<string>();

            DBConn.Open();

            DBComm.CommandText =
                  @"SELECT Login FROM Accounts";
            SQLiteDataReader Reader = DBComm.ExecuteReader();

            while (Reader.Read())
            {
                ResultList.Add(Reader.GetString(0));
            }

            Reader.Close();
            DBConn.Close();
            return ResultList;
        }

        // Добавить нового сотрудника
        public static void AddEmployee(string Name, string Phone, string Email, string Position, string Login, string Password, int Category)
        {
            DBConn.Open();

            int InsertID = 0;
            DBComm.CommandText =
                  @"INSERT INTO Accounts (Login, Password, Category)
                    VALUES (@LI, @PW, @CT)";
            DBComm.Parameters.AddWithValue("@LI", Login);
            DBComm.Parameters.AddWithValue("@PW", Password);
            DBComm.Parameters.AddWithValue("@CT", Category);
            DBComm.ExecuteNonQuery();
            InsertID = (int)DBConn.LastInsertRowId;

            DBComm.CommandText =
                  @"INSERT INTO Employee (AccID, Name, Position, Email, Phone)
                    VALUES (@AI, @EN, @PS, @EM, @PH)";
            DBComm.Parameters.AddWithValue("@AI", InsertID);
            DBComm.Parameters.AddWithValue("@EN", Name);
            DBComm.Parameters.AddWithValue("@PS", Position);
            DBComm.Parameters.AddWithValue("@EM", Email);
            DBComm.Parameters.AddWithValue("@PH", Phone);
            DBComm.ExecuteNonQuery();

            DBConn.Close();
        }

        // Удалить указанного сотрудника
        public static void RemoveEmployee(string Login)
        {
            DBConn.Open();

            DBComm.CommandText = 
                @"DELETE FROM Employee WHERE AccID IN
                (SELECT ID FROM Accounts WHERE Login == @Li)";
            DBComm.Parameters.AddWithValue("@Li", Login);
            DBComm.ExecuteNonQuery();
            DBComm.CommandText =
                @"DELETE FROM Employee WHERE AccID IS NULL";
            DBComm.ExecuteNonQuery();

            DBConn.Close();
        }
    }
}