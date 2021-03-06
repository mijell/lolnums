using System;
using System.IO;
using UserFacing.Testing;
using ObjectLayer.Tools;
using UserFacing.Evaluation;

namespace lolnums
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string dir = "..\\..\\..";
            Directory.SetCurrentDirectory(dir);

            string config_filename = "Config_files\\lolconfig.txt";

            Architect architect = new Architect();
            architect.initArchitect(config_filename);

            if (architect.configReader.loaded_flag)
            {
                switch (architect.configReader.program_type)
                {
                    case "run_eval":
                        Console.WriteLine("Run main evaluation.");
                        Evaluator evaluator = new Evaluator();
                        evaluator.loadEvaluation(architect);
                        evaluator.summarizeEvaluation();
                        break;

                    case "z_playground":
                        z_playground pg_z = new z_playground();
                        pg_z.play(architect);
                        break;

                    case "m_playground":
                        m_playground pg_m = new m_playground();
                        pg_m.play(architect);
                        break;

                    case "j_playground":
                        j_playground pg_j = new j_playground();
                        pg_j.play(architect);
                        break;

                    default:
                        Console.WriteLine("Unknown Program type [" + architect.configReader.program_type + "]. Exiting...");
                        break;
                }
            }
        }
    }
}