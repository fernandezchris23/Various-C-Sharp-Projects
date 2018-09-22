using System; 								// For String
using System.Windows.Forms;					// For Form, Panels, Labels, Docking, Text Alignment, Anchoring etc..
using System.Drawing;						// For Size, Color, Locations

namespace Assignment1
{
	class Assignment1Main
	{
		static void Main()
		{
			Form myForm = new Assignment1Form("My Awesome Form","Vanesa");
			Application.Run(myForm);
		}
	}

	class Assignment1Form : Form 						// Extends the Form class.
	{
		private string yourName;						// Name from second arg of constructor
		private Panel panel1;							// First Panel
		private Panel panel2;							// Second Panel
		private Label label1;							// First Panel's label
		private ListBox listControls;					// First Panel's listbox
        private Label label2;							// Second Panel's label
        private TextBox textbox2;						// Second Panel's textbox
        private Button button2;							// Second Panel's button
		
		public Assignment1Form(string formName, string yourName)// Constructor that takes two string args.
		{
			// Form setup
			this.Text = formName; 						// Sets the title of the form to the first string.
			this.yourName = yourName;					// Sets the second string to my name
			this.ClientSize = new Size(500,350);		// Form size
			this.ShowIcon = false;						// Removes Icon on top left of form
														// Centers form on screen when opened
			this.StartPosition = FormStartPosition.CenterScreen;					
			
			// Added Controls
			panel1 = new Panel();						// Add the first panel
			this.Controls.Add(panel1);					// Add it directly to form
			
			label1 = new Label();						// Add the label to the first panel
			panel1.Controls.Add(label1);				// Add it directly to panel 1
			
			listControls = new ListBox();				// Add the listbox to show all controls in form
			panel1.Controls.Add(listControls);			// Add it directly to panel 1

			panel2 = new Panel();						// Add the second panel
			this.Controls.Add(panel2);					// Add it directly to form
			
			label2 = new Label();						// Add the label to the second panel
			panel2.Controls.Add(label2);				// Add it directly to panel 2
			
			textbox2 = new TextBox();					// Add textbox to second panel
			panel2.Controls.Add(textbox2);				// Add it directly to panel 2
			
			button2 = new Button();						// Add button to second panel
			panel2.Controls.Add(button2);				// Add it directly to panel 2
			
			// First Panel Details
			panel1.BackColor = Color.LightSteelBlue;	// Darker color for bottom panel
			panel1.Dock = DockStyle.Bottom;				// Docked to bottom of form
			
			// First Panel Label Details
			label1.Text = yourName;						// Set the label to second constructor arg
			label1.BackColor = Color.LavenderBlush;		// Off pink
			label1.ForeColor = Color.DeepPink;			// Easier to read dark pink text on off pink
														// Center name in label			
			label1.TextAlign = ContentAlignment.MiddleCenter;
			
			// First Panel ListBox (all controls in form) Details
			listControls.BackColor = Color.LavenderBlush;// Same as label1
			listControls.ForeColor = Color.DeepPink;
			
				// Centering ListBox in panel														
			listControls.Anchor = AnchorStyles.None;	// Make anchors none so it centers in panel when form is resized
														// Account for panel size 
			int centerWidth = (panel1.Size.Width - listControls.Size.Width) / 2;
			int centerHeight = (panel1.Size.Height - listControls.Size.Height) / 2;			
														// Set new Point with size accounted for
			listControls.Location = new Point(centerWidth, centerHeight); 
			
				// Setting content for listbox
			FormControls(listControls, this, 0); 		// Call helper method to add to ListBox 
														// Initally start list indentation at 0
			// Second Panel Details
			panel2.BackColor = Color.AliceBlue;		    // Lighter color for larger panel2
			panel2.Dock = DockStyle.Fill;				// Docked to fill form
			
			// Second Panel Label Details
			label2.Text = "Comment: ";                  
			label2.BackColor = Color.LavenderBlush;		// Same as label 1
			label2.ForeColor = Color.DeepPink;			    
			label2.Location = new Point(Top, Left);			
			                                            // Center text in label
			label2.TextAlign = ContentAlignment.MiddleCenter;																						

			// Second Panel TextBox Details
			textbox2.Text = "Type greeting here."; 
			textbox2.BackColor = Color.LavenderBlush;	// Same as smaller panel1
			textbox2.ForeColor = Color.Red;			
														// Set of textbox to the size of label2
			textbox2.Size = new Size(220, label2.Size.Height);						
			                                            // Center text in textbox
			textbox2.TextAlign = HorizontalAlignment.Center;
														// Account for label size
			int leftAlignTextbox = (label2.Size.Width + Left) ; 
			textbox2.Location = new Point(leftAlignTextbox, Top);
														// Anchoring to left, right, and top
														// Stays in place when form is resized
			textbox2.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;				
			textbox2.Click += new EventHandler(textbox2_Click);

			// Second Panel Button Details
			button2.Text = "Click to display entered greeting.";
			button2.BackColor = Color.LavenderBlush;	// Same as label 1
			button2.ForeColor = Color.DeepPink;
			button2.AutoSize = true;					// Get button to show all text
			button2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
														// Center text in Button
			button2.TextAlign = ContentAlignment.MiddleCenter;
			button2.Size = new Size(label2.Size.Width, label2.Size.Height);	
														// Account for TextBox and Label size 			
			int rightAlignButton = (label2.Size.Width + textbox2.Size.Width);	
														// Account for Panel sizes to align on top of Panel 2
			int bottomAlignButton = (panel2.Size.Height - panel1.Size.Height - button2.Size.Height);
			button2.Location = new Point(rightAlignButton, bottomAlignButton);
														// Anchors button2 to textbox2 right edge during resized
														// Also Anchors button2 on top of panel2
			button2.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
			button2.Click += new EventHandler(button2_Click);
			
		}
		
		// Helper method to add all controls on form to ListBox
		// Recursively finds child controls in parent controls (got help from csharphelper.com)
		private void FormControls(ListBox listbox, Object parentControl,int indent)
		{
														// Create string for indentations
			string emptySpaces = new string(' ', indent); 
			
			Control control = parentControl as Control; 
														// Not using control.Name b/c I didn't name my controls in this form
			listbox.Items.Add(emptySpaces + control.GetType().Name); 
			foreach (Control child in control.Controls)
			{											// Start each child control with indentation (usually four spaces)
				FormControls(listbox, child, indent + 4);
			}
		}
		
		// EventHandlers
			// Textbox
		private void textbox2_Click(object sender, EventArgs e) 
		{
			textbox2.Clear();							// Clears old text
		}		
		
			// Button
		private void button2_Click(object sender, EventArgs e) 
		{
			if (textbox2.Text == "Type greeting here.")
				MessageBox.Show("You didn't enter anything");
			else if (textbox2.Text != "")
				MessageBox.Show(textbox2.Text);
			else
				MessageBox.Show("Try again.");
		}
		

	}
}