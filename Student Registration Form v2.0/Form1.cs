using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Registration_Form_v2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* Student name text fields */
            label2.Text = textBox1.Text;
            label3.Text = textBox2.Text;
            label4.Text = textBox3.Text;

            /* radio button for male or female */
            if (radioButton1.Checked == true)
            {
                MessageBox.Show(" Student name: " + textBox1.Text + " " + textBox2.Text + " " + textBox3.Text + "\n Gender: " + radioButton1.Text + "\n Relationship Status: " + comboBox2.Text + "\n Birthday: " + comboBox4.Text + " " + comboBox3.Text + "," + comboBox5.Text + "\n Course: " + comboBox6.Text, "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(" Student name: " + textBox1.Text + " " + textBox2.Text + " " + textBox3.Text + "\n Gender: " + radioButton2.Text + "\n Relationship Status: " + comboBox2.Text + "\n Birthday: " + comboBox4.Text + " " + comboBox3.Text + "," + comboBox5.Text + "\n Course: " + comboBox6.Text, "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /* Photobox */
            openFileDialog1.Filter = " (*.jpg; *.jpeg; *.png;)|*.jpg; *.jpeg; *.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {

           /* clears the text on textfield and combox */
           textBox1.Clear();
           textBox2.Clear();
           textBox3.Clear();

          

           comboBox2.ResetText();
           comboBox4.ResetText();
           comboBox5.ResetText();
           comboBox6.ResetText();
        }
    }
}
