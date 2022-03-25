using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace lolnums.Tools
{
    internal class ConfigReader
    {
        public bool         loaded_flag  { get; set; } 
        public string       program_type { get; set; }

        public ConfigReader()
        {
            loaded_flag = false;
            program_type = "";
        }

        public void loadFile(string filename)
        {
            FileInfo fileInfo = new FileInfo(filename);
            string filepath = fileInfo.DirectoryName;
            
            loaded_flag = true;

            //Try to open the config file
            foreach (string line in System.IO.File.ReadAllLines(filename))
            {
                //Ignore lines that start with #
                if (!line.StartsWith("#") && !String.IsNullOrEmpty(line))
                {
                    int index_of_space = line.IndexOf(' ');

                    string command = line.Substring(0, index_of_space);
                    string value = line.Substring(index_of_space + 1);

                    //Console.WriteLine("Command: " + command);
                    //Console.WriteLine("Value: " + value);

                    if (command == "program")
                    {
                        program_type = value;
                    }
                    else if (command == "include")
                    {
                        loadFile(filepath + "\\" + value);
                    }

                }
            }


        }

    }
}
