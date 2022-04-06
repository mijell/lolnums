using ObjectLayer.Champions;
using System;
using System.Collections.Generic;
using System.IO;
using UserFacing.Tools;

namespace UserFacing.Evaluation
{
    internal enum ActionType
    {
        Unknown = 0,
        AutoAttack = 1,
        Ability_1 = 2,
        Ability_2 = 3,
        Ability_3 = 4,
        Ability_4 = 5
    }

    /// Class for defining an action in the evaluation (AutoAttack, QWER etc)
    internal class EvalAction
    {
        private ActionType actionType;

        private List<Champion> auxTargetChampions;
        private Champion primaryTargetChampion;
        private double timeInEval_s;
        private Champion userChampion;
    }

    internal class EvalScript
    {
        private List<EvalAction> actions;
    }

    internal class Evaluator
    {
        public void loadEvaluation(Architect architect)
        {
            string evalFilename = architect.configReader.configDict["EvalFilename"];

            FileInfo fileInfo = new FileInfo(evalFilename);
            string filepath = fileInfo.DirectoryName;

            string continuedLine = "";
            //Try to open the config file
            foreach (string line in System.IO.File.ReadAllLines(evalFilename))
            {
                //Ignore lines that start with #
                if (!line.StartsWith("#") && !String.IsNullOrEmpty(line))
                {
                    if (!line.EndsWith(" \\"))
                    {
                        string fullLine = continuedLine + line.Trim(' ');
                        int index_of_space = fullLine.IndexOf(' ');

                        string key = fullLine.Substring(0, index_of_space);
                        string value = fullLine.Substring(index_of_space + 1);

                        if (key == "Attacker")
                        {
                            Console.WriteLine(fullLine);
                        }
                        else if (key == "Defender")
                        {
                        }
                        else if (key == "DefenderAlt")
                        {
                        }

                        continuedLine = "";
                    }
                    else
                    {
                        string trimmedLine = line;

                        //Remove the slash
                        trimmedLine = trimmedLine.Remove(trimmedLine.Length - 1, 1);
                        //Remove whitespace
                        trimmedLine = trimmedLine.Trim(' ');

                        continuedLine += trimmedLine;
                    }
                }
            }
        }

        public void runEvaluation(Architect architect)
        {
        }
    }
}