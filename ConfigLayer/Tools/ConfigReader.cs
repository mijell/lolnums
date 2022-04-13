using System;
using System.IO;
using System.Collections.Generic;

namespace ConfigLayer.Tools
{
    public class ConfigReader
    {
        public string championJsonFilename { get; set; }
        public Dictionary<string, string> configDict { get; set; }
        public bool loaded_flag { get; set; }

        public string program_type { get; set; }

        public ConfigReader()
        {
            loaded_flag = false;
            configDict = new Dictionary<string, string>();
            program_type = "";
        }

        /// <summary>
        /// This 100% can be done in a smarter way, I just want to get a list of all values for a
        /// given parameter in a single string. Please improve if you want.
        /// </summary>
        /// <param name="line">             </param>
        /// <param name="paramName">        </param>
        /// <param name="removeQuotes_flag"></param>
        /// <returns></returns>
        public static List<string> getMultiParamFromLine(string line, string paramName, bool removeQuotes_flag)
        {
            List<string> result = new List<string>();
            string value = "";

            do
            {
                int finalIndex = -1;
                value = "";
                if (line.Contains(paramName + "="))
                {
                    string paramEq = paramName + "=";
                    int index = line.IndexOf(paramName + "=");
                    int start_index = index + paramEq.Length;
                    int look_index = start_index;

                    //Check for quotes
                    char nextChar = line[start_index];
                    if (nextChar == '\"')
                    {
                        int q2_index = line.IndexOf('\"', start_index + 1);
                        if (q2_index != -1)
                        {
                            look_index = q2_index;
                        }
                    }

                    int sub_index = line.IndexOf(":", look_index);
                    if (sub_index != -1)
                    {
                        finalIndex = sub_index;
                        value = line.Substring(start_index, sub_index - start_index);
                    }
                    else
                    {
                        finalIndex = start_index;
                        value = line.Substring(start_index);
                    }
                }
                else if (line.Contains(paramName + ":") || line.EndsWith(paramName))
                {
                    value = "True";

                    finalIndex = line.IndexOf(paramName) + paramName.Length;
                }

                //Trim line
                if (finalIndex != -1)
                {
                    line = line.Substring(finalIndex);
                }

                if (removeQuotes_flag &&
                    value.StartsWith("\"") &&
                    value.EndsWith("\""))
                {
                    value = value.Substring(1, value.Length - 2);
                }

                if (!string.IsNullOrEmpty(value))
                {
                    result.Add(value);
                }
            } while (!string.IsNullOrEmpty(value));

            return result;
        }

        public static string getParamFromLine(string line, string paramName, string defaultValue, bool removeQuotes_flag)
        {
            string returnString = defaultValue;

            if (line.Contains(paramName + "="))
            {
                string paramEq = paramName + "=";
                int index = line.IndexOf(paramName + "=");
                int start_index = index + paramEq.Length;
                int look_index = start_index;

                //Check for quotes
                char nextChar = line[start_index];
                if (nextChar == '\"')
                {
                    int q2_index = line.IndexOf('\"', start_index + 1);
                    if (q2_index != -1)
                    {
                        look_index = q2_index;
                    }
                }

                int sub_index = line.IndexOf(":", look_index);
                if (sub_index != -1)
                {
                    returnString = line.Substring(start_index, sub_index - start_index);
                }
                else
                {
                    returnString = line.Substring(start_index);
                }
            }
            else if (line.Contains(paramName + ":") || line.EndsWith(paramName))
            {
                returnString = "True";
            }

            if (removeQuotes_flag &&
                returnString.StartsWith("\"") &&
                returnString.EndsWith("\""))
            {
                returnString = returnString.Substring(1, returnString.Length - 2);
            }

            return returnString;
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

                    configDict[command] = value;

                    if (command == "program")
                    {
                        program_type = value;
                    }
                    else if (command == "ChampionJson")
                    {
                        championJsonFilename = value;
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