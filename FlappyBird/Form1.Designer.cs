namespace FlappyBird
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
            this.components = new System.ComponentModel.Container();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblRekor = new System.Windows.Forms.Label();
            this.pbPipe5 = new System.Windows.Forms.PictureBox();
            this.pbPipe3 = new System.Windows.Forms.PictureBox();
            this.pbPipe1 = new System.Windows.Forms.PictureBox();
            this.pbGround = new System.Windows.Forms.PictureBox();
            this.pbPipe6 = new System.Windows.Forms.PictureBox();
            this.pbPipe4 = new System.Windows.Forms.PictureBox();
            this.pbPipe2 = new System.Windows.Forms.PictureBox();
            this.pbBird = new System.Windows.Forms.PictureBox();
            this.tmrGame = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBird)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.BackColor = System.Drawing.SystemColors.Info;
            this.lblScore.Location = new System.Drawing.Point(12, 478);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(129, 24);
            this.lblScore.TabIndex = 19;
            this.lblScore.Text = "Score: ";
            // 
            // lblRekor
            // 
            this.lblRekor.BackColor = System.Drawing.SystemColors.Info;
            this.lblRekor.Location = new System.Drawing.Point(296, 478);
            this.lblRekor.Name = "lblRekor";
            this.lblRekor.Size = new System.Drawing.Size(222, 24);
            this.lblRekor.TabIndex = 20;
            this.lblRekor.Text = "Highest Score:";
            // 
            // pbPipe5
            // 
            this.pbPipe5.Image = global::FlappyBird.Properties.Resources.pipe;
            this.pbPipe5.Location = new System.Drawing.Point(720, 362);
            this.pbPipe5.Name = "pbPipe5";
            this.pbPipe5.Size = new System.Drawing.Size(100, 100);
            this.pbPipe5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPipe5.TabIndex = 18;
            this.pbPipe5.TabStop = false;
            // 
            // pbPipe3
            // 
            this.pbPipe3.Image = global::FlappyBird.Properties.Resources.pipe;
            this.pbPipe3.Location = new System.Drawing.Point(510, 412);
            this.pbPipe3.Name = "pbPipe3";
            this.pbPipe3.Size = new System.Drawing.Size(100, 50);
            this.pbPipe3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPipe3.TabIndex = 17;
            this.pbPipe3.TabStop = false;
            // 
            // pbPipe1
            // 
            this.pbPipe1.Image = global::FlappyBird.Properties.Resources.pipe;
            this.pbPipe1.Location = new System.Drawing.Point(300, 312);
            this.pbPipe1.Name = "pbPipe1";
            this.pbPipe1.Size = new System.Drawing.Size(100, 150);
            this.pbPipe1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPipe1.TabIndex = 16;
            this.pbPipe1.TabStop = false;
            // 
            // pbGround
            // 
            this.pbGround.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbGround.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbGround.Image = global::FlappyBird.Properties.Resources.ground;
            this.pbGround.Location = new System.Drawing.Point(0, 461);
            this.pbGround.Name = "pbGround";
            this.pbGround.Size = new System.Drawing.Size(534, 50);
            this.pbGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGround.TabIndex = 15;
            this.pbGround.TabStop = false;
            // 
            // pbPipe6
            // 
            this.pbPipe6.Image = global::FlappyBird.Properties.Resources.pipedown;
            this.pbPipe6.Location = new System.Drawing.Point(720, 0);
            this.pbPipe6.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pbPipe6.Name = "pbPipe6";
            this.pbPipe6.Size = new System.Drawing.Size(100, 200);
            this.pbPipe6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPipe6.TabIndex = 14;
            this.pbPipe6.TabStop = false;
            // 
            // pbPipe4
            // 
            this.pbPipe4.Image = global::FlappyBird.Properties.Resources.pipedown;
            this.pbPipe4.Location = new System.Drawing.Point(510, 0);
            this.pbPipe4.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pbPipe4.Name = "pbPipe4";
            this.pbPipe4.Size = new System.Drawing.Size(100, 250);
            this.pbPipe4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPipe4.TabIndex = 11;
            this.pbPipe4.TabStop = false;
            // 
            // pbPipe2
            // 
            this.pbPipe2.Image = global::FlappyBird.Properties.Resources.pipedown;
            this.pbPipe2.Location = new System.Drawing.Point(300, 0);
            this.pbPipe2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pbPipe2.Name = "pbPipe2";
            this.pbPipe2.Size = new System.Drawing.Size(100, 150);
            this.pbPipe2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPipe2.TabIndex = 9;
            this.pbPipe2.TabStop = false;
            // 
            // pbBird
            // 
            this.pbBird.Image = global::FlappyBird.Properties.Resources.birdnew;
            this.pbBird.Location = new System.Drawing.Point(50, 150);
            this.pbBird.Margin = new System.Windows.Forms.Padding(11);
            this.pbBird.Name = "pbBird";
            this.pbBird.Size = new System.Drawing.Size(60, 60);
            this.pbBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBird.TabIndex = 8;
            this.pbBird.TabStop = false;
            // 
            // tmrGame
            // 
            this.tmrGame.Enabled = true;
            this.tmrGame.Interval = 20;
            this.tmrGame.Tick += new System.EventHandler(this.tmrGame_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 511);
            this.Controls.Add(this.lblRekor);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pbPipe5);
            this.Controls.Add(this.pbPipe3);
            this.Controls.Add(this.pbPipe1);
            this.Controls.Add(this.pbGround);
            this.Controls.Add(this.pbPipe6);
            this.Controls.Add(this.pbPipe4);
            this.Controls.Add(this.pbPipe2);
            this.Controls.Add(this.pbBird);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBird)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPipe6;
        private System.Windows.Forms.PictureBox pbPipe4;
        private System.Windows.Forms.PictureBox pbPipe2;
        private System.Windows.Forms.PictureBox pbBird;
        private System.Windows.Forms.PictureBox pbGround;
        private System.Windows.Forms.PictureBox pbPipe1;
        private System.Windows.Forms.PictureBox pbPipe3;
        private System.Windows.Forms.PictureBox pbPipe5;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblRekor;
        private System.Windows.Forms.Timer tmrGame;
    }
}

