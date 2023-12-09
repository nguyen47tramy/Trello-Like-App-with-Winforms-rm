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
            displayRemoveButton = new Button();
            SuspendLayout();
            // 
            // displayNodeButton
            // 
            displayNodeButton.Location = new Point(425, 51);
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
            addNodeButton.Location = new Point(6, 54);
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
            nodeInputBox.Location = new Point(174, 54);
            nodeInputBox.Name = "nodeInputBox";
            nodeInputBox.Size = new Size(245, 31);
            nodeInputBox.TabIndex = 3;
            nodeInputBox.Visible = false;
            // 
            // board
            // 
            board.AutoScroll = true;
            board.BackColor = SystemColors.Info;
            board.BorderStyle = BorderStyle.FixedSingle;
            board.Location = new Point(6, 116);
            board.Name = "board";
            board.Size = new Size(1165, 376);
            board.TabIndex = 4;
            // 
            // addCardButton
            // 
            addCardButton.Location = new Point(6, 12);
            addCardButton.Name = "addCardButton";
            addCardButton.Size = new Size(160, 38);
            addCardButton.TabIndex = 5;
            addCardButton.Text = "Add Card";
            addCardButton.UseVisualStyleBackColor = true;
            addCardButton.Click += addCardButton_Click;
            // 
            // cardLabelInputBox
            // 
            cardLabelInputBox.Location = new Point(174, 17);
            cardLabelInputBox.Name = "cardLabelInputBox";
            cardLabelInputBox.Size = new Size(245, 31);
            cardLabelInputBox.TabIndex = 6;
            cardLabelInputBox.Visible = false;
            cardLabelInputBox.TextChanged += textBox1_TextChanged;
            // 
            // displayCardButton
            // 
            displayCardButton.Location = new Point(425, 15);
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
            editButton.Location = new Point(640, 15);
            editButton.Name = "editButton";
            editButton.Size = new Size(105, 34);
            editButton.TabIndex = 8;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // editInput
            // 
            editInput.Location = new Point(862, 16);
            editInput.Name = "editInput";
            editInput.Size = new Size(198, 31);
            editInput.TabIndex = 9;
            editInput.Visible = false;
            // 
            // displayEditButton
            // 
            displayEditButton.Location = new Point(1066, 17);
            displayEditButton.Name = "displayEditButton";
            displayEditButton.Size = new Size(105, 34);
            displayEditButton.TabIndex = 10;
            displayEditButton.Text = "OK!";
            displayEditButton.UseVisualStyleBackColor = true;
            displayEditButton.Visible = false;
            displayEditButton.Click += displayEditButton_Click;
            // 
            // inputNode
            // 
            inputNode.Location = new Point(751, 16);
            inputNode.MaxLength = 1;
            inputNode.Name = "inputNode";
            inputNode.PlaceholderText = "which task?";
            inputNode.Size = new Size(105, 31);
            inputNode.TabIndex = 11;
            inputNode.Visible = false;
            inputNode.TextChanged += inputNode_TextChanged;
            inputNode.KeyPress += inputNode_KeyPress;
            // 
            // removeButton
            // 
            removeButton.Location = new Point(640, 54);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(105, 34);
            removeButton.TabIndex = 12;
            removeButton.Text = "Remove";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // removeInput
            // 
            removeInput.Location = new Point(751, 57);
            removeInput.Name = "removeInput";
            removeInput.PlaceholderText = "which task?";
            removeInput.Size = new Size(105, 31);
            removeInput.TabIndex = 13;
            removeInput.Visible = false;
            removeInput.KeyPress += RemoveInput_KeyPress;
            // 
            // displayRemoveButton
            // 
            displayRemoveButton.Location = new Point(1066, 57);
            displayRemoveButton.Name = "displayRemoveButton";
            displayRemoveButton.Size = new Size(105, 34);
            displayRemoveButton.TabIndex = 14;
            displayRemoveButton.Text = "OK!";
            displayRemoveButton.UseVisualStyleBackColor = true;
            displayRemoveButton.Visible = false;
            displayRemoveButton.Click += displayRemoveButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 508);
            Controls.Add(displayRemoveButton);
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
        private Button displayRemoveButton;
    }
}