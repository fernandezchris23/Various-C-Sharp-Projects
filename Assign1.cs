using System;
using System.Windows.Forms;
using System.Drawing;

namespace Assignment1
{

class Homework1
{
	static void Main(String[] args)
	{		
		Form form = new Homework1Form("The Great Form", "Chris Fernandez");
		Application.Run(form);
	}
}

class Homework1Form : Form
{
	private string name;
	private Panel panel1, panel2;
	private Button bttn;
	private TextBox txt;
	private Label label1, label2;
	private ListBox ctrlList;
	
	public Homework1Form(string title, string name)
	{
		this.Text = title;
		this.name = name;
		this.ClientSize = new Size(450,300);
		
		//First Panel
		panel1 = new Panel();
		panel1.BackColor = Color.Blue;
		panel1.Dock = DockStyle.Bottom;
		this.Controls.Add(panel1);
		
		//First Panel Label
		label1 = new Label();
		label1.Text = name;
		label1.ForeColor = Color.White;
		panel1.Controls.Add(label1);
		
		//First Panel ListBox
		ctrlList = new ListBox();
		ctrlList.BackColor = Color.Green;
		ctrlList.ForeColor = Color.White;
		ctrlList.Anchor = AnchorStyles.None;
		panel1.Controls.Add(ctrlList);
		
		//Used for centering the listbox
		int width = (panel1.Size.Width - ctrlList.Size.Width) / 2;
		int height = (panel1.Size.Height - ctrlList.Size.Height) / 2;
		
		ctrlList.Location = new Point(width, height);
		
		FormControls(ctrlList, this, 0); //Fills in listbox with controls		
		
		//Second Panel
		panel2 = new Panel();
		panel2.BackColor = Color.Red;
		panel2.Dock = DockStyle.Fill;
		this.Controls.Add(panel2);
		
		//Second Panel Label
		label2 = new Label();
		label2.Text = "Comment:";
		label2.ForeColor = Color.White;
		panel2.Controls.Add(label2);
		label2.Location = new Point(Top, Left);
		
		//Second Panel TextBox
		txt = new TextBox();
		txt.Size = new Size(180, label2.Size.Height);
		txt.Location = new Point(label2.Size.Width + Left, Top);
		txt.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
		panel2.Controls.Add(txt);
		
		//Second Panel Button
		bttn = new Button();
		bttn.Text = "Click Me";
		bttn.AutoSize = true;
		bttn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		bttn.Size = new Size(label2.Size.Width, label2.Size.Height);
		bttn.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
		
		//Used for positioning the button
		int rightAlign = label2.Size.Width + txt.Size.Width;
		int bttmAlign = panel2.Size.Height - panel1.Size.Height - bttn.Size.Height;
		
		bttn.Location = new Point(rightAlign, bttmAlign);
		panel2.Controls.Add(bttn);
		
		//Button Event
		txt.Click += new EventHandler(txt_Click);
		bttn.Click += new EventHandler(bttn_Click);
		
	}
	
	private void FormControls (ListBox list, Object parentControl, int indent)
	{
		string emptySpace = new string(' ', indent);
		Control ctrl = parentControl as Control;
		
		list.Items.Add(emptySpace + ctrl.GetType().Name);
		
		foreach(Control child in ctrl.Controls)
		{
			FormControls(list, child, indent + 4);
		}
	}
	
	private void txt_Click (object partent, EventArgs e)
	{
		txt.Clear();
	}
	
	private void bttn_Click (object parent, EventArgs e)
	{
		if(txt.Text != "") {
			MessageBox.Show(txt.Text);
		}
		else {
			MessageBox.Show("Please enter something");
		}
	}
}
}	