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
		string myNameApparently;

		public Assignment1Form(string str1, string str2)// Constructor that takes two string args.
		{
			// Form setup
			this.Text = str1; 							// Sets the title of the form to the first string.
			this.myNameApparently = str2;				// Sets the second string to my name
			this.ClientSize = new Size(500,350);		// Form size
			this.ShowIcon = false;						// Removes Icon on top left of form
			
			// Added Controls
			Panel panel1 = new Panel();					// Add the first panel
			this.Controls.Add(panel1);					// Add it directly to form
			
			Label label1 = new Label();					// Add the label to the first panel
			panel1.Controls.Add(label1);				// Add it directly to panel 1
			
			ListBox listControls = new ListBox();		// Add the listbox to show all controls in form
			panel1.Controls.Add(listControls);			// Add it directly to panel

			Panel panel2 = new Panel();					// Add the second panel
			this.Controls.Add(panel2);					// Add it directly to form
			
			Label label2 = new Label();					// Add the label to the second panel
			panel2.Controls.Add(label2);				// Add it directly to panel 2
			
			TextBox textbox2 = new TextBox();			// Add textbox to second panel
			panel2.Controls.Add(textbox2);				// Add it directly to panel 2
			
			Button button2 = new Button();				// Add button to second panel
			panel2.Controls.Add(button2);				// Add it directly to panel 2
			
			// First Panel Details
			panel1.BackColor = Color.Chocolate;			// Color is closest I could find to bronze
			panel1.Dock = DockStyle.Bottom;				// Docked to bottom of form
			
			// First Panel Label Details
			label1.Text = myNameApparently;				// Set the label to second constructor arg
			label1.BackColor = Color.White;				// Same color listbox
			label1.ForeColor = Color.Black;			    // Easier to read block text on white
														// Center name in label			
			label1.TextAlign = ContentAlignment.MiddleCenter;
			
			// First Panel ListBox (all controls in form) Details								
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
			panel2.BackColor = Color.Blue;			    // Ravenclaw color
			panel2.Dock = DockStyle.Fill;				// Docked to fill form
			
			// Second Panel Label Details
			label2.Text = "Comment: ";                  
			label2.BackColor = Color.White;				// Same as label 1
			label2.ForeColor = Color.Black;			    
			label2.Location = new Point(Top, Left);			
			                                            // Center text in label
			label2.TextAlign = ContentAlignment.MiddleCenter;																						

			// Second Panel TextBox Details
			textbox2.Text = "Type greeting here."; 
			textbox2.BackColor = Color.Chocolate;	 	
			textbox2.ForeColor = Color.Black;			
														// Set of textbox to the size of label2
			textbox2.Size = new Size(label2.Size.Width, label2.Size.Height);						
			                                            // Center text in textbox
			textbox2.TextAlign = HorizontalAlignment.Center;
														// Account for label size
			int leftAlignTextbox = (label2.Size.Width + Left) ; 
			textbox2.Location = new Point(leftAlignTextbox, Top);
														// Anchoring to left, right, and top
														// Stays in place when form is resized
			textbox2.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;	

			// Second Panel Button Details
			button2.Text = "Click to display entered greeting.";
			button2.BackColor = Color.White;	 		// Same as label 1
			button2.ForeColor = Color.Black;
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
	}
}