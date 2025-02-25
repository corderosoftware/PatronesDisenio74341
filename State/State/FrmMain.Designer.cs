namespace State
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
            PicSemaforo = new PictureBox();
            BtnComenzar = new Button();
            ((System.ComponentModel.ISupportInitialize)PicSemaforo).BeginInit();
            SuspendLayout();
            // 
            // PicSemaforo
            // 
            PicSemaforo.Image = Properties.Resources.luzroja;
            PicSemaforo.Location = new Point(23, 24);
            PicSemaforo.Name = "PicSemaforo";
            PicSemaforo.Size = new Size(240, 310);
            PicSemaforo.SizeMode = PictureBoxSizeMode.StretchImage;
            PicSemaforo.TabIndex = 0;
            PicSemaforo.TabStop = false;
            // 
            // BtnComenzar
            // 
            BtnComenzar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnComenzar.Location = new Point(23, 358);
            BtnComenzar.Name = "BtnComenzar";
            BtnComenzar.Size = new Size(240, 47);
            BtnComenzar.TabIndex = 1;
            BtnComenzar.Text = "Request";
            BtnComenzar.UseVisualStyleBackColor = true;
            BtnComenzar.Click += BtnComenzar_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 422);
            Controls.Add(BtnComenzar);
            Controls.Add(PicSemaforo);
            Name = "FrmMain";
            Text = "Patrón de Diseño - State";
            ((System.ComponentModel.ISupportInitialize)PicSemaforo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox PicSemaforo;
        private Button BtnComenzar;
    }
}
