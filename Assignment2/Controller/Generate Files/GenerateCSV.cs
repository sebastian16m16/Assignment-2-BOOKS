using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Assignment2.Controller.Generate_Files
{
    class GenerateCSV
    {

        public void addNeededBook(String title, String author)
        {
            var filename = "OutOFstock.csv";

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(author + "," + title);

            var projectFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            var path = projectFolder + "\\Out Of Stock\\CSV\\" + filename;

            File.AppendAllText(path, stringBuilder.ToString());


        }

        public void deleteNowOnStockBook(String title, String author)
        {
            var filename = "OutOFstock.csv";

            var projectFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            var path = projectFolder + "\\Out Of Stock\\CSV\\" + filename;

            List<string> list = new List<string>(File.ReadAllLines(path));

            //using (StreamReader reader = new StreamReader(filename))
            //{
            //    string line = reader.ReadLine();
            //    if (line == title+","+author)
            //    {

            //    }else
            //        list.Add(line);
            //}

            int line = list.FindIndex(x => x.Equals(author + "," + title));
            list.RemoveAt(line);

            StreamWriter streamWriter = new StreamWriter(path);
            streamWriter.Flush();
            streamWriter.Close();

            File.WriteAllLines(path, list.ToArray());

            
        }
    }
}

