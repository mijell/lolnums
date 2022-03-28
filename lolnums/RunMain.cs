
using System;
using System.IO;
using UserFacing.Tools;

using UserFacing.Testing;

namespace lolnums
{
    class Program
    {
        static void Main(string[] args)
        {
            string dir = "..\\..\\..";
            Directory.SetCurrentDirectory(dir);

            ConfigReader config          = new ConfigReader();
            string       config_filename = "Config_files\\lolconfig.txt";

            config.loadFile(config_filename);

            if (config.loaded_flag)
            {
                switch (config.program_type)
                {
                    case "run_eval":
                        Console.WriteLine("Run main evaluation.");
                        break;
                    case "z_playground":
                        z_playground pg_z = new z_playground();
                        pg_z.play(config);
                        break;
                    case "m_playground":
                        m_playground pg_m = new m_playground();
                        pg_m.play(config);
                        break;
                    case "j_playground":
                        j_playground pg_j = new j_playground();
                        pg_j.play(config);
                        break;

                    default:
                        Console.WriteLine("Unknown Program type [" + config.program_type + "]. Exiting...");
                        break;

                }

            }

        }
    }
}
