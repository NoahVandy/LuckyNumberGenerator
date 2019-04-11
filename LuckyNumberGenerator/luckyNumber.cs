using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuckyNumberGenerator
{
    public partial class luckyNumber : Form
    {
        public luckyNumber(int luckyNum)
        {
            InitializeComponent();
            lbl_number.Text = "Lucky Number is " + luckyNum.ToString();
        }

        private void lbl_number_Click(object sender, EventArgs e)
        {

        }
    }
}
