﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattelShip
{
    public partial class Form2_PantallaInicial : Form
    {
        public Form2_PantallaInicial()
        {
            InitializeComponent();
        }

        private void Button_Start_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Form2_PantallaInicial f2 = new Form2_PantallaInicial();
            Visible = false;
        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
