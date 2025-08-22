namespace TestApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.applyFilterButton = new System.Windows.Forms.Button();
            this.sortDirCombo = new System.Windows.Forms.ComboBox();
            this.sortFieldCombo = new System.Windows.Forms.ComboBox();
            this.lastNameFilter = new System.Windows.Forms.TextBox();
            this.postCombo = new System.Windows.Forms.ComboBox();
            this.depCombo = new System.Windows.Forms.ComboBox();
            this.statusCombo = new System.Windows.Forms.ComboBox();
            this.employeesGrid = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.getStatsButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbUnemploy = new System.Windows.Forms.RadioButton();
            this.rbEmploy = new System.Windows.Forms.RadioButton();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.statStatusCombo = new System.Windows.Forms.ComboBox();
            this.statsGrid = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesGrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.applyFilterButton);
            this.tabPage1.Controls.Add(this.sortDirCombo);
            this.tabPage1.Controls.Add(this.sortFieldCombo);
            this.tabPage1.Controls.Add(this.lastNameFilter);
            this.tabPage1.Controls.Add(this.postCombo);
            this.tabPage1.Controls.Add(this.depCombo);
            this.tabPage1.Controls.Add(this.statusCombo);
            this.tabPage1.Controls.Add(this.employeesGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Список сотрудников";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(252, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Порядок сортировки";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Сортировать по:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(604, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(388, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Должность";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Отдел";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Статус";
            // 
            // applyFilterButton
            // 
            this.applyFilterButton.Location = new System.Drawing.Point(618, 129);
            this.applyFilterButton.Name = "applyFilterButton";
            this.applyFilterButton.Size = new System.Drawing.Size(75, 23);
            this.applyFilterButton.TabIndex = 7;
            this.applyFilterButton.Text = "Применить";
            this.applyFilterButton.UseVisualStyleBackColor = true;
            this.applyFilterButton.Click += new System.EventHandler(this.applyFilterButton_Click);
            // 
            // sortDirCombo
            // 
            this.sortDirCombo.FormattingEnabled = true;
            this.sortDirCombo.Location = new System.Drawing.Point(371, 132);
            this.sortDirCombo.Name = "sortDirCombo";
            this.sortDirCombo.Size = new System.Drawing.Size(121, 21);
            this.sortDirCombo.TabIndex = 6;
            // 
            // sortFieldCombo
            // 
            this.sortFieldCombo.FormattingEnabled = true;
            this.sortFieldCombo.Location = new System.Drawing.Point(105, 132);
            this.sortFieldCombo.Name = "sortFieldCombo";
            this.sortFieldCombo.Size = new System.Drawing.Size(121, 21);
            this.sortFieldCombo.TabIndex = 5;
            // 
            // lastNameFilter
            // 
            this.lastNameFilter.Location = new System.Drawing.Point(666, 51);
            this.lastNameFilter.Name = "lastNameFilter";
            this.lastNameFilter.Size = new System.Drawing.Size(100, 20);
            this.lastNameFilter.TabIndex = 4;
            this.lastNameFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lastNameFilter_KeyDown);
            // 
            // postCombo
            // 
            this.postCombo.FormattingEnabled = true;
            this.postCombo.Location = new System.Drawing.Point(459, 50);
            this.postCombo.Name = "postCombo";
            this.postCombo.Size = new System.Drawing.Size(121, 21);
            this.postCombo.TabIndex = 3;
            // 
            // depCombo
            // 
            this.depCombo.FormattingEnabled = true;
            this.depCombo.Location = new System.Drawing.Point(243, 46);
            this.depCombo.Name = "depCombo";
            this.depCombo.Size = new System.Drawing.Size(121, 21);
            this.depCombo.TabIndex = 2;
            // 
            // statusCombo
            // 
            this.statusCombo.FormattingEnabled = true;
            this.statusCombo.Location = new System.Drawing.Point(57, 46);
            this.statusCombo.Name = "statusCombo";
            this.statusCombo.Size = new System.Drawing.Size(121, 21);
            this.statusCombo.TabIndex = 1;
            // 
            // employeesGrid
            // 
            this.employeesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.employeesGrid.Location = new System.Drawing.Point(3, 158);
            this.employeesGrid.Name = "employeesGrid";
            this.employeesGrid.Size = new System.Drawing.Size(786, 263);
            this.employeesGrid.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.getStatsButton);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.endDate);
            this.tabPage2.Controls.Add(this.startDate);
            this.tabPage2.Controls.Add(this.statStatusCombo);
            this.tabPage2.Controls.Add(this.statsGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Статистика";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(419, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "по";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(187, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "С";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Статус";
            // 
            // getStatsButton
            // 
            this.getStatsButton.Location = new System.Drawing.Point(390, 122);
            this.getStatsButton.Name = "getStatsButton";
            this.getStatsButton.Size = new System.Drawing.Size(75, 23);
            this.getStatsButton.TabIndex = 5;
            this.getStatsButton.Text = "Применить";
            this.getStatsButton.UseVisualStyleBackColor = true;
            this.getStatsButton.Click += new System.EventHandler(this.getStatsButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbUnemploy);
            this.groupBox1.Controls.Add(this.rbEmploy);
            this.groupBox1.Location = new System.Drawing.Point(650, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(118, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // rbUnemploy
            // 
            this.rbUnemploy.AutoSize = true;
            this.rbUnemploy.Location = new System.Drawing.Point(27, 55);
            this.rbUnemploy.Name = "rbUnemploy";
            this.rbUnemploy.Size = new System.Drawing.Size(63, 17);
            this.rbUnemploy.TabIndex = 1;
            this.rbUnemploy.TabStop = true;
            this.rbUnemploy.Text = "Уволен";
            this.rbUnemploy.UseVisualStyleBackColor = true;
            // 
            // rbEmploy
            // 
            this.rbEmploy.AutoSize = true;
            this.rbEmploy.Location = new System.Drawing.Point(27, 31);
            this.rbEmploy.Name = "rbEmploy";
            this.rbEmploy.Size = new System.Drawing.Size(56, 17);
            this.rbEmploy.TabIndex = 0;
            this.rbEmploy.TabStop = true;
            this.rbEmploy.Text = "Нанят";
            this.rbEmploy.UseVisualStyleBackColor = true;
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(444, 43);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(200, 20);
            this.endDate.TabIndex = 3;
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(207, 42);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(200, 20);
            this.startDate.TabIndex = 2;
            // 
            // statStatusCombo
            // 
            this.statStatusCombo.FormattingEnabled = true;
            this.statStatusCombo.Location = new System.Drawing.Point(52, 45);
            this.statStatusCombo.Name = "statStatusCombo";
            this.statStatusCombo.Size = new System.Drawing.Size(121, 21);
            this.statStatusCombo.TabIndex = 1;
            // 
            // statsGrid
            // 
            this.statsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statsGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statsGrid.Location = new System.Drawing.Point(3, 181);
            this.statsGrid.Name = "statsGrid";
            this.statsGrid.Size = new System.Drawing.Size(786, 240);
            this.statsGrid.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesGrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView employeesGrid;
        private System.Windows.Forms.ComboBox statusCombo;
        private System.Windows.Forms.ComboBox depCombo;
        private System.Windows.Forms.ComboBox postCombo;
        private System.Windows.Forms.TextBox lastNameFilter;
        private System.Windows.Forms.ComboBox sortFieldCombo;
        private System.Windows.Forms.ComboBox sortDirCombo;
        private System.Windows.Forms.Button applyFilterButton;
        private System.Windows.Forms.DataGridView statsGrid;
        private System.Windows.Forms.ComboBox statStatusCombo;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbEmploy;
        private System.Windows.Forms.RadioButton rbUnemploy;
        private System.Windows.Forms.Button getStatsButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}

