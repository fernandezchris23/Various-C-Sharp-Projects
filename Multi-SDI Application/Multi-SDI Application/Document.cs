using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Multi_SDI_Application
{
    [Serializable()]
    public class Document : Container, ISerializable
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

        public Shape GetShape(string id)
        {
            foreach(Shape component in Components)
            {
                if(string.Equals(id, component.ShapeId))
                {
                    return component;
                }
            }
            return null; //Should Never reach this because validation
        }

        public int countShapes()
        {
            return numShapes;
        }

        public Document() { }

        public Document(SerializationInfo info, StreamingContext context)
        {
            Shape sh;
            for (int x = 0; x < Components.Count; ++x)
                sh = (Shape)info.GetValue("item" + x, typeof(Shape));

            Console.WriteLine("All data deserialized");
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            int count = 0;
            foreach(Shape component in Components)
            {
                info.AddValue("item" + count, component);
                ++count;
            }
        }
    }
}
