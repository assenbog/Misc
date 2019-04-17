using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace Morse_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            const int defaultFrequency = 1000;
            const int defaultDiDuration = 60;

            var whitespace = new List<char> { ' ', '\t', '\r', '\n' };
            int frequency;
            int diDuration;

            var waveOut = new WaveOut();

            // Try to get Frequency and DiDuration from the config file
            if (!int.TryParse(ConfigurationManager.AppSettings["Frequency"], out frequency))
            {
                frequency = defaultFrequency;
            }

            if (!int.TryParse(ConfigurationManager.AppSettings["DiDuration"], out diDuration))
            {
                diDuration = defaultDiDuration;
            }

            var dahDuration = diDuration * 3;
            var separatorDuration = diDuration * 7;

            var text = string.IsNullOrEmpty(args[0]) ? "Test" : args[0];

            var codes = new Dictionary<char, string>
            {
                {'a', ".-"}, {'b', "-..."}, {'c', "-.-."}, {'d', "-.."},
                {'e', "."}, {'f', "..-."}, {'g', "--."}, {'h', "...."},
                {'i', ".."}, {'j', ".---"}, {'k', "-.-"}, {'l', ".-.."},
                {'m', "--"}, {'n', "-."}, {'o', "---"}, {'p', ".--."},
                {'q', "--.-"}, {'r', ".-."}, {'s', "..."}, {'t', "-"},
                {'u', "..-"}, {'v', "...-"}, {'w', ".--"}, {'x', "-..-"},
                {'y', "-.--"}, {'z', "--.."}, {'0', "-----"}, {'1', ".----"},
                {'2', "..---"}, {'3', "...--"}, {'4', "....-"}, {'5', "....."},
                {'6', "-...."}, {'7', "--..."}, {'8', "---.."}, {'9', "----."}
            };

            Console.WriteLine("Morse Code generator");
            Console.WriteLine("====================\n");

            while (!string.IsNullOrEmpty(text))
            {
                var stopWatch = new Stopwatch();
                stopWatch.Start();
                foreach (var c in text.ToLower())
                {
                    if (whitespace.Contains(c))
                    {
                        Console.Write(" ");
                        Thread.Sleep(separatorDuration);
                    }
                    else if (codes.Keys.Contains(c))
                    {
                        Console.Write($"{c}");

                        var code = codes[c];

                        foreach (var diDah in code)
                        {
                            Thread.Sleep(diDuration);
                            PlaySound(waveOut, frequency, diDah == '.' ? diDuration : dahDuration);
                        }
                        Thread.Sleep(dahDuration);
                    }
                    else
                    {
                        Console.Write("?");
                    }
                }
                stopWatch.Stop();
                var elapsed = stopWatch.ElapsedMilliseconds;
                var speed = text.Length * 60000 / elapsed;
                Console.Write($"\tSpeed - {speed} chars/min. ");
                Console.Write("\n\nEnter new string: ");
                text = Console.ReadLine();
            }
            waveOut.Dispose();
            Console.Write($"\n\nPress any key to exit ... ");
            Console.ReadKey();
        }

        private static void PlaySound(WaveOut waveOut, double frequency, int duration)
        {
            var mySinus = new SignalGenerator(44100, 1)
            {
                Frequency = frequency,
                Type = SignalGeneratorType.Sin
            };

            waveOut.Init(mySinus);

            waveOut.Play();
            Thread.Sleep(duration);
            waveOut.Stop();
        }
    }

}
