using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectLayer.Champions
{// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Info
    {
        public int attack { get; set; }
        public int defense { get; set; }
        public int magic { get; set; }
        public int difficulty { get; set; }
    }

    public class Image
    {
        public string full { get; set; }
        public string sprite { get; set; }
        public string group { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int w { get; set; }
        public int h { get; set; }
    }

    public class Stats
    {
        public double hp { get; set; }
        public double hpperlevel { get; set; }
        public double mp { get; set; }
        public double mpperlevel { get; set; }
        public int movespeed { get; set; }
        public int armor { get; set; }
        public double armorperlevel { get; set; }
        public double spellblock { get; set; }
        public double spellblockperlevel { get; set; }
        public int attackrange { get; set; }
        public double hpregen { get; set; }
        public double hpregenperlevel { get; set; }
        public double mpregen { get; set; }
        public double mpregenperlevel { get; set; }
        public int crit { get; set; }
        public int critperlevel { get; set; }
        public double attackdamage { get; set; }
        public double attackdamageperlevel { get; set; }
        public double attackspeedperlevel { get; set; }
        public double attackspeed { get; set; }
    }

    public class Aatrox
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Ahri
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Akali
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Akshan
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Alistar
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Amumu
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Anivia
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Annie
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Aphelios
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Ashe
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class AurelionSol
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Azir
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Bard
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Blitzcrank
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Brand
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Braum
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Caitlyn
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Camille
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Cassiopeia
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Chogath
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Corki
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Darius
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Diana
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Draven
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class DrMundo
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Ekko
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Elise
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Evelynn
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Ezreal
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Fiddlesticks
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Fiora
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Fizz
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Galio
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Gangplank
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Garen
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Gnar
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Gragas
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Graves
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Gwen
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Hecarim
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Heimerdinger
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Illaoi
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Irelia
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Ivern
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Janna
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class JarvanIV
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Jax
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Jayce
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Jhin
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Jinx
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Kaisa
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Kalista
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Karma
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Karthus
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Kassadin
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Katarina
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Kayle
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Kayn
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Kennen
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Khazix
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Kindred
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Kled
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class KogMaw
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Leblanc
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class LeeSin
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Leona
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Lillia
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Lissandra
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Lucian
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Lulu
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Lux
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Malphite
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Malzahar
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Maokai
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class MasterYi
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class MissFortune
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class MonkeyKing
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Mordekaiser
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Morgana
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Nami
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Nasus
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Nautilus
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Neeko
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Nidalee
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Nocturne
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Nunu
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Olaf
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Orianna
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Ornn
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Pantheon
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Poppy
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Pyke
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Qiyana
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Quinn
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Rakan
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Rammus
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class RekSai
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Rell
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Renekton
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Rengar
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Riven
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Rumble
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Ryze
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Samira
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Sejuani
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Senna
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Seraphine
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Sett
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Shaco
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Shen
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Shyvana
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Singed
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Sion
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Sivir
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Skarner
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Sona
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Soraka
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Swain
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Sylas
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Syndra
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class TahmKench
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Taliyah
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Talon
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Taric
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Teemo
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Thresh
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Tristana
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Trundle
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Tryndamere
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class TwistedFate
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Twitch
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Udyr
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Urgot
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Varus
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Vayne
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Veigar
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Velkoz
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Vex
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Vi
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Viego
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Viktor
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Vladimir
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Volibear
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Warwick
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Xayah
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Xerath
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class XinZhao
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Yasuo
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Yone
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Yorick
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Yuumi
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Zac
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Zed
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Ziggs
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Zilean
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Zoe
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Zyra
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Champion
    {
        public Aatrox Aatrox { get; set; }
        public Ahri Ahri { get; set; }
        public Akali Akali { get; set; }
        public Akshan Akshan { get; set; }
        public Alistar Alistar { get; set; }
        public Amumu Amumu { get; set; }
        public Anivia Anivia { get; set; }
        public Annie Annie { get; set; }
        public Aphelios Aphelios { get; set; }
        public Ashe Ashe { get; set; }
        public AurelionSol AurelionSol { get; set; }
        public Azir Azir { get; set; }
        public Bard Bard { get; set; }
        public Blitzcrank Blitzcrank { get; set; }
        public Brand Brand { get; set; }
        public Braum Braum { get; set; }
        public Caitlyn Caitlyn { get; set; }
        public Camille Camille { get; set; }
        public Cassiopeia Cassiopeia { get; set; }
        public Chogath Chogath { get; set; }
        public Corki Corki { get; set; }
        public Darius Darius { get; set; }
        public Diana Diana { get; set; }
        public Draven Draven { get; set; }
        public DrMundo DrMundo { get; set; }
        public Ekko Ekko { get; set; }
        public Elise Elise { get; set; }
        public Evelynn Evelynn { get; set; }
        public Ezreal Ezreal { get; set; }
        public Fiddlesticks Fiddlesticks { get; set; }
        public Fiora Fiora { get; set; }
        public Fizz Fizz { get; set; }
        public Galio Galio { get; set; }
        public Gangplank Gangplank { get; set; }
        public Garen Garen { get; set; }
        public Gnar Gnar { get; set; }
        public Gragas Gragas { get; set; }
        public Graves Graves { get; set; }
        public Gwen Gwen { get; set; }
        public Hecarim Hecarim { get; set; }
        public Heimerdinger Heimerdinger { get; set; }
        public Illaoi Illaoi { get; set; }
        public Irelia Irelia { get; set; }
        public Ivern Ivern { get; set; }
        public Janna Janna { get; set; }
        public JarvanIV JarvanIV { get; set; }
        public Jax Jax { get; set; }
        public Jayce Jayce { get; set; }
        public Jhin Jhin { get; set; }
        public Jinx Jinx { get; set; }
        public Kaisa Kaisa { get; set; }
        public Kalista Kalista { get; set; }
        public Karma Karma { get; set; }
        public Karthus Karthus { get; set; }
        public Kassadin Kassadin { get; set; }
        public Katarina Katarina { get; set; }
        public Kayle Kayle { get; set; }
        public Kayn Kayn { get; set; }
        public Kennen Kennen { get; set; }
        public Khazix Khazix { get; set; }
        public Kindred Kindred { get; set; }
        public Kled Kled { get; set; }
        public KogMaw KogMaw { get; set; }
        public Leblanc Leblanc { get; set; }
        public LeeSin LeeSin { get; set; }
        public Leona Leona { get; set; }
        public Lillia Lillia { get; set; }
        public Lissandra Lissandra { get; set; }
        public Lucian Lucian { get; set; }
        public Lulu Lulu { get; set; }
        public Lux Lux { get; set; }
        public Malphite Malphite { get; set; }
        public Malzahar Malzahar { get; set; }
        public Maokai Maokai { get; set; }
        public MasterYi MasterYi { get; set; }
        public MissFortune MissFortune { get; set; }
        public MonkeyKing MonkeyKing { get; set; }
        public Mordekaiser Mordekaiser { get; set; }
        public Morgana Morgana { get; set; }
        public Nami Nami { get; set; }
        public Nasus Nasus { get; set; }
        public Nautilus Nautilus { get; set; }
        public Neeko Neeko { get; set; }
        public Nidalee Nidalee { get; set; }
        public Nocturne Nocturne { get; set; }
        public Nunu Nunu { get; set; }
        public Olaf Olaf { get; set; }
        public Orianna Orianna { get; set; }
        public Ornn Ornn { get; set; }
        public Pantheon Pantheon { get; set; }
        public Poppy Poppy { get; set; }
        public Pyke Pyke { get; set; }
        public Qiyana Qiyana { get; set; }
        public Quinn Quinn { get; set; }
        public Rakan Rakan { get; set; }
        public Rammus Rammus { get; set; }
        public RekSai RekSai { get; set; }
        public Rell Rell { get; set; }
        public Renekton Renekton { get; set; }
        public Rengar Rengar { get; set; }
        public Riven Riven { get; set; }
        public Rumble Rumble { get; set; }
        public Ryze Ryze { get; set; }
        public Samira Samira { get; set; }
        public Sejuani Sejuani { get; set; }
        public Senna Senna { get; set; }
        public Seraphine Seraphine { get; set; }
        public Sett Sett { get; set; }
        public Shaco Shaco { get; set; }
        public Shen Shen { get; set; }
        public Shyvana Shyvana { get; set; }
        public Singed Singed { get; set; }
        public Sion Sion { get; set; }
        public Sivir Sivir { get; set; }
        public Skarner Skarner { get; set; }
        public Sona Sona { get; set; }
        public Soraka Soraka { get; set; }
        public Swain Swain { get; set; }
        public Sylas Sylas { get; set; }
        public Syndra Syndra { get; set; }
        public TahmKench TahmKench { get; set; }
        public Taliyah Taliyah { get; set; }
        public Talon Talon { get; set; }
        public Taric Taric { get; set; }
        public Teemo Teemo { get; set; }
        public Thresh Thresh { get; set; }
        public Tristana Tristana { get; set; }
        public Trundle Trundle { get; set; }
        public Tryndamere Tryndamere { get; set; }
        public TwistedFate TwistedFate { get; set; }
        public Twitch Twitch { get; set; }
        public Udyr Udyr { get; set; }
        public Urgot Urgot { get; set; }
        public Varus Varus { get; set; }
        public Vayne Vayne { get; set; }
        public Veigar Veigar { get; set; }
        public Velkoz Velkoz { get; set; }
        public Vex Vex { get; set; }
        public Vi Vi { get; set; }
        public Viego Viego { get; set; }
        public Viktor Viktor { get; set; }
        public Vladimir Vladimir { get; set; }
        public Volibear Volibear { get; set; }
        public Warwick Warwick { get; set; }
        public Xayah Xayah { get; set; }
        public Xerath Xerath { get; set; }
        public XinZhao XinZhao { get; set; }
        public Yasuo Yasuo { get; set; }
        public Yone Yone { get; set; }
        public Yorick Yorick { get; set; }
        public Yuumi Yuumi { get; set; }
        public Zac Zac { get; set; }
        public Zed Zed { get; set; }
        public Ziggs Ziggs { get; set; }
        public Zilean Zilean { get; set; }
        public Zoe Zoe { get; set; }
        public Zyra Zyra { get; set; }
    }


}
