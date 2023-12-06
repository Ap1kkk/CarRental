namespace CarRental
{
    partial class DeleteSalonForm
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
            this.DeleteShop = new System.Windows.Forms.Button();
            this.txtBoxDeleteNameShop = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DeleteShop
            // 
            this.DeleteShop.AllowDrop = true;
            this.DeleteShop.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.DeleteShop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteShop.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DeleteShop.Location = new System.Drawing.Point(162, 57);
            this.DeleteShop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteShop.Name = "DeleteShop";
            this.DeleteShop.Size = new System.Drawing.Size(106, 31);
            this.DeleteShop.TabIndex = 14;
            this.DeleteShop.Text = "Удалить";
            this.DeleteShop.UseVisualStyleBackColor = true;
            this.DeleteShop.Click += new System.EventHandler(this.DeleteShop_Click);
            // 
            // txtBoxDeleteNameShop
            // 
            this.txtBoxDeleteNameShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxDeleteNameShop.Location = new System.Drawing.Point(175, 11);
            this.txtBoxDeleteNameShop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxDeleteNameShop.Name = "txtBoxDeleteNameShop";
            this.txtBoxDeleteNameShop.Size = new System.Drawing.Size(255, 26);
            this.txtBoxDeleteNameShop.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(20, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Название магазина:";
            // 
            // DeleteSalonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 99);
            this.Controls.Add(this.DeleteShop);
            this.Controls.Add(this.txtBoxDeleteNameShop);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DeleteSalonForm";
            this.Text = "DeleteShopForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteShop;
        private System.Windows.Forms.TextBox txtBoxDeleteNameShop;
        private System.Windows.Forms.Label label1;
    }
}