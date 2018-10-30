using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

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

        public Text GetText(int id)
        {
            Text itemToReturn = null; //Should never return null because validation

            base.ForEach(delegate(Text item)
                {
                    if (id == item.TextId)
                    {
                        itemToReturn = item;
                    }
                });
            return itemToReturn;
        }

        public int countTextElem()
        {
            return numOfTextElem;
        }

        public Document(SerializationInfo info, StreamingContext context)
        {
            for (int x = 0; x < info.MemberCount; ++x)
                //this.Add((Text)info.GetValue("item" + x, typeof(Text)));
            Console.WriteLine(info.MemberCount + " components");
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
