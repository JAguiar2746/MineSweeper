using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MineSweeper
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            int rowVal = Int32.Parse(row.Text);
            int colVal = Int32.Parse(col.Text);
            int minesVal = Int32.Parse(mines.Text);
            if (rowVal * colVal < 18 || minesVal > rowVal * colVal / 2 || rowVal <= 0 || colVal <= 0 || minesVal <= 0)
                MessageBox.Show("Invalid values...Please try again");
            else
            {                          
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
