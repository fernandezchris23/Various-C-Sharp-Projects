using System; 								// For String
using System.Windows.Forms;					// For form, panels, labels, Docking, Text Alignment,
using System.Drawing;						// For Size, Color

namespace Assignment1
{
	class Assignment1Main
	{
		static void Main()
		{
			Form myForm = new Assignment1Form("1","Jamie Jamesssssssssssssssssssss");
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
			this.Controls.Add(panel1);
			
			Label label1 = new Label();					// Add the label to the first panel
			panel1.Controls.Add(label1);	
			
			// First Panel Details
			panel1.BackColor = Color.Chocolate;			// Color is closest I could find to bronze
			panel1.Dock = DockStyle.Bottom;				// Docked to bottom of form
			
			// First Label Details
			label1.Text = myNameApparently;				// Set the label to second constructor arg
			label1.BackColor = Color.Blue;				// 
			label1.ForeColor = Color.White;			//
			label1.TextAlign = ContentAlignment.MiddleCenter;// Center name in label
			
		}
	}
}