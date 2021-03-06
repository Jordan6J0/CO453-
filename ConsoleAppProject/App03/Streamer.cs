﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// This class will save and load data from binary file.  
    /// </summary>
    public static class Streamer
    {
        public static string SerializationFile = Path.Combine(@"C:\Users\Jorda\OneDrive\Desktop\S2\Application Programming\ConsoleApps15-master\ConsoleAppProject\App03 - Copy", "Student.bin");
                                                
        /// <summary>
        /// save a given list to binary format
        /// </summary>
        /// <param name="Students">A given list</param>
        public static void SaveFile(List<Student> Students)
        {
            using (Stream stream = File.Open(SerializationFile, FileMode.Create))
            {
                var Bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                Bformatter.Serialize(stream, Students);
            }
        }

        /// <summary>
        /// read file and return it as a list
        /// </summary>
        /// <returns>a list of data</returns>
        public static List<Student> ReadFile()
        {
            using (Stream stream = File.Open(SerializationFile, FileMode.Open))
            {
                var Bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                return (List<Student>)Bformatter.Deserialize(stream);
            }
        }
    }
}