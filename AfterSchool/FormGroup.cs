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
    public partial class FormGroup : Form
    {
        public FormGroup()
        {
            InitializeComponent();
        }
        int[] EmpID { get; set; }

        // Переход между формами приложения
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

        private void FormGroup_Load(object sender, EventArgs e)
        {
            GroupActivitiesOperations.FillGroupForm(this);
        }

        public void WriteGroups(object[] GroupList)
        {
            comboBox1.Items.Clear();
            for(int i = 0; i < GroupList.Length; i++)
            {
                comboBox1.Items.Add(GroupList[i].ToString().Split(';')[0]);
            }
        }

        public void WriteEmployees(object[] EmpList)
        {
            comboBox3.Items.Clear();
            EmpID = new int[EmpList.Length];
            for (int i = 0; i < EmpList.Length; i++)
            {
                comboBox3.Items.Add(EmpList[i].ToString().Split(';')[0]);
                EmpID[i] = Int32.Parse(EmpList[i].ToString().Split(';')[1]);
            }
        }

        private void bt_AddGroup_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.IndexOf(comboBox1.Text) == -1)
            {
                string NewGroup = comboBox1.Text;
                GroupActivitiesOperations.AddGroup(comboBox1.Text, EmpID[comboBox3.SelectedIndex]);
                GroupActivitiesOperations.FillGroupForm(this);
                comboBox1.SelectedItem = NewGroup;
            }
            else
                MessageBox.Show("Группа с таким названием уже создана");
        }

        // Импорт информации о составе новой группы из книги Excel
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.IndexOf(comboBox1.Text) == -1)
            {
                OpenFileDialog OFD = new OpenFileDialog();
                // Файл, откуда будет произведен импорт
                string FilePath = "";
                OFD.Filter = "Книга Excel (*.xlsx)|*.xlsx";

                if (OFD.ShowDialog() == DialogResult.OK)
                {
                    FilePath = OFD.FileName;
                    GroupActivitiesOperations.ImportGroup(FilePath, dgv_Group, comboBox1.Text);
                }
            }
            else
                MessageBox.Show("Не выбрана группа для импорта данных");
        }

        private void bt_DeleteChild_Click(object sender, EventArgs e)
        {
            GroupActivitiesOperations.RemoveChild(Int32.Parse(dgv_Group.CurrentRow.Cells[11].Value.ToString()));
        }

        private void bt_AddChild_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.IndexOf(comboBox1.Text) == -1)
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox5.Text != "" &&
                  ((textBox6.Text != "" && textBox8.Text != "" && textBox10.Text != "") || (textBox7.Text != "" && textBox9.Text != "" && textBox11.Text != "")))
                {
                    int NewID = GroupActivitiesOperations.AddChild(comboBox1.Text, textBox1.Text, textBox2.Text, checkBox1.Checked, textBox3.Text, textBox5.Text);
                    if (textBox6.Text != "" && textBox8.Text != "" && textBox10.Text != "")
                        GroupActivitiesOperations.AddParent(textBox6.Text, textBox8.Text, textBox10.Text, NewID);
                    if (textBox7.Text != "" && textBox9.Text != "" && textBox11.Text != "")
                        GroupActivitiesOperations.AddParent(textBox7.Text, textBox9.Text, textBox11.Text, NewID);
                }
                else
                    MessageBox.Show("Введены не все необходимые для регистрации ребенка данные");
            }
            else
                MessageBox.Show("Не выбрана группа");
        }

        private void bt_Assign_Click(object sender, EventArgs e)
        {
            if (comboBox3.Items.IndexOf(comboBox3.Text) != -1)
            {
                if (comboBox1.Items.IndexOf(comboBox1.Text) != -1)
                {
                    if (!GroupActivitiesOperations.CheckIsFree(EmpID[comboBox3.SelectedIndex]))
                        GroupActivitiesOperations.ChangeGroupEdu(comboBox1.Text, EmpID[comboBox3.SelectedIndex]);
                    else
                        MessageBox.Show("Указанный воспитатель уже руководит группой");
                }
                else
                    MessageBox.Show("Не выбрана группа");
            }
            else
                MessageBox.Show("Не выбран воспитатель для назначения");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.SelectedItem = GroupActivitiesOperations.GetEdu(comboBox1.Text);
            GroupActivitiesOperations.LoadChildren(comboBox1.Text, dgv_Group);
        }
    }
}
