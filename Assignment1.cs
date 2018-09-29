using System.Windows.Forms;
using System;
using System.Drawing;

namespace Assignment1
{
    class Assignment1Main
    {
        static void Main(String[] args)
        {
            Form form = new CustomForm("Team 2", "Alejandro Barnola");
            Application.Run(form);
        }
    }
    class CustomForm : Form
    {

        private String name;
        private const int WIDTH = 400;
        private const int HEIGHT = 250;
        private Panel panel;
        private Panel panel2;
        private TextBox textBox;
        private ListView listView;


        public CustomForm(String titleText, String userName)
        {
            this.name = userName;
            this.Text = titleText;
            this.Size = new Size(WIDTH, HEIGHT);

            CreatePanel();
            CreatePanel2();
            ListControls();
        }

        private void CreatePanel()
        {
            Label label = new Label();
            label.Text = this.name;

            this.panel = new Panel();
            this.panel.BackColor = Color.Orange;
            this.panel.Dock = DockStyle.Bottom;
            this.panel.Controls.Add(label);
            this.Controls.Add(panel);
        }

        private void CreatePanel2()
        {
            Label label = new Label();
            label.Text = "Comment";
            label.Left = 10;
            label.Top = 10;

            this.textBox = new TextBox();
            this.textBox.Top = 10;
            this.textBox.Left = 120;
            this.textBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.textBox.Width = 5;

            Button button = new Button();
            button.Left = 235;
            button.Top = 40;
            button.Size = new Size(75, 25);
            button.Text = "Click Me";
            button.Click += new EventHandler(ButtonClick);


            this.panel2 = new Panel();
            this.panel2.BackColor = Color.LightYellow;
            this.panel2.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(button);
            this.panel2.Controls.Add(label);
            this.panel2.Controls.Add(this.textBox);
            this.Controls.Add(panel2);
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.textBox.Text))
                MessageBox.Show(this.textBox.Text);
        }

        private void ListControls()
        {
            this.listView = new ListView();

            foreach (Control control in this.Controls)
            {
                this.listView.Items.Add(new ListViewItem(control.Name));

                foreach (Control c2 in control.Controls)
                    this.listView.Items.Add(new ListViewItem(c2.Name));
            }
        }
    }
}


