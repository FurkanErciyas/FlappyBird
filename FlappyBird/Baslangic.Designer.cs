namespace FlappyBird
{
    partial class Baslangic
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.cmbZorlukSeviyesi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(43, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(398, 43);
            this.label3.TabIndex = 9;
            this.label3.Text = "NOT: Her bir zorluk seviyesi için; Kolay +3 puan, Orta +6 puan, Zor +9 puan değer" +
    "indedir.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBaslat
            // 
            this.btnBaslat.Location = new System.Drawing.Point(339, 82);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(102, 34);
            this.btnBaslat.TabIndex = 8;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // cmbZorlukSeviyesi
            // 
            this.cmbZorlukSeviyesi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZorlukSeviyesi.FormattingEnabled = true;
            this.cmbZorlukSeviyesi.Items.AddRange(new object[] {
            "Kolay",
            "Orta",
            "Zor"});
            this.cmbZorlukSeviyesi.Location = new System.Drawing.Point(196, 84);
            this.cmbZorlukSeviyesi.Name = "cmbZorlukSeviyesi";
            this.cmbZorlukSeviyesi.Size = new System.Drawing.Size(121, 32);
            this.cmbZorlukSeviyesi.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Flappy Bird\'e Hoş Geldiniz!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Zorluk Seviyesi: ";
            // 
            // Baslangic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 211);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.cmbZorlukSeviyesi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Baslangic";
            this.Text = "Baslangic";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.ComboBox cmbZorlukSeviyesi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}