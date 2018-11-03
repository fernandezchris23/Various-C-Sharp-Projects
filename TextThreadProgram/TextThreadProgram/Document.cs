using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TextThreadProgram
{
    [Serializable()]
    class Document:List<Text>, ISerializable
    {
        private int numOfTextElem = 0;

        public void AddItem(Text item)
        {
            base.Add(item);
            numOfTextElem++;
        }

        public void RemoveItem(Text item)
        {
            base.Remove(item);
            if (numOfTextElem > 0)
            {
                numOfTextElem--;
            }
        }

        public Text GetText(Point mouseLoc)
        {
            Text itemToReturn = null; //Should never return null because validation
            int highestZorder = 0;

            base.ForEach(delegate(Text item)
                {
                    if ((mouseLoc.X >= item.TextLocation.X && (mouseLoc.X < item.TextLocation.X + item.TextSize.Width)) &&
                         mouseLoc.Y >= item.TextLocation.Y && mouseLoc.Y <= (item.TextLocation.Y + item.TextSize.Height))
                    {
                        if(item.Z_Order >= highestZorder)
                        {
                            itemToReturn = item;
                            highestZorder = item.Z_Order;
                        }
                    }
                });
            return itemToReturn;
        }

        public int countTextElem()
        {
            return numOfTextElem;
        }

        public void moveText(Text item, Point newLocation)
        {
            RemoveItem(item);

            item.TextLocation = newLocation;

            AddItem(item);
        }

        public Document(SerializationInfo info, StreamingContext context)
        {
            for (int x = 0; x < info.MemberCount; ++x)
                this.Add((Text)info.GetValue("item" + x, typeof(Text)));
        }

        public Document() { }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            int count = 0;
            base.ForEach(delegate (Text item)
            {
                info.AddValue("item" + count, item);
                ++count;
            });

            Console.WriteLine(count + " items added");
        }
    }
}
