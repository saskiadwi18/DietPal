using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_Akhir_UI
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //tampilan awal aplikasi
            userControlCase1Fisik1.Hide();
            userControlCase1malam1.Hide();
            userControlCase1pagi1.Hide();
            userControlCase1siang1.Hide();
            userControlCase2fisik1.Hide();
            userControlCase2malam1.Hide();
            userControlCase2pagi1.Hide();
            userControlCase2siang1.Hide();
            userControlCase3fisik1.Hide();
            userControlCase3malam1.Hide();
            userControlCase3pagi1.Hide();
            userControlCase3siang1.Hide();
            userControlUserPria1.Hide();
            userControlUserWanita1.Hide();
            flowLayoutPanel1.Top = infoUserButton.Top;
            flowLayoutPanel1.Height = infoUserButton.Height;

            using (var db = new RegisterModel())
            {
                var query = from register in db.Registers select register;
                foreach (var item in query)
                {
                    if (item.Jenis_Kelamin == "Wanita")
                    {
                        flowLayoutPanel1.Height = infoUserButton.Height;
                        flowLayoutPanel1.Top = infoUserButton.Top;
                        userControlUserWanita1.Show();
                        userControlUserWanita1.BringToFront();
                    }
                    else
                    {
                        flowLayoutPanel1.Height = infoUserButton.Height;
                        flowLayoutPanel1.Top = infoUserButton.Top;
                        userControlUserPria1.Show();
                        userControlUserPria1.BringToFront();
                    }
                }
            }
        }

        private void infoUserButton_Click(object sender, EventArgs e)
        {
            using (var db = new RegisterModel())
            {
                var query = from register in db.Registers select register;
                foreach (var item in query)
                {
                    if (item.Jenis_Kelamin == "Wanita")
                    {
                        flowLayoutPanel1.Height = infoUserButton.Height;
                        flowLayoutPanel1.Top = infoUserButton.Top;
                        userControlUserWanita1.Show();
                        userControlUserWanita1.BringToFront();
                    }
                    else
                    {
                        flowLayoutPanel1.Height = infoUserButton.Height;
                        flowLayoutPanel1.Top = infoUserButton.Top;
                        userControlUserPria1.Show();
                        userControlUserPria1.BringToFront();
                    }
                }
            }
        }

        private void aktivitasFisikButton_Click(object sender, EventArgs e)
        {
            using (var db = new RegisterModel())
            {
                var query = from register in db.Registers select register;
                foreach (var item in query)
                {
                    double a = double.Parse(item.Berat_Badan);
                    double b = double.Parse(item.Tinggi_Badan) / 100;
                    double c = Math.Round(a / Math.Pow(b, 2), 2);
                    if (c < 18.5)
                    {
                        flowLayoutPanel1.Height = aktivitasFisikButton.Height;
                        flowLayoutPanel1.Top = aktivitasFisikButton.Top;
                        userControlCase1Fisik1.Show();
                        userControlCase1Fisik1.BringToFront();
                    }
                    else if(c>=18.5 && c <= 24.9)
                    {
                        flowLayoutPanel1.Height = aktivitasFisikButton.Height;
                        flowLayoutPanel1.Top = aktivitasFisikButton.Top;
                        userControlCase2fisik1.Show();
                        userControlCase2fisik1.BringToFront();
                    }
                    else
                    {
                        flowLayoutPanel1.Height = aktivitasFisikButton.Height;
                        flowLayoutPanel1.Top = aktivitasFisikButton.Top;
                        userControlCase3fisik1.Show();
                        userControlCase3fisik1.BringToFront();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new RegisterModel())
            {
                var query = from register in db.Registers select register;
                foreach (var item in query)
                {
                    double a = double.Parse(item.Berat_Badan);
                    double b = double.Parse(item.Tinggi_Badan) / 100;
                    double c = Math.Round(a / Math.Pow(b, 2), 2);
                    if (c < 18.5)
                    {
                        flowLayoutPanel1.Height = rencanaMakanButton.Height;
                        flowLayoutPanel1.Top = rencanaMakanButton.Top;
                        userControlCase1pagi1.Show();
                        userControlCase1pagi1.BringToFront();
                    }
                    else if (c >= 18.5 && c <= 24.9)
                    {
                        flowLayoutPanel1.Height = rencanaMakanButton.Height;
                        flowLayoutPanel1.Top = rencanaMakanButton.Top;
                        userControlCase2pagi1.Show();
                        userControlCase2pagi1.BringToFront();
                    }
                    else
                    {
                        flowLayoutPanel1.Height = rencanaMakanButton.Height;
                        flowLayoutPanel1.Top = rencanaMakanButton.Top;
                        userControlCase3pagi1.Show();
                        userControlCase3pagi1.BringToFront();
                    }
                }
            }
            
        }

        private void ExitLogin_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah Anda ingin keluar?", "Exit DietPal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }
    }
}
