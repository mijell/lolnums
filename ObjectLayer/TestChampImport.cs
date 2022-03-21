using ObjectLayer.Champions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace ObjectLayer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string fileName = "C:\\Users\\Mitchell\\source\\repos\\lolnums\\ObjectLayer\\Champions\\Champions_11_24.json";
            string jsonString = File.ReadAllText(fileName);

            List<Champion> allChamps =
                JsonSerializer.Deserialize<List<Champion>>(jsonString);

            Console.WriteLine(allChamps.Count);
        }
    }
}