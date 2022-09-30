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

namespace MineSweeper
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Play(object sender, EventArgs e)
        {
            int row=0, col=0,mines = 0;//row*col >=18, mines <= row*col/2
            String text = "";
            Form2 f = null;
            if (easy.Checked || easyMenu.Pressed)
            {
                row = col = 9;
                mines = 10;
                text = "Easy - " + textBox2.Text;
            }
            else if (medium.Checked || mediumMenu.Pressed)
            {
                row = col = 16;
                mines = 40;
                text = "Medium - " + textBox2.Text;
            }
            else if (expert.Checked || expertMenu.Pressed)
            {
                row = 30;
                col = 16;
                mines = 99;
                text = "Expert - " + textBox2.Text;
            }
            else if (custom.Checked)
            {
                Form3 c = new Form3();
                c.Owner = this;
                c.ShowDialog();
                if (c.DialogResult == DialogResult.Cancel)
                {
                    this.Close();
                }
                else
                {
                    row = Int32.Parse(c.row.Text);
                    col = Int32.Parse(c.col.Text);
                    mines = Int32.Parse(c.mines.Text);
                    text = "Custom - " + textBox2.Text;
                }            
                   
            }
            else
                return;
            if (row > 0 && col > 0 && mines > 0)
            {
                int size = Math.Min(30, 1000 / Math.Max(row, col));
                f = new Form2(text, row, col, size, mines);
                f.Show(this);
                textBox1.Text = this.OwnedForms.Length.ToString();
                if(custom.Checked)
                    textBox1.Text = (this.OwnedForms.Length - 1).ToString();
            }
        }

        private void Close(object sender, EventArgs e)
        {
            foreach(Form f in this.OwnedForms)
            {
                f.Close();
                textBox1.Text = this.OwnedForms.Length.ToString();
            }

        }

        private void exitMenuClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
