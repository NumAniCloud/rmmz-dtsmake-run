using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace dtsmake_run
{
    class Program
    {
        private static string[] ScriptFiles = {
            "main.js",
            "rmmz_core.js",
            "rmmz_managers.js",
            "rmmz_objects.js",
            "rmmz_scenes.js",
            "rmmz_sprites.js",
            "rmmz_windows.js"
        };
        private static string[] TargetFiles = {
            "main.js",
            "rmmz_core.js",
            "rmmz_managers.js",
            "rmmz_objects.js",
            "rmmz_scenes.js",
            "rmmz_sprites.js",
            "rmmz_windows.js"
        };

        static void Main(string[] args)
        {
            foreach (var item in GetCommands())
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("> " + item);
                Console.ForegroundColor = ConsoleColor.Gray;

                var info = new ProcessStartInfo("cmd", $"/c {item}");
                info.CreateNoWindow = true;
                info.UseShellExecute = false;
                info.RedirectStandardOutput = true;
                info.RedirectStandardError = true;

                var p = Process.Start(info);
                p.WaitForExit();

                Console.WriteLine(p.StandardError.ReadToEnd());
                Console.WriteLine(p.StandardOutput.ReadToEnd());

                p.Close();
            }
        }

        private static IEnumerable<string> GetCommands()
        {
            var hints = string.Join(",", ScriptFiles);
            foreach (var item in TargetFiles)
            {
               yield return $"dtsmake -s {item} -x \"{hints}\""; 
            }
        }
    }
}
