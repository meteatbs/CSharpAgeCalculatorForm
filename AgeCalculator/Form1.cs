using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeCalculator
{
    public partial class dtpCurrentDate : Form
    {
        public dtpCurrentDate()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if(dtpCurrendate.Value < dtpDOB.Value)
                {
                    MessageBox.Show("Current Date must be greater than DOB");
                }
                int Age = dtpCurrendate.Value.Year - dtpDOB.Value.Year;
                //if add DOB+Age < Current Date
                if (dtpDOB.Value.AddYears(Age) > dtpCurrendate.Value)
                {
                    Age--;
                    lblAge.Text = "Your Age : " + Age.ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error Message");
            }
        }
    }
}
