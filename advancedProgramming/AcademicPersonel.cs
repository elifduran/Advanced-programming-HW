using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace advancedProgramming
{
    public partial class AcademicPersonel : Form
    {
        MartialStatue martialStatue;
        int numberOfChild;
        int step;
        int degree;

        public void postData(MartialStatue martialStatue, int numberOfChild, int step, int degree)
        {
            this.martialStatue = martialStatue;
            this.numberOfChild = numberOfChild;
            this.step = step;
            this.degree = degree;

        }

        public AcademicPersonel()
        {
            InitializeComponent();
        }

        private void button_AcademiCalculate_Click(object sender, EventArgs e)
        {
            Academic_Personel ap = new Academic_Personel();
            ap.coefficient= Convert.ToInt16(textBox_academicCoefficient.Text);
            label1.Text = ap.PersonelGroup();
            label2.Text = ap.CalculateSalary(martialStatue, numberOfChild, step, degree).ToString();
        }
    }
}
