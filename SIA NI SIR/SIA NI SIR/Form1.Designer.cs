namespace SIA_NI_SIR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            checkedListBox1 = new CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(248, 317);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(157, 77);
            button1.TabIndex = 0;
            button1.Text = "Student";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Yellow;
            label3.Location = new Point(262, 171);
            label3.Name = "label3";
            label3.Size = new Size(371, 38);
            label3.TabIndex = 5;
            label3.Text = "QUEZON CITY UNIVERSITY";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(289, 209);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(305, 28);
            label4.TabIndex = 6;
            label4.Text = "Reserve's Officer Training Corp";
            label4.Click += label4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(395, 269);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 3;
            label1.Text = "Login As:";
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(482, 317);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(151, 77);
            button2.TabIndex = 7;
            button2.Text = "Teacher";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(248, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(360, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(235, 248);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(411, 4);
            checkedListBox1.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 0);
            ClientSize = new Size(914, 600);
            Controls.Add(checkedListBox1);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "T";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label3;
        private Label label4;
        private Label label1;
        private Button button2;
        private PictureBox pictureBox1;
        private CheckedListBox checkedListBox1;
    }
}
