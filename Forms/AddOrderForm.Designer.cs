namespace CarRental
{
    partial class AddOrderForm
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
            this.AddOrderBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddOLineItemBtn = new System.Windows.Forms.Button();
            this.IndexTxt = new System.Windows.Forms.TextBox();
            this.descTxt = new System.Windows.Forms.TextBox();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddOrderBtn
            // 
            this.AddOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddOrderBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AddOrderBtn.Location = new System.Drawing.Point(11, 151);
            this.AddOrderBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddOrderBtn.Name = "AddOrderBtn";
            this.AddOrderBtn.Size = new System.Drawing.Size(144, 30);
            this.AddOrderBtn.TabIndex = 0;
            this.AddOrderBtn.Text = "Оформить заказ";
            this.AddOrderBtn.UseVisualStyleBackColor = true;
            this.AddOrderBtn.Click += new System.EventHandler(this.AddOrderBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Индекс заказа:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Описание к заказу:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Итоговая цена:";
            // 
            // AddOLineItemBtn
            // 
            this.AddOLineItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddOLineItemBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AddOLineItemBtn.Location = new System.Drawing.Point(341, 151);
            this.AddOLineItemBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddOLineItemBtn.Name = "AddOLineItemBtn";
            this.AddOLineItemBtn.Size = new System.Drawing.Size(207, 30);
            this.AddOLineItemBtn.TabIndex = 4;
            this.AddOLineItemBtn.Text = "Добавить автомобиль";
            this.AddOLineItemBtn.UseVisualStyleBackColor = true;
            this.AddOLineItemBtn.Click += new System.EventHandler(this.AddOLineItemBtn_Click);
            // 
            // IndexTxt
            // 
            this.IndexTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IndexTxt.Location = new System.Drawing.Point(224, 11);
            this.IndexTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IndexTxt.Name = "IndexTxt";
            this.IndexTxt.Size = new System.Drawing.Size(324, 26);
            this.IndexTxt.TabIndex = 5;
            // 
            // descTxt
            // 
            this.descTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descTxt.Location = new System.Drawing.Point(224, 54);
            this.descTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.descTxt.Name = "descTxt";
            this.descTxt.Size = new System.Drawing.Size(324, 26);
            this.descTxt.TabIndex = 6;
            // 
            // priceTxt
            // 
            this.priceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceTxt.Location = new System.Drawing.Point(224, 98);
            this.priceTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(324, 26);
            this.priceTxt.TabIndex = 7;
            // 
            // AddOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 192);
            this.Controls.Add(this.priceTxt);
            this.Controls.Add(this.descTxt);
            this.Controls.Add(this.IndexTxt);
            this.Controls.Add(this.AddOLineItemBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddOrderBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddOrderForm";
            this.Text = "Добавление заказа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddOrderBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddOLineItemBtn;
        private System.Windows.Forms.TextBox IndexTxt;
        private System.Windows.Forms.TextBox descTxt;
        private System.Windows.Forms.TextBox priceTxt;
    }
}