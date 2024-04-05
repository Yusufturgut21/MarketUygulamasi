namespace Market
{
    partial class Satış
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
            label1 = new Label();
            label2 = new Label();
            satiş_btn = new Button();
            seri_txt = new TextBox();
            adet_txt = new TextBox();
            label3 = new Label();
            alinan_txt = new TextBox();
            label4 = new Label();
            label6 = new Label();
            tutar_lbl = new Label();
            paraust_lbl = new Label();
            hesapla_txt = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Red;
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(67, 104);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 0;
            label1.Text = "SERİNO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Red;
            label2.ForeColor = Color.Yellow;
            label2.Location = new Point(67, 167);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 1;
            label2.Text = "MİKTAR";
            // 
            // satiş_btn
            // 
            satiş_btn.Location = new Point(162, 235);
            satiş_btn.Name = "satiş_btn";
            satiş_btn.Size = new Size(94, 29);
            satiş_btn.TabIndex = 2;
            satiş_btn.Text = "SATIŞ";
            satiş_btn.UseVisualStyleBackColor = true;
           
            // 
            // seri_txt
            // 
            seri_txt.Location = new Point(162, 104);
            seri_txt.Name = "seri_txt";
            seri_txt.Size = new Size(125, 27);
            seri_txt.TabIndex = 3;
            // 
            // adet_txt
            // 
            adet_txt.Location = new Point(162, 160);
            adet_txt.Name = "adet_txt";
            adet_txt.Size = new Size(125, 27);
            adet_txt.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Red;
            label3.ForeColor = Color.Yellow;
            label3.Location = new Point(405, 174);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 5;
            label3.Text = "ALINAN PARA";
            // 
            // alinan_txt
            // 
            alinan_txt.Location = new Point(539, 171);
            alinan_txt.Name = "alinan_txt";
            alinan_txt.Size = new Size(125, 27);
            alinan_txt.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Red;
            label4.ForeColor = Color.Yellow;
            label4.Location = new Point(405, 107);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 9;
            label4.Text = "TUTAR";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Red;
            label6.ForeColor = Color.Yellow;
            label6.Location = new Point(405, 292);
            label6.Name = "label6";
            label6.Size = new Size(85, 20);
            label6.TabIndex = 10;
            label6.Text = "PARA ÜSTÜ";
            // 
            // tutar_lbl
            // 
            tutar_lbl.AutoSize = true;
            tutar_lbl.Location = new Point(539, 107);
            tutar_lbl.Name = "tutar_lbl";
            tutar_lbl.Size = new Size(50, 20);
            tutar_lbl.TabIndex = 8;
            tutar_lbl.Text = "label5";
            // 
            // paraust_lbl
            // 
            paraust_lbl.AutoSize = true;
            paraust_lbl.Location = new Point(539, 292);
            paraust_lbl.Name = "paraust_lbl";
            paraust_lbl.Size = new Size(50, 20);
            paraust_lbl.TabIndex = 11;
            paraust_lbl.Text = "label7";
            // 
            // hesapla_txt
            // 
            hesapla_txt.Location = new Point(405, 235);
            hesapla_txt.Name = "hesapla_txt";
            hesapla_txt.Size = new Size(94, 29);
            hesapla_txt.TabIndex = 12;
            hesapla_txt.Text = "HESAPLA";
            hesapla_txt.UseVisualStyleBackColor = true;
            hesapla_txt.Click += hesapla_txt_Click;
            // 
            // Satış
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(hesapla_txt);
            Controls.Add(paraust_lbl);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(tutar_lbl);
            Controls.Add(alinan_txt);
            Controls.Add(label3);
            Controls.Add(adet_txt);
            Controls.Add(seri_txt);
            Controls.Add(satiş_btn);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Satış";
            Text = "Satış";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button satiş_btn;
        private TextBox seri_txt;
        private TextBox adet_txt;
        private Label label3;
        private TextBox alinan_txt;
        private Label label4;
        private Label label6;
        private Label tutar_lbl;
        private Label paraust_lbl;
        private Button hesapla_txt;
    }
}