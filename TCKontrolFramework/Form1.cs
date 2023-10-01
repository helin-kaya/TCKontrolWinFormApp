using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCKontrolFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            long kimlikNo = long.Parse(TxtTC.Text);
            int yil = int.Parse(txtYil.Text);
            bool durum;
            try
            {
                using (TcDogrula.KPSPublicSoapClient service =new TcDogrula.KPSPublicSoapClient { })
                {
                    durum = service.TCKimlikNoDogrula(kimlikNo, txtAd.Text, txtSoyad.Text, yil);

                }
            }
            catch (Exception)
            {

                throw;
            }
            if (durum==true)
            {
                MessageBox.Show("Bilgileriniz doğru");
            }
            else
            {
                MessageBox.Show("Bilgileriniz yanlış");
            }
            

        }
    }
}
