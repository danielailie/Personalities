using System;

namespace Personalities
{
    class Program
    {
        private static string _filePath;

        static void Main()
        {
            var personality=new Personality();
            _filePath = "C:\\Users\\daniela.ilie\\Documents\\visual studio 2013\\Projects\\Personalities\\Personalities\\bin\\Debug\\Personalities.csv";
            personality.ReadFromFile(_filePath);
            foreach (var p in personality.Personalities)
            {
                Console.WriteLine(p.ToString());
            }
        }
    }
}
