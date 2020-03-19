using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace Kostka_do_gry
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Losuj(0);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        public void Losuj(int sekundy)
        {
            Random rnd = new Random();
            int j = rnd.Next(1, 15);
            int wartosc = 0;
            Debug.WriteLine("j: " + j);
            for (int i = 0; i < j; i++)
            {
                labelWynik.Text = "Trwa losowanie!";
                wartosc = rnd.Next(1, 7);
                Debug.WriteLine("wartosc: " + wartosc);
                Debug.WriteLine("i: " + i);
                switch (wartosc)
                {
                    case 1:
                        labelDotTopLeft.Visible = false;
                        labelCenterLeft.Visible = false;
                        labelDownLeft.Visible = false;
                        labelCenter.Visible = true;
                        labelTopRight.Visible = false;
                        labelCenterRight.Visible = false;
                        labelDownRight.Visible = false;
                        break;
                    case 2:
                        labelDotTopLeft.Visible = false;
                        labelCenterLeft.Visible = false;
                        labelDownLeft.Visible = true;
                        labelCenter.Visible = false;
                        labelTopRight.Visible = true;
                        labelCenterRight.Visible = false;
                        labelDownRight.Visible = false;
                        break;
                    case 3:
                        labelDotTopLeft.Visible = false;
                        labelCenterLeft.Visible = false;
                        labelDownLeft.Visible = true;
                        labelCenter.Visible = true;
                        labelTopRight.Visible = true;
                        labelCenterRight.Visible = false;
                        labelDownRight.Visible = false;
                        break;
                    case 4:
                        labelDotTopLeft.Visible = true;
                        labelCenterLeft.Visible = false;
                        labelDownLeft.Visible = true;
                        labelCenter.Visible = false;
                        labelTopRight.Visible = true;
                        labelCenterRight.Visible = false;
                        labelDownRight.Visible = true;
                        break;
                    case 5:
                        labelDotTopLeft.Visible = true;
                        labelCenterLeft.Visible = false;
                        labelDownLeft.Visible = true;
                        labelCenter.Visible = true;
                        labelTopRight.Visible = true;
                        labelCenterRight.Visible = false;
                        labelDownRight.Visible = true;
                        break;
                    case 6:
                        labelDotTopLeft.Visible = true;
                        labelCenterLeft.Visible = true;
                        labelDownLeft.Visible = true;
                        labelCenter.Visible = false;
                        labelTopRight.Visible = true;
                        labelCenterRight.Visible = true;
                        labelDownRight.Visible = true;
                        break;
                }

                WaitNSeconds(sekundy);
            }
            labelWynik.Text = "Twój wynik to: " + wartosc;
            globalVariable.doSchowka = wartosc;
        }
        private void labelControl_DoubleClick(object sender, EventArgs e)
        {

        }

        public void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Po naciśnięciu klawisza r, wylosuje nową wartość
            if (e.KeyChar == 'r')
            {
                Losuj(1);
            }
        }

        private void WaitNSeconds(int segundos)
        {
            if (segundos < 1) return;
            DateTime _desired = DateTime.Now.AddSeconds(segundos);
            while (DateTime.Now < _desired)
            {
                System.Windows.Forms.Application.DoEvents();
            }
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            using (Pen pen = new Pen(Color.Black))
            {
                g.DrawRectangle(pen, 200, 86, 220, 225);
                Brush brush = new SolidBrush(Color.White);
                g.FillRectangle(brush, 201, 87, 219, 224);
            }
        }

        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Clipboard.SetText(globalVariable.doSchowka.ToString());
        }
    }
}
