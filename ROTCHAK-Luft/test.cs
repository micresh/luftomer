using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ROTCHAK_Luft
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void btncheck_Click(object sender, EventArgs e)
        {
            //string s1, s2;
            //s1 = comboBox1.SelectedItem.ToString();
            //s2 = comboBox2.SelectedItem.ToString();
            //if (s1 == "Подключен" && s2 == "Подключен")
            //{
            //    btnfor.Enabled = true;
            //}
            //string[] ports = sensors.PortList();
            //for (int i = 0; i < ports.Length; i++)
            //{
            //    listBox1.Items.Add(ports[i]);
            //}
          //  textBox6.Text = sensors.GetBPPportname();
        }

        private void btnfor_Click(object sender, EventArgs e)
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
            databaseop.WriteData("1.xml", "1521531","15.23",Convert.ToString(number+1));
          
        }
    }
}
