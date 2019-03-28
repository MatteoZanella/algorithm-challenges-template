using System;
using System.Threading;
using System.IO;

namespace AlgorithmChallengesTemplate {
   struct Example {
      int Points;
      public Example(int points) {
         Points = points;
      }
   }

   internal static class Program {
      private static void Main() {
         const string inputNames = "a b c";
         foreach (var inputName in inputNames.Split(" ")) {
            var newThread = new Thread(() => Run(inputName));
            newThread.Start();
         }
      }

      private static void Run(string inputName) {
         //INPUT
         var streamReader = new StreamReader($"./in/{inputName}.txt");
         var firstLine = streamReader.ReadLine();
         streamReader.Close();
        
         //CODE
         /*
          * Bla bla bla bla
          */
         
         //OUTPUT
         using (var streamWriter = new StreamWriter($"./out/{inputName}.txt")) {
            streamWriter.WriteLine(firstLine + " elaborato con successo");
         }

         Console.WriteLine("Termine esecuzione per input " + inputName);
      }
   }
}