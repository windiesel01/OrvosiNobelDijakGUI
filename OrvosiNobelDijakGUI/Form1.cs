using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrvosiNobelDijakGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_adatok_mentese_Click(object sender, EventArgs e)
        {
            int convert;
            bool hibae = false;
            string hiba = "Hiba!";
            if (textBox_ev.Text == "" && textBox_neve.Text == "" && textBox_sz_h.Text == "" && textBox_orszag.Text == "")
            {
                MessageBox.Show("Hiba! Töltsön ki minden mezőt!","Mentés",MessageBoxButtons.OK);
            }
            else
            {
                convert = Convert.ToInt32(textBox_ev.Text);
                if (!(convert > 1989))
                {
                    MessageBox.Show("Hiba! Az évszám nem megfelelő!","Mentés", MessageBoxButtons.OK);
                }
                else
                {
                    try
                    {
                        if (!File.Exists("uj_díjazott.txt"))
                        {
                            File.WriteAllText("uj_díjazott.txt", "Év;Név;SzületésHalálozás;Országkód\n");
                            File.AppendAllText("uj_díjazott.txt", $"{textBox_ev.Text},{textBox_neve.Text},{textBox_sz_h.Text},{textBox_orszag.Text}\n");
                        }
                        else
                        {
                            File.AppendAllText("uj_díjazott.txt", $"{textBox_ev.Text},{textBox_neve.Text},{textBox_sz_h.Text},{textBox_orszag.Text}\n");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + Environment.NewLine + "A program leáll!");
                        Environment.Exit(0);
                    }
                }
                textBox_ev.Clear();
                textBox_neve.Clear();
                textBox_orszag.Clear();
                textBox_sz_h.Clear();
            }
        }
    }
}
