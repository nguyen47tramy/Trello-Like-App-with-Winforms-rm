namespace Trello
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //create a list  to manage card's list 
        //List<LinkedList<string>> cardList = new List<LinkedList<string>>();
        List<CardLinkedList> cardList = new List<CardLinkedList>();


        //create a list to manage the actual visualization of cardList (f)
        List<TextBox> cardboxList = new List<TextBox>();

        //create a list to manage the label of card (f)
        List<Button> labelList = new List<Button>();


        int x = 20; //x-ist of cardbox
        int labelID = 1;

        int detectID = 2;

        private TextBox addCardbox()
        {
            //LinkedList<string> card = new LinkedList<string>();
            CardLinkedList card = new CardLinkedList();

            TextBox cardbox = new TextBox();
            cardbox.Name = "textBox";
            cardbox.BackColor = SystemColors.GradientInactiveCaption;
            cardbox.Multiline = true;
            cardbox.Location = new Point(x, 40);
            cardbox.Size = new Size(163, 275);
            cardbox.ReadOnly = true;
            cardbox.ScrollBars = ScrollBars.Vertical;

            cardboxList.Add(cardbox);
            cardList.Add(card);


            return cardbox;
        }

        private Button addLabel()
        {

            Button label = new Button();
            label.Name = "label";
            label.Text = cardLabelInputBox.Text;
            label.Location = new Point(x, 1);
            label.Size = new Size(160, 34);
            label.Tag = labelID++;
            label.Click += new EventHandler(myHandler);

            labelList.Add(label);

            return label;
        }

        void myHandler(object sender, EventArgs e) //detect card id when click on label
        {

            detectID = (int)(sender as Control).Tag;
            addNodeButton.Visible = true;
            nodeInputBox.Visible = true;
            displayNodeButton.Visible = true;
            Console.WriteLine("detectID: " + detectID);

        }

        Node current;
        bool clearFlag = false;
        bool onlyOneFlag = false;

        private void displayAll()
        {
            cardboxList.ElementAt(detectID - 1).Clear();

            if (cardList.ElementAt(detectID - 1).First == null)
            {
                cardboxList.ElementAt(detectID - 1).Text = "EMPTY";
                clearFlag = false;
                displayRemoveButton.Visible = false;
            }

            if (cardList.ElementAt(detectID - 1).First != null && cardList.ElementAt(detectID - 1).First.Next == null)
            {
                onlyOneFlag = true;
            }

            if (clearFlag == true && cardList.ElementAt(detectID - 1).First != null)
            {
                current = cardList.ElementAt(detectID - 1).First;
                Console.WriteLine("first: " + (cardList.ElementAt(detectID - 1).First.task));

                if (onlyOneFlag == true)
                {
                    current = cardList.ElementAt(detectID - 1).First;
                    cardboxList.ElementAt(detectID - 1).AppendText(current.task);
                    cardboxList.ElementAt(detectID - 1).AppendText(Environment.NewLine);
                }
                else if (current.Next != null)
                {
                    cardboxList.ElementAt(detectID - 1).AppendText(cardList.ElementAt(detectID - 1).First.task);
                    cardboxList.ElementAt(detectID - 1).AppendText(Environment.NewLine);

                    while (current.Next != null)
                    {
                        cardboxList.ElementAt(detectID - 1).AppendText(current.Next.task);
                        cardboxList.ElementAt(detectID - 1).AppendText(Environment.NewLine);
                        current = current.Next;
                    }
                }

                clearFlag = false;
            }
        }
        private void displayNodeButton_Click(object sender, EventArgs e)
        {
            cardList.ElementAt(detectID - 1).AddLast(new Node(nodeInputBox.Text));
            //cardboxList.ElementAt(detectID - 1).Text = String.Join(Environment.NewLine, cardList.ElementAt(detectID - 1).toString());
            //cardboxList.ElementAt(detectID - 1).Text = cardList.ElementAt(detectID - 1).ToString();


            //Console.WriteLine(current.task);

            if (cardList.ElementAt(detectID - 1).First.Next == null)
            {
                current = cardList.ElementAt(detectID - 1).First;
                cardboxList.ElementAt(detectID - 1).AppendText(current.task);
                cardboxList.ElementAt(detectID - 1).AppendText(Environment.NewLine);
            }
            else if (current.Next != null)
            {
                while (current.Next != null)
                {
                    //cardboxList.ElementAt(detectID - 1).AppendText(cardList.ElementAt(detectID - 1).First.task);
                    cardboxList.ElementAt(detectID - 1).AppendText(current.Next.task);
                    cardboxList.ElementAt(detectID - 1).AppendText(Environment.NewLine);
                    current = current.Next;
                }
            }


            nodeInputBox.Clear();
            nodeInputBox.Visible = false;
            addNodeButton.Visible = false;
            nodeInputBox.Visible = false;
            displayNodeButton.Visible = false;
        }

        //edit 
        private void editButton_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("pre-edit: " +current.task);       

            //Console.WriteLine("post-edit: " + current.Next.task);            
            clearFlag = true;
            inputNode.Visible = true;
        }

        private void displayEditButton_Click(object sender, EventArgs e)
        {
            Node editNode = cardList.ElementAt(detectID - 1).selectNode(int.Parse(inputNode.Text));
            editNode.task = editInput.Text;
            cardboxList.ElementAt(detectID - 1).Clear();

            displayAll();
            editInput.Clear();
            editInput.Visible = false;
        }
        private void addNodeButton_Click(object sender, EventArgs e)
        {
            nodeInputBox.Visible = true;
        }

        private void addCardButton_Click(object sender, EventArgs e)
        {
            cardLabelInputBox.Visible = true;
            displayCardButton.Visible = true;

            cardLabelInputBox.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void displayCard_Click(object sender, EventArgs e)
        {
            board.Controls.Add(addLabel());
            board.Controls.Add(addCardbox());
            x = x + 200;
            cardLabelInputBox.Clear();
            cardLabelInputBox.Visible = false;
            displayCardButton.Visible = false;

        }

        private void inputNode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void inputNode_TextChanged(object sender, EventArgs e)
        {
            clearFlag = true;
            displayEditButton.Visible = true;
            editInput.Visible = true;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            displayRemoveButton.Visible = true;
            removeInput.Visible = true;
        }

        private void RemoveInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (cardList.ElementAt(detectID - 1).First != null)
            {
                displayRemoveButton.Visible = true;
            }
            else
            {
                displayRemoveButton.Visible = false;
            }
        }

        private void displayRemoveButton_Click(object sender, EventArgs e)
        {
            clearFlag = true;

            if (removeInput.Text.Equals("1"))
            {
                cardList.ElementAt(detectID - 1).First = cardList.ElementAt(detectID - 1).selectNode(2);
            }
            else
            {
                Node preNode = cardList.ElementAt(detectID - 1).selectNode(int.Parse(removeInput.Text) - 1);
                Node removeNode = cardList.ElementAt(detectID - 1).selectNode(int.Parse(removeInput.Text));
                Node nextNode = cardList.ElementAt(detectID - 1).selectNode(int.Parse(removeInput.Text) + 1);

                preNode.Next = nextNode;
            }


            //clear and display all tasks again (after any editing and removal)
            displayAll();
        }
    }
}