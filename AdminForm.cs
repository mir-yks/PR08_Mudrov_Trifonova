﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR08_Mudrov_Trifonova
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditProduct editProduct = new EditProduct();
            editProduct.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditProduct editProduct = new EditProduct();
            editProduct.ShowDialog();
        }
    }
}
