using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnintegers_Click(object sender, EventArgs e)
        {
            float firsNumber;
            float secondNumber;
            float floatAnswer;
            firsNumber = 10.4F;
            secondNumber = 11.2F;
            floatAnswer = firsNumber + secondNumber;
            MessageBox.Show(floatAnswer.ToString());
        }
    }
}
