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
    public partial class Personel : Form
    {
        public Personel()
        {
            InitializeComponent();
        }

        private void buttonPersonel_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text== "Administrative Personel")
            {
                AdministrativePersonel a = new AdministrativePersonel();
                MartialStatue selectedStatue = (MartialStatue)Enum.Parse(typeof(MartialStatue), comboBox2.SelectedItem.ToString());
                a.postData(selectedStatue, Convert.ToInt16(textBox_numberOfChild.Text), Convert.ToInt16(textBox_step.Text), Convert.ToInt16(textBox_degree.Text));
                a.Show();

            }

            if(comboBox1.Text== "Academic Personel")
            {
                AcademicPersonel b = new AcademicPersonel();
                MartialStatue selectedStatue = (MartialStatue)Enum.Parse(typeof(MartialStatue), comboBox2.SelectedItem.ToString());
                b.postData(selectedStatue, Convert.ToInt16(textBox_numberOfChild.Text), Convert.ToInt16(textBox_step.Text), Convert.ToInt16(textBox_degree.Text));
                b.Show();
            }
        }
    }
}
