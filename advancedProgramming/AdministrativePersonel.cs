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
    public partial class AdministrativePersonel : Form
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

        public AdministrativePersonel()
        {
            InitializeComponent();
        }

        private void button_AdministrativeCalculate_Click(object sender, EventArgs e)
        {
            Administrative_Personel ap = new Administrative_Personel();
            ap.hasadmin = checkBox1.Checked;
            label1.Text = ap.PersonelGroup();
            label2.Text = ap.CalculateSalary(martialStatue, numberOfChild, step, degree).ToString();

        }

    }
}
