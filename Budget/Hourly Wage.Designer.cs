namespace Budget
{
    partial class Hourly_Wage
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
            this.txtHourlyWageEdit = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtHourlyWageEdit
            // 
            this.txtHourlyWageEdit.Location = new System.Drawing.Point(13, 13);
            this.txtHourlyWageEdit.Name = "txtHourlyWageEdit";
            this.txtHourlyWageEdit.Size = new System.Drawing.Size(131, 20);
            this.txtHourlyWageEdit.TabIndex = 1;
            this.txtHourlyWageEdit.Text = "Enter New Hourly Wage";
            this.txtHourlyWageEdit.Click += new System.EventHandler(this.txtHourlyWageEdit_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(34, 39);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "&Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // Hourly_Wage
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(153, 68);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtHourlyWageEdit);
            this.Name = "Hourly_Wage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hourly_Wage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHourlyWageEdit;
        private System.Windows.Forms.Button btnEnter;
    }
}