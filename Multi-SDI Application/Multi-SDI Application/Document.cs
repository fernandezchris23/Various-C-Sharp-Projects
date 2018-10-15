using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_SDI_Application
{
    class Document : Container
    {
        private int numShapes = 0;

        public override void Add(IComponent component)
        {
            if(component is Shape)
            {
                base.Add(component);
                numShapes++;
            }
        }

        public override void Remove(IComponent component)
        {
            if (component is Shape)
            {
                base.Remove(component);
                if (numShapes > 0)
                {
                    numShapes--;
                }
            }
        }

        public int countShapes()
        {
            return numShapes;
        }
    }
}
