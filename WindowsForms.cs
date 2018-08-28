using System;
using System.Windows.Forms;

namespace AssignmentForms
{
    public class WindowsForms
    {
        public static void Main(String[] args)
        {
            String title = "Assignment 1";
            String team = "Team 2";
            if(args.Length == 2)
            {
                title = args[0];
                team = args[1];
            }
            Application.Run(new CustomForm(title, team));
        }
    }
}
