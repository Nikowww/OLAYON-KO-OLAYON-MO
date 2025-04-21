namespace SIA_NI_SIR
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            textBox1 = new TextBox();
            label1 = new Label();
            checkedListBox1 = new CheckedListBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label5 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(401, 301);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(167, 27);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(280, 305);
            label1.Name = "label1";
            label1.Size = new Size(118, 17);
            label1.TabIndex = 1;
            label1.Text = "Student Number:";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(239, 253);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(411, 4);
            checkedListBox1.TabIndex = 17;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(258, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(360, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(338, 226);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(221, 21);
            label2.TabIndex = 15;
            label2.Text = "Reserve's Officer Training Corp";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Yellow;
            label5.Location = new Point(297, 185);
            label5.Name = "label5";
            label5.Size = new Size(298, 36);
            label5.TabIndex = 14;
            label5.Text = "QUEZON CITY UNIVERSITY";
            // 
            // button1
            // 
            button1.Location = new Point(420, 366);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 18;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 0);
            ClientSize = new Size(914, 600);
            Controls.Add(button1);
            Controls.Add(checkedListBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private CheckedListBox checkedListBox1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label5;
        private Button button1;
    }
}