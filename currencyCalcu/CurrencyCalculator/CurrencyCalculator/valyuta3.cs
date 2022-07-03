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
    public partial class valyuta3 : Form
    {
        public valyuta3()
        {
            InitializeComponent();
        }

        private void yenileB_Click(object sender, EventArgs e)
        {

            string Val1 = "https://www.cbar.az/currencies/04.06.2022.xml";
            var Val1xml = new XmlDocument();
            string uzs_;
            string pln_;
            string rub_;
            string sgd_;
            string sar_;
            string try_;
            string twd_;
            string tjs_;
            string tmt_;
            string uah_;
            string jpy_;
            string nzd_;
            string xau_;
            string xag_;
            string xpt_;
            string xpd_;

            Val1xml.Load(Val1);
            uzs_ = Val1xml.SelectSingleNode("ValCurs/ ValType [@Type='Xarici valyutalar']/Valute [@Code = 'UZS']/Value").InnerXml;
            uzs.Text = uzs_;

            pln_ = Val1xml.SelectSingleNode("ValCurs/ ValType [@Type='Xarici valyutalar']/Valute [@Code = 'PLN']/Value").InnerXml;
            pln.Text = pln_;

            rub_ = Val1xml.SelectSingleNode("ValCurs/ ValType [@Type='Xarici valyutalar']/Valute [@Code = 'RUB']/Value").InnerXml;
            rub.Text = rub_;

            sgd_ = Val1xml.SelectSingleNode("ValCurs/ ValType [@Type='Xarici valyutalar']/Valute [@Code = 'SGD']/Value").InnerXml;
            sgd.Text = sgd_;

            sar_ = Val1xml.SelectSingleNode("ValCurs/ ValType [@Type='Xarici valyutalar']/Valute [@Code = 'SAR']/Value").InnerXml;
            sar.Text = sar_;

            try_ = Val1xml.SelectSingleNode("ValCurs/ ValType [@Type='Xarici valyutalar']/Valute [@Code = 'TRY']/Value").InnerXml;
            tryy.Text = try_;

            twd_ = Val1xml.SelectSingleNode("ValCurs/ ValType [@Type='Xarici valyutalar']/Valute [@Code = 'TWD']/Value").InnerXml;
            twd.Text = twd_;

            tjs_ = Val1xml.SelectSingleNode("ValCurs/ ValType [@Type='Xarici valyutalar']/Valute [@Code = 'TJS']/Value").InnerXml;
            tjs.Text = tjs_;

            tmt_ = Val1xml.SelectSingleNode("ValCurs/ ValType [@Type='Xarici valyutalar']/Valute [@Code = 'TMT']/Value").InnerXml;
            tmt.Text = tmt_;

            uah_ = Val1xml.SelectSingleNode("ValCurs/ ValType [@Type='Xarici valyutalar']/Valute [@Code = 'UAH']/Value").InnerXml;
            uah.Text = uah_;

            jpy_ = Val1xml.SelectSingleNode("ValCurs/ ValType [@Type='Xarici valyutalar']/Valute [@Code = 'JPY']/Value").InnerXml;
            jpy.Text = jpy_;

            nzd_ = Val1xml.SelectSingleNode("ValCurs/ ValType [@Type='Xarici valyutalar']/Valute [@Code = 'NZD']/Value").InnerXml;
            nzd.Text = nzd_;

            xau_ = Val1xml.SelectSingleNode("ValCurs/ ValType [@Type='Bank metalları']/Valute [@Code = 'XAU']/Value").InnerXml;
            xau.Text = xau_;

            xag_ = Val1xml.SelectSingleNode("ValCurs/ ValType [@Type='Bank metalları']/Valute [@Code = 'XAG']/Value").InnerXml;
            xag.Text = xag_;

            xpt_ = Val1xml.SelectSingleNode("ValCurs/ ValType [@Type='Bank metalları']/Valute [@Code = 'XPT']/Value").InnerXml;
            xpt.Text = xpt_;

            xpd_ = Val1xml.SelectSingleNode("ValCurs/ ValType [@Type='Bank metalları']/Valute [@Code = 'XPD']/Value").InnerXml;
            xpd.Text = xpd_;

        }

        private void timer1_Tick(object sender, EventArgs e)
            {
                t1.Text = DateTime.Now.ToString("HH:mm:ss");
                t2.Text = DateTime.Now.ToShortDateString();
                timer1.Start();
            }

        private void s2_Click(object sender, EventArgs e)
        {
            valyuta1 val1 = new valyuta1();
            val1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            valyuta2 val2 = new valyuta2();
            val2.Show();
            this.Hide();
        }

        private void valyuta3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculator kal = new calculator();
            kal.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }   

