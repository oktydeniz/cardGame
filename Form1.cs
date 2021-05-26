using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_games
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int random;
        int sayac = 0;
        int oyuncu_toplam = 0;
        int bilgisayar_random;
        int pc_toplam = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            if (sayac == 0)
            {
                Random rnd = new Random();
                random = rnd.Next(1, 14);
                bilgisayar_random = rnd.Next(1, 14);
                pictureBox1.Image = ımageList1.Images[random];
                pictureBox5.Image = ımageList1.Images[bilgisayar_random];
                oyuncu_toplam += random;
                pc_toplam += bilgisayar_random;
                label9.Text = oyuncu_toplam.ToString();
                label10.Text = pc_toplam.ToString();

                sayac++;
            }
            else if (sayac == 1)
            {
                Random rnd = new Random();
                random = rnd.Next(1, 14);
                bilgisayar_random = rnd.Next(1, 14);
                pictureBox2.Image = ımageList1.Images[random];
                pictureBox6.Image = ımageList1.Images[bilgisayar_random];
                oyuncu_toplam += random;
                pc_toplam += bilgisayar_random;
                label9.Text = oyuncu_toplam.ToString();
                label10.Text = pc_toplam.ToString();
                sayac++;
                

            }
            else if (sayac == 2)
            {
                
                Random rnd = new Random();
                    random = rnd.Next(1, 14);
                    bilgisayar_random = rnd.Next(1, 14);
                    pictureBox3.Image = ımageList1.Images[random];
                    pictureBox7.Image = ımageList1.Images[bilgisayar_random];
                    oyuncu_toplam += random;
                    pc_toplam += bilgisayar_random;
                    label9.Text = oyuncu_toplam.ToString();
                    label10.Text = pc_toplam.ToString();
                    sayac++;
                    


            }
            else if (sayac == 3)
            {
               
                    Random rnd = new Random();
                    random = rnd.Next(1, 14);
                    bilgisayar_random = rnd.Next(1, 14);
                    pictureBox4.Image = ımageList1.Images[random];
                    pictureBox8.Image = ımageList1.Images[bilgisayar_random];
                    oyuncu_toplam += random;
                    pc_toplam += bilgisayar_random;
                    label9.Text = oyuncu_toplam.ToString();
                    label10.Text = pc_toplam.ToString();
                    sayac++;
               
                
            }
            if (sayac == 4)
            {
                button1.Enabled = false;
                label9.Text = oyuncu_toplam.ToString();
                label10.Text = pc_toplam.ToString();
                button2.Enabled = true;
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            contorl();
        }
       
        private void contorl()
        {
            label9.Text = "";
            label10.Text = "";
            label3.Text = "";
            pc_toplam = 0;
            oyuncu_toplam = 0;
            sayac = 0;
            if (button1.Enabled == false)
            {
                button1.Enabled = true;
            }
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            pictureBox6.Image = null;
            pictureBox7.Image = null;
            pictureBox8.Image = null;
        }
    }
}
