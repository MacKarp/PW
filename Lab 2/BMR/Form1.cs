using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Diagnostics;

namespace BMR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBoxMasaInput.Text != "") && (textBoxWzrostInput.Text != "") && (textBoxWiekInput.Text != "") && ((radioButtonMezczyzna.Checked == true) || (radioButtonKobieta.Checked == true)))
            {
                double waga = Convert.ToDouble(textBoxMasaInput.Text);
                double wzrost = Convert.ToDouble(textBoxWzrostInput.Text);
                int wiek = Convert.ToUInt16(textBoxWiekInput.Text);
                //Debug.WriteLine(waga);
                //Debug.WriteLine(wzrost);
                //Debug.WriteLine(wiek);
                double bmr = 0;
                if (radioButtonMezczyzna.Checked)
                {

                    bmr = (9.99 * waga) + (6.25 * wzrost) - (4.92 * wiek) + 5;

                }
                else if (radioButtonKobieta.Checked)
                {
                    bmr = (9.99 * waga) + (6.25 * wzrost) - (4.92 * wiek) - 161;
                }

                labelWynikOutput.ForeColor = Color.Black;
                labelWynikOutput.Text = bmr.ToString();
            }
            else
            {
                labelWynikOutput.ForeColor = Color.Red;
                labelWynikOutput.Text = "Brak danych";
            }
        }

        private void buttonWyczysc_Click(object sender, EventArgs e)
        {
            labelWynikOutput.Text = "";
            textBoxMasaInput.Text = "";
            textBoxWzrostInput.Text = "";
            textBoxWiekInput.Text = "";
            radioButtonKobieta.Checked = false;
            radioButtonMezczyzna.Checked = false;

        }
    }
}
