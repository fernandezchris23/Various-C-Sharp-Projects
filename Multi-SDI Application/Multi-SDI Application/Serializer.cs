using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters;
using System.IO;

namespace Multi_SDI_Application
{
    class Serializer
    {
        /**
         * Serialize file
         * Uses binary formatter to serialize file
         * 
         * */
        public static Boolean Serialize(String filename, SerializableProperties serializableProperties)
        {
            Stream stream = File.OpenWrite(filename);

            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, serializableProperties);
            }
            catch (SerializationException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            finally
            {
                stream.Flush();
                stream.Dispose();
                stream.Close();
            }

            return true;
        }

        /**
         * Deserialize file
         * Uses binary formatter to deserialize file
         * returns the deserialize file
         * */
        public static SerializableProperties Deserialize(String filename)
        {
            FileStream stream = null;
            object obj;

            try
            {
                stream = File.Open(filename, FileMode.Open);
                obj = new BinaryFormatter().Deserialize(stream);
            }
            catch (Exception e)
            {
                obj = null;
                Console.WriteLine(e.Message);
            }
            finally
            {
                stream.Flush();
                stream.Dispose();
                stream.Close();
            }

            return (SerializableProperties)obj;
        }

        
    }


}
