﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook
{
    public partial class ContactViewer : Form
    {
        public ContactViewer(Contact toView)
        {
            InitializeComponent();
            this.Text = toView.FirstName + " " + toView.LastName;
        }

        private void ContactViewer_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)//Closes the contact view window
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
