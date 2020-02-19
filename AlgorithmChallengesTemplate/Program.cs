using System;
using System.Collections;
using System.IO;
using System.Threading;

namespace AlgorithmChallengesTemplate {
   internal static class Program {
      private static void Run(string inputName) {
         //INPUT
         using (var streamReader = new StreamReader($"./in/{inputName}.txt")) {
            var line = streamReader.ReadLine();
         }
         //CODE
         /*
         * Bla bla bla bla
         */
         //OUTPUT

         if (!Directory.Exists("./out")) Directory.CreateDirectory("./out");
         using (var streamWriter = new StreamWriter($"./out/{inputName}.txt")) {
            streamWriter.WriteLine($"{inputName} solution! :)");
            //streamWriter.WriteLine($"\t Scoring measure: {scoring}");
         }

         Console.Out.WriteLine($"{inputName} executed ☑");
      }

      private static void Main() {
         var inputNames = new[] {"a", "b", "c"};
         var threads = new Thread[inputNames.Length];
         for (var i = 0; i < inputNames.Length; ++i) {
            var name = inputNames[i];
            threads[i] = new Thread(() => Run(name));
            threads[i].Start();
         }

         Console.Out.WriteLine("Threads started...");
         foreach (var thread in threads) {
            thread.Join();
         }

         Console.Out.WriteLine("Threads executed!");
         Console.ReadKey();
      }
   }
}