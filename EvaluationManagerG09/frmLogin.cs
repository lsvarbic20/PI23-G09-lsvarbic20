﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluationManagerG09 {
    public partial class frmLogin : System.Windows.Forms.Form {
        public frmLogin() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void btnLogin_Click(object sender, EventArgs e) {
            if(txtUsername.Text == "") {
                MessageBox.Show("Korisničko ime nije uneseno", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
