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
    public partial class FormRegister : Form
    {
        Register register;
        string gender;
        public enum Mode { Insert, Edit }
        Mode mode;
        public FormRegister()
        {
            InitializeComponent();
            mode = Mode.Insert;
        }

        private void TambahData()
        {
            if (tbNama.Text != "" && tbUsia.Text != "" && tbTinggi_Badan.Text != "")
            {
                using (var db = new RegisterModel())
                {
                    db.Registers.RemoveRange(db.Registers.Where(item => item.Nama != ""));
                    db.SaveChanges();
                    db.Registers.Add(new Register
                    {
                        Nama = tbNama.Text,
                        Jenis_Kelamin = gender,
                        Usia = tbUsia.Text,
                        Tinggi_Badan = tbTinggi_Badan.Text,
                        Berat_Badan = tbBerat_Badan.Text,
                    });
                    db.SaveChanges();
                    MessageBox.Show("Registrasi sukses");
                    this.Hide();
                }
            }
        }

        private void UsiaKeypress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Input hanya berupa bilangan bulat!");
            }
        }

        private void TinggiKeypress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Input hanya berupa bilangan bulat!");
            }
        }

        private void BeratKeypress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Input hanya berupa bilangan bulat!");
            }
        }

        private void ExitLogin_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah Anda ingin keluar?", "Exit DietPal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void radioButtonMale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Pria";
        }

        private void radioButtonFemale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Wanita";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (mode == Mode.Insert && tbNama.Text != "" && tbUsia.Text != "" && tbTinggi_Badan.Text != "" && tbBerat_Badan.Text != "" && (gender == "Pria" || gender == "Wanita"))
            {
                TambahData();
                FormMain f = new FormMain();
                f.Show();
            }
            else
            {
                MessageBox.Show("Masukkan data dengan benar");
            }
        }
    }
}
