﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDPHomework
{
    public partial class Form2 : Form1 // Form1dan kalıtım  alındı.
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        // Çalışan bencereleri tamamen kapatmak.
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
