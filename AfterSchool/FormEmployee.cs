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
    public partial class FormEmployee : Form
    {
        public FormEmployee()
        {
            InitializeComponent();
        }

        // Переход между формами приложения
        private void mi_Employee_Click(object sender, EventArgs e)
        {

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

        private void mi_Timetable_Click(object sender, EventArgs e)
        {
            Owner.OwnedForms[3].Activate();
            Owner.OwnedForms[3].Show();
            Hide();
        }

        private void mi_Finish_Click(object sender, EventArgs e)
        {
            Owner.Activate();
            Owner.Show();
            Hide();
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            EmployeeOperations.FillForm(this);
        }

        public void WriteEmployee(List<string> EmployeeList)
        {
            foreach (string Emp in EmployeeList)
            {
                object[] Row = new object[3];
                Row[0] = Emp.Split(';')[2];
                Row[1] = Emp.Split(';')[0];
                Row[2] = Emp.Split(';')[1];
                dgv_Employee.Rows.Add(Row);
            }
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            EmployeeOperations.RemoveEmp(dgv_Employee.CurrentRow.Cells[2].Value.ToString());
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            if (tb_FIO.Text != "" && tb_Phone.Text != "" && tb_Email.Text != "" && cb_Position.SelectedItem != null && tb_Login.Text != "" && tb_Password.Text != "")
            {
                if (EmployeeOperations.CheckLogin(tb_Login.Text))
                    EmployeeOperations.AddNewEmp(tb_FIO.Text, tb_Phone.Text, tb_Email.Text, cb_Position.Text, tb_Login.Text, tb_Password.Text, cb_Position.SelectedIndex);
                else
                    MessageBox.Show("Пользователь с таким логином уже зарегистрирован в системе");
            }
            else
                MessageBox.Show("Введены не все необходимые данные");
        }

        // Сгенерировать логин и пароль для нового пользователя
        private void bt_Generate_Click(object sender, EventArgs e)
        {
            string[] LogPas = EmployeeOperations.RandomLogPass();
            tb_Login.Text = LogPas[0];
            tb_Password.Text = LogPas[1];
        }
    }
}
