using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DamaTaxtasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[,] buttons = new Button[8, 8];
            int _top = 10;
            int _left = 10;
            string btnName = "btn";
            for (int i = 0; i <= buttons.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Name = btnName + i;
                    buttons[i, j].Top = _top;
                    buttons[i, j].Left = _left;
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    if ((i + j) % 2 == 1)
                    {
                        buttons[i, j].BackColor = Color.White;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    this.Controls.Add(buttons[i, j]);
                    _left += 50;
                }
                _left = 10;
                _top += 50;
            }
        }
    }
}
