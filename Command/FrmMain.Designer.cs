namespace Command
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
            BtnNetFilx = new Button();
            BtnAmazon = new Button();
            LblInfo = new Label();
            BtnYoutube = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(331, 243);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // BtnNetFilx
            // 
            BtnNetFilx.BackColor = Color.White;
            BtnNetFilx.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnNetFilx.ForeColor = Color.FromArgb(192, 0, 0);
            BtnNetFilx.Location = new Point(12, 271);
            BtnNetFilx.Name = "BtnNetFilx";
            BtnNetFilx.Size = new Size(166, 44);
            BtnNetFilx.TabIndex = 1;
            BtnNetFilx.Text = "NETFLIX";
            BtnNetFilx.UseVisualStyleBackColor = false;
            BtnNetFilx.Click += BtnNetFilx_Click;
            // 
            // BtnAmazon
            // 
            BtnAmazon.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAmazon.ForeColor = Color.FromArgb(255, 128, 0);
            BtnAmazon.Location = new Point(184, 271);
            BtnAmazon.Name = "BtnAmazon";
            BtnAmazon.Size = new Size(159, 44);
            BtnAmazon.TabIndex = 2;
            BtnAmazon.Text = "Amazon";
            BtnAmazon.UseVisualStyleBackColor = true;
            BtnAmazon.Click += BtnAmazon_Click;
            // 
            // LblInfo
            // 
            LblInfo.AutoSize = true;
            LblInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblInfo.Location = new Point(66, 30);
            LblInfo.Name = "LblInfo";
            LblInfo.Size = new Size(30, 17);
            LblInfo.TabIndex = 3;
            LblInfo.Text = "Info";
            // 
            // BtnYoutube
            // 
            BtnYoutube.BackColor = Color.White;
            BtnYoutube.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnYoutube.ForeColor = Color.FromArgb(192, 0, 0);
            BtnYoutube.Location = new Point(12, 321);
            BtnYoutube.Name = "BtnYoutube";
            BtnYoutube.Size = new Size(331, 44);
            BtnYoutube.TabIndex = 4;
            BtnYoutube.Text = "YouTube";
            BtnYoutube.UseVisualStyleBackColor = false;
            BtnYoutube.Click += BtnYoutube_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 378);
            Controls.Add(BtnYoutube);
            Controls.Add(LblInfo);
            Controls.Add(BtnAmazon);
            Controls.Add(BtnNetFilx);
            Controls.Add(pictureBox1);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Patrón de Diseño Command";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button BtnNetFilx;
        private Button BtnAmazon;
        private Label LblInfo;
        private Button BtnYoutube;
    }
}
