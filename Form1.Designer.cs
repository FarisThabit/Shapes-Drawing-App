namespace Shapes
{
    partial class Form1
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
            panel1 = new Panel();
            Clear_Butt = new Button();
            Circle_Butt = new Button();
            Line_Butt = new Button();
            Tringle = new Button();
            Square_Butt = new Button();
            Rectangle_Butt = new Button();
            InfoMode_Butt = new Button();
            Drawing_Pannel = new Panel();
            ShapesInfo_Pannel = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(Clear_Butt);
            panel1.Controls.Add(Circle_Butt);
            panel1.Controls.Add(Line_Butt);
            panel1.Controls.Add(Tringle);
            panel1.Controls.Add(Square_Butt);
            panel1.Controls.Add(Rectangle_Butt);
            panel1.Location = new Point(12, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(89, 386);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // Clear_Butt
            // 
            Clear_Butt.Location = new Point(4, 204);
            Clear_Butt.Name = "Clear_Butt";
            Clear_Butt.Size = new Size(75, 23);
            Clear_Butt.TabIndex = 5;
            Clear_Butt.Text = "Clear";
            Clear_Butt.UseVisualStyleBackColor = true;
            Clear_Butt.Click += button1_Click_1;
            // 
            // Circle_Butt
            // 
            Circle_Butt.Location = new Point(6, 117);
            Circle_Butt.Name = "Circle_Butt";
            Circle_Butt.Size = new Size(75, 23);
            Circle_Butt.TabIndex = 3;
            Circle_Butt.Text = "Circle";
            Circle_Butt.UseVisualStyleBackColor = true;
            Circle_Butt.Click += Circle_Butt_Click;
            // 
            // Line_Butt
            // 
            Line_Butt.Location = new Point(4, 175);
            Line_Butt.Name = "Line_Butt";
            Line_Butt.Size = new Size(75, 23);
            Line_Butt.TabIndex = 4;
            Line_Butt.Text = "Line";
            Line_Butt.UseVisualStyleBackColor = true;
            Line_Butt.Click += Line_Butt_Click;
            // 
            // Tringle
            // 
            Tringle.Location = new Point(5, 146);
            Tringle.Name = "Tringle";
            Tringle.Size = new Size(75, 23);
            Tringle.TabIndex = 2;
            Tringle.Text = "Tringle";
            Tringle.UseVisualStyleBackColor = true;
            Tringle.Click += Tringle_Click;
            // 
            // Square_Butt
            // 
            Square_Butt.Location = new Point(6, 91);
            Square_Butt.Name = "Square_Butt";
            Square_Butt.Size = new Size(75, 23);
            Square_Butt.TabIndex = 1;
            Square_Butt.Text = "Square";
            Square_Butt.UseVisualStyleBackColor = true;
            Square_Butt.Click += Square_Butt_Click;
            // 
            // Rectangle_Butt
            // 
            Rectangle_Butt.Location = new Point(7, 64);
            Rectangle_Butt.Name = "Rectangle_Butt";
            Rectangle_Butt.Size = new Size(75, 23);
            Rectangle_Butt.TabIndex = 0;
            Rectangle_Butt.Text = "Rectangle";
            Rectangle_Butt.UseVisualStyleBackColor = true;
            Rectangle_Butt.Click += Rectangle_Butt_Click;
            // 
            // InfoMode_Butt
            // 
            InfoMode_Butt.Location = new Point(571, 23);
            InfoMode_Butt.Name = "InfoMode_Butt";
            InfoMode_Butt.Size = new Size(130, 23);
            InfoMode_Butt.TabIndex = 2;
            InfoMode_Butt.Text = "Info Mode";
            InfoMode_Butt.UseVisualStyleBackColor = true;
            InfoMode_Butt.Click += InfoMode_Butt_Click;
            // 
            // Drawing_Pannel
            // 
            Drawing_Pannel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Drawing_Pannel.BackColor = SystemColors.ButtonHighlight;
            Drawing_Pannel.Location = new Point(107, 52);
            Drawing_Pannel.Name = "Drawing_Pannel";
            Drawing_Pannel.Size = new Size(480, 386);
            Drawing_Pannel.TabIndex = 3;
            Drawing_Pannel.Paint += Drawing_Pannel_Paint;
            // 
            // ShapesInfo_Pannel
            // 
            ShapesInfo_Pannel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ShapesInfo_Pannel.BackColor = SystemColors.ButtonHighlight;
            ShapesInfo_Pannel.Location = new Point(593, 122);
            ShapesInfo_Pannel.Name = "ShapesInfo_Pannel";
            ShapesInfo_Pannel.Size = new Size(200, 316);
            ShapesInfo_Pannel.TabIndex = 4;
            ShapesInfo_Pannel.Paint += ShapesInfo_Pannel_Paint;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(670, 100);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 5;
            label1.Text = "Shapes";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(ShapesInfo_Pannel);
            Controls.Add(Drawing_Pannel);
            Controls.Add(InfoMode_Butt);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Draw App";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button InfoMode_Butt;
        private Panel Drawing_Pannel;
        private Panel ShapesInfo_Pannel;
        private Button Line_Butt;
        private Button Circle_Butt;
        private Button Tringle;
        private Button Square_Butt;
        private Button Rectangle_Butt;
        private Label label1;
        private Button Clear_Butt;
    }
}
