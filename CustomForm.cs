using System;
using System.Windows.Forms;
using System.Drawing;

namespace AssignmentForms
{
    class CustomForm: Form
    {
        private String name;
        private const int WIDTH = 400;
        private const int HEIGHT = 250;
        private Panel panel;
        private Panel panel2;
        private TextBox textBox;
	private ListView listView;

        public CustomForm(String title, String name)
        {
            this.Text = title;
            this.name = name;
            this.Size = new Size(WIDTH, HEIGHT);
            InitFirstPanel();
            InitSecondPanel();
            ListControls();
        }

        private void InitFirstPanel()
        {
            Label label = new Label();
            label.Text = this.name;
            label.Left = (WIDTH / 2) - (label.Width / 2);

            this.listView = new ListView();
            this.listView.Name = "controls listview";
            this.listView.Size = new Size(121, 97);

            this.panel = new Panel();
            this.panel.BackColor = Color.Blue;
            this.panel.Dock = DockStyle.Bottom;
            this.panel.Controls.Add(label);
            this.Controls.Add(panel);
        }

        private void InitSecondPanel()
        {
            Label label = new Label();
            label.Text = "Comment:";
            label.Left = 10;
            label.Top = 10;

            this.textBox = new TextBox();
            this.textBox.Top = 10;
            this.textBox.Left = 120;
            this.textBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.textBox.Width = 5;

            Button button = new Button();
            button.Left= 235;
            button.Top = 40;
            button.Size = new Size(75, 23);
            button.Text = "Show Msg";
            button.BackColor = Color.White;
            button.Click += new EventHandler(ClickHandler);

            this.panel2 = new Panel();
            this.panel2.BackColor = Color.Brown;
            this.panel2.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(label);
            this.panel2.Controls.Add(this.textBox);
            this.panel2.Controls.Add(button);
            this.Controls.Add(panel2);
        }

        private void ListControls()
        {
            foreach (Control control in this.Controls)
            {
                this.listView.Items.Add(new ListViewItem(control.Name));
                foreach(Control control2 in control.Controls)
                    this.listView.Items.Add(new ListViewItem(control2.Name));
            }
                
        }

        private void ClickHandler(object sender, EventArgs e)
        {
            String msg = this.textBox.Text;
            if(!String.IsNullOrEmpty(msg))
                MessageBox.Show(msg);
        }
    }
}
