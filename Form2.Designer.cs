namespace Shapes
{
    partial class Form2
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
            label1 = new Label();
            InfoPannel = new Panel();
            Refresh_Butt = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 82);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 2;
            label1.Text = "Shapes";
            // 
            // InfoPannel
            // 
            InfoPannel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            InfoPannel.BackColor = SystemColors.ButtonHighlight;
            InfoPannel.Location = new Point(12, 100);
            InfoPannel.Name = "InfoPannel";
            InfoPannel.Size = new Size(759, 338);
            InfoPannel.TabIndex = 3;
            InfoPannel.Paint += InfoPannel_Paint;
            // 
            // Refresh_Butt
            // 
            Refresh_Butt.Location = new Point(560, 74);
            Refresh_Butt.Name = "Refresh_Butt";
            Refresh_Butt.Size = new Size(75, 23);
            Refresh_Butt.TabIndex = 4;
            Refresh_Butt.Text = "Refresh";
            Refresh_Butt.UseVisualStyleBackColor = true;
            Refresh_Butt.Click += Refresh_Butt_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Refresh_Butt);
            Controls.Add(InfoPannel);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Panel InfoPannel;
        private Button Refresh_Butt;
    }
}