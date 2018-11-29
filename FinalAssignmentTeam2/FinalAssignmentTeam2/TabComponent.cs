using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalAssignmentTeam2
{
    public partial class TabComponent : UserControl
    {
        public DoubleLinkedList backForwardList;

        public TabComponent()
        {
            backForwardList = new DoubleLinkedList();

            InitializeComponent();
        }
    }
}
