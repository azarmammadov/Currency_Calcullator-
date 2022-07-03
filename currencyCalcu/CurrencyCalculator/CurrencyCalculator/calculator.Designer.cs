
namespace CurrencyCalculator
{
    partial class calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calculator));
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.neticeLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dmtext = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CevCB2 = new System.Windows.Forms.ComboBox();
            this.Dcb1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(226, 390);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(348, 27);
            this.button3.TabIndex = 158;
            this.button3.Text = "Bütün məzənnələrə baxış";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(226, 357);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(348, 27);
            this.button2.TabIndex = 157;
            this.button2.Text = "Çevir";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(226, 330);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 1);
            this.panel1.TabIndex = 156;
            // 
            // neticeLabel
            // 
            this.neticeLabel.AutoSize = true;
            this.neticeLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.neticeLabel.Location = new System.Drawing.Point(226, 308);
            this.neticeLabel.Name = "neticeLabel";
            this.neticeLabel.Size = new System.Drawing.Size(57, 19);
            this.neticeLabel.TabIndex = 155;
            this.neticeLabel.Text = "______";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(226, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 19);
            this.label5.TabIndex = 154;
            this.label5.Text = "Nəticə";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(226, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 19);
            this.label4.TabIndex = 153;
            this.label4.Text = "Çevriləcək valyutanı seçin";
            // 
            // dmtext
            // 
            this.dmtext.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dmtext.Location = new System.Drawing.Point(226, 190);
            this.dmtext.Name = "dmtext";
            this.dmtext.Size = new System.Drawing.Size(348, 26);
            this.dmtext.TabIndex = 152;
            this.dmtext.TextChanged += new System.EventHandler(this.dmtext_TextChanged_1);
            this.dmtext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dmtext_KeyPress_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(226, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 19);
            this.label3.TabIndex = 151;
            this.label3.Text = "Daxil ediləcək valyutanın məbləği";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(226, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 19);
            this.label1.TabIndex = 150;
            this.label1.Text = "Daxil ediləcək valyutanı seçin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(300, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 24);
            this.label2.TabIndex = 149;
            this.label2.Text = "Valyuta kalkulyatoru";
            // 
            // CevCB2
            // 
            this.CevCB2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CevCB2.FormattingEnabled = true;
            this.CevCB2.Items.AddRange(new object[] {
            "Azərbaycan manatı, AZN",
            "ABŞ dolları, USD",
            "Avro, EUR",
            "Astraliya dolları, AUD",
            "Argentina pesosu, ARS",
            "Belarus rublu, BYN",
            "Brazilya realı, BRL",
            "BƏƏ dirhəmi, AED",
            "Cənubi Afrika randı, ZAR",
            "Cənubi Koreya vonu, KRW",
            "Çexiya kronu, CZK",
            "Çili pesosu, CLP",
            "Çin yuanı, CNY",
            "Danimarka kronu, DKK",
            "Gürcüstan larisi, GEL",
            "Honq Konq dolları, HKD",
            "Hindistan rupisi, INR",
            "İngiltərə funt sterlinqi, GBP",
            "İndoneziya rupiası, IDR",
            "İran realı, IRR",
            "İsveç kronu, SEK",
            "İsveçrə frankı, CHF",
            "İsrail şekeli, ILS",
            "Kanada dolları, CAD",
            "Küveyt dinarı, KWD",
            "Qazaxıstan tengəsi, KZT",
            "Qırğızıstan somu, KGS",
            "Livan funtu, LBP",
            "Malaziya rinqqiti, MYR",
            "Meksika pesosu, MXN",
            "Moldova leyi, MDL",
            "Misir funtu, EGP",
            "Norveç kronu, NOK",
            "Özbəkistan somu, UZS",
            "Polşa zlotısı, PLN",
            "Rusiya rublu, RUB",
            "Sinqapur dolları, SGD",
            "Səudiyyə Ərəbistanı rialı, SAR",
            "Türkiyə lirəsi, TRY",
            "Tayvan dolları, TWD",
            "Tacikistan sominisi, TJS",
            "Türkmənistan manatı, TMT",
            "Ukrayna qrivnası, UAH",
            "Yaponiya yeni, JPY",
            "Yeni Zellandiya dolları, NZD",
            "Qızıl, XAU",
            "Gümüş, XAG",
            "Platin, XPT",
            "Palladium, XPD"});
            this.CevCB2.Location = new System.Drawing.Point(226, 261);
            this.CevCB2.Name = "CevCB2";
            this.CevCB2.Size = new System.Drawing.Size(348, 25);
            this.CevCB2.TabIndex = 148;
            this.CevCB2.TextChanged += new System.EventHandler(this.CevCB2_TextChanged);
            // 
            // Dcb1
            // 
            this.Dcb1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Dcb1.FormattingEnabled = true;
            this.Dcb1.Items.AddRange(new object[] {
            "Azərbaycan manatı, AZN",
            "ABŞ dolları, USD",
            "Avro, EUR",
            "Astraliya dolları, AUD",
            "Argentina pesosu, ARS",
            "Belarus rublu, BYN",
            "Brazilya realı, BRL",
            "BƏƏ dirhəmi, AED",
            "Cənubi Afrika randı, ZAR",
            "Cənubi Koreya vonu, KRW",
            "Çexiya kronu, CZK",
            "Çili pesosu, CLP",
            "Çin yuanı, CNY",
            "Danimarka kronu, DKK",
            "Gürcüstan larisi, GEL",
            "Honq Konq dolları, HKD",
            "Hindistan rupisi, INR",
            "İngiltərə funt sterlinqi, GBP",
            "İndoneziya rupiası, IDR",
            "İran realı, IRR",
            "İsveç kronu, SEK",
            "İsveçrə frankı, CHF",
            "İsrail şekeli, ILS",
            "Kanada dolları, CAD",
            "Küveyt dinarı, KWD",
            "Qazaxıstan tengəsi, KZT",
            "Qırğızıstan somu, KGS",
            "Livan funtu, LBP",
            "Malaziya rinqqiti, MYR",
            "Meksika pesosu, MXN",
            "Moldova leyi, MDL",
            "Misir funtu, EGP",
            "Norveç kronu, NOK",
            "Özbəkistan somu, UZS",
            "Polşa zlotısı, PLN",
            "Rusiya rublu, RUB",
            "Sinqapur dolları, SGD",
            "Səudiyyə Ərəbistanı rialı, SAR",
            "Türkiyə lirəsi, TRY",
            "Tayvan dolları, TWD",
            "Tacikistan sominisi, TJS",
            "Türkmənistan manatı, TMT",
            "Ukrayna qrivnası, UAH",
            "Yaponiya yeni, JPY",
            "Yeni Zellandiya dolları, NZD",
            "Qızıl, XAU",
            "Gümüş, XAG",
            "Platin, XPT",
            "Palladium, XPD"});
            this.Dcb1.Location = new System.Drawing.Point(226, 140);
            this.Dcb1.Name = "Dcb1";
            this.Dcb1.Size = new System.Drawing.Size(348, 25);
            this.Dcb1.TabIndex = 147;
            this.Dcb1.TextChanged += new System.EventHandler(this.Dcb1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(773, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 31);
            this.button1.TabIndex = 159;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(840, 484);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.neticeLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dmtext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CevCB2);
            this.Controls.Add(this.Dcb1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "calculator";
            this.Load += new System.EventHandler(this.calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label neticeLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dmtext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CevCB2;
        private System.Windows.Forms.ComboBox Dcb1;
        private System.Windows.Forms.Button button1;
    }
}