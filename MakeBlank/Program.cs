using System;
using System.IO;

namespace MakeBlank
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "방탈출후기.txt";
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].StartsWith("-"))
                    {
                        lines[i] = "";
                    }
                }
                File.WriteAllLines(path, lines);
            }
        }

    }
}
