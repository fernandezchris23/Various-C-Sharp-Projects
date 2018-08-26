using System; 								// For String
using System.Windows.Forms;					// For Form, Panels, Labels, Docking, Text Alignment, Anchoring etc..
using System.Drawing;						// For Size, Color, Locations

using System.Collections.Generic;

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
			this.Text = str1; 							// sets the title of the form to the first string.
			this.myNameApparently = str2;				// sets the second string to my name
			this.ClientSize = new Size(700,350);		// Form size
			
			// Added Controls
			Panel panel1 = new Panel();					// Add the first panel
			this.Controls.Add(panel1);					// Add it directly to form
			
			Label label1 = new Label();					// Add the label to the first panel
			panel1.Controls.Add(label1);				// Add it directly to panel
			
			ListBox listControls = new ListBox();		// Add the listbox to show all controls in form
			panel1.Controls.Add(listControls);			// Add it directly to panel
			
			// First Panel Details
			panel1.BackColor = Color.Chocolate;			// Color is closest I could find to bronze
			panel1.Dock = DockStyle.Bottom;				// Docked to bottom of form
			
			// First Panel Label Details
			label1.Text = myNameApparently;				// Set the label to second constructor arg
			label1.BackColor = Color.Blue;				// Same as the color that Panel 2 
			label1.ForeColor = Color.White;			    // Easier to read white text, instead of chocolate
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

		}
		
		// Helper method to add all controls on form to ListBox
		// Recursively finds child controls in parent controls (got help from csharphelper.com)
		private void FormControls(ListBox listbox, Object parentControl,int indent)
		{
														// Create string for indentations
			string emptySpaces = new string(' ', indent); 
			
			Control control = parentControl as Control; 
														// not using control.Name b/c I didn't name my controls in this form
			listbox.Items.Add(emptySpaces + control.GetType().Name); 
			foreach (Control child in control.Controls)
			{											// Start each child control with indentation (usually four spaces)
				FormControls(listbox, child, indent + 4);
			}
		}
	}
}