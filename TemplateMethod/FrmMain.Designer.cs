namespace TemplateMethod
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
            BtnBanco = new Button();
            BtnSoftware = new Button();
            ListActividades = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(28, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(286, 201);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // BtnBanco
            // 
            BtnBanco.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnBanco.Location = new Point(28, 247);
            BtnBanco.Name = "BtnBanco";
            BtnBanco.Size = new Size(97, 32);
            BtnBanco.TabIndex = 2;
            BtnBanco.Text = "Banco";
            BtnBanco.UseVisualStyleBackColor = true;
            BtnBanco.Click += BtnBanco_Click;
            // 
            // BtnSoftware
            // 
            BtnSoftware.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSoftware.Location = new Point(136, 247);
            BtnSoftware.Name = "BtnSoftware";
            BtnSoftware.Size = new Size(176, 32);
            BtnSoftware.TabIndex = 3;
            BtnSoftware.Text = "Software Factory";
            BtnSoftware.UseVisualStyleBackColor = true;
            BtnSoftware.Click += BtnSoftware_Click;
            // 
            // ListActividades
            // 
            ListActividades.FormattingEnabled = true;
            ListActividades.Location = new Point(27, 299);
            ListActividades.Name = "ListActividades";
            ListActividades.Size = new Size(287, 124);
            ListActividades.TabIndex = 4;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 450);
            Controls.Add(ListActividades);
            Controls.Add(BtnSoftware);
            Controls.Add(BtnBanco);
            Controls.Add(pictureBox1);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Patrón de Diseño TemplateMethod - RRHH";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Button BtnBanco;
        private Button BtnSoftware;
        private ListBox ListActividades;
    }
}
