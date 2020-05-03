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
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
        }

        // Вход в систему
        private void bt_LogIn_Click(object sender, EventArgs e)
        {
            try
            {
                LoginOperations.Initialisation(tb_Login.Text, tb_Password.Text, this);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Введены неверный логин или пароль.");
            }
            finally
            {
                if (OwnedForms.Length > 0)
                {
                    OwnedForms[0].Show();
                    OwnedForms[0].Activate();
                    Hide();
                }
            }
        }

        private void FormLogIn_Activated(object sender, EventArgs e)
        {
            foreach (Form f in OwnedForms)
                f.Close();
            this.Refresh();
        }

        private void bt_Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
