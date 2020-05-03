namespace AfterSchool
{
    partial class FormActivity
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
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Activities = new System.Windows.Forms.ListBox();
            this.bt_DeleteAct = new System.Windows.Forms.Button();
            this.bt_AddAct = new System.Windows.Forms.Button();
            this.tb_ActName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_ActType = new System.Windows.Forms.ComboBox();
            this.lb_Employee = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
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
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mi_Employee
            // 
            this.mi_Employee.BackColor = System.Drawing.SystemColors.Control;
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
            this.mi_Activity.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mi_Activity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mi_Activity.Name = "mi_Activity";
            this.mi_Activity.Size = new System.Drawing.Size(102, 21);
            this.mi_Activity.Text = "Деятельность";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Виды деятельности, осуществляемые ГПД";
            // 
            // lb_Activities
            // 
            this.lb_Activities.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Activities.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Activities.FormattingEnabled = true;
            this.lb_Activities.ItemHeight = 16;
            this.lb_Activities.Location = new System.Drawing.Point(16, 57);
            this.lb_Activities.Name = "lb_Activities";
            this.lb_Activities.Size = new System.Drawing.Size(250, 660);
            this.lb_Activities.TabIndex = 3;
            // 
            // bt_DeleteAct
            // 
            this.bt_DeleteAct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_DeleteAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_DeleteAct.Location = new System.Drawing.Point(12, 720);
            this.bt_DeleteAct.Name = "bt_DeleteAct";
            this.bt_DeleteAct.Size = new System.Drawing.Size(94, 30);
            this.bt_DeleteAct.TabIndex = 4;
            this.bt_DeleteAct.Text = "Удалить";
            this.bt_DeleteAct.UseVisualStyleBackColor = true;
            this.bt_DeleteAct.Click += new System.EventHandler(this.bt_DeleteAct_Click);
            // 
            // bt_AddAct
            // 
            this.bt_AddAct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_AddAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_AddAct.Location = new System.Drawing.Point(297, 167);
            this.bt_AddAct.Name = "bt_AddAct";
            this.bt_AddAct.Size = new System.Drawing.Size(94, 30);
            this.bt_AddAct.TabIndex = 5;
            this.bt_AddAct.Text = "Добавить";
            this.bt_AddAct.UseVisualStyleBackColor = true;
            this.bt_AddAct.Click += new System.EventHandler(this.bt_AddAct_Click);
            // 
            // tb_ActName
            // 
            this.tb_ActName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_ActName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_ActName.Location = new System.Drawing.Point(297, 81);
            this.tb_ActName.Name = "tb_ActName";
            this.tb_ActName.Size = new System.Drawing.Size(250, 26);
            this.tb_ActName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(293, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Наименование";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(293, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Тип деятельности";
            // 
            // cb_ActType
            // 
            this.cb_ActType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_ActType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_ActType.FormattingEnabled = true;
            this.cb_ActType.Location = new System.Drawing.Point(297, 133);
            this.cb_ActType.Name = "cb_ActType";
            this.cb_ActType.Size = new System.Drawing.Size(250, 28);
            this.cb_ActType.TabIndex = 9;
            // 
            // lb_Employee
            // 
            this.lb_Employee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Employee.FormattingEnabled = true;
            this.lb_Employee.ItemHeight = 16;
            this.lb_Employee.Location = new System.Drawing.Point(591, 58);
            this.lb_Employee.Name = "lb_Employee";
            this.lb_Employee.Size = new System.Drawing.Size(250, 292);
            this.lb_Employee.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(587, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Руководители кружков";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(591, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 54);
            this.button1.TabIndex = 12;
            this.button1.Text = "Назначить для существующей";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(591, 416);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 35);
            this.button2.TabIndex = 13;
            this.button2.Text = "Назначить для новой";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 762);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_Employee);
            this.Controls.Add(this.cb_ActType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_ActName);
            this.Controls.Add(this.bt_AddAct);
            this.Controls.Add(this.bt_DeleteAct);
            this.Controls.Add(this.lb_Activities);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormActivity";
            this.Text = "FormActivity";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormActivity_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mi_Group;
        private System.Windows.Forms.ToolStripMenuItem mi_Employee;
        private System.Windows.Forms.ToolStripMenuItem mi_Activity;
        private System.Windows.Forms.ToolStripMenuItem mi_Timetable;
        private System.Windows.Forms.ToolStripMenuItem mi_Finish;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lb_Activities;
        private System.Windows.Forms.Button bt_DeleteAct;
        private System.Windows.Forms.Button bt_AddAct;
        private System.Windows.Forms.TextBox tb_ActName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_ActType;
        private System.Windows.Forms.ListBox lb_Employee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}