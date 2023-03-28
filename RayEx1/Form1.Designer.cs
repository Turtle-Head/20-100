namespace RayEx1
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
            output = new RichTextBox();
            panel1 = new Panel();
            b1 = new Button();
            twt = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // output
            // 
            output.BackColor = SystemColors.MenuText;
            output.Font = new Font("Sitka Banner", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            output.ForeColor = Color.Lime;
            output.Location = new Point(3, 3);
            output.Name = "output";
            output.Size = new Size(401, 251);
            output.TabIndex = 0;
            output.Text = "";
            // 
            // panel1
            // 
            panel1.Controls.Add(output);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(407, 257);
            panel1.TabIndex = 1;
            // 
            // b1
            // 
            b1.Location = new Point(225, 275);
            b1.Name = "b1";
            b1.Size = new Size(194, 46);
            b1.TabIndex = 2;
            b1.Text = "100";
            b1.UseVisualStyleBackColor = true;
            b1.Click += b1_Click;
            // 
            // twt
            // 
            twt.Location = new Point(15, 275);
            twt.Name = "twt";
            twt.Size = new Size(188, 46);
            twt.TabIndex = 3;
            twt.Text = "20";
            twt.UseVisualStyleBackColor = true;
            twt.Click += twt_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.blue_2889381_960_720;
            ClientSize = new Size(431, 333);
            Controls.Add(twt);
            Controls.Add(b1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "20-100";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox output;
        private Panel panel1;
        private Button b1;
        private Button twt;
    }
}