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

//private abstract void BladSprawdzania();

namespace Pesel
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxPeselInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSprawdz_Click(object sender, EventArgs e)
        {
            //Debug.WriteLine("private void buttonSprawdz_Click(object sender, EventArgs e)");
            if (textBoxPeselInput.Text != "")
            {
                //Debug.WriteLine("if (textBoxPeselInput.Text != )");
                labelWynikSprawdzania.ForeColor = Color.Black;
                try
                {
                    //Debug.WriteLine("Try");
                    if (textBoxPeselInput.TextLength == 11)
                    {
                        //Debug.WriteLine("if (textBoxPeselInput.TextLength == 11)");
                        string pesel = Convert.ToString(textBoxPeselInput.Text);
                        //char[] pesel = new char[11];
                        //pesel = stringPesel.ToCharArray();

                        try
                        {
                            //Debug.WriteLine("Obliczam sume kontrolna:");
                            int suma_kontrolna = (1 * (Convert.ToInt32(pesel.ElementAt(0)) - 48)) + (3 * (Convert.ToInt32(pesel.ElementAt(1)) - 48)) + (7 * (Convert.ToInt32(pesel.ElementAt(2)) - 48)) + (9 * (Convert.ToInt32(pesel.ElementAt(3)) - 48)) + (1 * (Convert.ToInt32(pesel.ElementAt(4)) - 48)) + (3 * (Convert.ToInt32(pesel.ElementAt(5)) - 48)) + (7 * (Convert.ToInt32(pesel.ElementAt(6)) - 48)) + (9 * (Convert.ToInt32(pesel.ElementAt(7)) - 48)) + (1 * (Convert.ToInt32(pesel.ElementAt(8)) - 48)) + (3 * (Convert.ToInt32(pesel.ElementAt(9)) - 48));
                            int ostatniaCyfra = Convert.ToInt32(pesel.ElementAt(10)) - 48;
                            //Debug.WriteLine(ostatniaCyfra);
                            //Debug.WriteLine(suma_kontrolna);
                            //Debug.WriteLine(suma_kontrolna % 10);
                            //Debug.WriteLine(pesel.ElementAt(10));
                            if ((10 - suma_kontrolna % 10) == ostatniaCyfra)
                            {
                                labelWynikSprawdzania.Text = "Pesel jest prawidłowy! :)";
                            }
                            else
                            {
                                labelWynikSprawdzania.ForeColor = Color.Red;
                                labelWynikSprawdzania.Text = "Pesel jest nieprawidłowy! :(";
                            }
                        }
                        catch
                        {
                            //Debug.WriteLine("Blad danych przy probie obliczen");
                            labelWynikSprawdzania.ForeColor = Color.Red;
                            labelWynikSprawdzania.Text = "Nieporawne Dane!";
                        }
                    }
                    else
                    {
                        //Debug.WriteLine("else przy if (textBoxPeselInput.TextLength == 11)");
                        labelWynikSprawdzania.ForeColor = Color.Red;
                        labelWynikSprawdzania.Text = "Nieporawne Dane!";
                    }
                }
                catch
                {
                    //Debug.WriteLine("catch");
                    labelWynikSprawdzania.ForeColor = Color.Red;
                    labelWynikSprawdzania.Text = "Nieporawne Dane!";
                }

            }
            else
            {
                //Debug.WriteLine("else przy if (textBoxPeselInput.Text != )");
                labelWynikSprawdzania.ForeColor = Color.Red;
                labelWynikSprawdzania.Text = "Nieporawne Dane!";
            }
        }
    }

}

/*
    private void BladSprawdzania()
    {
        labelWynikSprawdzania.ForeColor = Color.Red;
        labelWynikSprawdzania.Text = "Nieporawne Dane!";
    }
*/
