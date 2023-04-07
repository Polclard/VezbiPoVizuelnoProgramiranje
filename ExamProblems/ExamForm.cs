using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamProblems
{
    public partial class ExamForm : Form
    {
        public ExamForm()
        {
            InitializeComponent();
        }

        ErrorProvider monthNotSelectedError = new ErrorProvider();

        private void numericUpDownYear_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1Month_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1Month.Text == "" || comboBox1Month.Text == " ")
            {
                monthNotSelectedError.SetError(comboBox1Month, "Селектирај месец!");
            }
            else
            {
                monthNotSelectedError.SetError(comboBox1Month, null);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBox1Month.Text != "" && numericUpDownYear.Value > 1900)
            {
                Form1.exam = new Exam(comboBox1Month.Text, (int)numericUpDownYear.Value, new Exercise("",0), new Exercise("",0));
                this.Close();
            }
        }
    }
}
