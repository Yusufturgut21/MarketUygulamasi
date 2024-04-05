namespace Market
{
    partial class PersonelEkle
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
            ad = new TextBox();
            soyad = new TextBox();
            button1 = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Red;
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(80, 65);
            label1.Name = "label1";
            label1.Size = new Size(30, 20);
            label1.TabIndex = 0;
            label1.Text = "AD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Red;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(80, 114);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 1;
            label2.Text = "SOYAD";
            // 
            // ad
            // 
            ad.Location = new Point(190, 62);
            ad.Name = "ad";
            ad.Size = new Size(125, 27);
            ad.TabIndex = 2;
            // 
            // soyad
            // 
            soyad.Location = new Point(190, 107);
            soyad.Name = "soyad";
            soyad.Size = new Size(125, 27);
            soyad.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(80, 180);
            button1.Name = "button1";
            button1.Size = new Size(199, 54);
            button1.TabIndex = 4;
            button1.Text = "PERSONEL EKLE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(442, 48);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(281, 184);
            listBox1.TabIndex = 5;
            // 
            // PersonelEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(soyad);
            Controls.Add(ad);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PersonelEkle";
            Text = "PersonelEkle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox ad;
        private TextBox soyad;
        private Button button1;
        private ListBox listBox1;
    }
}