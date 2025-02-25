namespace Proxy
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
            label1 = new Label();
            BtnRetirar = new Button();
            TxtMonto = new TextBox();
            LblInfo = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(347, 363);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 388);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 1;
            label1.Text = "Monto:";
            // 
            // BtnRetirar
            // 
            BtnRetirar.Location = new Point(173, 385);
            BtnRetirar.Name = "BtnRetirar";
            BtnRetirar.Size = new Size(75, 23);
            BtnRetirar.TabIndex = 2;
            BtnRetirar.Text = "Retirar";
            BtnRetirar.UseVisualStyleBackColor = true;
            BtnRetirar.Click += BtnRetirar_Click;
            // 
            // TxtMonto
            // 
            TxtMonto.Location = new Point(67, 384);
            TxtMonto.Name = "TxtMonto";
            TxtMonto.Size = new Size(100, 23);
            TxtMonto.TabIndex = 3;
            // 
            // LblInfo
            // 
            LblInfo.AutoSize = true;
            LblInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblInfo.Location = new Point(16, 419);
            LblInfo.Name = "LblInfo";
            LblInfo.Size = new Size(33, 17);
            LblInfo.TabIndex = 4;
            LblInfo.Text = "Info";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 450);
            Controls.Add(LblInfo);
            Controls.Add(TxtMonto);
            Controls.Add(BtnRetirar);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Patrón de Diseño - Proxy";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button BtnRetirar;
        private TextBox TxtMonto;
        private Label LblInfo;
    }
}
