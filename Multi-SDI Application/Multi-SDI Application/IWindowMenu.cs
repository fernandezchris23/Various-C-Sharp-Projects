using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_SDI_Application
{
    interface IWindowMenu
    {
        string[] formTitles { get; set; }
        object[] formTags { get; set; }
    }
}
