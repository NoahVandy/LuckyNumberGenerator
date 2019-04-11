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
    public partial class LuckyNumberGenerator : Form
    {

        //List<String> years = new List<String>();
        int[] years = new int[120];
        String[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        int[] days31 = new int[31];
        int[] days30 = new int[30];
        int[] days29 = new int[29];

        String[] colors = { "Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Violet" };

        public LuckyNumberGenerator()
        {
            InitializeComponent();

            for (int i = 0; i < 120; i++)
            {
                years[i] = i + 1900;
            }

            this.cmbbx_year.DataSource = years;

            this.cmbbx_month.DataSource = months;

            this.cmbbx_color.DataSource = colors;



        }

        private void cmbbx_month_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbbx_month.SelectedIndex == 0 || this.cmbbx_month.SelectedIndex == 2 || this.cmbbx_month.SelectedIndex == 4 || this.cmbbx_month.SelectedIndex == 6 || this.cmbbx_month.SelectedIndex == 7 || this.cmbbx_month.SelectedIndex == 9 || this.cmbbx_month.SelectedIndex == 11 )
            {
                for (int i = 0; i < days31.Length; i++)
                {
                    days31[i] = i + 1;
                }
                this.cmbbx_date.DataSource = days31;
            }
            else if (this.cmbbx_month.SelectedIndex == 3 || this.cmbbx_month.SelectedIndex == 5 || this.cmbbx_month.SelectedIndex == 8 || this.cmbbx_month.SelectedIndex == 10) 
            {
                for (int i = 0; i < days30.Length; i++)
                {
                    days30[i] = i + 1;
                }
                this.cmbbx_date.DataSource = days30;
            }
            else if (this.cmbbx_month.SelectedIndex == 1)
            {
                for (int i = 0; i < days29.Length; i++)
                {
                    days29[i] = i + 1;
                }
                this.cmbbx_date.DataSource = days29;
            }
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            int year = cmbbx_year.SelectedIndex + 1;
            int month = cmbbx_month.SelectedIndex + 1;
            int day = cmbbx_date.SelectedIndex + 1;
            int color = cmbbx_color.SelectedIndex + 1;

            int luckyNum = (year + month + (day * color)) % 19;
            luckyNumber luckyNumberForm = new luckyNumber(luckyNum);
            luckyNumberForm.ShowDialog();


        }



        
    }

}
