namespace PİZZASİPARİS
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtToplam = new System.Windows.Forms.TextBox();
            this.txtadet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Malzemeler = new System.Windows.Forms.GroupBox();
            this.peynir = new System.Windows.Forms.CheckBox();
            this.tonbaligi = new System.Windows.Forms.CheckBox();
            this.mantar = new System.Windows.Forms.CheckBox();
            this.sucuk = new System.Windows.Forms.CheckBox();
            this.salam = new System.Windows.Forms.CheckBox();
            this.zeytin = new System.Windows.Forms.CheckBox();
            this.anquez = new System.Windows.Forms.CheckBox();
            this.mısır = new System.Windows.Forms.CheckBox();
            this.sosis = new System.Windows.Forms.CheckBox();
            this.jambon = new System.Windows.Forms.CheckBox();
            this.radio2 = new System.Windows.Forms.RadioButton();
            this.radio1 = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ebat = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Malzemeler.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(139, 384);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 27);
            this.button2.TabIndex = 25;
            this.button2.Text = "Kapat";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(225, 384);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 27);
            this.button1.TabIndex = 24;
            this.button1.Text = "Sipariş Ver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtToplam
            // 
            this.txtToplam.Location = new System.Drawing.Point(225, 361);
            this.txtToplam.Margin = new System.Windows.Forms.Padding(2);
            this.txtToplam.Name = "txtToplam";
            this.txtToplam.Size = new System.Drawing.Size(80, 20);
            this.txtToplam.TabIndex = 23;
            // 
            // txtadet
            // 
            this.txtadet.Location = new System.Drawing.Point(100, 361);
            this.txtadet.Margin = new System.Windows.Forms.Padding(2);
            this.txtadet.Name = "txtadet";
            this.txtadet.Size = new System.Drawing.Size(60, 20);
            this.txtadet.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(173, 364);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Toplam :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(61, 364);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Adet :";
            // 
            // Malzemeler
            // 
            this.Malzemeler.Controls.Add(this.peynir);
            this.Malzemeler.Controls.Add(this.tonbaligi);
            this.Malzemeler.Controls.Add(this.mantar);
            this.Malzemeler.Controls.Add(this.sucuk);
            this.Malzemeler.Controls.Add(this.salam);
            this.Malzemeler.Controls.Add(this.zeytin);
            this.Malzemeler.Controls.Add(this.anquez);
            this.Malzemeler.Controls.Add(this.mısır);
            this.Malzemeler.Controls.Add(this.sosis);
            this.Malzemeler.Controls.Add(this.jambon);
            this.Malzemeler.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Malzemeler.Location = new System.Drawing.Point(87, 212);
            this.Malzemeler.Margin = new System.Windows.Forms.Padding(2);
            this.Malzemeler.Name = "Malzemeler";
            this.Malzemeler.Padding = new System.Windows.Forms.Padding(2);
            this.Malzemeler.Size = new System.Drawing.Size(193, 136);
            this.Malzemeler.TabIndex = 19;
            this.Malzemeler.TabStop = false;
            this.Malzemeler.Text = "Malzemeler";
            // 
            // peynir
            // 
            this.peynir.AutoSize = true;
            this.peynir.Location = new System.Drawing.Point(112, 114);
            this.peynir.Margin = new System.Windows.Forms.Padding(2);
            this.peynir.Name = "peynir";
            this.peynir.Size = new System.Drawing.Size(61, 17);
            this.peynir.TabIndex = 9;
            this.peynir.Text = "Peynir";
            this.peynir.UseVisualStyleBackColor = true;
            // 
            // tonbaligi
            // 
            this.tonbaligi.AutoSize = true;
            this.tonbaligi.Location = new System.Drawing.Point(112, 92);
            this.tonbaligi.Margin = new System.Windows.Forms.Padding(2);
            this.tonbaligi.Name = "tonbaligi";
            this.tonbaligi.Size = new System.Drawing.Size(83, 17);
            this.tonbaligi.TabIndex = 8;
            this.tonbaligi.Text = "Ton Balığı";
            this.tonbaligi.UseVisualStyleBackColor = true;
            // 
            // mantar
            // 
            this.mantar.AutoSize = true;
            this.mantar.Location = new System.Drawing.Point(112, 70);
            this.mantar.Margin = new System.Windows.Forms.Padding(2);
            this.mantar.Name = "mantar";
            this.mantar.Size = new System.Drawing.Size(65, 17);
            this.mantar.TabIndex = 7;
            this.mantar.Text = "Mantar";
            this.mantar.UseVisualStyleBackColor = true;
            // 
            // sucuk
            // 
            this.sucuk.AutoSize = true;
            this.sucuk.Location = new System.Drawing.Point(112, 49);
            this.sucuk.Margin = new System.Windows.Forms.Padding(2);
            this.sucuk.Name = "sucuk";
            this.sucuk.Size = new System.Drawing.Size(62, 17);
            this.sucuk.TabIndex = 6;
            this.sucuk.Text = "Sucuk";
            this.sucuk.UseVisualStyleBackColor = true;
            // 
            // salam
            // 
            this.salam.AutoSize = true;
            this.salam.Location = new System.Drawing.Point(112, 28);
            this.salam.Margin = new System.Windows.Forms.Padding(2);
            this.salam.Name = "salam";
            this.salam.Size = new System.Drawing.Size(60, 17);
            this.salam.TabIndex = 5;
            this.salam.Text = "Salam";
            this.salam.UseVisualStyleBackColor = true;
            // 
            // zeytin
            // 
            this.zeytin.AutoSize = true;
            this.zeytin.Location = new System.Drawing.Point(13, 115);
            this.zeytin.Margin = new System.Windows.Forms.Padding(2);
            this.zeytin.Name = "zeytin";
            this.zeytin.Size = new System.Drawing.Size(61, 17);
            this.zeytin.TabIndex = 4;
            this.zeytin.Text = "Zeytin";
            this.zeytin.UseVisualStyleBackColor = true;
            // 
            // anquez
            // 
            this.anquez.AutoSize = true;
            this.anquez.Location = new System.Drawing.Point(13, 93);
            this.anquez.Margin = new System.Windows.Forms.Padding(2);
            this.anquez.Name = "anquez";
            this.anquez.Size = new System.Drawing.Size(68, 17);
            this.anquez.TabIndex = 3;
            this.anquez.Text = "Anquez";
            this.anquez.UseVisualStyleBackColor = true;
            // 
            // mısır
            // 
            this.mısır.AutoSize = true;
            this.mısır.Location = new System.Drawing.Point(13, 71);
            this.mısır.Margin = new System.Windows.Forms.Padding(2);
            this.mısır.Name = "mısır";
            this.mısır.Size = new System.Drawing.Size(52, 17);
            this.mısır.TabIndex = 2;
            this.mısır.Text = "Mısır";
            this.mısır.UseVisualStyleBackColor = true;
            // 
            // sosis
            // 
            this.sosis.AutoSize = true;
            this.sosis.Location = new System.Drawing.Point(13, 49);
            this.sosis.Margin = new System.Windows.Forms.Padding(2);
            this.sosis.Name = "sosis";
            this.sosis.Size = new System.Drawing.Size(56, 17);
            this.sosis.TabIndex = 1;
            this.sosis.Text = "Sosis";
            this.sosis.UseVisualStyleBackColor = true;
            // 
            // jambon
            // 
            this.jambon.AutoSize = true;
            this.jambon.Location = new System.Drawing.Point(13, 28);
            this.jambon.Margin = new System.Windows.Forms.Padding(2);
            this.jambon.Name = "jambon";
            this.jambon.Size = new System.Drawing.Size(103, 17);
            this.jambon.TabIndex = 0;
            this.jambon.Text = "Dana Jambon";
            this.jambon.UseVisualStyleBackColor = true;
            // 
            // radio2
            // 
            this.radio2.AutoSize = true;
            this.radio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radio2.Location = new System.Drawing.Point(203, 170);
            this.radio2.Margin = new System.Windows.Forms.Padding(2);
            this.radio2.Name = "radio2";
            this.radio2.Size = new System.Drawing.Size(79, 17);
            this.radio2.TabIndex = 18;
            this.radio2.TabStop = true;
            this.radio2.Text = "Kalın Kenar";
            this.radio2.UseVisualStyleBackColor = true;
            // 
            // radio1
            // 
            this.radio1.AutoSize = true;
            this.radio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radio1.Location = new System.Drawing.Point(87, 170);
            this.radio1.Margin = new System.Windows.Forms.Padding(2);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(77, 17);
            this.radio1.TabIndex = 17;
            this.radio1.TabStop = true;
            this.radio1.Text = "İnce Kenar";
            this.radio1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "American Hot",
            "Callypso",
            "Turkish",
            "Pizza İtaliano",
            "Extravaganzza"});
            this.listBox1.Location = new System.Drawing.Point(87, 85);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(194, 69);
            this.listBox1.TabIndex = 16;
            // 
            // ebat
            // 
            this.ebat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ebat.FormattingEnabled = true;
            this.ebat.Items.AddRange(new object[] {
            "Büyük",
            "Orta",
            "Küçük"});
            this.ebat.Location = new System.Drawing.Point(87, 60);
            this.ebat.Margin = new System.Windows.Forms.Padding(2);
            this.ebat.Name = "ebat";
            this.ebat.Size = new System.Drawing.Size(194, 21);
            this.ebat.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(35, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ebat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 36);
            this.label1.TabIndex = 13;
            this.label1.Text = "PİZZA SİPARİŞ EKRANI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 510);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtToplam);
            this.Controls.Add(this.txtadet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Malzemeler);
            this.Controls.Add(this.radio2);
            this.Controls.Add(this.radio1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ebat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Malzemeler.ResumeLayout(false);
            this.Malzemeler.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtToplam;
        private System.Windows.Forms.TextBox txtadet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox Malzemeler;
        private System.Windows.Forms.CheckBox peynir;
        private System.Windows.Forms.CheckBox tonbaligi;
        private System.Windows.Forms.CheckBox mantar;
        private System.Windows.Forms.CheckBox sucuk;
        private System.Windows.Forms.CheckBox salam;
        private System.Windows.Forms.CheckBox zeytin;
        private System.Windows.Forms.CheckBox anquez;
        private System.Windows.Forms.CheckBox mısır;
        private System.Windows.Forms.CheckBox sosis;
        private System.Windows.Forms.CheckBox jambon;
        private System.Windows.Forms.RadioButton radio2;
        private System.Windows.Forms.RadioButton radio1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox ebat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

