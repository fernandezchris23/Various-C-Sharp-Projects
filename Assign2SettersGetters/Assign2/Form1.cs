using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assign2
{
    public partial class Form1 : Form
    {
        private string nameUser;
        private int validName; //0 = valid, 1 = empty, 2 = no non-space, 3 = more than max characters
        private const int MAX_CHAR = 15;

        public Form1()
        {
            InitializeComponent();
        }

        // Properties with setters/getters instead of typing Properities.Settings every time
        public Size UserSize { get { return Properties.Settings.Default.UserSize; } set { Properties.Settings.Default.UserSize = (value); } }
        public Point UserLocation { get { return Properties.Settings.Default.UserLocation; } set { Properties.Settings.Default.UserLocation = (value); } }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.SetDesktopLocation(UserLocation.X, UserLocation.Y);

            this.ClientSize = new Size(UserSize.Width, UserSize.Height);
            this.SetClientSizeCore(UserSize.Width, UserSize.Height);
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            TextBox name = (TextBox)nameBox;

            string textFromBox = name.Text;

            nameUser = textFromBox;
        }
        
        //Reset Settings Button Handler
        private void resetSettBttn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
        }

        //Save Size Button Handler
        private void saveSizeBttn_Click(object sender, EventArgs e)
        {
            UserSize = new Size(this.ClientSize.Width, this.ClientSize.Height);
            Properties.Settings.Default.Save(); //Save Properties
        }

        //Save Location Button Handler
        private void saveLocBttn_Click(object sender, EventArgs e)
        {
           UserLocation = this.DesktopLocation; //Copies Location settings to Properties for saving
            Properties.Settings.Default.Save(); //Save Properties
        }

        //Add Name Button Handler
        private void addNameBttn_Click_1(object sender, EventArgs e)
        {
            validName = 0; //Assumes text is valid until proven to not be

            if (String.IsNullOrEmpty(nameUser))
            {
                validName = 1;
            }
            else if (validName != 1 && nameUser.Length > MAX_CHAR)
            {
                validName = 3;
            }
            else
            {
                if(nameUser.Length == 1 && String.Equals(nameUser, " "))
                {
                    validName = 2;
                }

                foreach (char c in nameUser)
                {
                    if (char.IsLetter(c)) //If a single non-space charcter is found, condition is satisfied
                    {
                        validName = 0;
                        break;
                    }
                    validName = 2; //For every space character found, we will set valid name to not being valid
                }
            }

            if (validName == 0)
            {
                errorProvider1.Clear();
                addListBox();
            }
            else
            {
                if(validName == 1)
                    errorProvider1.SetError(nameBox, "Text Field is empty! Please enter something!");
                else if (validName == 2)
                    errorProvider1.SetError(nameBox, "Names must contain at least 1 non-space character!");
                else if (validName == 3)
                    errorProvider1.SetError(nameBox, "No more than 15 characters may be used!");
            }
        }

        private void addListBox()
        {

        }
    }
}
