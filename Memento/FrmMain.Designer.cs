namespace Memento
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
            BtnNewGame = new Button();
            TxtMessage = new TextBox();
            BtnLevel1 = new Button();
            BtnLevel2 = new Button();
            BtnLevel3 = new Button();
            BtnMemento = new Button();
            CmbLevel = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(253, 271);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // BtnNewGame
            // 
            BtnNewGame.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnNewGame.Location = new Point(290, 12);
            BtnNewGame.Name = "BtnNewGame";
            BtnNewGame.Size = new Size(190, 30);
            BtnNewGame.TabIndex = 1;
            BtnNewGame.Text = "New Game";
            BtnNewGame.UseVisualStyleBackColor = true;
            BtnNewGame.Click += BtnNewGame_Click;
            // 
            // TxtMessage
            // 
            TxtMessage.Location = new Point(290, 190);
            TxtMessage.Multiline = true;
            TxtMessage.Name = "TxtMessage";
            TxtMessage.Size = new Size(190, 93);
            TxtMessage.TabIndex = 2;
            // 
            // BtnLevel1
            // 
            BtnLevel1.Enabled = false;
            BtnLevel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnLevel1.ForeColor = Color.FromArgb(255, 128, 0);
            BtnLevel1.Location = new Point(290, 48);
            BtnLevel1.Name = "BtnLevel1";
            BtnLevel1.Size = new Size(190, 30);
            BtnLevel1.TabIndex = 3;
            BtnLevel1.Text = "Level 1";
            BtnLevel1.UseVisualStyleBackColor = true;
            BtnLevel1.Click += BtnLevel1_Click;
            // 
            // BtnLevel2
            // 
            BtnLevel2.Enabled = false;
            BtnLevel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnLevel2.ForeColor = Color.FromArgb(0, 64, 0);
            BtnLevel2.Location = new Point(290, 83);
            BtnLevel2.Name = "BtnLevel2";
            BtnLevel2.Size = new Size(190, 30);
            BtnLevel2.TabIndex = 4;
            BtnLevel2.Text = "Level 2";
            BtnLevel2.UseVisualStyleBackColor = true;
            BtnLevel2.Click += BtnLevel2_Click;
            // 
            // BtnLevel3
            // 
            BtnLevel3.Enabled = false;
            BtnLevel3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnLevel3.ForeColor = Color.Navy;
            BtnLevel3.Location = new Point(290, 118);
            BtnLevel3.Name = "BtnLevel3";
            BtnLevel3.Size = new Size(190, 30);
            BtnLevel3.TabIndex = 5;
            BtnLevel3.Text = "Level 3";
            BtnLevel3.UseVisualStyleBackColor = true;
            BtnLevel3.Click += BtnLevel3_Click;
            // 
            // BtnMemento
            // 
            BtnMemento.Enabled = false;
            BtnMemento.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnMemento.ForeColor = Color.Purple;
            BtnMemento.Location = new Point(356, 154);
            BtnMemento.Name = "BtnMemento";
            BtnMemento.Size = new Size(124, 30);
            BtnMemento.TabIndex = 6;
            BtnMemento.Text = "Memento";
            BtnMemento.UseVisualStyleBackColor = true;
            BtnMemento.Click += BtnMemento_Click;
            // 
            // CmbLevel
            // 
            CmbLevel.Enabled = false;
            CmbLevel.FormattingEnabled = true;
            CmbLevel.Items.AddRange(new object[] { "1", "2", "3" });
            CmbLevel.Location = new Point(290, 157);
            CmbLevel.Name = "CmbLevel";
            CmbLevel.Size = new Size(60, 23);
            CmbLevel.TabIndex = 7;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 296);
            Controls.Add(CmbLevel);
            Controls.Add(BtnMemento);
            Controls.Add(BtnLevel3);
            Controls.Add(BtnLevel2);
            Controls.Add(BtnLevel1);
            Controls.Add(TxtMessage);
            Controls.Add(BtnNewGame);
            Controls.Add(pictureBox1);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Patrón de Diseño - Memento";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button BtnNewGame;
        private TextBox TxtMessage;
        private Button BtnLevel1;
        private Button BtnLevel2;
        private Button BtnLevel3;
        private Button BtnMemento;
        private ComboBox CmbLevel;
    }
}
