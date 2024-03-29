﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(String text, int row, int col, int size, int mines) : this()
        {
            this.Text = text;
            textBox1.Text = mines.ToString();
            field = new Field(row, col, mines);
            this.ClientSize = new Size(row * size, col * size + 50);
            buttons = new Button[row][];
            for (int i = 0; i < row; i++)
                buttons[i] = new Button[col];
            foreach (int i in Enumerable.Range(0, row))
                foreach (int j in Enumerable.Range(0, col))
                {
                    buttons[i][j] = new Button();
                    buttons[i][j].Text = "";
                    buttons[i][j].BackColor = Color.White;
                    buttons[i][j].Name = i + "," + j;
                    buttons[i][j].Size = new Size(size, size);
                    buttons[i][j].Location = new Point(size * i, size * j + 50);
                    buttons[i][j].UseVisualStyleBackColor = false;
                    buttons[i][j].MouseUp += new MouseEventHandler(Button_Click);
                    this.Controls.Add(buttons[i][j]);
                }
        }
        private void Button_Click(object sender, MouseEventArgs e)
        {
            Button b = (Button)sender;
            int temp = b.Name.IndexOf(",");
            int click_x = Int16.Parse(b.Name.Substring(0, temp));
            int click_y = Int16.Parse(b.Name.Substring(temp + 1));
            switch (e.Button)
            {
                case MouseButtons.Left:
                    // Left click
                    if (!this.field.Started)
                    {
                        this.field.Initialize(click_x, click_y);
                        timer1.Start();
                    }
                    int n = this.field.CountMines(click_x, click_y);
                    if (this.field.IsMine(click_x, click_y))
                    {
                        b.BackColor = Color.Red;
                        MessageBox.Show("Game Over! You clicked on a mine!");
                        timer1.Stop();
                        break;
                    }
                    if (this.field.Discovered.Contains(click_x * buttons[0].Length + click_y))
                        break;
                    foreach (int k in this.field.GetSafeIsland(click_x, click_y))
                    {
                        int i = k / buttons[0].Length;
                        int j = k % buttons[0].Length;
                        buttons[i][j].BackColor = Color.LightGray;
                        int m = this.field.CountMines(i, j);
                        if (m > 0)
                        {
                            buttons[i][j].Text = m + "";
                            buttons[i][j].Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                            buttons[i][j].BackColor = Color.LightGray;
                            if (m == 1)
                            {
                                buttons[i][j].ForeColor = Color.Blue;
                            }
                            else if (m == 2)
                            {
                                buttons[i][j].ForeColor = Color.Green;
                            }
                            else if (m == 3)
                            {
                                buttons[i][j].ForeColor = Color.Red;
                            }
                            else if (m == 4)
                            {
                                buttons[i][j].ForeColor = Color.DarkBlue;
                            }
                            else if (m == 5)
                            {
                                buttons[i][j].ForeColor = Color.Maroon;
                            }
                            else
                            {
                                buttons[i][j].ForeColor = Color.DarkRed;
                            }
                        }
                        else
                            buttons[i][j].Enabled = false;
                    }
                    if (field.Win())
                    {                        
                        MessageBox.Show("Congratulations! You discovered all safe squares in " + textBox2.Text + " seconds!");
                        timer1.Stop();
                    }
                    break;
                case MouseButtons.Right:
                    // Right click
                    if (this.field.Discovered.Contains(click_x * buttons[0].Length + click_y))
                        break;
                    if (field.Flagged.Contains(click_x * buttons[0].Length + click_y))
                    {
                        b.BackColor = Color.White;
                        field.Flagged.Remove(click_x * buttons[0].Length + click_y);
                        textBox1.Text = (Int32.Parse(textBox1.Text) + 1).ToString();
                    }
                    else
                    {
                        b.BackColor = Color.Yellow;
                        field.Flagged.Add(click_x * buttons[0].Length + click_y);
                        textBox1.Text = (Int32.Parse(textBox1.Text) - 1).ToString();

                    }  
                    break;
                case MouseButtons.Middle:
                    if (!this.field.Discovered.Contains(click_x * buttons[0].Length + click_y))
                        break;
                    int Flagged_Count = 0;
                    foreach (int k in this.field.GetNeighbors(click_x, click_y))
                        if (field.Flagged.Contains(k))
                            Flagged_Count++;
                    if (this.field.CountMines(click_x, click_y) != Flagged_Count)
                        break;
                    foreach (int k in this.field.GetNeighbors(click_x, click_y))
                    {
                        if (field.Flagged.Contains(k) || field.Discovered.Contains(k))
                            continue;
                        if (this.field.IsMine(k / buttons[0].Length, k % buttons[0].Length))
                        {
                            b.BackColor = Color.Red;
                            MessageBox.Show("Game Over! You clicked on a mine!");
                            timer1.Stop();
                            break;
                        }
                        foreach (int l in this.field.GetSafeIsland(k / buttons[0].Length, k % buttons[0].Length))
                        {
                            int i = l / buttons[0].Length;
                            int j = l % buttons[0].Length;
                            buttons[i][j].BackColor = Color.LightGray;
                            int m = this.field.CountMines(i, j);
                            if (m > 0)
                            {
                                buttons[i][j].Text = m + "";
                                buttons[i][j].Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                                buttons[i][j].BackColor = Color.LightGray;
                                if (m == 1)
                                {
                                    buttons[i][j].ForeColor = Color.Blue;
                                }
                                else if (m == 2)
                                {
                                    buttons[i][j].ForeColor = Color.Green;
                                }
                                else if (m == 3)
                                {
                                    buttons[i][j].ForeColor = Color.Red;
                                }
                                else if (m == 4)
                                {
                                    buttons[i][j].ForeColor = Color.DarkBlue;
                                }
                                else if (m == 5)
                                {
                                    buttons[i][j].ForeColor = Color.Maroon;
                                }
                            }
                            else
                                buttons[i][j].Enabled = false;
                        }
                        if (field.Win())
                        {                            
                            MessageBox.Show("Congratulations! You discovered all safe squares in " + textBox2.Text +" seconds!");
                            timer1.Stop();
                        }
                    }
                    break;
            }
                

        }
        private Button[][] buttons;
        private Field field;

        private void timer1_Tick(object sender, EventArgs e)
        {
            int currentTime = (int)(10 * Double.Parse(textBox2.Text));
            currentTime++;
            textBox2.Text = currentTime / 10.0 +
                (currentTime % 10 == 0 ? ".0" : "");
            if (currentTime < 100)
                textBox2.Text = "0" + textBox2.Text;
            if (currentTime < 1000)
                textBox2.Text = "0" + textBox2.Text;
        }

        private void Form2_Deactivate(object sender, EventArgs e)
        {
            timer1.Stop();
        }
        private void Form2_Activated(object sender, EventArgs e)
        {
            if (this.field.Started)
                timer1.Start();
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((MainForm)this.Owner).textBox1.Text = (Int32.Parse(((MainForm)this.Owner).textBox1.Text) - 1).ToString();
            
        }
    }
}
