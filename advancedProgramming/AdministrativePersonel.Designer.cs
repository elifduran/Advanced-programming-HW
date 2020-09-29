namespace advancedProgramming
{
    partial class AdministrativePersonel
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_AdministrativeCalculate = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salary";
            // 
            // button_AdministrativeCalculate
            // 
            this.button_AdministrativeCalculate.Location = new System.Drawing.Point(98, 88);
            this.button_AdministrativeCalculate.Name = "button_AdministrativeCalculate";
            this.button_AdministrativeCalculate.Size = new System.Drawing.Size(256, 23);
            this.button_AdministrativeCalculate.TabIndex = 2;
            this.button_AdministrativeCalculate.Text = "Calculate";
            this.button_AdministrativeCalculate.UseVisualStyleBackColor = true;
            this.button_AdministrativeCalculate.Click += new System.EventHandler(this.button_AdministrativeCalculate_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(300, 38);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(54, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "admin";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // AdministrativePersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 380);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button_AdministrativeCalculate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdministrativePersonel";
            this.Text = "AdministrativePersonel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_AdministrativeCalculate;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}