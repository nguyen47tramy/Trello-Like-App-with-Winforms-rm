namespace Trello
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<LinkedList<string>> tasks = new List<LinkedList<string>>();
        List<TextBox> tasksList = new List<TextBox>();
        List<Button> labelList = new List<Button>();
        //IDictionary<int, Button> labelList = new Dictionary<int, Button>();
        int x = 20;
        int labelID = 1;
        string labelTag;
        int detectID = 0;

        private TextBox addTextBox()
        {
            LinkedList<string> taskString = new LinkedList<string>();
            TextBox textBox = new TextBox();
            textBox.Name = "textBox";
            textBox.BackColor = SystemColors.GradientInactiveCaption;
            textBox.Multiline = true;
            textBox.Location = new Point(x, 40);
            textBox.Size = new Size(163, 275);

            tasksList.Add(textBox);
            tasks.Add(taskString);

            return textBox;
        }

        private Button addLabel()
        {

            Button label = new Button();
            label.Name = "label";
            label.Text = textBox1.Text;
            label.Location = new Point(x, 1);
            label.Size = new Size(160, 34);
            label.Tag = labelID++;
            label.Click += new EventHandler(myHandler);

            //buttonList.Add(label);
            labelList.Add(label);

            return label;
        }

        void myHandler(object sender, EventArgs e)
        {
            //Console.WriteLine("tag: " +(sender as Control).Tag);
            detectID = (int)(sender as Control).Tag;
            Console.WriteLine("detectID: "+detectID);
            //foreach (var label in labelList) {
            //    Console.WriteLine("Label ID: {0}, Label: {1}", label.Key, label.Value);
            //}
        }


        private void button1_Click(object sender, EventArgs e)
        {
            tasks.ElementAt(detectID-1).AddLast(textBox2.Text);
            tasksList.ElementAt(detectID-1).Text = String.Join(Environment.NewLine, tasks.ElementAt(detectID - 1));
            textBox2.Clear();
            textBox2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            okButton.Visible = true;

            textBox1.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Controls.Add(addLabel());
            panel1.Controls.Add(addTextBox());
            x = x + 200;
            textBox1.Clear();
            textBox1.Visible = false;
            okButton.Visible = false;
        }

    }
}