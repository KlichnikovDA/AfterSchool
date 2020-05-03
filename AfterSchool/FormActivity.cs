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
    public partial class FormActivity : Form
    {
        int EducatorForNewAct { get; set; }
        int[] ShownIDs { get; set; }

        public FormActivity()
        {
            InitializeComponent();
        }

        private void mi_Group_Click(object sender, EventArgs e)
        {
            Owner.OwnedForms[2].Activate();
            Owner.OwnedForms[2].Show();
            Hide();
        }

        private void mi_Employee_Click(object sender, EventArgs e)
        {
            Owner.OwnedForms[0].Activate();
            Owner.OwnedForms[0].Show();
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

        private void FormActivity_Load(object sender, EventArgs e)
        {
            EducatorForNewAct = -1;
            GroupActivitiesOperations.FillActForm(this);
        }

        public void WriteActivities(object[] ActArray)
        {
            lb_Activities.Items.Clear();
            lb_Activities.Items.AddRange(ActArray);
        }

        public void WriteActivityTypes(object[] TypesArray)
        {
            cb_ActType.Items.Clear();
            cb_ActType.Items.AddRange(TypesArray);
        }

        public void WriteEmployees(object[] EmpArray)
        {
            lb_Employee.Items.Clear();
            ShownIDs = new int[EmpArray.Length];
            for (int i = 0; i < EmpArray.Length; i++)
            {
                lb_Employee.Items.Add(EmpArray[i].ToString().Split(';')[0]);
                ShownIDs[i] = Int32.Parse(EmpArray[i].ToString().Split(';')[1]);
            }
        }

        private void bt_DeleteAct_Click(object sender, EventArgs e)
        {
            if (lb_Activities.SelectedItems.Count > 0)
                GroupActivitiesOperations.RemoveAct(lb_Activities.SelectedItem.ToString());
            else
                MessageBox.Show("Не выбран вид деятельности для удаления");
        }

        private void bt_AddAct_Click(object sender, EventArgs e)
        {
            if (tb_ActName.Text != "" && cb_ActType.SelectedItem != null)
            {
                GroupActivitiesOperations.AddAct(tb_ActName.Text, cb_ActType.SelectedItem.ToString(), EducatorForNewAct);
                GroupActivitiesOperations.FillActForm(this);
                EducatorForNewAct = -1;
            }
            else
            {
                MessageBox.Show("Требуется ввести название и указать категорию для новой деятельности");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lb_Activities.SelectedItems.Count > 0)
            {
                if (lb_Employee.SelectedItems.Count > 0)
                {
                    if (GroupActivitiesOperations.CheckIsFree(ShownIDs[lb_Employee.SelectedIndex]))
                    {
                        GroupActivitiesOperations.ChangeActEdu(lb_Activities.SelectedItem.ToString(), ShownIDs[lb_Employee.SelectedIndex]);
                        if (ShownIDs[lb_Employee.SelectedIndex] == EducatorForNewAct)
                            EducatorForNewAct = -1;
                    }
                    else
                        MessageBox.Show("Выбранный преподаватель уже руководит занятиями");
                }
                else
                    MessageBox.Show("Не выбран преподаватель для назначения");
            }
            else
                MessageBox.Show("Не выбран вид деятельности для назначения");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lb_Employee.SelectedItems.Count > 0)
            {
                if (GroupActivitiesOperations.CheckIsFree(ShownIDs[lb_Employee.SelectedIndex]))
                {
                    EducatorForNewAct = ShownIDs[lb_Employee.SelectedIndex];
                }
                else
                    MessageBox.Show("Выбранный преподаватель уже руководит занятиями");
            }
            else
                MessageBox.Show("Не выбран преподаватель для назначения");
        }
    }
}
