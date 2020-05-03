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
    public partial class FormTimetable : Form
    {
        // День недели , на который составляется расписание
        int Day = 0;
        bool DaysFirstRow = true;

        public FormTimetable()
        {
            InitializeComponent();
        }

        private void mi_Finish_Click(object sender, EventArgs e)
        {
            Owner.Activate();
            Owner.Show();
            Hide();
        }

        // Переход от одной формы к другой
        private void mi_Employee_Click(object sender, EventArgs e)
        {
            Owner.OwnedForms[0].Activate();
            Owner.OwnedForms[0].Show();
            Hide();
        }

        private void mi_Group_Click(object sender, EventArgs e)
        {
            Owner.OwnedForms[2].Activate();
            Owner.OwnedForms[2].Show();
            Hide();
        }

        private void mi_Activity_Click(object sender, EventArgs e)
        {
            Owner.OwnedForms[1].Activate();
            Owner.OwnedForms[1].Show();
            Hide();
        }

        // Заполнение полей формы данными из БД
        private void FormTimetable_Load(object sender, EventArgs e)
        {
            TimetableOperations.FillForm(this);
        }

        public void WriteActivities(ListBox.ObjectCollection ActivitiesList)
        {
            lb_Activities.Items.AddRange(ActivitiesList);
        }

        public void WriteGroups(object[] Groups)
        {
            comboBox1.Items.AddRange(Groups);
        }

        // Добавить занятие в расписание
        private void lb_Activities_Click(object sender, EventArgs e)
        {
            if (lb_Activities.SelectedItem != null)
            {
                AddPeriodRow(lb_Activities.SelectedItem.ToString());
            }
            lb_Activities.ClearSelected();
            DaysFirstRow = false;
        }

        private void AddPeriodRow(string ActivityName)
        {
            // Массив элементов строки
            object[] Row = new object[4];

            if (DaysFirstRow)
                Row[1] = "13:00";
            else
            {
                string[] TimeString = dgv_Timetable.Rows[dgv_Timetable.Rows.Count - 1].Cells[1].Value.ToString().Split(':');
                int StartTime = Int32.Parse(TimeString[0]) * 60 + Int32.Parse(TimeString[1]) +
                    Int32.Parse(dgv_Timetable.Rows[dgv_Timetable.Rows.Count - 1].Cells[2].Value.ToString());
                string TimeToString = (StartTime / 60).ToString() + ":" + (StartTime % 60).ToString();
                Row[1] = TimeToString;
            }
            var timeSpan = TimeSpan.Parse(Row[1].ToString());
            Row[1] = timeSpan.ToString(@"hh\:mm");
            switch (Day)
            {
                case 0:
                    Row[0] = "ПН";
                    break;
                case 1:
                    Row[0] = "ВТ";
                    break;
                case 2:
                    Row[0] = "СР";
                    break;
                case 3:
                    Row[0] = "ЧТ";
                    break;
                case 4:
                    Row[0] = "ПТ";
                    break;
                case 5:
                    Row[0] = "СБ";
                    break;
            }
            Row[2] = "0";
            Row[3] = ActivityName;
            dgv_Timetable.Rows.Add(Row);
        }

        // Утверждение составленного расписания
        private void bt_Apply_Click(object sender, EventArgs e)
        {
            if (dgv_Timetable.RowCount > 0)
            {
                if (comboBox1.SelectedItem != null)
                {
                    if (TimetableOperations.CheckTimetable(dgv_Timetable, comboBox1.SelectedItem.ToString()))
                    {
                        if (!DaysFirstRow)
                            AddPeriodRow("Конец дня");
                        TimetableOperations.ExportTimetable(dgv_Timetable, comboBox1.SelectedItem.ToString());
                        MessageBox.Show("Новое расписание утверждено. Лицам, затронутым изменениями, отправлены уведомления.");
                    }
                    else
                    {

                    }
                }
                else
                    MessageBox.Show("Не выбрана группа");
            }
            else
                MessageBox.Show("Расписание не заполнено");
        }

        private void bt_NextDay_Click(object sender, EventArgs e)
        {
            if (!DaysFirstRow)
            {
                AddPeriodRow("Конец дня");
                if (Day < 5)
                {
                    Day++;
                    DaysFirstRow = true;
                }
            }
            else
                MessageBox.Show("Для текущего дня должно быть указано хотя бы одно занятие");
        }

        private void bt_Clear_Click(object sender, EventArgs e)
        {
            DaysFirstRow = true;
            Day = 0;
            dgv_Timetable.Rows.Clear();
        }

        // Проверка корректности введенных данных
        private void dgv_Timetable_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            dgv_Timetable.Rows[e.RowIndex].ErrorText = "";
            int NewValue = 0;

            if (e.ColumnIndex != 2 || dgv_Timetable.Rows[e.RowIndex].IsNewRow)
            {
                return;
            }
            // Введено не натуральное число
            if (!int.TryParse(e.FormattedValue.ToString(),
                out NewValue) || (NewValue <= 0 && dgv_Timetable.Rows[e.RowIndex].Cells[3].Value.ToString() != "Конец дня"))
            {
                e.Cancel = true;
                MessageBox.Show("Длителность занятия должна быть выражена целым положительным числом");
                return;
            }
        }

        // Пересчитать время начала последующих занятий
        private void dgv_Timetable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex + 1;
            while (i < dgv_Timetable.RowCount && dgv_Timetable.Rows[i].Cells[0].Value == dgv_Timetable.Rows[e.RowIndex].Cells[0].Value)
            {
                string[] TimeString = dgv_Timetable.Rows[i-1].Cells[1].Value.ToString().Split(':');
                int StartTime = Int32.Parse(TimeString[0]) * 60 + Int32.Parse(TimeString[1]) +
                    Int32.Parse(dgv_Timetable.Rows[i-1].Cells[2].Value.ToString());
                string TimeToString = (StartTime / 60).ToString() + ":" + (StartTime % 60).ToString();
                //dgv_Timetable.Rows[i++].Cells[1].Value = TimeToString;
                dgv_Timetable.Rows[i++].Cells[1].Value = TimeSpan.Parse(TimeToString).ToString(@"hh\:mm");
            }
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            if (dgv_Timetable.CurrentRow.Cells[3].Value.ToString() != "Конец дня")
            {
                dgv_Timetable.Rows.Remove(dgv_Timetable.CurrentRow);
                dgv_Timetable_CellEndEdit(sender, new DataGridViewCellEventArgs(dgv_Timetable.CurrentCell.ColumnIndex, dgv_Timetable.CurrentRow.Index - 1));
            }
            else
            {
                MessageBox.Show("Нельзя удалить строку с системными данными");
            }
        }
    }
}
