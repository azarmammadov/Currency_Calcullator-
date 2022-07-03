using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace CurrencyCalculator
{
    public partial class valyuta2 : Form
    {
        public valyuta2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void valyuta2_Load(object sender, EventArgs e)
        {
            timer1.Start();
            t1.Text = DateTime.Now.ToString("HH:mm:ss");
            t2.Text = DateTime.Now.ToShortDateString();


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t1.Text = DateTime.Now.ToString("HH:mm:ss");
            t2.Text = DateTime.Now.ToShortDateString();
            timer1.Start();
        }

        private void s2_Click(object sender, EventArgs e)
        {
            valyuta3 val3 = new valyuta3();
            val3.Show();
            this.Hide();
        }

        private void s3_Click(object sender, EventArgs e)
        {
            valyuta1 val1 = new valyuta1();
            val1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            string Val1 = "https://www.cbar.az/currencies/04.06.2022.xml";
            var Val1xml = new XmlDocument();
            string gbp_;
            string idr_;
            string irr_;
            string sek_;
            string chf_;
            string ils_;
            string cad_;
            string kwd_;
            string kzt_;
            string kgs_;
            string lbp_;
            string myr_;
            string mxn_;
            string mdl_;
            string egp_;
            string nok_;

            Val1xml.Load(Val1);
            gbp_ = Val1xml.SelectSingleNode("ValCurs/ ValType [@Type='Xarici valyutalar']/Valute [@Code = 'GBP']/Value").InnerXml;
            gbp.Text = gbp_;

            idr_ = Val1xml.SelectSingleNode("ValCurs/ ValType [@Type='Xarici valyutalar']/Valute [@Code = 'IDR']/Value").InnerXml;
            idr.Text = idr_;

            irr_ = Val1xml.SelectSingleNode("ValCurs/ ValType [@Type='Xarici valyutalar']/Valute [@Code = 'IRR']/Value").InnerXml;
            irr.Text = irr_;

            sek_ = Val1xml.SelectSingleNode("ValCurs/ ValType [@Type='Xarici valyutalar']/Valute [@Code = 'SEK']/Value").InnerXml;
            sek.Text = sek_;

            chf_ = Val1xml.SelectSingleNode("ValCurs/ ValType [@Type='Xarici valyutalar']/Valute [@Code = 'CHF']/Value").InnerXml;
            chf.Text = chf_;

            ils_ = Val1xml.SelectSingleNode("ValCurs/ ValType [@Type='Xarici valyutalar']/Valute [@Code = 'ILS']/Value").InnerXml;
            ils.Text = ils_;

            cad_ = Val1xml.SelectSingleNode("ValCurs/ ValType [@Type='Xarici valyutalar']/Valute [@Code = 'CAD']/Value").InnerXml;
            cad.Text = cad_;

            kwd_ = Val1xml.SelectSingleNode("ValCurs/ ValType [@Type='Xarici valyutalar']/Valute [@Code = 'KWD']/Value").InnerXml;
            kwd.Text = kwd_;

            kzt_ = Val1xml.SelectSingleNode("ValCurs/ ValType [@Type='Xarici valyutalar']/Valute [@Code = 'KZT']/Value").InnerXml;
            kzt.Text = kzt_;

            kgs_ = Val1xml.SelectSingleNode("ValCurs/ ValType [@Type='Xarici valyutalar']/Valute [@Code = 'KGS']/Value").InnerXml;
            kgs.Text = kgs_;

            lbp_ = Val1xml.SelectSingleNode("ValCurs/ ValType [@Type='Xarici valyutalar']/Valute [@Code = 'LBP']/Value").InnerXml;
            lbp.Text = lbp_;

            myr_ = Val1xml.SelectSingleNode("ValCurs/ ValType [@Type='Xarici valyutalar']/Valute [@Code = 'MYR']/Value").InnerXml;
            myr.Text = myr_;

            mxn_ = Val1xml.SelectSingleNode("ValCurs/ ValType [@Type='Xarici valyutalar']/Valute [@Code = 'MXN']/Value").InnerXml;
            mxn.Text = mxn_;

            mdl_ = Val1xml.SelectSingleNode("ValCurs/ ValType [@Type='Xarici valyutalar']/Valute [@Code = 'MDL']/Value").InnerXml;
            mdl.Text = mdl_;

            egp_ = Val1xml.SelectSingleNode("ValCurs/ ValType [@Type='Xarici valyutalar']/Valute [@Code = 'EGP']/Value").InnerXml;
            egp.Text = egp_;

            nok_ = Val1xml.SelectSingleNode("ValCurs/ ValType [@Type='Xarici valyutalar']/Valute [@Code = 'NOK']/Value").InnerXml;
            nok.Text = nok_;
        }

        private void button3_Click_1(object sender, EventArgs e)
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
