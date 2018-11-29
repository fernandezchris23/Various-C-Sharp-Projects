using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Reflection;

namespace FinalAssignmentTeam2
{
    class Serializer
    {

        /**
        * Serialize file
        * Uses binary formatter to serialize file
        * 
        * */
        public static Boolean Serialize(String filename, object serializableProperties)
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
        public static object Deserialize(String filename)
        {
            FileStream stream = null;
            object obj;

            try
            {
                stream = File.Open(filename, FileMode.Open);
                obj = new BinaryFormatter().Deserialize(stream);
            }
            catch (TargetInvocationException e)
            {
                obj = null;
                Console.WriteLine(e.Message);

            }
            catch (FileNotFoundException e)
            {
                obj = null;
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                obj = null;
                Console.WriteLine(e.Message);
            }

            finally
            {
                if(stream != null)
                {
                    stream.Flush();
                    stream.Dispose();
                    stream.Close();
                }
            }

            return obj;
        }

    }
}
