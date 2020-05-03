namespace AfterSchool
{
    partial class FormClass
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
            this.mi_Finish = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Educator = new System.Windows.Forms.TextBox();
            this.mc_ClassDate = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_Activities = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_TimeBegun = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Duration = new System.Windows.Forms.TextBox();
            this.dgv_Attendance = new System.Windows.Forms.DataGridView();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAttended = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_GroupName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_WorkDone = new System.Windows.Forms.TextBox();
            this.bt_Apply = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Attendance)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_Finish});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Пользователь:";
            // 
            // tb_Educator
            // 
            this.tb_Educator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Educator.Location = new System.Drawing.Point(143, 25);
            this.tb_Educator.Name = "tb_Educator";
            this.tb_Educator.ReadOnly = true;
            this.tb_Educator.Size = new System.Drawing.Size(300, 26);
            this.tb_Educator.TabIndex = 2;
            // 
            // mc_ClassDate
            // 
            this.mc_ClassDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mc_ClassDate.Location = new System.Drawing.Point(76, 63);
            this.mc_ClassDate.MaxSelectionCount = 1;
            this.mc_ClassDate.Name = "mc_ClassDate";
            this.mc_ClassDate.TabIndex = 3;
            this.mc_ClassDate.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mc_ClassDate_DateSelected);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Дата:";
            // 
            // lb_Activities
            // 
            this.lb_Activities.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Activities.FormattingEnabled = true;
            this.lb_Activities.ItemHeight = 16;
            this.lb_Activities.Location = new System.Drawing.Point(336, 63);
            this.lb_Activities.Name = "lb_Activities";
            this.lb_Activities.Size = new System.Drawing.Size(200, 164);
            this.lb_Activities.TabIndex = 5;
            this.lb_Activities.SelectedIndexChanged += new System.EventHandler(this.lb_Activities_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(252, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Занятие:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(542, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Начало:";
            // 
            // tb_TimeBegun
            // 
            this.tb_TimeBegun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_TimeBegun.Location = new System.Drawing.Point(673, 63);
            this.tb_TimeBegun.Name = "tb_TimeBegun";
            this.tb_TimeBegun.ReadOnly = true;
            this.tb_TimeBegun.Size = new System.Drawing.Size(100, 26);
            this.tb_TimeBegun.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(542, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Длительность:";
            // 
            // tb_Duration
            // 
            this.tb_Duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Duration.Location = new System.Drawing.Point(673, 95);
            this.tb_Duration.Name = "tb_Duration";
            this.tb_Duration.ReadOnly = true;
            this.tb_Duration.Size = new System.Drawing.Size(100, 26);
            this.tb_Duration.TabIndex = 10;
            // 
            // dgv_Attendance
            // 
            this.dgv_Attendance.AllowUserToAddRows = false;
            this.dgv_Attendance.AllowUserToDeleteRows = false;
            this.dgv_Attendance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Attendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Attendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Attendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColName,
            this.ColGrade,
            this.ColAttended,
            this.ID});
            this.dgv_Attendance.Location = new System.Drawing.Point(12, 256);
            this.dgv_Attendance.Name = "dgv_Attendance";
            this.dgv_Attendance.RowHeadersVisible = false;
            this.dgv_Attendance.Size = new System.Drawing.Size(524, 494);
            this.dgv_Attendance.TabIndex = 11;
            // 
            // ColName
            // 
            this.ColName.FillWeight = 8F;
            this.ColName.HeaderText = "ФИО";
            this.ColName.Name = "ColName";
            // 
            // ColGrade
            // 
            this.ColGrade.FillWeight = 2F;
            this.ColGrade.HeaderText = "Класс";
            this.ColGrade.Name = "ColGrade";
            // 
            // ColAttended
            // 
            this.ColAttended.FillWeight = 2F;
            this.ColAttended.HeaderText = "Присутствовал";
            this.ColAttended.Name = "ColAttended";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(471, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Группа:";
            // 
            // tb_GroupName
            // 
            this.tb_GroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_GroupName.Location = new System.Drawing.Point(542, 28);
            this.tb_GroupName.Name = "tb_GroupName";
            this.tb_GroupName.ReadOnly = true;
            this.tb_GroupName.Size = new System.Drawing.Size(231, 26);
            this.tb_GroupName.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Присутствовавшие дети:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(542, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Проведенная работа:";
            // 
            // tb_WorkDone
            // 
            this.tb_WorkDone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_WorkDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_WorkDone.Location = new System.Drawing.Point(542, 279);
            this.tb_WorkDone.Multiline = true;
            this.tb_WorkDone.Name = "tb_WorkDone";
            this.tb_WorkDone.Size = new System.Drawing.Size(710, 471);
            this.tb_WorkDone.TabIndex = 1;
            // 
            // bt_Apply
            // 
            this.bt_Apply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_Apply.Location = new System.Drawing.Point(556, 197);
            this.bt_Apply.Name = "bt_Apply";
            this.bt_Apply.Size = new System.Drawing.Size(161, 28);
            this.bt_Apply.TabIndex = 21;
            this.bt_Apply.Text = "Отправить отчет";
            this.bt_Apply.UseVisualStyleBackColor = true;
            this.bt_Apply.Click += new System.EventHandler(this.bt_Apply_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "Column1";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // FormClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 762);
            this.Controls.Add(this.bt_Apply);
            this.Controls.Add(this.tb_WorkDone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_GroupName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgv_Attendance);
            this.Controls.Add(this.tb_Duration);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_TimeBegun);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_Activities);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mc_ClassDate);
            this.Controls.Add(this.tb_Educator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormClass";
            this.Text = "FormClass";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClass_FormClosing);
            this.Load += new System.EventHandler(this.FormClass_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Attendance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mi_Finish;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Educator;
        private System.Windows.Forms.MonthCalendar mc_ClassDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lb_Activities;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_TimeBegun;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Duration;
        private System.Windows.Forms.DataGridView dgv_Attendance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_GroupName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGrade;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColAttended;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_WorkDone;
        private System.Windows.Forms.Button bt_Apply;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}