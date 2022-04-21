using ObjectLayer.Champions;
using System;
using System.Collections.Generic;
using System.IO;
using ObjectLayer.Tools;
using ConfigLayer.Tools;

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
        private string actionName;
        private ActionType actionType;

        private Champion userChampion;
        private Champion primaryTargetChampion;
        private List<Champion> auxTargetChampions;

        private Dictionary<string, string> parameters;
    }

    internal class EvalScript
    {
        private List<EvalAction> registeredActions;
        private List<EvalAction> scriptedActions;
    }

    internal class Evaluator
    {
        private Champion attacker;
        private Champion defender;
        private List<Champion> altDefenders;

        private List<EvalScript> evalScripts;

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
                            string championName = ConfigReader.getParamFromLine(value, "ChampionName", "", true);
                            attacker = architect.getChampionByName(championName.ToLower());
                            if (attacker != null)
                            {
                                attacker.setChampionLoadout(value);
                            }
                        }
                        else if (key == "Defender")
                        {
                            string championName = ConfigReader.getParamFromLine(value, "ChampionName", "", true);
                            defender = architect.getChampionByName(championName.ToLower());
                            if (defender != null)
                            {
                                defender.setChampionLoadout(value);
                            }
                        }
                        else if (key == "DefenderAlt")
                        {
                            //string championName = ConfigReader.getParamFromLine(value, "ChampionName", "", true);
                            // = architect.getChampionByName(championName.ToLower());
                        }
                        else if (key == "Script")
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

        public void summarizeEvaluation()
        {
            if (attacker != null)
            {
                attacker.printSummary();
            }
            else
            {
                Console.WriteLine("No Attacker declared...");
            }

            if (defender != null)
            {
                defender.printSummary();
            }
            else
            {
                Console.WriteLine("No Defender declared...");
            }
        }

        public void runEvaluation(Architect architect)
        {
        }
    }
}