namespace Singleton
{
    partial class FrmEventLogger
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            ListEvents = new ListBox();
            groupBox2 = new GroupBox();
            TxtMessage = new TextBox();
            BtnRegistrar = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ListEvents);
            groupBox1.Location = new Point(12, 118);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(377, 226);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Eventos";
            // 
            // ListEvents
            // 
            ListEvents.FormattingEnabled = true;
            ListEvents.Location = new Point(15, 22);
            ListEvents.Name = "ListEvents";
            ListEvents.Size = new Size(344, 184);
            ListEvents.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(TxtMessage);
            groupBox2.Controls.Add(BtnRegistrar);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(377, 100);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // TxtMessage
            // 
            TxtMessage.Location = new Point(20, 33);
            TxtMessage.Name = "TxtMessage";
            TxtMessage.Size = new Size(339, 23);
            TxtMessage.TabIndex = 1;
            // 
            // BtnRegistrar
            // 
            BtnRegistrar.Location = new Point(143, 65);
            BtnRegistrar.Name = "BtnRegistrar";
            BtnRegistrar.Size = new Size(75, 23);
            BtnRegistrar.TabIndex = 0;
            BtnRegistrar.Text = "Registrar";
            BtnRegistrar.UseVisualStyleBackColor = true;
            BtnRegistrar.Click += BtnRegistrar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(269, 65);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Registrar 2";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmEventLogger
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 360);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmEventLogger";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EventLogger - Patrón Singleton";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox ListEvents;
        private GroupBox groupBox2;
        private TextBox TxtMessage;
        private Button BtnRegistrar;
        private Button button1;
    }
}