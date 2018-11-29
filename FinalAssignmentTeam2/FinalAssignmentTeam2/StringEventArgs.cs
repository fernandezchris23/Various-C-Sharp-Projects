using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Used to pass strings through the event args

namespace FinalAssignmentTeam2
{
    public class StringEventArgs : EventArgs
    {
        public string ListItemBeingPassed { get; set; }

        public StringEventArgs(string value)
        {
            ListItemBeingPassed = value;
        }
    }
}
