namespace Trello
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
            button1 = new Button();
            button2 = new Button();
            textBox2 = new TextBox();
            panel1 = new Panel();
            button3 = new Button();
            textBox1 = new TextBox();
            okButton = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(934, 12);
            button1.Name = "button1";
            button1.Size = new Size(160, 34);
            button1.TabIndex = 1;
            button1.Text = "hit it";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(934, 52);
            button2.Name = "button2";
            button2.Size = new Size(160, 34);
            button2.TabIndex = 2;
            button2.Text = "add task!";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(934, 92);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(160, 31);
            textBox2.TabIndex = 3;
            textBox2.Visible = false;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = SystemColors.Info;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(6, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(922, 373);
            panel1.TabIndex = 4;
            // 
            // button3
            // 
            button3.Location = new Point(949, 129);
            button3.Name = "button3";
            button3.Size = new Size(131, 133);
            button3.TabIndex = 5;
            button3.Text = "add list!";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(934, 280);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(160, 31);
            textBox1.TabIndex = 6;
            textBox1.Visible = false;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // okButton
            // 
            okButton.Location = new Point(959, 317);
            okButton.Name = "okButton";
            okButton.Size = new Size(112, 34);
            okButton.TabIndex = 7;
            okButton.Text = "OK!";
            okButton.UseVisualStyleBackColor = true;
            okButton.Visible = false;
            okButton.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 451);
            Controls.Add(okButton);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private TextBox textBox2;
        private Panel panel1;
        private Button button3;
        private TextBox textBox1;
        private Button okButton;
    }
}