namespace advancedProgramming
{
    partial class AcademicPersonel
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
            this.textBox_academicCoefficient = new System.Windows.Forms.TextBox();
            this.button_AcademiCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salary";
            // 
            // textBox_academicCoefficient
            // 
            this.textBox_academicCoefficient.Location = new System.Drawing.Point(86, 90);
            this.textBox_academicCoefficient.Name = "textBox_academicCoefficient";
            this.textBox_academicCoefficient.Size = new System.Drawing.Size(100, 20);
            this.textBox_academicCoefficient.TabIndex = 2;
            // 
            // button_AcademiCalculate
            // 
            this.button_AcademiCalculate.Location = new System.Drawing.Point(86, 165);
            this.button_AcademiCalculate.Name = "button_AcademiCalculate";
            this.button_AcademiCalculate.Size = new System.Drawing.Size(100, 23);
            this.button_AcademiCalculate.TabIndex = 3;
            this.button_AcademiCalculate.Text = "Calculate";
            this.button_AcademiCalculate.UseVisualStyleBackColor = true;
            this.button_AcademiCalculate.Click += new System.EventHandler(this.button_AcademiCalculate_Click);
            // 
            // AcademicPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_AcademiCalculate);
            this.Controls.Add(this.textBox_academicCoefficient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AcademicPersonel";
            this.Text = "AcademicPersonel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_academicCoefficient;
        private System.Windows.Forms.Button button_AcademiCalculate;
    }
}