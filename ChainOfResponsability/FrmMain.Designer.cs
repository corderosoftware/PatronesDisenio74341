namespace ChainOfResponsability
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
            groupBox1 = new GroupBox();
            TxtObjetivo = new TextBox();
            TxtMonto = new TextBox();
            TxtNro = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            BtnAprobar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(31, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(275, 266);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtObjetivo);
            groupBox1.Controls.Add(TxtMonto);
            groupBox1.Controls.Add(TxtNro);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(31, 294);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(275, 100);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // TxtObjetivo
            // 
            TxtObjetivo.Location = new Point(62, 67);
            TxtObjetivo.Name = "TxtObjetivo";
            TxtObjetivo.Size = new Size(207, 23);
            TxtObjetivo.TabIndex = 5;
            // 
            // TxtMonto
            // 
            TxtMonto.Location = new Point(62, 42);
            TxtMonto.Name = "TxtMonto";
            TxtMonto.Size = new Size(100, 23);
            TxtMonto.TabIndex = 4;
            // 
            // TxtNro
            // 
            TxtNro.Location = new Point(62, 17);
            TxtNro.Name = "TxtNro";
            TxtNro.Size = new Size(100, 23);
            TxtNro.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 70);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 2;
            label3.Text = "Objetivo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 42);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Monto:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 17);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 0;
            label1.Text = "Nro.:";
            // 
            // BtnAprobar
            // 
            BtnAprobar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAprobar.Location = new Point(31, 405);
            BtnAprobar.Name = "BtnAprobar";
            BtnAprobar.Size = new Size(275, 36);
            BtnAprobar.TabIndex = 2;
            BtnAprobar.Text = "Aprobar";
            BtnAprobar.UseVisualStyleBackColor = true;
            BtnAprobar.Click += BtnAprobar_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 450);
            Controls.Add(BtnAprobar);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Patrón de Diseño Chain Of Responsability";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Button BtnAprobar;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox TxtObjetivo;
        private TextBox TxtMonto;
        private TextBox TxtNro;
    }
}
