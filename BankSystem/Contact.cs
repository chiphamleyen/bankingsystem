﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class Contact : Form
    {
        public Contact()
        {
            InitializeComponent();
        }

        private void send_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Message Has Been Sent Successfully", "Thank You!");
            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
