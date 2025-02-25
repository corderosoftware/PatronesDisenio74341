namespace Builder
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
            BtnClasic = new Button();
            BtnVeggie = new Button();
            TxtMessage = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(450, 197);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // BtnClasic
            // 
            BtnClasic.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnClasic.Location = new Point(61, 216);
            BtnClasic.Name = "BtnClasic";
            BtnClasic.Size = new Size(146, 35);
            BtnClasic.TabIndex = 1;
            BtnClasic.Text = "Clasic";
            BtnClasic.UseVisualStyleBackColor = true;
            BtnClasic.Click += BtnClasic_Click;
            // 
            // BtnVeggie
            // 
            BtnVeggie.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnVeggie.Location = new Point(280, 216);
            BtnVeggie.Name = "BtnVeggie";
            BtnVeggie.Size = new Size(146, 35);
            BtnVeggie.TabIndex = 2;
            BtnVeggie.Text = "Veggie";
            BtnVeggie.UseVisualStyleBackColor = true;
            BtnVeggie.Click += BtnVeggie_Click;
            // 
            // TxtMessage
            // 
            TxtMessage.Location = new Point(61, 259);
            TxtMessage.Multiline = true;
            TxtMessage.Name = "TxtMessage";
            TxtMessage.Size = new Size(365, 117);
            TxtMessage.TabIndex = 3;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 391);
            Controls.Add(TxtMessage);
            Controls.Add(BtnVeggie);
            Controls.Add(BtnClasic);
            Controls.Add(pictureBox1);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Patrón de Diseño - Builder";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button BtnClasic;
        private Button BtnVeggie;
        private TextBox TxtMessage;
    }
}
