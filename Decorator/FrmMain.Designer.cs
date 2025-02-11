namespace Decorator
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
            BtnTocino = new Button();
            BtnQueso = new Button();
            TxtMessage = new TextBox();
            BtnPedido = new Button();
            BtnFinPedido = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(268, 243);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // BtnTocino
            // 
            BtnTocino.Enabled = false;
            BtnTocino.Image = (Image)resources.GetObject("BtnTocino.Image");
            BtnTocino.Location = new Point(329, 69);
            BtnTocino.Name = "BtnTocino";
            BtnTocino.Size = new Size(167, 101);
            BtnTocino.TabIndex = 1;
            BtnTocino.UseVisualStyleBackColor = true;
            BtnTocino.Click += BtnTocino_Click;
            // 
            // BtnQueso
            // 
            BtnQueso.Enabled = false;
            BtnQueso.Image = (Image)resources.GetObject("BtnQueso.Image");
            BtnQueso.Location = new Point(513, 69);
            BtnQueso.Name = "BtnQueso";
            BtnQueso.Size = new Size(167, 101);
            BtnQueso.TabIndex = 2;
            BtnQueso.UseVisualStyleBackColor = true;
            BtnQueso.Click += BtnQueso_Click;
            // 
            // TxtMessage
            // 
            TxtMessage.Location = new Point(329, 178);
            TxtMessage.Multiline = true;
            TxtMessage.Name = "TxtMessage";
            TxtMessage.ReadOnly = true;
            TxtMessage.Size = new Size(351, 85);
            TxtMessage.TabIndex = 3;
            // 
            // BtnPedido
            // 
            BtnPedido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPedido.ForeColor = Color.Green;
            BtnPedido.Location = new Point(329, 28);
            BtnPedido.Name = "BtnPedido";
            BtnPedido.Size = new Size(167, 35);
            BtnPedido.TabIndex = 4;
            BtnPedido.Text = "Iniciar Pedido";
            BtnPedido.UseVisualStyleBackColor = true;
            BtnPedido.Click += BtnPedido_Click;
            // 
            // BtnFinPedido
            // 
            BtnFinPedido.Enabled = false;
            BtnFinPedido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnFinPedido.ForeColor = Color.Maroon;
            BtnFinPedido.Location = new Point(513, 28);
            BtnFinPedido.Name = "BtnFinPedido";
            BtnFinPedido.Size = new Size(167, 35);
            BtnFinPedido.TabIndex = 5;
            BtnFinPedido.Text = "Fin Pedido";
            BtnFinPedido.UseVisualStyleBackColor = true;
            BtnFinPedido.Click += BtnFinPedido_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 288);
            Controls.Add(BtnFinPedido);
            Controls.Add(BtnPedido);
            Controls.Add(TxtMessage);
            Controls.Add(BtnQueso);
            Controls.Add(BtnTocino);
            Controls.Add(pictureBox1);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Patrón de diseño Decorator";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button BtnTocino;
        private Button BtnQueso;
        private TextBox TxtMessage;
        private Button BtnPedido;
        private Button BtnFinPedido;
    }
}
