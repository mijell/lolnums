
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using ObjectLayer.Champions;

namespace lolnums
{
    class Program
    {
        static void Main(string[] args)
        {
            string dir = "..\\..\\..";
            Directory.SetCurrentDirectory(dir);

            string import_filename = "..\\input\\Champions_11_24.json";
            string jsonString = File.ReadAllText(import_filename);
            var allChamps = JsonSerializer.Deserialize<Champion>(jsonString);

            Console.WriteLine(allChamps.Brand.stats.hp);
        }
    }
}
