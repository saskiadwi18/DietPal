using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_Akhir_UI
{
    public partial class UserControlUserWanita : UserControl
    {
        public UserControlUserWanita()
        {
            InitializeComponent();
            using (var db = new RegisterModel())
            {
                var query = from register in db.Registers select register;
                foreach (var item in query)
                {
                    double a = double.Parse(item.Berat_Badan);
                    double b = double.Parse(item.Tinggi_Badan) / 100;
                    double c = Math.Round(a / Math.Pow(b, 2), 2);
                    string d = c.ToString();
                    txt2Nama.Text = item.Nama;
                    txt2Usia.Text = item.Usia;
                    txt2Berat_Badan.Text = item.Berat_Badan;
                    txt2Tinggi_Badan.Text = item.Tinggi_Badan;
                    txt2BMI.Text = d;
                }
            }
        }
    }
}
