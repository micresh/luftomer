using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ROTCHAK_Luft
{
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btntest_Click(object sender, EventArgs e)
        {
            
        }

        private void btnpref_Click(object sender, EventArgs e)
        {
            Form f1 = new preferences();
            f1.Show();
        }

        private void btndbstart_Click(object sender, EventArgs e)
        {
            Form f1 = new database();
            f1.Show();
        }

        private void btntest_Click_1(object sender, EventArgs e)
        {
            test newMDichild = new test();
            newMDichild.MdiParent = this;
            newMDichild.Show();
        }

        private void btnexit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnpref_Click_1(object sender, EventArgs e)
        {
            preferences newMDichild = new preferences();
            newMDichild.MdiParent = this;
            newMDichild.Show();
        }

        private void btndb_Click(object sender, EventArgs e)
        {
            database newMDIchild = new database();
            newMDIchild.MdiParent = this;
            newMDIchild.Show();
        }

        

        
    }
}
