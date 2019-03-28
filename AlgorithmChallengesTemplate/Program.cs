using System;
using System.IO;
using System.Threading;

namespace AlgorithmChallengesTemplate
{
    internal struct Example
    {
        private int Points;

        public Example(int points)
        {
            Points = points;
        }
    }

    internal static class Program
    {
        private static void Main()
        {
            #if DEBUG
                Console.WriteLine("Sei in debug");
            #else
                Console.WriteLine("Non sei in debug");
            #endif

            const string inputNames = "a b c";
            foreach (var input in inputNames.Split(" "))
            {
                var name = input;
                var newThread = new Thread(() => Run(name));
                newThread.Start();
            }
            #if DEBUG
                Console.ReadKey();
            #endif

        }

        private static void Run(string inputName)
        {
            //INPUT
            var streamReader = new StreamReader($"./in/{inputName}.txt");
            var firstLine = streamReader.ReadLine();
            streamReader.Close();

            //CODE
            /*
            * Bla bla bla bla
            */
            //OUTPUT

            if (!Directory.Exists("./out"))
                Directory.CreateDirectory("./out");
            using (var streamWriter = new StreamWriter($"./out/{inputName}.txt"))
            {
                streamWriter.WriteLine(firstLine + " elaborato con successo");
            }

            Console.WriteLine("Termine esecuzione per input " + inputName);
        }
    }
}