namespace FactoryMethod
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
            BtnAuto = new Button();
            BtnMoto = new Button();
            BtnBici = new Button();
            TxtMessage = new TextBox();
            BtnProbar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(272, 307);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // BtnAuto
            // 
            BtnAuto.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAuto.Location = new Point(312, 13);
            BtnAuto.Name = "BtnAuto";
            BtnAuto.Size = new Size(235, 41);
            BtnAuto.TabIndex = 1;
            BtnAuto.Text = "Auto";
            BtnAuto.UseVisualStyleBackColor = true;
            BtnAuto.Click += BtnAuto_Click;
            // 
            // BtnMoto
            // 
            BtnMoto.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnMoto.Location = new Point(312, 59);
            BtnMoto.Name = "BtnMoto";
            BtnMoto.Size = new Size(235, 41);
            BtnMoto.TabIndex = 2;
            BtnMoto.Text = "Moto";
            BtnMoto.UseVisualStyleBackColor = true;
            BtnMoto.Click += BtnMoto_Click;
            // 
            // BtnBici
            // 
            BtnBici.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnBici.Location = new Point(312, 105);
            BtnBici.Name = "BtnBici";
            BtnBici.Size = new Size(235, 41);
            BtnBici.TabIndex = 3;
            BtnBici.Text = "Bicicleta";
            BtnBici.UseVisualStyleBackColor = true;
            BtnBici.Click += BtnBici_Click;
            // 
            // TxtMessage
            // 
            TxtMessage.Location = new Point(315, 213);
            TxtMessage.Multiline = true;
            TxtMessage.Name = "TxtMessage";
            TxtMessage.Size = new Size(232, 106);
            TxtMessage.TabIndex = 4;
            // 
            // BtnProbar
            // 
            BtnProbar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnProbar.ForeColor = Color.Green;
            BtnProbar.Location = new Point(312, 158);
            BtnProbar.Name = "BtnProbar";
            BtnProbar.Size = new Size(235, 41);
            BtnProbar.TabIndex = 5;
            BtnProbar.Text = "Probar";
            BtnProbar.UseVisualStyleBackColor = true;
            BtnProbar.Click += BtnProbar_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 334);
            Controls.Add(BtnProbar);
            Controls.Add(TxtMessage);
            Controls.Add(BtnBici);
            Controls.Add(BtnMoto);
            Controls.Add(BtnAuto);
            Controls.Add(pictureBox1);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Patrón de Diseño - Factory Method";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button BtnAuto;
        private Button BtnMoto;
        private Button BtnBici;
        private TextBox TxtMessage;
        private Button BtnProbar;
    }
}
