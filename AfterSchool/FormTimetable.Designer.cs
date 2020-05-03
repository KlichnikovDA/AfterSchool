namespace AfterSchool
{
    partial class FormTimetable
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
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lb_Activities = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Timetable = new System.Windows.Forms.DataGridView();
            this.ColDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBegin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_Apply = new System.Windows.Forms.Button();
            this.bt_NextDay = new System.Windows.Forms.Button();
            this.bt_Clear = new System.Windows.Forms.Button();
            this.bt_Delete = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Timetable)).BeginInit();
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
            this.mi_Activity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mi_Activity.Name = "mi_Activity";
            this.mi_Activity.Size = new System.Drawing.Size(102, 21);
            this.mi_Activity.Text = "Деятельность";
            this.mi_Activity.Click += new System.EventHandler(this.mi_Activity_Click);
            // 
            // mi_Timetable
            // 
            this.mi_Timetable.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mi_Timetable.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mi_Timetable.Name = "mi_Timetable";
            this.mi_Timetable.Size = new System.Drawing.Size(88, 21);
            this.mi_Timetable.Text = "Расписание";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Группа:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(74, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(250, 28);
            this.comboBox1.TabIndex = 15;
            // 
            // lb_Activities
            // 
            this.lb_Activities.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Activities.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Activities.FormattingEnabled = true;
            this.lb_Activities.ItemHeight = 16;
            this.lb_Activities.Location = new System.Drawing.Point(16, 85);
            this.lb_Activities.Name = "lb_Activities";
            this.lb_Activities.Size = new System.Drawing.Size(250, 660);
            this.lb_Activities.TabIndex = 17;
            this.lb_Activities.Click += new System.EventHandler(this.lb_Activities_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Виды деятельности";
            // 
            // dgv_Timetable
            // 
            this.dgv_Timetable.AllowUserToAddRows = false;
            this.dgv_Timetable.AllowUserToDeleteRows = false;
            this.dgv_Timetable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Timetable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Timetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Timetable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColDay,
            this.ColBegin,
            this.ColDur,
            this.ColAct});
            this.dgv_Timetable.Location = new System.Drawing.Point(729, 85);
            this.dgv_Timetable.Name = "dgv_Timetable";
            this.dgv_Timetable.RowHeadersVisible = false;
            this.dgv_Timetable.Size = new System.Drawing.Size(500, 660);
            this.dgv_Timetable.TabIndex = 18;
            this.dgv_Timetable.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Timetable_CellEndEdit);
            this.dgv_Timetable.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgv_Timetable_CellValidating);
            // 
            // ColDay
            // 
            this.ColDay.FillWeight = 17.11675F;
            this.ColDay.HeaderText = "День недели";
            this.ColDay.Name = "ColDay";
            this.ColDay.ReadOnly = true;
            this.ColDay.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColDay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColBegin
            // 
            this.ColBegin.FillWeight = 17.81388F;
            this.ColBegin.HeaderText = "Начало";
            this.ColBegin.Name = "ColBegin";
            this.ColBegin.ReadOnly = true;
            this.ColBegin.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColDur
            // 
            this.ColDur.FillWeight = 17.81388F;
            this.ColDur.HeaderText = "Длительность";
            this.ColDur.Name = "ColDur";
            this.ColDur.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColAct
            // 
            this.ColAct.FillWeight = 71.2555F;
            this.ColAct.HeaderText = "Деятельность";
            this.ColAct.Name = "ColAct";
            this.ColAct.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(725, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Расписание";
            // 
            // bt_Apply
            // 
            this.bt_Apply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_Apply.Location = new System.Drawing.Point(330, 30);
            this.bt_Apply.Name = "bt_Apply";
            this.bt_Apply.Size = new System.Drawing.Size(111, 28);
            this.bt_Apply.TabIndex = 20;
            this.bt_Apply.Text = "Утвердить";
            this.bt_Apply.UseVisualStyleBackColor = true;
            this.bt_Apply.Click += new System.EventHandler(this.bt_Apply_Click);
            // 
            // bt_NextDay
            // 
            this.bt_NextDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_NextDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_NextDay.Location = new System.Drawing.Point(272, 85);
            this.bt_NextDay.Name = "bt_NextDay";
            this.bt_NextDay.Size = new System.Drawing.Size(152, 28);
            this.bt_NextDay.TabIndex = 21;
            this.bt_NextDay.Text = "Следующий день";
            this.bt_NextDay.UseVisualStyleBackColor = true;
            this.bt_NextDay.Click += new System.EventHandler(this.bt_NextDay_Click);
            // 
            // bt_Clear
            // 
            this.bt_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_Clear.Location = new System.Drawing.Point(612, 121);
            this.bt_Clear.Name = "bt_Clear";
            this.bt_Clear.Size = new System.Drawing.Size(111, 28);
            this.bt_Clear.TabIndex = 23;
            this.bt_Clear.Text = "Очистить";
            this.bt_Clear.UseVisualStyleBackColor = true;
            this.bt_Clear.Click += new System.EventHandler(this.bt_Clear_Click);
            // 
            // bt_Delete
            // 
            this.bt_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_Delete.Location = new System.Drawing.Point(612, 87);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.Size = new System.Drawing.Size(111, 28);
            this.bt_Delete.TabIndex = 24;
            this.bt_Delete.Text = "Удалить";
            this.bt_Delete.UseVisualStyleBackColor = true;
            this.bt_Delete.Click += new System.EventHandler(this.bt_Delete_Click);
            // 
            // FormTimetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 762);
            this.Controls.Add(this.bt_Delete);
            this.Controls.Add(this.bt_Clear);
            this.Controls.Add(this.bt_NextDay);
            this.Controls.Add(this.bt_Apply);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_Timetable);
            this.Controls.Add(this.lb_Activities);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTimetable";
            this.Text = "FormTimetable";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormTimetable_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Timetable)).EndInit();
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox lb_Activities;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Timetable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_Apply;
        private System.Windows.Forms.Button bt_NextDay;
        private System.Windows.Forms.Button bt_Clear;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBegin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDur;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAct;
        private System.Windows.Forms.Button bt_Delete;
    }
}