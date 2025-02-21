namespace AbstractFactory
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
            CmbTipo = new ComboBox();
            TxtMonto = new TextBox();
            label1 = new Label();
            BtnProcesar = new Button();
            label2 = new Label();
            TxtMessage = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(315, 276);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // CmbTipo
            // 
            CmbTipo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CmbTipo.FormattingEnabled = true;
            CmbTipo.Items.AddRange(new object[] { "PayPal", "Stripe" });
            CmbTipo.Location = new Point(119, 333);
            CmbTipo.Name = "CmbTipo";
            CmbTipo.Size = new Size(208, 29);
            CmbTipo.TabIndex = 1;
            // 
            // TxtMonto
            // 
            TxtMonto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtMonto.Location = new Point(119, 297);
            TxtMonto.Name = "TxtMonto";
            TxtMonto.Size = new Size(208, 29);
            TxtMonto.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 303);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 3;
            label1.Text = "Indique el Monto:";
            // 
            // BtnProcesar
            // 
            BtnProcesar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnProcesar.Location = new Point(119, 368);
            BtnProcesar.Name = "BtnProcesar";
            BtnProcesar.Size = new Size(208, 32);
            BtnProcesar.TabIndex = 4;
            BtnProcesar.Text = "Procesar";
            BtnProcesar.UseVisualStyleBackColor = true;
            BtnProcesar.Click += BtnProcesar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 339);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 5;
            label2.Text = "Seleccione:";
            // 
            // TxtMessage
            // 
            TxtMessage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtMessage.Location = new Point(12, 411);
            TxtMessage.Multiline = true;
            TxtMessage.Name = "TxtMessage";
            TxtMessage.Size = new Size(315, 84);
            TxtMessage.TabIndex = 6;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 509);
            Controls.Add(TxtMessage);
            Controls.Add(label2);
            Controls.Add(BtnProcesar);
            Controls.Add(label1);
            Controls.Add(TxtMonto);
            Controls.Add(CmbTipo);
            Controls.Add(pictureBox1);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Patrón de Diseño - AbstractFactory";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ComboBox CmbTipo;
        private TextBox TxtMonto;
        private Label label1;
        private Button BtnProcesar;
        private Label label2;
        private TextBox TxtMessage;
    }
}
