namespace zadachi
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
            label2 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Monotype Corsiva", 20.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(173, 8);
            label2.Name = "label2";
            label2.Size = new Size(163, 33);
            label2.TabIndex = 1;
            label2.Text = "zdravei kotence";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Fat_Cat;
            pictureBox1.Location = new Point(295, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 158);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Monotype Corsiva", 12F, FontStyle.Italic, GraphicsUnit.Point, 204);
            button1.Location = new Point(43, 199);
            button1.Name = "button1";
            button1.Size = new Size(82, 39);
            button1.TabIndex = 3;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(501, 524);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Font = new Font("Monotype Corsiva", 9F, FontStyle.Italic, GraphicsUnit.Point, 204);
            Name = "Form1";
            Text = "Zdr";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private PictureBox pictureBox1;
        private Button button1;
    }
}
