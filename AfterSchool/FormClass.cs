using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AfterSchool
{
    public partial class FormClass : Form
    {
        public DayOfWeek CurrentDay
        {
            get
            {
                return mc_ClassDate.SelectionRange.Start.DayOfWeek;
            }
        }

        private string[] ActTimes { get; set; }

        public FormClass()
        {
            InitializeComponent();
        }

        private void mi_Finish_Click(object sender, EventArgs e)
        {
            Owner.Activate();
            Owner.Show();
            Hide();
        }

        private void FormClass_FormClosing(object sender, FormClosingEventArgs e)
        {
            mi_Finish_Click(sender, e);
        }

        private void FormClass_Load(object sender, EventArgs e)
        {
            ClassOperations.FillForm(this);
        }

        // Методы для работы с данными в элементах формы
        public void WriteName(string EducatorName)
        {
            tb_Educator.Text = EducatorName;
        }

        // Методы для работы с данными в элементах формы
        public void WriteGroup(string GroupName)
        {
            tb_GroupName.Text = GroupName;
        }

        public void WriteActivities(object[] ActArray)
        {
            lb_Activities.Items.Clear();
            tb_Duration.Text = "";
            tb_TimeBegun.Text = "";
            // Сохраняем время начала и конца занятий
            ActTimes = new string[ActArray.Length];
            for (int i = 0; i < ActArray.Length; i++)
            {
                lb_Activities.Items.Add(ActArray[i].ToString().Split(';')[0]);
                ActTimes[i] = ActArray[i].ToString().Split(';')[1];
            }
        }

        // При изменении выбранной даты пересчитываем проведенные занятия
        private void mc_ClassDate_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (e.Start > DateTime.Today)
            {
                mc_ClassDate.SetDate(DateTime.Today);
                MessageBox.Show("Нельзя выбрать еще не наступившую дату");
            }
            WriteActivities(ClassOperations.ReadTodaysActivities(tb_GroupName.Text, mc_ClassDate.SelectionStart.DayOfWeek));
        }
        
        // При выборе занятия выводим его начало и длительность
        private void lb_Activities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_Activities.SelectedIndex != -1)
            {
                TimeSpan Begin = TimeSpan.Parse(ActTimes[lb_Activities.SelectedIndex].Split('-')[0]);
                TimeSpan End = TimeSpan.Parse(ActTimes[lb_Activities.SelectedIndex].Split('-')[1]);
                tb_TimeBegun.Text = Begin.ToString(@"hh\:mm");
                tb_Duration.Text = (End - Begin).TotalMinutes.ToString();
            }
        }

        // Выводим список детей из группы
        public void WriteChildren(List<string> ChildrenList)
        {
            foreach(string Child in ChildrenList)
            {
                object[] Row = new object[4];
                Row[0] = Child.Split(';')[0];
                Row[1] = Int32.Parse(Child.Split(';')[1]);
                Row[2] = false;
                Row[3] = Int32.Parse(Child.Split(';')[2]);
                dgv_Attendance.Rows.Add(Row);
            }
        }

        private void bt_Apply_Click(object sender, EventArgs e)
        {
            // Сохранить отчет о проведенном занятии
            ClassOperations.SendPeriodReport(lb_Activities.SelectedItem.ToString(), tb_GroupName.Text, mc_ClassDate.SelectionStart.Date, tb_TimeBegun.Text, 
                Int32.Parse(tb_Duration.Text), tb_WorkDone.Text, dgv_Attendance);
            MessageBox.Show("Отчет о проведенном занятии сохранен.");
        }
    }
}
