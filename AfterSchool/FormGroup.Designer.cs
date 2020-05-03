namespace AfterSchool
{
    partial class FormGroup
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bt_AddGroup = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgv_Group = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_DeleteChild = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.bt_AddChild = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.bt_Assign = new System.Windows.Forms.Button();
            this.ColChildName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrivilege = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColParentName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPhone1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmail1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColParentName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPhone2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Group)).BeginInit();
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
            this.mi_Employee.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mi_Employee.Name = "mi_Employee";
            this.mi_Employee.Size = new System.Drawing.Size(89, 21);
            this.mi_Employee.Text = "Сотрудники";
            this.mi_Employee.Click += new System.EventHandler(this.mi_Employee_Click);
            // 
            // mi_Group
            // 
            this.mi_Group.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mi_Group.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mi_Group.Name = "mi_Group";
            this.mi_Group.Size = new System.Drawing.Size(63, 21);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Группа";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 28);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // bt_AddGroup
            // 
            this.bt_AddGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_AddGroup.Location = new System.Drawing.Point(218, 65);
            this.bt_AddGroup.Name = "bt_AddGroup";
            this.bt_AddGroup.Size = new System.Drawing.Size(169, 28);
            this.bt_AddGroup.TabIndex = 4;
            this.bt_AddGroup.Text = "Добавить группу";
            this.bt_AddGroup.UseVisualStyleBackColor = true;
            this.bt_AddGroup.Click += new System.EventHandler(this.bt_AddGroup_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(393, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Импорт из Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv_Group
            // 
            this.dgv_Group.AllowUserToAddRows = false;
            this.dgv_Group.AllowUserToDeleteRows = false;
            this.dgv_Group.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Group.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Group.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Group.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColChildName,
            this.ColGrade,
            this.ColBirth,
            this.ColAddress,
            this.ColPrivilege,
            this.ColParentName1,
            this.ColPhone1,
            this.ColEmail1,
            this.ColParentName2,
            this.ColPhone2,
            this.ColEmail,
            this.Column1});
            this.dgv_Group.Location = new System.Drawing.Point(12, 99);
            this.dgv_Group.MultiSelect = false;
            this.dgv_Group.Name = "dgv_Group";
            this.dgv_Group.ReadOnly = true;
            this.dgv_Group.RowHeadersVisible = false;
            this.dgv_Group.Size = new System.Drawing.Size(934, 651);
            this.dgv_Group.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(952, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "ФИО ребенка";
            // 
            // bt_DeleteChild
            // 
            this.bt_DeleteChild.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bt_DeleteChild.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_DeleteChild.Location = new System.Drawing.Point(952, 121);
            this.bt_DeleteChild.Name = "bt_DeleteChild";
            this.bt_DeleteChild.Size = new System.Drawing.Size(101, 28);
            this.bt_DeleteChild.TabIndex = 8;
            this.bt_DeleteChild.Text = "Удалить";
            this.bt_DeleteChild.UseVisualStyleBackColor = true;
            this.bt_DeleteChild.Click += new System.EventHandler(this.bt_DeleteChild_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(952, 175);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 26);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(952, 227);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(300, 26);
            this.textBox2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(952, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Класс";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(952, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Дата рождения";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(952, 279);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(300, 26);
            this.textBox3.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(952, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Домашний адрес";
            // 
            // textBox5
            // 
            this.textBox5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5.Location = new System.Drawing.Point(952, 361);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(300, 26);
            this.textBox5.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(952, 390);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "ФИО родителя";
            // 
            // textBox6
            // 
            this.textBox6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox6.Location = new System.Drawing.Point(952, 413);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(300, 26);
            this.textBox6.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(952, 442);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "ФИО родителя";
            // 
            // textBox7
            // 
            this.textBox7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox7.Location = new System.Drawing.Point(952, 465);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(300, 26);
            this.textBox7.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(952, 494);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Контактный номер 1";
            // 
            // textBox8
            // 
            this.textBox8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox8.Location = new System.Drawing.Point(952, 517);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(300, 26);
            this.textBox8.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(952, 546);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "Контактный номер 2";
            // 
            // textBox9
            // 
            this.textBox9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox9.Location = new System.Drawing.Point(952, 569);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(300, 26);
            this.textBox9.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(952, 598);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(173, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "Электронная почта 1";
            // 
            // textBox10
            // 
            this.textBox10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox10.Location = new System.Drawing.Point(952, 621);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(300, 26);
            this.textBox10.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(952, 650);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(173, 20);
            this.label12.TabIndex = 28;
            this.label12.Text = "Электронная почта 2";
            // 
            // textBox11
            // 
            this.textBox11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox11.Location = new System.Drawing.Point(952, 673);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(300, 26);
            this.textBox11.TabIndex = 29;
            // 
            // bt_AddChild
            // 
            this.bt_AddChild.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bt_AddChild.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_AddChild.Location = new System.Drawing.Point(952, 705);
            this.bt_AddChild.Name = "bt_AddChild";
            this.bt_AddChild.Size = new System.Drawing.Size(101, 28);
            this.bt_AddChild.TabIndex = 30;
            this.bt_AddChild.Text = "Добавить";
            this.bt_AddChild.UseVisualStyleBackColor = true;
            this.bt_AddChild.Click += new System.EventHandler(this.bt_AddChild_Click);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(642, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 20);
            this.label13.TabIndex = 32;
            this.label13.Text = "Руководитель";
            // 
            // comboBox3
            // 
            this.comboBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(646, 65);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(300, 28);
            this.comboBox3.TabIndex = 33;
            // 
            // bt_Assign
            // 
            this.bt_Assign.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Assign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_Assign.Location = new System.Drawing.Point(952, 65);
            this.bt_Assign.Name = "bt_Assign";
            this.bt_Assign.Size = new System.Drawing.Size(101, 28);
            this.bt_Assign.TabIndex = 34;
            this.bt_Assign.Text = "Назначить";
            this.bt_Assign.UseVisualStyleBackColor = true;
            this.bt_Assign.Click += new System.EventHandler(this.bt_Assign_Click);
            // 
            // ColChildName
            // 
            this.ColChildName.HeaderText = "ФИО ребенка";
            this.ColChildName.Name = "ColChildName";
            // 
            // ColGrade
            // 
            this.ColGrade.FillWeight = 50F;
            this.ColGrade.HeaderText = "Класс";
            this.ColGrade.Name = "ColGrade";
            // 
            // ColBirth
            // 
            this.ColBirth.HeaderText = "Дата рождения";
            this.ColBirth.Name = "ColBirth";
            // 
            // ColAddress
            // 
            this.ColAddress.HeaderText = "Домашний адрес";
            this.ColAddress.Name = "ColAddress";
            // 
            // ColPrivilege
            // 
            this.ColPrivilege.FillWeight = 50F;
            this.ColPrivilege.HeaderText = "Льготы";
            this.ColPrivilege.Name = "ColPrivilege";
            this.ColPrivilege.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColPrivilege.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ColParentName1
            // 
            this.ColParentName1.HeaderText = "ФИО родителя";
            this.ColParentName1.Name = "ColParentName1";
            // 
            // ColPhone1
            // 
            this.ColPhone1.HeaderText = "Телефон родителя";
            this.ColPhone1.Name = "ColPhone1";
            // 
            // ColEmail1
            // 
            this.ColEmail1.HeaderText = "Электронная почта";
            this.ColEmail1.Name = "ColEmail1";
            // 
            // ColParentName2
            // 
            this.ColParentName2.HeaderText = "ФИО родителя";
            this.ColParentName2.Name = "ColParentName2";
            // 
            // ColPhone2
            // 
            this.ColPhone2.HeaderText = "Телефонный номер";
            this.ColPhone2.Name = "ColPhone2";
            // 
            // ColEmail
            // 
            this.ColEmail.HeaderText = "Электронная почта";
            this.ColEmail.Name = "ColEmail";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(956, 311);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(85, 24);
            this.checkBox1.TabIndex = 35;
            this.checkBox1.Text = "Льготы";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // FormGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 762);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.bt_Assign);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.bt_AddChild);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bt_DeleteChild);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_Group);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_AddGroup);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormGroup";
            this.Text = "FormGroup";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormGroup_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Group)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button bt_AddGroup;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgv_Group;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_DeleteChild;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Button bt_AddChild;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button bt_Assign;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColChildName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAddress;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColPrivilege;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColParentName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPhone1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmail1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColParentName2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPhone2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}