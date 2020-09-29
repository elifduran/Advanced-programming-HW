namespace advancedProgramming
{
    partial class Personel
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox_numberOfChild = new System.Windows.Forms.TextBox();
            this.textBox_step = new System.Windows.Forms.TextBox();
            this.textBox_degree = new System.Windows.Forms.TextBox();
            this.buttonPersonel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Academic Personel",
            "Administrative Personel"});
            this.comboBox1.Location = new System.Drawing.Point(67, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Single",
            "Married"});
            this.comboBox2.Location = new System.Drawing.Point(67, 73);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // textBox_numberOfChild
            // 
            this.textBox_numberOfChild.Location = new System.Drawing.Point(67, 119);
            this.textBox_numberOfChild.Name = "textBox_numberOfChild";
            this.textBox_numberOfChild.Size = new System.Drawing.Size(121, 20);
            this.textBox_numberOfChild.TabIndex = 2;
            // 
            // textBox_step
            // 
            this.textBox_step.Location = new System.Drawing.Point(67, 162);
            this.textBox_step.Name = "textBox_step";
            this.textBox_step.Size = new System.Drawing.Size(121, 20);
            this.textBox_step.TabIndex = 3;
            // 
            // textBox_degree
            // 
            this.textBox_degree.Location = new System.Drawing.Point(67, 207);
            this.textBox_degree.Name = "textBox_degree";
            this.textBox_degree.Size = new System.Drawing.Size(121, 20);
            this.textBox_degree.TabIndex = 4;
            // 
            // buttonPersonel
            // 
            this.buttonPersonel.Location = new System.Drawing.Point(67, 263);
            this.buttonPersonel.Name = "buttonPersonel";
            this.buttonPersonel.Size = new System.Drawing.Size(121, 23);
            this.buttonPersonel.TabIndex = 5;
            this.buttonPersonel.Text = "redirect";
            this.buttonPersonel.UseVisualStyleBackColor = true;
            this.buttonPersonel.Click += new System.EventHandler(this.buttonPersonel_Click);
            // 
            // Personel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonPersonel);
            this.Controls.Add(this.textBox_degree);
            this.Controls.Add(this.textBox_step);
            this.Controls.Add(this.textBox_numberOfChild);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "Personel";
            this.Text = "Personel_";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox_numberOfChild;
        private System.Windows.Forms.TextBox textBox_step;
        private System.Windows.Forms.TextBox textBox_degree;
        private System.Windows.Forms.Button buttonPersonel;
    }
}