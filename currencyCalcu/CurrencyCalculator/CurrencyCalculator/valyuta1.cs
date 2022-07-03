using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Xml;

namespace CurrencyCalculator
{
    public partial class valyuta1 : Form
    {
        public valyuta1()
        {
            InitializeComponent();
        }
        private void valyuta1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            t1.Text = DateTime.Now.ToString("HH:mm:ss");
            t2.Text = DateTime.Now.ToShortDateString();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            t1.Text = DateTime.Now.ToString("HH:mm:ss");
            t2.Text = DateTime.Now.ToShortDateString();
            timer1.Start();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label47_Click(object sender, EventArgs e)
        {

        }

        private void t2_Click(object sender, EventArgs e)
        {

        }

       

        private void s2_Click(object sender, EventArgs e)
        {
            valyuta2 val2 = new valyuta2();
            val2.Show();
            this.Hide();
        }

        private void s3_Click(object sender, EventArgs e)
        {
            valyuta3 val3 = new valyuta3();
            val3.Show();
            this.Hide();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           


        }


        private void button2_Click(object sender, EventArgs e)
        {

            string Val1 = "https://www.cbar.az/currencies/04.06.2022.xml";
            var Val1xml = new XmlDocument();
            string USD_;
            string eur_;
            string aud_;
            string ars_;
            string byn_;
            string brl_;
            string aed_;
            string zar_;
            string krw_;
            string czk_;
            string clp_;
            string cny_;
            string dkk_;
            string gel_;
            string hkd_;
            string inr_;

            Val1xml.Load(Val1);
            USD_ = Val1xml.SelectSingleNode("ValCurs/ ValType [@Type='Xarici valyutalar']/Valute [@Code = 'USD']/Value").InnerXml;
            usd.Text = USD_;

            eur_ = Val1xml.SelectSingleNode("ValCurs/ ValType [@Type='Xarici valyutalar']/Valute [@Code = 'EUR']/Value").InnerXml;
            eur.Text = eur_;

            aud_ = Val1xml.SelectSingleNode("ValCurs/ ValType [@Type='Xarici valyutalar']/Valute [@Code = 'AUD']/Value").InnerXml;
            aud.Text = aud_;

            ars_ = Val1xml.SelectSingleNode("ValCurs/ ValType [@Type='Xarici valyutalar']/Valute [@Code = 'ARS']/Value").InnerXml;
            ars.Text = ars_;

            byn_ = Val1xml.SelectSingleNode("ValCurs/ ValType [@Type='Xarici valyutalar']/Valute [@Code = 'BYN']/Value").InnerXml;
            byn.Text = byn_;

            brl_ = Val1xml.SelectSingleNode("ValCurs/ ValType [@Type='Xarici valyutalar']/Valute [@Code = 'BRL']/Value").InnerXml;
            brl.Text = brl_;

            aed_ = Val1xml.SelectSingleNode("ValCurs/ ValType [@Type='Xarici valyutalar']/Valute [@Code = 'AED']/Value").InnerXml;
            aed.Text = aed_;

            zar_ = Val1xml.SelectSingleNode("ValCurs/ ValType [@Type='Xarici valyutalar']/Valute [@Code = 'ZAR']/Value").InnerXml;
            zar.Text = zar_;

            krw_ = Val1xml.SelectSingleNode("ValCurs/ ValType [@Type='Xarici valyutalar']/Valute [@Code = 'KRW']/Value").InnerXml;
            krw.Text = krw_;

            czk_ = Val1xml.SelectSingleNode("ValCurs/ ValType [@Type='Xarici valyutalar']/Valute [@Code = 'CZK']/Value").InnerXml;
            czk.Text = czk_;

            clp_ = Val1xml.SelectSingleNode("ValCurs/ ValType [@Type='Xarici valyutalar']/Valute [@Code = 'CLP']/Value").InnerXml;
            clp.Text = clp_;

            cny_ = Val1xml.SelectSingleNode("ValCurs/ ValType [@Type='Xarici valyutalar']/Valute [@Code = 'CNY']/Value").InnerXml;
            cny.Text = cny_;

            dkk_ = Val1xml.SelectSingleNode("ValCurs/ ValType [@Type='Xarici valyutalar']/Valute [@Code = 'DKK']/Value").InnerXml;
            dkk.Text = dkk_;

            gel_ = Val1xml.SelectSingleNode("ValCurs/ ValType [@Type='Xarici valyutalar']/Valute [@Code = 'GEL']/Value").InnerXml;
            gel.Text = gel_;

            hkd_ = Val1xml.SelectSingleNode("ValCurs/ ValType [@Type='Xarici valyutalar']/Valute [@Code = 'HKD']/Value").InnerXml;
            hkd.Text = hkd_;

            inr_ = Val1xml.SelectSingleNode("ValCurs/ ValType [@Type='Xarici valyutalar']/Valute [@Code = 'INR']/Value").InnerXml;
            inr.Text = inr_;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            calculator kal = new calculator();
            kal.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
