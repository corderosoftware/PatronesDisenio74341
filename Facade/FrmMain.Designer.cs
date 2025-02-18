namespace Facade
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            pictureBox1 = new PictureBox();
            BtnMovie = new Button();
            BtnStop = new Button();
            TxtMessage = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(342, 243);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // BtnMovie
            // 
            BtnMovie.Font = new Font("Segoe UI", 12F);
            BtnMovie.Location = new Point(13, 376);
            BtnMovie.Name = "BtnMovie";
            BtnMovie.Size = new Size(179, 35);
            BtnMovie.TabIndex = 2;
            BtnMovie.Text = "Reproducir Película";
            BtnMovie.UseVisualStyleBackColor = true;
            BtnMovie.Click += BtnMovie_Click;
            // 
            // BtnStop
            // 
            BtnStop.Enabled = false;
            BtnStop.Font = new Font("Segoe UI", 12F);
            BtnStop.Location = new Point(198, 376);
            BtnStop.Name = "BtnStop";
            BtnStop.Size = new Size(156, 35);
            BtnStop.TabIndex = 5;
            BtnStop.Text = "Detener";
            BtnStop.UseVisualStyleBackColor = true;
            BtnStop.Click += BtnStop_Click;
            // 
            // TxtMessage
            // 
            TxtMessage.Location = new Point(13, 268);
            TxtMessage.Multiline = true;
            TxtMessage.Name = "TxtMessage";
            TxtMessage.Size = new Size(341, 99);
            TxtMessage.TabIndex = 6;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 421);
            Controls.Add(TxtMessage);
            Controls.Add(BtnStop);
            Controls.Add(BtnMovie);
            Controls.Add(pictureBox1);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Patrón de Diseño - Facade";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button BtnMovie;
        private Button BtnStop;
        private TextBox TxtMessage;
    }
}
