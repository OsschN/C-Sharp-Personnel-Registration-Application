
namespace Personnel_Registration_Application
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.TxtPerJob = new System.Windows.Forms.TextBox();
            this.MaskWage = new System.Windows.Forms.MaskedTextBox();
            this.CmbCity = new System.Windows.Forms.ComboBox();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtPerİd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnChart = new System.Windows.Forms.Button();
            this.BtnStatistics = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnList = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.perİdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perWageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perStatusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.perJobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPersonnelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pERSONEL_VERİTABANIDataSet = new Personnel_Registration_Application.PERSONEL_VERİTABANIDataSet();
            this.tbl_PersonnelTableAdapter = new Personnel_Registration_Application.PERSONEL_VERİTABANIDataSetTableAdapters.Tbl_PersonnelTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonnelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONEL_VERİTABANIDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.TxtPerJob);
            this.groupBox1.Controls.Add(this.MaskWage);
            this.groupBox1.Controls.Add(this.CmbCity);
            this.groupBox1.Controls.Add(this.TxtSurname);
            this.groupBox1.Controls.Add(this.TxtName);
            this.groupBox1.Controls.Add(this.TxtPerİd);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 493);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personnel Registration";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(359, 290);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(102, 36);
            this.radioButton2.TabIndex = 16;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Single";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(234, 290);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(119, 36);
            this.radioButton1.TabIndex = 15;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Married";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // TxtPerJob
            // 
            this.TxtPerJob.Location = new System.Drawing.Point(253, 343);
            this.TxtPerJob.Name = "TxtPerJob";
            this.TxtPerJob.Size = new System.Drawing.Size(208, 38);
            this.TxtPerJob.TabIndex = 14;
            // 
            // MaskWage
            // 
            this.MaskWage.Location = new System.Drawing.Point(253, 228);
            this.MaskWage.Name = "MaskWage";
            this.MaskWage.Size = new System.Drawing.Size(208, 38);
            this.MaskWage.TabIndex = 11;
            // 
            // CmbCity
            // 
            this.CmbCity.FormattingEnabled = true;
            this.CmbCity.Location = new System.Drawing.Point(253, 181);
            this.CmbCity.Name = "CmbCity";
            this.CmbCity.Size = new System.Drawing.Size(208, 39);
            this.CmbCity.TabIndex = 10;
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(253, 135);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(208, 38);
            this.TxtSurname.TabIndex = 9;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(253, 87);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(208, 38);
            this.TxtName.TabIndex = 8;
            // 
            // TxtPerİd
            // 
            this.TxtPerİd.Location = new System.Drawing.Point(253, 42);
            this.TxtPerİd.Name = "TxtPerİd";
            this.TxtPerİd.Size = new System.Drawing.Size(208, 38);
            this.TxtPerİd.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 32);
            this.label7.TabIndex = 6;
            this.label7.Text = "Personnel Job:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "Personnel Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Personnel Wage:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Personnel City:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Personnel Surname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Personnel Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personnel İd:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnChart);
            this.groupBox2.Controls.Add(this.BtnStatistics);
            this.groupBox2.Controls.Add(this.BtnClear);
            this.groupBox2.Controls.Add(this.BtnUpdate);
            this.groupBox2.Controls.Add(this.BtnDelete);
            this.groupBox2.Controls.Add(this.BtnSave);
            this.groupBox2.Controls.Add(this.BtnList);
            this.groupBox2.Location = new System.Drawing.Point(615, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 501);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Process";
            // 
            // BtnChart
            // 
            this.BtnChart.Location = new System.Drawing.Point(45, 434);
            this.BtnChart.Name = "BtnChart";
            this.BtnChart.Size = new System.Drawing.Size(217, 59);
            this.BtnChart.TabIndex = 6;
            this.BtnChart.Text = "Chart";
            this.BtnChart.UseVisualStyleBackColor = true;
            this.BtnChart.Click += new System.EventHandler(this.BtnChart_Click);
            // 
            // BtnStatistics
            // 
            this.BtnStatistics.Location = new System.Drawing.Point(45, 370);
            this.BtnStatistics.Name = "BtnStatistics";
            this.BtnStatistics.Size = new System.Drawing.Size(217, 59);
            this.BtnStatistics.TabIndex = 5;
            this.BtnStatistics.Text = "Statistics";
            this.BtnStatistics.UseVisualStyleBackColor = true;
            this.BtnStatistics.Click += new System.EventHandler(this.BtnStatistics_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(45, 305);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(217, 59);
            this.BtnClear.TabIndex = 4;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(45, 240);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(217, 59);
            this.BtnUpdate.TabIndex = 3;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(45, 175);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(217, 59);
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(45, 110);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(217, 59);
            this.BtnSave.TabIndex = 1;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnList
            // 
            this.BtnList.Location = new System.Drawing.Point(45, 45);
            this.BtnList.Name = "BtnList";
            this.BtnList.Size = new System.Drawing.Size(217, 59);
            this.BtnList.TabIndex = 0;
            this.BtnList.Text = "List";
            this.BtnList.UseVisualStyleBackColor = true;
            this.BtnList.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 511);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1004, 212);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Records";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.perİdDataGridViewTextBoxColumn,
            this.perNameDataGridViewTextBoxColumn,
            this.perSurnameDataGridViewTextBoxColumn,
            this.perCityDataGridViewTextBoxColumn,
            this.perWageDataGridViewTextBoxColumn,
            this.perStatusDataGridViewCheckBoxColumn,
            this.perJobDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPersonnelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(992, 169);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // perİdDataGridViewTextBoxColumn
            // 
            this.perİdDataGridViewTextBoxColumn.DataPropertyName = "Perİd";
            this.perİdDataGridViewTextBoxColumn.HeaderText = "Perİd";
            this.perİdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perİdDataGridViewTextBoxColumn.Name = "perİdDataGridViewTextBoxColumn";
            this.perİdDataGridViewTextBoxColumn.ReadOnly = true;
            this.perİdDataGridViewTextBoxColumn.Width = 125;
            // 
            // perNameDataGridViewTextBoxColumn
            // 
            this.perNameDataGridViewTextBoxColumn.DataPropertyName = "PerName";
            this.perNameDataGridViewTextBoxColumn.HeaderText = "PerName";
            this.perNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perNameDataGridViewTextBoxColumn.Name = "perNameDataGridViewTextBoxColumn";
            this.perNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // perSurnameDataGridViewTextBoxColumn
            // 
            this.perSurnameDataGridViewTextBoxColumn.DataPropertyName = "PerSurname";
            this.perSurnameDataGridViewTextBoxColumn.HeaderText = "PerSurname";
            this.perSurnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perSurnameDataGridViewTextBoxColumn.Name = "perSurnameDataGridViewTextBoxColumn";
            this.perSurnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // perCityDataGridViewTextBoxColumn
            // 
            this.perCityDataGridViewTextBoxColumn.DataPropertyName = "PerCity";
            this.perCityDataGridViewTextBoxColumn.HeaderText = "PerCity";
            this.perCityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perCityDataGridViewTextBoxColumn.Name = "perCityDataGridViewTextBoxColumn";
            this.perCityDataGridViewTextBoxColumn.Width = 125;
            // 
            // perWageDataGridViewTextBoxColumn
            // 
            this.perWageDataGridViewTextBoxColumn.DataPropertyName = "PerWage";
            this.perWageDataGridViewTextBoxColumn.HeaderText = "PerWage";
            this.perWageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perWageDataGridViewTextBoxColumn.Name = "perWageDataGridViewTextBoxColumn";
            this.perWageDataGridViewTextBoxColumn.Width = 125;
            // 
            // perStatusDataGridViewCheckBoxColumn
            // 
            this.perStatusDataGridViewCheckBoxColumn.DataPropertyName = "PerStatus";
            this.perStatusDataGridViewCheckBoxColumn.HeaderText = "PerStatus";
            this.perStatusDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.perStatusDataGridViewCheckBoxColumn.Name = "perStatusDataGridViewCheckBoxColumn";
            this.perStatusDataGridViewCheckBoxColumn.Width = 125;
            // 
            // perJobDataGridViewTextBoxColumn
            // 
            this.perJobDataGridViewTextBoxColumn.DataPropertyName = "PerJob";
            this.perJobDataGridViewTextBoxColumn.HeaderText = "PerJob";
            this.perJobDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perJobDataGridViewTextBoxColumn.Name = "perJobDataGridViewTextBoxColumn";
            this.perJobDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblPersonnelBindingSource
            // 
            this.tblPersonnelBindingSource.DataMember = "Tbl_Personnel";
            this.tblPersonnelBindingSource.DataSource = this.pERSONEL_VERİTABANIDataSet;
            // 
            // pERSONEL_VERİTABANIDataSet
            // 
            this.pERSONEL_VERİTABANIDataSet.DataSetName = "PERSONEL_VERİTABANIDataSet";
            this.pERSONEL_VERİTABANIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_PersonnelTableAdapter
            // 
            this.tbl_PersonnelTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(966, 460);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 32);
            this.label8.TabIndex = 3;
            this.label8.Visible = false;
            this.label8.TextChanged += new System.EventHandler(this.label8_TextChanged);
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 52);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1070, 735);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonnelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONEL_VERİTABANIDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtPerJob;
        private System.Windows.Forms.MaskedTextBox MaskWage;
        private System.Windows.Forms.ComboBox CmbCity;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtPerİd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnChart;
        private System.Windows.Forms.Button BtnStatistics;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnList;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PERSONEL_VERİTABANIDataSet pERSONEL_VERİTABANIDataSet;
        private System.Windows.Forms.BindingSource tblPersonnelBindingSource;
        private PERSONEL_VERİTABANIDataSetTableAdapters.Tbl_PersonnelTableAdapter tbl_PersonnelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn perİdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perWageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn perStatusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perJobDataGridViewTextBoxColumn;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}

