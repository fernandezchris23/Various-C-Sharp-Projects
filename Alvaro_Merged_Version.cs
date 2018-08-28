using System;
using System.Windows.Forms;
using System.Drawing;

namespace AssignmentForms
{
    public class WindowsForms
    {
        public static void Main(String[] args)
        {
            String title = "Assignment 1";
            String team = "Team 2";
			
            if(args.Length == 1)
				team = args[0];					
			

			else if(args.Length != 0)
			{
				title = "";
				
				for(int i = 0; i < args.Length-1; i++)
					title += " " + args[i];		
				
				team = args[args.Length - 1];	
			}
			
            Application.Run(new CustomForm(title, team));
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
		private ListBox listControls;

        public CustomForm(String title, String name)
        {
            this.Text = title;
            this.name = name;
            this.Size = new Size(WIDTH, HEIGHT);
            InitFirstPanel();
            InitSecondPanel();
			FormControls(listControls, this, 0);
        }

        private void InitFirstPanel()
        {
			
			this.panel = new Panel();
            this.panel.BackColor = Color.Blue;
            this.panel.Dock = DockStyle.Bottom;
			
			this.listControls = new ListBox();
			this.listControls.BackColor = Color.LightSkyBlue;
			this.listControls.ForeColor = Color.Blue;
			this.listControls.Anchor = AnchorStyles.None;
			int centerWidth = (this.panel.Size.Width - this.listControls.Size.Width) / 2;
			int centerHeight = (this.panel.Size.Height - this.listControls.Size.Height) / 2;
			this.listControls.Location = new Point(centerWidth, centerHeight);
			
			Label label = new Label();
            label.Text = this.name;
            label.TextAlign = ContentAlignment.MiddleCenter;
			label.BackColor = Color.LightSkyBlue;
			
            this.panel.Controls.Add(label);
			this.panel.Controls.Add(listControls);
			this.Controls.Add(panel);
        }

        private void InitSecondPanel()
        {
			this.panel2 = new Panel();
            this.panel2.BackColor = Color.Gold;
            this.panel2.Dock = DockStyle.Fill;
			
            Label label = new Label();
            label.Text = "Comment:";
            label.Left = 10;
            label.Top = 10;
			label.TextAlign = ContentAlignment.MiddleCenter;

            this.textBox = new TextBox();
            this.textBox.Top = 10;
            this.textBox.Left = 120;
            this.textBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.textBox.Width = 5;

            Button button = new Button();
            button.Size = new Size(75, 23);
			button.AutoSize = true;					
			button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			int rightAlignButton = (label.Size.Width + textBox.Size.Width+label.Left);
			int bottomAlignButton = (panel.Size.Height - panel2.Size.Height - button.Size.Height - 10);
			button.Location = new Point(rightAlignButton, bottomAlignButton);
			button.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button.Text = "Show Msg";
            button.BackColor = Color.White;
            button.Click += new EventHandler(ClickHandler);
			
            this.panel2.Controls.Add(label);
            this.panel2.Controls.Add(this.textBox);
            this.panel2.Controls.Add(button);
            this.Controls.Add(panel2);
        }

        private void ClickHandler(object sender, EventArgs e)
        {
            String msg = this.textBox.Text;
            if(!String.IsNullOrEmpty(msg))
                MessageBox.Show(msg);
			else
				MessageBox.Show("No input given!");
        }
		
		private void FormControls(ListBox listbox, Object parentControl,int indent)
		{
			string emptySpaces = new string(' ', indent); 
			
			Control control = parentControl as Control; 
			listbox.Items.Add(emptySpaces + control.GetType().Name); 
			
			foreach (Control child in control.Controls)
			{
				FormControls(listbox, child, indent + 4);
			}
		}
    }
}