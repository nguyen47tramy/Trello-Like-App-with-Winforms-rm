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
            displayNodeButton = new Button();
            addNodeButton = new Button();
            nodeInputBox = new TextBox();
            board = new Panel();
            addCardButton = new Button();
            cardLabelInputBox = new TextBox();
            displayCardButton = new Button();
            editButton = new Button();
            editInput = new TextBox();
            displayEditButton = new Button();
            inputNode = new TextBox();
            removeButton = new Button();
            removeInput = new TextBox();
            SuspendLayout();
            // 
            // displayNodeButton
            // 
            displayNodeButton.Location = new Point(955, 254);
            displayNodeButton.Name = "displayNodeButton";
            displayNodeButton.Size = new Size(112, 34);
            displayNodeButton.TabIndex = 1;
            displayNodeButton.Text = "OK!";
            displayNodeButton.UseVisualStyleBackColor = true;
            displayNodeButton.Visible = false;
            displayNodeButton.Click += displayNodeButton_Click;
            // 
            // addNodeButton
            // 
            addNodeButton.Location = new Point(934, 177);
            addNodeButton.Name = "addNodeButton";
            addNodeButton.Size = new Size(160, 34);
            addNodeButton.TabIndex = 2;
            addNodeButton.Text = "Add Task";
            addNodeButton.UseVisualStyleBackColor = true;
            addNodeButton.Visible = false;
            addNodeButton.Click += addNodeButton_Click;
            // 
            // nodeInputBox
            // 
            nodeInputBox.Location = new Point(934, 217);
            nodeInputBox.Name = "nodeInputBox";
            nodeInputBox.Size = new Size(160, 31);
            nodeInputBox.TabIndex = 3;
            nodeInputBox.Visible = false;
            // 
            // board
            // 
            board.AutoScroll = true;
            board.BackColor = SystemColors.Info;
            board.BorderStyle = BorderStyle.FixedSingle;
            board.Location = new Point(6, 3);
            board.Name = "board";
            board.Size = new Size(922, 338);
            board.TabIndex = 4;
            // 
            // addCardButton
            // 
            addCardButton.Location = new Point(934, 12);
            addCardButton.Name = "addCardButton";
            addCardButton.Size = new Size(160, 38);
            addCardButton.TabIndex = 5;
            addCardButton.Text = "Add Card";
            addCardButton.UseVisualStyleBackColor = true;
            addCardButton.Click += addCardButton_Click;
            // 
            // cardLabelInputBox
            // 
            cardLabelInputBox.Location = new Point(934, 56);
            cardLabelInputBox.Name = "cardLabelInputBox";
            cardLabelInputBox.Size = new Size(160, 31);
            cardLabelInputBox.TabIndex = 6;
            cardLabelInputBox.Visible = false;
            cardLabelInputBox.TextChanged += textBox1_TextChanged;
            // 
            // displayCardButton
            // 
            displayCardButton.Location = new Point(955, 93);
            displayCardButton.Name = "displayCardButton";
            displayCardButton.Size = new Size(112, 34);
            displayCardButton.TabIndex = 7;
            displayCardButton.Text = "OK!";
            displayCardButton.UseVisualStyleBackColor = true;
            displayCardButton.Visible = false;
            displayCardButton.Click += displayCard_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(6, 359);
            editButton.Name = "editButton";
            editButton.Size = new Size(160, 34);
            editButton.TabIndex = 8;
            editButton.Text = "edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // editInput
            // 
            editInput.Location = new Point(169, 398);
            editInput.Name = "editInput";
            editInput.Size = new Size(100, 31);
            editInput.TabIndex = 9;
            editInput.Visible = false;
            // 
            // displayEditButton
            // 
            displayEditButton.Location = new Point(172, 359);
            displayEditButton.Name = "displayEditButton";
            displayEditButton.Size = new Size(154, 34);
            displayEditButton.TabIndex = 10;
            displayEditButton.Text = "displayEditButton";
            displayEditButton.UseVisualStyleBackColor = true;
            displayEditButton.Visible = false;
            displayEditButton.Click += displayEditButton_Click;
            // 
            // inputNode
            // 
            inputNode.Location = new Point(6, 399);
            inputNode.MaxLength = 1;
            inputNode.Name = "inputNode";
            inputNode.PlaceholderText = "which task?";
            inputNode.Size = new Size(100, 31);
            inputNode.TabIndex = 11;
            inputNode.TextChanged += inputNode_TextChanged;
            inputNode.KeyPress += inputNode_KeyPress;
            // 
            // removeButton
            // 
            removeButton.Location = new Point(332, 359);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(112, 34);
            removeButton.TabIndex = 12;
            removeButton.Text = "remove";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // removeInput
            // 
            removeInput.Location = new Point(332, 398);
            removeInput.Name = "removeInput";
            removeInput.Size = new Size(150, 31);
            removeInput.TabIndex = 13;
            removeInput.KeyPress += RemoveInput_KeyPress;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1101, 453);
            Controls.Add(removeInput);
            Controls.Add(removeButton);
            Controls.Add(inputNode);
            Controls.Add(displayEditButton);
            Controls.Add(editInput);
            Controls.Add(editButton);
            Controls.Add(displayNodeButton);
            Controls.Add(displayCardButton);
            Controls.Add(nodeInputBox);
            Controls.Add(addNodeButton);
            Controls.Add(cardLabelInputBox);
            Controls.Add(addCardButton);
            Controls.Add(board);
            Name = "Form1";
            Text = "Trello";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button displayNodeButton;
        private Button addNodeButton;
        private TextBox nodeInputBox;
        private Panel board;
        private Button addCardButton;
        private TextBox cardLabelInputBox;
        private Button displayCardButton;
        private Button editButton;
        private TextBox editInput;
        private Button displayEditButton;
        private TextBox inputNode;
        private Button removeButton;
        private TextBox removeInput;
    }
}