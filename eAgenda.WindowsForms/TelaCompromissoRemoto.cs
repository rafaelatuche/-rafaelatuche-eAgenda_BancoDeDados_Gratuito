﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WindowsForms
{
    public partial class TelaCompromissoRemoto : Form
    {
        public TelaCompromissoRemoto()
        {
            InitializeComponent();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btOk_Click(object sender, EventArgs e)
        {

        }
    }
}