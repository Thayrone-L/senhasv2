﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static senhasv2.DAL.LoginDALcomandos;

namespace senhasv2.Apresentacao
{
    public partial class f_Principal : Form
    {
        public f_Principal()
        {
            InitializeComponent();
            label2.Text = " Bem vindo " + Dadosdelogin.nomeUsuario + "!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
