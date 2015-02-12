namespace Faktury
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_NazwaZamowienia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bt_dodaj = new System.Windows.Forms.Button();
            this.lv_Zamowienia = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bt_usun = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_nazwaProduktu = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.tb_cena = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_vat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_rabat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_ilosc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lv_produkty = new System.Windows.Forms.ListView();
            this.colNazwa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIlosc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCena = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colVat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRabat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_NazwaZamowienia);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.bt_dodaj);
            this.groupBox1.Controls.Add(this.lv_Zamowienia);
            this.groupBox1.Controls.Add(this.bt_usun);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 314);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista zamówień";
            // 
            // tb_NazwaZamowienia
            // 
            this.tb_NazwaZamowienia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_NazwaZamowienia.Location = new System.Drawing.Point(63, 242);
            this.tb_NazwaZamowienia.Name = "tb_NazwaZamowienia";
            this.tb_NazwaZamowienia.Size = new System.Drawing.Size(115, 21);
            this.tb_NazwaZamowienia.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(6, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Nazwa: ";
            // 
            // bt_dodaj
            // 
            this.bt_dodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_dodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_dodaj.Location = new System.Drawing.Point(184, 238);
            this.bt_dodaj.Name = "bt_dodaj";
            this.bt_dodaj.Size = new System.Drawing.Size(179, 30);
            this.bt_dodaj.TabIndex = 16;
            this.bt_dodaj.Text = "Dodaj zamówienie";
            this.bt_dodaj.UseVisualStyleBackColor = false;
            this.bt_dodaj.Click += new System.EventHandler(this.bt_dodaj_Click);
            // 
            // lv_Zamowienia
            // 
            this.lv_Zamowienia.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lv_Zamowienia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lv_Zamowienia.Location = new System.Drawing.Point(7, 22);
            this.lv_Zamowienia.MultiSelect = false;
            this.lv_Zamowienia.Name = "lv_Zamowienia";
            this.lv_Zamowienia.Size = new System.Drawing.Size(356, 210);
            this.lv_Zamowienia.TabIndex = 5;
            this.lv_Zamowienia.UseCompatibleStateImageBehavior = false;
            this.lv_Zamowienia.View = System.Windows.Forms.View.Details;
            this.lv_Zamowienia.SelectedIndexChanged += new System.EventHandler(this.lv_Zamowienia_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nazwa";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Wartość";
            this.columnHeader2.Width = 85;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Rabat";
            this.columnHeader3.Width = 65;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Produkty";
            this.columnHeader4.Width = 80;
            // 
            // bt_usun
            // 
            this.bt_usun.BackColor = System.Drawing.Color.Red;
            this.bt_usun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_usun.Location = new System.Drawing.Point(184, 274);
            this.bt_usun.Name = "bt_usun";
            this.bt_usun.Size = new System.Drawing.Size(179, 30);
            this.bt_usun.TabIndex = 3;
            this.bt_usun.Text = "Usuń zaznaczone";
            this.bt_usun.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(442, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(573, 314);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zamówienie";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.tb_nazwaProduktu);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.tb_cena);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.tb_vat);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.tb_rabat);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.tb_ilosc);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox4.Location = new System.Drawing.Point(6, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(169, 285);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dodawanie produktu";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(8, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Zmień zaznaczone";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_nazwaProduktu
            // 
            this.tb_nazwaProduktu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_nazwaProduktu.Location = new System.Drawing.Point(61, 30);
            this.tb_nazwaProduktu.Name = "tb_nazwaProduktu";
            this.tb_nazwaProduktu.Size = new System.Drawing.Size(100, 21);
            this.tb_nazwaProduktu.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(8, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 30);
            this.button2.TabIndex = 6;
            this.button2.Text = "Usuń zaznaczone";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(9, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ilość: ";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(8, 171);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 30);
            this.button3.TabIndex = 5;
            this.button3.Text = "Dodaj";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tb_cena
            // 
            this.tb_cena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_cena.Location = new System.Drawing.Point(61, 86);
            this.tb_cena.Name = "tb_cena";
            this.tb_cena.Size = new System.Drawing.Size(100, 21);
            this.tb_cena.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(9, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Rabat: ";
            // 
            // tb_vat
            // 
            this.tb_vat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_vat.Location = new System.Drawing.Point(61, 114);
            this.tb_vat.Name = "tb_vat";
            this.tb_vat.Size = new System.Drawing.Size(100, 21);
            this.tb_vat.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(9, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "VAT: ";
            // 
            // tb_rabat
            // 
            this.tb_rabat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_rabat.Location = new System.Drawing.Point(61, 142);
            this.tb_rabat.Name = "tb_rabat";
            this.tb_rabat.Size = new System.Drawing.Size(100, 21);
            this.tb_rabat.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(9, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cena:";
            // 
            // tb_ilosc
            // 
            this.tb_ilosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_ilosc.Location = new System.Drawing.Point(61, 58);
            this.tb_ilosc.Name = "tb_ilosc";
            this.tb_ilosc.Size = new System.Drawing.Size(100, 21);
            this.tb_ilosc.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(9, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nazwa: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lv_produkty);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.Location = new System.Drawing.Point(181, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(381, 285);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lista produktów";
            // 
            // lv_produkty
            // 
            this.lv_produkty.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNazwa,
            this.colIlosc,
            this.colCena,
            this.colVat,
            this.colRabat});
            this.lv_produkty.Location = new System.Drawing.Point(6, 20);
            this.lv_produkty.MultiSelect = false;
            this.lv_produkty.Name = "lv_produkty";
            this.lv_produkty.Size = new System.Drawing.Size(365, 253);
            this.lv_produkty.TabIndex = 0;
            this.lv_produkty.UseCompatibleStateImageBehavior = false;
            this.lv_produkty.View = System.Windows.Forms.View.Details;
            this.lv_produkty.SelectedIndexChanged += new System.EventHandler(this.lv_produkty_SelectedIndexChanged);
            // 
            // colNazwa
            // 
            this.colNazwa.Text = "Nazwa";
            this.colNazwa.Width = 120;
            // 
            // colIlosc
            // 
            this.colIlosc.Text = "Ilość";
            // 
            // colCena
            // 
            this.colCena.Text = "Cena";
            // 
            // colVat
            // 
            this.colVat.Text = "VAT";
            // 
            // colRabat
            // 
            this.colRabat.Text = "Rabat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 340);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Faktury";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_usun;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_ilosc;
        private System.Windows.Forms.TextBox tb_rabat;
        private System.Windows.Forms.TextBox tb_vat;
        private System.Windows.Forms.TextBox tb_cena;
        private System.Windows.Forms.TextBox tb_nazwaProduktu;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView lv_produkty;
        private System.Windows.Forms.ColumnHeader colNazwa;
        private System.Windows.Forms.ColumnHeader colIlosc;
        private System.Windows.Forms.ColumnHeader colCena;
        private System.Windows.Forms.ColumnHeader colVat;
        private System.Windows.Forms.ColumnHeader colRabat;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView lv_Zamowienia;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox tb_NazwaZamowienia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bt_dodaj;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

