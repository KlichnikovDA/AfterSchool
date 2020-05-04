namespace AfterSchool
{
    partial class FormEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mi_Employee = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Group = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Activity = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Timetable = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Finish = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv_Employee = new System.Windows.Forms.DataGridView();
            this.PositionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Delete = new System.Windows.Forms.Button();
            this.bt_Generate = new System.Windows.Forms.Button();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_Login = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_FIO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_Add = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_Position = new System.Windows.Forms.ComboBox();
            this.tb_Phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_Employee,
            this.mi_Group,
            this.mi_Activity,
            this.mi_Timetable,
            this.mi_Finish});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mi_Employee
            // 
            this.mi_Employee.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mi_Employee.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mi_Employee.Name = "mi_Employee";
            this.mi_Employee.Size = new System.Drawing.Size(89, 21);
            this.mi_Employee.Text = "Сотрудники";
            this.mi_Employee.Click += new System.EventHandler(this.mi_Employee_Click);
            // 
            // mi_Group
            // 
            this.mi_Group.Name = "mi_Group";
            this.mi_Group.Size = new System.Drawing.Size(61, 21);
            this.mi_Group.Text = "Группы";
            this.mi_Group.Click += new System.EventHandler(this.mi_Group_Click);
            // 
            // mi_Activity
            // 
            this.mi_Activity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mi_Activity.Name = "mi_Activity";
            this.mi_Activity.Size = new System.Drawing.Size(102, 21);
            this.mi_Activity.Text = "Деятельность";
            this.mi_Activity.Click += new System.EventHandler(this.mi_Activity_Click);
            // 
            // mi_Timetable
            // 
            this.mi_Timetable.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mi_Timetable.Name = "mi_Timetable";
            this.mi_Timetable.Size = new System.Drawing.Size(88, 21);
            this.mi_Timetable.Text = "Расписание";
            this.mi_Timetable.Click += new System.EventHandler(this.mi_Timetable_Click);
            // 
            // mi_Finish
            // 
            this.mi_Finish.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mi_Finish.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mi_Finish.Name = "mi_Finish";
            this.mi_Finish.Size = new System.Drawing.Size(172, 21);
            this.mi_Finish.Text = "Завершить сеанс работы";
            this.mi_Finish.Click += new System.EventHandler(this.mi_Finish_Click);
            // 
            // dgv_Employee
            // 
            this.dgv_Employee.AllowUserToAddRows = false;
            this.dgv_Employee.AllowUserToDeleteRows = false;
            this.dgv_Employee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Employee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Employee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PositionCol,
            this.NameCol,
            this.LoginCol});
            this.dgv_Employee.Location = new System.Drawing.Point(0, 51);
            this.dgv_Employee.Name = "dgv_Employee";
            this.dgv_Employee.RowHeadersVisible = false;
            this.dgv_Employee.Size = new System.Drawing.Size(800, 699);
            this.dgv_Employee.TabIndex = 1;
            // 
            // PositionCol
            // 
            this.PositionCol.FillWeight = 3F;
            this.PositionCol.HeaderText = "Должность";
            this.PositionCol.Name = "PositionCol";
            this.PositionCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PositionCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // NameCol
            // 
            this.NameCol.FillWeight = 3F;
            this.NameCol.HeaderText = "ФИО";
            this.NameCol.Name = "NameCol";
            // 
            // LoginCol
            // 
            this.LoginCol.FillWeight = 2F;
            this.LoginCol.HeaderText = "Логин";
            this.LoginCol.Name = "LoginCol";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Сотрудники группы продленного дня";
            // 
            // bt_Delete
            // 
            this.bt_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_Delete.Location = new System.Drawing.Point(806, 51);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.Size = new System.Drawing.Size(98, 27);
            this.bt_Delete.TabIndex = 3;
            this.bt_Delete.Text = "Удалить";
            this.bt_Delete.UseVisualStyleBackColor = true;
            this.bt_Delete.Click += new System.EventHandler(this.bt_Delete_Click);
            // 
            // bt_Generate
            // 
            this.bt_Generate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_Generate.Location = new System.Drawing.Point(1117, 406);
            this.bt_Generate.Name = "bt_Generate";
            this.bt_Generate.Size = new System.Drawing.Size(139, 30);
            this.bt_Generate.TabIndex = 34;
            this.bt_Generate.Text = "Сгенерировать";
            this.bt_Generate.UseVisualStyleBackColor = true;
            this.bt_Generate.Click += new System.EventHandler(this.bt_Generate_Click);
            // 
            // tb_Password
            // 
            this.tb_Password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Password.Location = new System.Drawing.Point(810, 410);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(300, 26);
            this.tb_Password.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(810, 387);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Пароль";
            // 
            // tb_Login
            // 
            this.tb_Login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Login.Location = new System.Drawing.Point(810, 358);
            this.tb_Login.Name = "tb_Login";
            this.tb_Login.Size = new System.Drawing.Size(300, 26);
            this.tb_Login.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(810, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Логин";
            // 
            // tb_FIO
            // 
            this.tb_FIO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_FIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_FIO.Location = new System.Drawing.Point(806, 128);
            this.tb_FIO.Name = "tb_FIO";
            this.tb_FIO.Size = new System.Drawing.Size(300, 26);
            this.tb_FIO.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(802, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "ФИО";
            // 
            // bt_Add
            // 
            this.bt_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_Add.Location = new System.Drawing.Point(810, 442);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(98, 27);
            this.bt_Add.TabIndex = 35;
            this.bt_Add.Text = "Добавить";
            this.bt_Add.UseVisualStyleBackColor = true;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(806, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Должность";
            // 
            // cb_Position
            // 
            this.cb_Position.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_Position.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_Position.FormattingEnabled = true;
            this.cb_Position.Items.AddRange(new object[] {
            "Руководитель группы",
            "Воспитатель",
            "Руководитель кружка"});
            this.cb_Position.Location = new System.Drawing.Point(806, 180);
            this.cb_Position.Name = "cb_Position";
            this.cb_Position.Size = new System.Drawing.Size(300, 28);
            this.cb_Position.TabIndex = 37;
            // 
            // tb_Phone
            // 
            this.tb_Phone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Phone.Location = new System.Drawing.Point(806, 239);
            this.tb_Phone.Name = "tb_Phone";
            this.tb_Phone.Size = new System.Drawing.Size(300, 26);
            this.tb_Phone.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(802, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Телефон";
            // 
            // tb_Email
            // 
            this.tb_Email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Email.Location = new System.Drawing.Point(810, 298);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(300, 26);
            this.tb_Email.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(806, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "Email";
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 762);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_Phone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_Position);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_Add);
            this.Controls.Add(this.bt_Generate);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_Login);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_FIO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_Delete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Employee);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormEmployee";
            this.Text = "EmployeeForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormEmployee_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mi_Employee;
        private System.Windows.Forms.ToolStripMenuItem mi_Group;
        private System.Windows.Forms.ToolStripMenuItem mi_Activity;
        private System.Windows.Forms.ToolStripMenuItem mi_Timetable;
        private System.Windows.Forms.ToolStripMenuItem mi_Finish;
        private System.Windows.Forms.DataGridView dgv_Employee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Delete;
        private System.Windows.Forms.Button bt_Generate;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_Login;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_FIO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn PositionCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginCol;
        private System.Windows.Forms.TextBox tb_Phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.Label label5;
    }
}