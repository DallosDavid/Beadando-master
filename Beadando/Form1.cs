using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beadando
{
    public partial class Form1 : Form
    {

        public string ido;

        public Form1()
        {
            InitializeComponent();
        }

      


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            int b = int.Parse(textBox2.Text);
            bool l = checkBox1.Checked ? true : false;
            listBox1.Items.Add(new Pekaru(a,b,l));
            
         }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_torol.Enabled = true;


            /*string [] ws =listBox1.SelectedItem.ToString().Split('(');
            textBox1.Text = ws[0];
            string[] ws2 = ws[1].Split(':');
            string[] ws3 = ws2[1].Split('F');
            string[] ws4 = ws3[1].Split('/');
            textBox2.Text = ws3[0];*/


        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            Pakseg pek = (Pakseg)listBox2.SelectedItem;
            if (pek != null)
            {
                for (int i = 0; i < pek.Termekek.Count; i++)
                {
                    listBox3.Items.Add(pek.Termekek[i]);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            List<Pekaru> pekarus = new List<Pekaru>();
            Pakseg pek = new Pakseg(textBox3.Text,pekarus,DateTime.Now);
            listBox2.Items.Add(pek);
            listBox4.Items.Clear();
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                listBox4.Items.Add(listBox2.Items[i]);
            }
        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox4.Items.Clear();
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                listBox4.Items.Add(listBox2.Items[i]);
            }

        }




        private void button3_Click(object sender, EventArgs e)
        {

            Pakseg pekseg = (Pakseg)listBox2.SelectedItem;
            Pekaru pekaru = (Pekaru)listBox1.SelectedItem;
            pekseg.Termekek.Add(pekaru);
            listBox3.Items.Add(pekaru);
            
            
            /*listBox4.Items.Add(listBox2.SelectedItem.ToString());
            label1.Text = textBox3.Text+"\nAlapitva:"+ido+"";
            string[] ws = listBox1.SelectedItem.ToString().Split('(');
            textBox1.Text = ws[0];
            string[] ws2 = ws[1].Split(':');
            string[] ws3 = ws2[1].Split('/');
            textBox2.Text = ws3[0];
            if (listBox1.SelectedItem != null && listBox2.SelectedItem != null)
            {
                listBox3.Items.Add(ws[0] + " (" + ws3[0]+"Ft/db)");
            }
            else {
                MessageBox.Show("Kérem jelöljön ki mind 2 listából!" );
            }*/
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

            Pakseg pekarseg = (Pakseg)listBox4.SelectedItem;
            label1.Text = pekarseg.Nev;
            dateTimePicker1.Value = pekarseg.Alapitva;



        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button_torol_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Kérem válaszon egy pékárut.");
            }
            else {
                Pekaru pekaru = (Pekaru)listBox1.SelectedItem;
                textBox1.Text = pekaru.Nev;
                textBox2.Text = Convert.ToString(pekaru.Ar);
                checkBox1.Checked = pekaru.Laktozmentes;
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);

            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
