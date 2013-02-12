using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;


namespace ROTCHAK_Luft
{
    public partial class database : Form
    {
        public database()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        
        }

        private void btncheck_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                btnsave.Enabled = true;

            }
            else
            {
                MessageBox.Show("Введены не все данные", "Ошибка");
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            DataSet data = new DataSet();
            if (!File.Exists("1.xml"))
            {
                databaseop.CreateXMLDocument("1.xml");
            }
            data.ReadXml("1.xml");

            int number;
            if (data.Tables.Count != 0)
            {
                int z = data.Tables[0].Rows.Count;
                number = Convert.ToInt32(data.Tables[0].Rows[z - 1].ItemArray[0]);
            }
            else
            {
                number = 0;
            }
            databaseop.WriteData("1.xml",Convert.ToString(number + 1),textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            btnsave.Enabled = false;
            DataSet data1 = new DataSet();
            //data.Tables[0].NewRow = la[1];
            data1.ReadXml("1.xml");
            dataGridView1.DataSource = data1.Tables[0];
            dataGridView1.Update();
        }

        private void database_Load(object sender, EventArgs e)
        {
            DataSet data1 = new DataSet();
            //data.Tables[0].NewRow = la[1];
            data1.ReadXml("1.xml");
            dataGridView1.DataSource = data1.Tables[0];
            dataGridView1.Update();
        }
    }
}
