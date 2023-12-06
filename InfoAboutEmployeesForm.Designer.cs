﻿namespace CarRental
{
    partial class InfoAboutEmployeesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DeleteEmployeeBtn = new System.Windows.Forms.Button();
            this.AddEmployeeBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Experience = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workBegin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteEmployeeBtn
            // 
            this.DeleteEmployeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteEmployeeBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteEmployeeBtn.Location = new System.Drawing.Point(157, 446);
            this.DeleteEmployeeBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteEmployeeBtn.Name = "DeleteEmployeeBtn";
            this.DeleteEmployeeBtn.Size = new System.Drawing.Size(142, 39);
            this.DeleteEmployeeBtn.TabIndex = 4;
            this.DeleteEmployeeBtn.Text = "Удалить";
            this.DeleteEmployeeBtn.UseVisualStyleBackColor = true;
            this.DeleteEmployeeBtn.Click += new System.EventHandler(this.DeleteEmployeeBtn_Click);
            // 
            // AddEmployeeBtn
            // 
            this.AddEmployeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEmployeeBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddEmployeeBtn.Location = new System.Drawing.Point(11, 446);
            this.AddEmployeeBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddEmployeeBtn.Name = "AddEmployeeBtn";
            this.AddEmployeeBtn.Size = new System.Drawing.Size(142, 39);
            this.AddEmployeeBtn.TabIndex = 3;
            this.AddEmployeeBtn.Text = "Добавить";
            this.AddEmployeeBtn.UseVisualStyleBackColor = true;
            this.AddEmployeeBtn.Click += new System.EventHandler(this.AddEmployeeBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.PhoneNumber,
            this.Status,
            this.Experience,
            this.workBegin,
            this.workEnd});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(936, 433);
            this.dataGridView1.TabIndex = 5;
            // 
            // FirstName
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstName.DefaultCellStyle = dataGridViewCellStyle1;
            this.FirstName.HeaderText = "Имя";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.Width = 125;
            // 
            // LastName
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.LastName.DefaultCellStyle = dataGridViewCellStyle2;
            this.LastName.HeaderText = "Фамилия";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.Width = 125;
            // 
            // PhoneNumber
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.PhoneNumber.DefaultCellStyle = dataGridViewCellStyle3;
            this.PhoneNumber.HeaderText = "Телефон";
            this.PhoneNumber.MinimumWidth = 6;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Width = 125;
            // 
            // Status
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Status.DefaultCellStyle = dataGridViewCellStyle4;
            this.Status.HeaderText = "Должность";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Width = 125;
            // 
            // Experience
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Experience.DefaultCellStyle = dataGridViewCellStyle5;
            this.Experience.HeaderText = "Опыт";
            this.Experience.MinimumWidth = 6;
            this.Experience.Name = "Experience";
            this.Experience.Width = 125;
            // 
            // workBegin
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.workBegin.DefaultCellStyle = dataGridViewCellStyle6;
            this.workBegin.HeaderText = "Начало работы";
            this.workBegin.MinimumWidth = 6;
            this.workBegin.Name = "workBegin";
            this.workBegin.Width = 125;
            // 
            // workEnd
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.workEnd.DefaultCellStyle = dataGridViewCellStyle7;
            this.workEnd.HeaderText = "Конец работы";
            this.workEnd.MinimumWidth = 6;
            this.workEnd.Name = "workEnd";
            this.workEnd.Width = 125;
            // 
            // InfoAboutEmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 496);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DeleteEmployeeBtn);
            this.Controls.Add(this.AddEmployeeBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "InfoAboutEmployeesForm";
            this.Text = "InfoAboutEmployees";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DeleteEmployeeBtn;
        private System.Windows.Forms.Button AddEmployeeBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Experience;
        private System.Windows.Forms.DataGridViewTextBoxColumn workBegin;
        private System.Windows.Forms.DataGridViewTextBoxColumn workEnd;
    }
}