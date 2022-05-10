using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ListClass.Classes
{
    class ConnectHelper
    {
        public static List<STUDENT> student = new List<STUDENT>();
        public static void ReadListFromFile(string filename)
        {
            StreamReader streamReader = new StreamReader(filename, Encoding.UTF8);
            while (!streamReader.EndOfStream)
            {
                string line = streamReader.ReadLine();
                string[] items = line.Split(';');
                STUDENT students = new STUDENT()
                {
                    Name = items[0].Trim(),
                    Group = items[1].Trim(),
                    Math = int.Parse(items[2].Trim()),
                    History = int.Parse(items[3].Trim()),
                    Physics = int.Parse(items[4].Trim()),
                    Obzh = int.Parse(items[5].Trim()),
                    French = int.Parse(items[6].Trim()),
                };
                student.Add(students);
            }
        }
        public static void SaveListToFile(string filename)
        {
            StreamWriter streamWriter = new StreamWriter(filename, false, Encoding.UTF8);
            foreach (STUDENT ph in student)
            {
                streamWriter.WriteLine($"{ph.Name};{ph.Group};{ph.Math};{ph.History};{ph.Physics};{ph.Obzh};{ph.French}");
            }
            streamWriter.Close();
        }
    }
}
