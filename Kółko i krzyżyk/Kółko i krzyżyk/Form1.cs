using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kółko_i_krzyżyk
{
    public partial class Form1 : Form
    {
        //zminna kontrolująca czy teraz stawiane jest kółko czy krzyżyk
        bool kolejO = true;
        //zmienna kontrolująca czy przycisk Start był kliknięty
        bool czyKlikniety = false;
        public Form1()
        {
            InitializeComponent();
        }   
        
        private void btnStart_Click(object sender, EventArgs e)
        {
            //jeżli jest to pierwsze klikniecie przycisku start, pole gry się odblokowuje, jak i przycisk nowa gra
            if (!czyKlikniety)
            { 
                btn1.Enabled = btn2.Enabled = btn3.Enabled = btn4.Enabled = btn5.Enabled = btn6.Enabled = btn7.Enabled = btn8.Enabled = btn9.Enabled = true;
                btnNowaGra.Enabled = true;
                btnStart.Text = "WYZERUJ WYNIKI";
                czyKlikniety = true;
            }
            else //jeżeli kiedyś klikneliśmy przyscisk start czyści się pole gry wyniki się zerują i zaczynamy rozgrywkę od nowa
            {
                btn1.Enabled = btn2.Enabled = btn3.Enabled = btn4.Enabled = btn5.Enabled = btn6.Enabled = btn7.Enabled = btn8.Enabled = btn9.Enabled = true;
                btn1.Text = btn2.Text = btn3.Text = btn4.Text = btn5.Text = btn6.Text = btn7.Text = btn8.Text = btn9.Text = "";
                btn1.BackColor = btn2.BackColor = btn3.BackColor = btn4.BackColor = btn5.BackColor = btn6.BackColor = btn7.BackColor = btn8.BackColor = btn9.BackColor = Color.White;
                lblWynikO.Text = "0";                lblWynikX.Text = "0";
            }
            
        }
        //wyjście z aplikacji
        private void btnWyjście_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //przy każdym naciśnięciu nowej gry odblokowujemy dostęp do wszystkich pól gry i czyścimy je 

        private void btnNowaGra_Click(object sender, EventArgs e)
        {
            btn1.Enabled = btn2.Enabled = btn3.Enabled = btn4.Enabled = btn5.Enabled = btn6.Enabled = btn7.Enabled = btn8.Enabled = btn9.Enabled = true;
            btn1.Text = btn2.Text = btn3.Text = btn4.Text = btn5.Text = btn6.Text = btn7.Text = btn8.Text = btn9.Text = "";
            btn1.BackColor = btn2.BackColor = btn3.BackColor = btn4.BackColor = btn5.BackColor = btn6.BackColor = btn7.BackColor = btn8.BackColor = btn9.BackColor = Color.White;
        }
        //metoda sprawdzająca czy ktoś wygrał daną rundę
        public bool koniecGry() 
        {
            bool info = false;
            //Sprawdzam warunek wygranej X
            if (btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X")
            {
                btn1.BackColor = btn2.BackColor = btn3.BackColor = Color.Pink;
                lblWynikX.Text = Convert.ToString(int.Parse(lblWynikX.Text) + 1);
                btn1.Enabled = btn2.Enabled = btn3.Enabled = btn4.Enabled = btn5.Enabled = btn6.Enabled = btn7.Enabled = btn8.Enabled = btn9.Enabled = false;
                MessageBox.Show("Wygrał gracz X!");
                info = true;
            }
            else if (btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X")
            {
                btn1.BackColor = btn4.BackColor = btn7.BackColor = Color.Pink;
                lblWynikX.Text = Convert.ToString(int.Parse(lblWynikX.Text) + 1);
                btn1.Enabled = btn2.Enabled = btn3.Enabled = btn4.Enabled = btn5.Enabled = btn6.Enabled = btn7.Enabled = btn8.Enabled = btn9.Enabled = false;
                MessageBox.Show("Wygrał gracz X!");
                info = true;
            }
            else if (btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X")
            {
                btn1.BackColor = btn5.BackColor = btn9.BackColor = Color.Pink;
                lblWynikX.Text = Convert.ToString(int.Parse(lblWynikX.Text) + 1);
                btn1.Enabled = btn2.Enabled = btn3.Enabled = btn4.Enabled = btn5.Enabled = btn6.Enabled = btn7.Enabled = btn8.Enabled = btn9.Enabled = false;
                MessageBox.Show("Wygrał gracz X!");
                info = true;

            }
            else if (btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X")
            {
                btn4.BackColor = btn5.BackColor = btn6.BackColor = Color.Pink;
                lblWynikX.Text = Convert.ToString(int.Parse(lblWynikX.Text) + 1);
                btn1.Enabled = btn2.Enabled = btn3.Enabled = btn4.Enabled = btn5.Enabled = btn6.Enabled = btn7.Enabled = btn8.Enabled = btn9.Enabled = false;
                MessageBox.Show("Wygrał gracz X!");
                info = true;

            }
            else if (btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X")
            {
                btn7.BackColor = btn8.BackColor = btn9.BackColor = Color.Pink;
                lblWynikX.Text = Convert.ToString(int.Parse(lblWynikX.Text) + 1);
                btn1.Enabled = btn2.Enabled = btn3.Enabled = btn4.Enabled = btn5.Enabled = btn6.Enabled = btn7.Enabled = btn8.Enabled = btn9.Enabled = false;
                MessageBox.Show("Wygrał gracz X!");
                info = true;

            }
            else if (btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X")
            {
                btn2.BackColor = btn5.BackColor = btn8.BackColor = Color.Pink;
                lblWynikX.Text = Convert.ToString(int.Parse(lblWynikX.Text) + 1);
                btn1.Enabled = btn2.Enabled = btn3.Enabled = btn4.Enabled = btn5.Enabled = btn6.Enabled = btn7.Enabled = btn8.Enabled = btn9.Enabled = false;
                MessageBox.Show("Wygrał gracz X!");
                info = true;

            }
            else if (btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X")
            {
                btn3.BackColor = btn6.BackColor = btn9.BackColor = Color.Pink;
                lblWynikX.Text = Convert.ToString(int.Parse(lblWynikX.Text) + 1);
                btn1.Enabled = btn2.Enabled = btn3.Enabled = btn4.Enabled = btn5.Enabled = btn6.Enabled = btn7.Enabled = btn8.Enabled = btn9.Enabled = false;
                MessageBox.Show("Wygrał gracz X!");
                info = true;

            }
            else if (btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X")
            {
                btn3.BackColor = btn5.BackColor = btn7.BackColor = Color.Pink;
                lblWynikX.Text = Convert.ToString(int.Parse(lblWynikX.Text) + 1);
                btn1.Enabled = btn2.Enabled = btn3.Enabled = btn4.Enabled = btn5.Enabled = btn6.Enabled = btn7.Enabled = btn8.Enabled = btn9.Enabled = false;
                MessageBox.Show("Wygrał gracz X!");
                info = true;

            }
            else if (btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O") //Warunki wygranej O
            {
                btn1.BackColor = btn2.BackColor = btn3.BackColor = Color.Pink;
                lblWynikO.Text = Convert.ToString(int.Parse(lblWynikO.Text) + 1);
                btn1.Enabled = btn2.Enabled = btn3.Enabled = btn4.Enabled = btn5.Enabled = btn6.Enabled = btn7.Enabled = btn8.Enabled = btn9.Enabled = false;
                MessageBox.Show("Wygrał gracz O!");
                info = true;

            }
            else if (btn1.Text == "O" && btn4.Text == "O" && btn7.Text == "O")
            {
                btn1.BackColor = btn4.BackColor = btn7.BackColor = Color.Pink;
                lblWynikO.Text = Convert.ToString(int.Parse(lblWynikO.Text) + 1);
                btn1.Enabled = btn2.Enabled = btn3.Enabled = btn4.Enabled = btn5.Enabled = btn6.Enabled = btn7.Enabled = btn8.Enabled = btn9.Enabled = false;
                MessageBox.Show("Wygrał gracz O!");
                info = true;

            }
            else if (btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O")
            {
                btn1.BackColor = btn5.BackColor = btn9.BackColor = Color.Pink;
                lblWynikO.Text = Convert.ToString(int.Parse(lblWynikO.Text) + 1);
                btn1.Enabled = btn2.Enabled = btn3.Enabled = btn4.Enabled = btn5.Enabled = btn6.Enabled = btn7.Enabled = btn8.Enabled = btn9.Enabled = false;
                MessageBox.Show("Wygrał gracz O!");
                info = true;

            }
            else if (btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O")
            {
                btn4.BackColor = btn5.BackColor = btn6.BackColor = Color.Pink;
                lblWynikO.Text = Convert.ToString(int.Parse(lblWynikO.Text) + 1);
                btn1.Enabled = btn2.Enabled = btn3.Enabled = btn4.Enabled = btn5.Enabled = btn6.Enabled = btn7.Enabled = btn8.Enabled = btn9.Enabled = false;
                MessageBox.Show("Wygrał gracz O!");
                info = true;

            }
            else if (btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O")
            {
                btn7.BackColor = btn8.BackColor = btn9.BackColor = Color.Pink;
                lblWynikO.Text = Convert.ToString(int.Parse(lblWynikO.Text) + 1);
                btn1.Enabled = btn2.Enabled = btn3.Enabled = btn4.Enabled = btn5.Enabled = btn6.Enabled = btn7.Enabled = btn8.Enabled = btn9.Enabled = false;
                MessageBox.Show("Wygrał gracz O!");
                info = true;

            }
            else if (btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "O")
            {
                btn2.BackColor = btn5.BackColor = btn8.BackColor = Color.Pink;
                lblWynikO.Text = Convert.ToString(int.Parse(lblWynikO.Text) + 1);
                btn1.Enabled = btn2.Enabled = btn3.Enabled = btn4.Enabled = btn5.Enabled = btn6.Enabled = btn7.Enabled = btn8.Enabled = btn9.Enabled = false;
                MessageBox.Show("Wygrał gracz O!");
                info = true;

            }
            else if (btn3.Text == "O" && btn6.Text == "O" && btn9.Text == "O")
            {
                btn3.BackColor = btn6.BackColor = btn9.BackColor = Color.Pink;
                lblWynikO.Text = Convert.ToString(int.Parse(lblWynikO.Text) + 1);
                btn1.Enabled = btn2.Enabled = btn3.Enabled = btn4.Enabled = btn5.Enabled = btn6.Enabled = btn7.Enabled = btn8.Enabled = btn9.Enabled = false;
                MessageBox.Show("Wygrał gracz O!");
                info = true;

            }
            else if (btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O")
            {
                btn3.BackColor = btn5.BackColor = btn7.BackColor = Color.Pink;
                lblWynikO.Text = Convert.ToString(int.Parse(lblWynikO.Text) + 1);
                btn1.Enabled = btn2.Enabled = btn3.Enabled = btn4.Enabled = btn5.Enabled = btn6.Enabled = btn7.Enabled = btn8.Enabled = btn9.Enabled = false;
                MessageBox.Show("Wygrał gracz O!");
                info = true;

            }
            return info; 
        }
        //po kliknięciu w jakikolwiek przycisk blokujemy do niego dostęp i wstawiamy na nim X,O w zależności od tego którego jest kolei i sprawdzamy czy dana runda się skończyła wygraną jednego z graczy
        private void btn1_Click(object sender, EventArgs e)
        {
            btn1.Enabled = false;           
            
            if (kolejO)
            {
                btn1.Text = "O";
                kolejO = false;
            }
            else
            {
                btn1.Text = "X";
                kolejO = true;
            }

            koniecGry();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            btn2.Enabled = false;
            
            
                if (kolejO)
                {
                    btn2.Text = "O";
                    kolejO = false;
                }
                else
                {
                    btn2.Text = "X";
                    kolejO = true;
                }
            koniecGry();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            btn3.Enabled = false;
            
                if (kolejO)
                {
                    btn3.Text = "O";
                    kolejO = false;
                }
                else
                {
                    btn3.Text = "X";
                    kolejO = true;
                }
                koniecGry();
            }

        private void btn4_Click(object sender, EventArgs e)
        {
            btn4.Enabled = false;
            
                if (kolejO)
                {
                    btn4.Text = "O";
                    kolejO = false;
                }
                else
                {
                    btn4.Text = "X";
                    kolejO = true;
                }
            koniecGry();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            btn5.Enabled = false;
            
                if (kolejO)
                {
                    btn5.Text = "O";
                    kolejO = false;
                }
                else
                {
                    btn5.Text = "X";
                    kolejO = true;
                }
            koniecGry();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            btn6.Enabled = false;
            
                if (kolejO)
                {
                    btn6.Text = "O";
                    kolejO = false;
                }
                else
                {
                    btn6.Text = "X";
                    kolejO = true;
                }
            koniecGry();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            btn7.Enabled = false;
            
                if (kolejO)
                {
                    btn7.Text = "O";
                    kolejO = false;
                }
                else
                {
                    btn7.Text = "X";
                    kolejO = true;
                }
            koniecGry();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            btn8.Enabled = false;
            
                if (kolejO)
                {
                    btn8.Text = "O";
                    kolejO = false;
                }
                else
                {
                    btn8.Text = "X";                    
                    kolejO = true;
                }
            koniecGry();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            btn9.Enabled = false;
            
                if (kolejO)
                {
                    btn9.Text = "O";                    
                    kolejO = false;
                }
                else
                {
                    btn9.Text = "X";
                    kolejO = true;
                }
            koniecGry();
        }
    }
}
